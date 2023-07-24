using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldParser.Grammar;

namespace GoldParser.ParseTree
{
	public enum TokenType
    {
		Terminal,
		NonTerminal
    }
    public class Token
    {        
        private GrammarSymbol _symbol;
        private Position _position;
        private object _data;

        private int _state;


		public GrammarSymbol Symbol
		{
			get
			{
				return _symbol;
			}
			internal set
			{
				_symbol = value;
			}
		}
		public Position Position
		{
			get
            {
				return _position;
            }
		}
		public object Data
		{
			get
			{
				return _data;
			}
			set
			{
				_data = value;
			}
		}

		internal int State
		{
			get
			{
				return _state;
			}
			set
			{
				_state = value;
			}
		}


		public Token()
		{
			_position = new Position();
			_symbol = null;
			_data = null;
			_state = 0;
		}
		public Token(GrammarSymbol sym, object dat)
		{
			_position = new Position();
			_symbol = sym;
			_data = dat;
			_state = 0;
		}



		public GrammarSymbolType SymbolType
		{
			get
            {
				return _symbol.Type;
			}
		}
		internal GrammarGroup SymbolGroup
		{
			get
            {
				return _symbol.Group;
			}
		}

	}
}


//GrammarSymbol Parent		Symbol Symbol
//Position Position()		Position Position
//GrammarSymbolType			SymbolType
//Type() is SymbolType
//Group() is SymbolGroup