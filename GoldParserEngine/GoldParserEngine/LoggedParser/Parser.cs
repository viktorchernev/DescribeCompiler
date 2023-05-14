using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.LoggedParser
{
	public enum ParseMessage
	{
		TokenRead,
		Reduction,
		Accept,
		NotLoadedError,
		LexicalError,
		SyntaxError,
		GroupError,
		InternalError
	}
	public class Parser : ParserLexer
    {
		enum ParseResult
		{
			Accept = 1,
			Shift,
			ReduceNormal,
			ReduceEliminated,
			SyntaxError,
			InternalError
		}

		private bool _trimReductions;
		private bool _haveReduction;
		private int _CurrentLALR;

		private Stack<Token> _stack;
		private Stack<Token> _inputTokens;
		private Position _currentPosition;
		List<GrammarSymbol> _expectedSymbols;




		/// <summary>
		/// Determines if reductions will be trimmed in cases where a production contains a single element.
		/// </summary>
		public bool TrimReductions
		{
			get
			{
				return _trimReductions;
			}
			set
			{
				_trimReductions = value;
			}
		}

		/// <summary>
		/// When the Parse() method returns a Reduce, this property will contain the current Reduction.
		/// </summary>
		public Reduction CurrentReduction
		{
			get
			{
				if (_haveReduction && _stack.Peek().Data is Reduction)
				{
					return (Reduction)_stack.Peek().Data;
				}
				else
				{
					return null;
				}
			}
			set
			{
				if (_haveReduction)
				{
					_stack.Peek().Data = value;
				}
			}
		}

		/// <summary>
		/// If the Parse() function returns TokenRead, this method will return that last read token.
		/// </summary>
		/// <returns></returns>
		public Token CurrentToken
		{
			get
            {
				return _inputTokens.Peek();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public Position CurrentPosition
		{
			get
            {
				return _currentPosition;
            }
		}

		/// <summary>
		/// If the Parse() method returns a SyntaxError, 
		/// this method will contain a list of the symbols the grammar expected to see.
		/// </summary>
		/// <returns></returns>
		public List<GrammarSymbol> ExpectedSymbols
		{
			get 
			{
				return _expectedSymbols; 
			}
		}



		/// <summary>
		/// Ctor.
		/// </summary>
		public Parser()
		{
			_expectedSymbols = new List<GrammarSymbol>();
			_stack = new Stack<Token>();
			_inputTokens = new Stack<Token>();

			_currentPosition = new Position();
			_currentPosition.Line = 0;
			_currentPosition.Column = 0;

			_haveReduction = false;
			_tablesLoaded = false;
			_trimReductions = false;
		}

		/// <summary>
		/// Opens a string for parsing.
		/// </summary>
		/// <param name="text">The string to be parsed</param>
		/// <returns></returns>
		public bool Open(string text)
		{
			bool opened = Open(new StringReader(text));
			Logging.Log("Lexer Opened string for parsing");
			return opened;
		}

		/// <summary>
		/// Opens a text stream for parsing.
		/// </summary>
		/// <param name="reader">The TextReader stream to be parsed</param>
		/// <returns></returns>
		public bool Open(TextReader reader)
		{
			Restart();
			_Source = reader;
			Logging.Log("Lexer Opened reader for parsing - \"_Source = reader\"");

			Token token = new Token();
			token.State = _grammar.InitialStates.DfaInitialState;
			_stack.Push(token);
			return true;
		}

		/// <summary>
		/// Restarts the parser. Loaded tables are retained.
		/// </summary>
		public new void Restart()
		{
			base.Restart();

			_CurrentLALR = _grammar.InitialStates.LrInitialState;

			_currentPosition.Line = 0;
			_currentPosition.Column = 0;
			_haveReduction = false;

			_expectedSymbols.Clear();
			_inputTokens.Clear();
			_stack.Clear();
		}

		/// <summary>
		/// Removes the next token from the input queue.
		/// </summary>
		/// <returns></returns>
		public Token PopToken()
		{
			return _inputTokens.Pop();
		}

		/// <summary>
		/// Pushes the token onto the top of the input stack. This token will be analyzed next.
		/// </summary>
		/// <param name="TheToken"></param>
		public void PushToken(ref Token token)
		{
			_inputTokens.Push(token);
		}

		/// <summary>
		/// Performs a parse action on the input.
		/// </summary>
		/// <returns>ParseMessage</returns>
		public ParseMessage Parse()
		{
			if (!_tablesLoaded) return ParseMessage.NotLoadedError;
			while (true)
			{
				if (_inputTokens.Count == 0)
				{
					Token t = produceToken();
					_inputTokens.Push(t);
					return ParseMessage.TokenRead;
				}

				Token token = _inputTokens.Peek();
				_currentPosition.Copy(token.Position);

				if (_GroupStack.Count != 0) return ParseMessage.GroupError;
				if (token.SymbolType == GrammarSymbolType.Error) return ParseMessage.LexicalError;
				if (token.SymbolType == GrammarSymbolType.Noise)
				{
					_inputTokens.Pop();
					continue;
				}

				ParseResult r = ParseLALR(ref token);
				switch (r)
				{
					case ParseResult.Accept: return ParseMessage.Accept;
					case ParseResult.ReduceNormal: return ParseMessage.Reduction;
					case ParseResult.SyntaxError: return ParseMessage.SyntaxError;
					case ParseResult.InternalError: return ParseMessage.InternalError;
					case ParseResult.Shift: _inputTokens.Pop(); break;
				}
			}
		}
		private ParseResult ParseLALR(ref Token token)
		{
			GrammarLRState lRState = _grammar.LRStates[_CurrentLALR];
			GrammarLRAction lRAction = lRState[token.Symbol];

			if (lRAction == null)
			{
				_expectedSymbols.Clear();
				try
				{
					for (int i = 0; i < lRState.Count(); i++)
					{
						GrammarLRAction lra = lRState[i];
						switch (lra.Symbol.Type)
						{
							case GrammarSymbolType.Terminal:
							case GrammarSymbolType.End:
							case GrammarSymbolType.GroupStart:
							case GrammarSymbolType.GroupEnd:
								_expectedSymbols.Add(lra.Symbol);
								break;
						}
					}
				}
				catch { }
				return ParseResult.SyntaxError;
			}

			_haveReduction = false;
			switch (lRAction.Type)
			{
				case LRActionType.Accept:
					_haveReduction = true;
					return ParseResult.Accept;

				case LRActionType.Shift:
					_CurrentLALR = lRAction.Value;
					token.State = _CurrentLALR;                                                         //checked(_CurrentLALR);
					_stack.Push(token);                                                             //_Stack.Push(ref token);
					return ParseResult.Shift;

				case LRActionType.Reduce:

					GrammarProduction production = _grammar.Productions[lRAction.Value];

					ParseResult result;
					Token t;
					if (_trimReductions && production.ContainsOneNonTerminal())
					{
						t = _stack.Pop();
						t.Symbol = production.Head;
						result = ParseResult.ReduceEliminated;
					}
					else
					{
						_haveReduction = true;
						Reduction reduction = new Reduction(production.Handle.Count());
						reduction.Production = production;
						for (int i = production.Handle.Count() - 1; i >= 0; i -= 1)
						{
							reduction[i] = _stack.Pop();
						}
						t = new Token(production.Head, reduction);
						result = ParseResult.ReduceNormal;
					}

					int stateindex = _stack.Peek().State;
					GrammarLRState state = _grammar.LRStates[stateindex];
					int actionindex = state.IndexOf(production.Head); //action index is returned

					if (actionindex == -1) { return ParseResult.InternalError; }

					GrammarLRAction lra = state[actionindex];
					_CurrentLALR = lra.Value;
					t.State = _CurrentLALR;
					_stack.Push(t);

					return result;

				default:
					return ParseResult.InternalError;
			}
		}
	}
}
//_InputTokens.Top() is _InputTokens.Peek()
//_ExpectedSymbols is _expectedSymbols
//ExpectedSymbols() is ExpectedSymbols.get
//PushInput(Token) is PushToken(Token)
//DiscardCurrentToken() is PopToken()
//Clear() seems pointless, when we have Restart() that does the same

//EnqueueInput(Token) has been removed as it is not used, isn't clear to me if useful,
//and @meziantou has omitted it as well - https://github.com/meziantou/GoldParser-Engine/
//It will require custom stack class to be implemented, hurting code readability