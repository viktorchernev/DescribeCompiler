using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GoldParser.Parser
{
    public class ParserLexer : ParserBase
    {
        protected TextReader _Source;
        protected Stack<Token> _GroupStack;
        private Position _SysPosition;
        private string _LookaheadBuffer;



        /// <summary>
        /// Ctor.
        /// </summary>
        public ParserLexer() : base()
        {
            _GroupStack = new Stack<Token>();
            _SysPosition = new Position();
            _LookaheadBuffer = "";
        }

        /// <summary>
        /// Restarts the Lexer. Loaded tables are retained.
        /// </summary>
        public void Restart()
        {
            _GroupStack.Clear();
            _SysPosition.Column = 0;
            _SysPosition.Line = 0;
            _LookaheadBuffer = "";
        }




        /// <summary>
        /// This function creates a token and also takes into account the current
        /// lexing mode of the parser. In particular, it contains the group logic. 
        ///
        /// A stack is used to track the current "group". This replaces the comment
        /// level counter. Also, text is appended to the token on the top of the 
        /// stack. This allows the group text to returned in one chunk.
        /// </summary>
        /// <returns></returns>
        protected Token produceToken()
        {
            while (true)
            {
                Token token = produceTokenDFA();

                //The logic - to determine if a group should be nested - requires that the top of the stack
                //and the symbol's linked group need to be looked at. Both of these can be unset. So, this section
                //sets a Boolean and avoids errors. We will use this boolean in the logic chain below. 
                bool nestGroup = false;
                if (token.SymbolType == GrammarSymbolType.GroupStart)
                {
                    nestGroup = _GroupStack.Count == 0 ||
                        _GroupStack.Peek().SymbolGroup.Nesting.Contains(token.SymbolGroup.TableIndex);
                }

                //TOKEN IS GROUP START-ING
                //If a token is one that is a start of a group, we can start a 
                //group by pushing it on the group stack. We are allowed to do so,
                //if the group stack is empty(we are not in a group), or group
                //stack is not empty(we are in a group) and that groups' Nesting
                //allows for current group we are starting to be nested in.
                if (nestGroup)
                {
                    trimBuffer((token.Data as string).Length);
                    _GroupStack.Push(token);
                }

                //TOKEN IS NOT GROUP-START OR IS NOT NESTABLE GROUP-START
                //WE ARE NOT IN A GROUP
                else if (_GroupStack.Count == 0)
                {
                    trimBuffer((token.Data as string).Length);
                    return token;
                }

                //TOKEN IS NOT GROUP-START OR IS NOT NESTABLE GROUP-START
                //WE ARE NOT-NOT IN A GROUP
                //TOKEN IS GROUP END-ING
                else if (_GroupStack.Peek().SymbolGroup.EndSymbol == token.Symbol)
                {
                    //End the current group
                    Token pop = _GroupStack.Pop();

                    //if we have GrammarGroupEndingMode.Closed then add the end
                    //token, otherwise don't
                    if (pop.SymbolGroup.Ending == GrammarGroupEndingMode.Closed)
                    {
                        pop.Data = (pop.Data as string) + (token.Data as string);
                        trimBuffer((token.Data as string).Length);
                    }

                    //We are out of the group. Return pop'd token (which contains all the group text)
                    if (_GroupStack.Count == 0)
                    {
                        pop.Symbol = pop.SymbolGroup.ContainerSymbol; //Change symbol to symbol of the group
                        return pop;
                    }
                    else
                    {
                        Token top = _GroupStack.Peek();
                        top.Data = (top.Data as string) + (pop.Data as string);
                    }
                }

                //TOKEN IS NOT GROUP-START OR IS NOT NESTABLE GROUP-START
                //TOKEN IS GROUP END-ING
                //WE ARE NOT-NOT IN A GROUP
                //TOKEN IS EOF - "End Of File"
                else if (token.SymbolType == GrammarSymbolType.End)
                {
                    return token;
                }

                //TOKEN IS NOT GROUP-START OR IS NOT NESTABLE GROUP-START
                //TOKEN IS NOT GROUP END-ING
                //WE ARE NOT-NOT IN A GROUP
                //TOKEN IS NOT EOF - "End Of File"
                //
                //we are in group and none of the above, so if that group is TokenAdvance
                //we add the text of the token to the Data of previous one, otherwise, if
                //we have CharacterAdvance, we add just the first character. we then continue
                //on with the loop
                else
                {
                    Token previousToken = _GroupStack.Peek();
                    if (previousToken.SymbolGroup.Advance == GrammarGroupAdvanceMode.Token)
                    {
                        previousToken.Data = (previousToken.Data as string) + (token.Data as string);
                        trimBuffer((token.Data as string).Length);
                    }
                    else
                    {
                        previousToken.Data = (previousToken.Data as string) + (token.Data as string)[0];
                        trimBuffer(1);
                    }
                }
            }
        }

        /// <summary>
        /// This function implements the DFA for the parser's lexer.
        /// It generates a token which is used by the LALR state machine.
        /// </summary>
        /// <returns>//https://github.com/meziantou/GoldParser-Engine/blob/master/GoldParserEngine/GoldParserEngine/Parser.cs</returns>
        Token produceTokenDFA()
        {
            Token result = new Token();
            int currentDfa = _grammar.InitialStates.DfaInitialState;
            int lastAcceptState = -1;                                                   //Next byte in the input Stream
            int lastAcceptPosition = -1;                                                //We have not yet accepted a character string
            int currentPosition = 1;
            bool done = false;

            string ch = getCharacter(1);                                                   // Get first symbol from the lookahead buffer
            if (ch != "" && Convert.ToInt32(ch[0]) != 65535)                            // End of file is not reached
            {
                while (done == false)
                {
                    // This code searches all the branches of the current DFA state
                    // for the next character in the input Stream. If found the
                    // target state is returned.
                    ch = getCharacter(currentPosition);                                    //Get first x symbols from the lookahead buffer
                    int target = -1;
                    //if ch is "", then End of file reached, so do not match            
                    if (!string.IsNullOrEmpty(ch))
                    {
                        GrammarFAState currentFAState = _grammar.FAStates[currentDfa];
                        for (int n = 0; n < currentFAState.Edges.Count(); n++)
                        {
                            GrammarFAEdge fAEdge = currentFAState.Edges[n];
                            //Look for character in the Character Set Table
                            if (fAEdge.CharacterSet.Contains(Convert.ToInt32(ch[0])))
                            {
                                target = fAEdge.Target;
                                break;
                            }
                        }
                    }


                    // This block-if statement checks whether an edge was found from the current state. If so, the state and current
                    // position advance. Otherwise it is time to exit the main loop and report the token found (if there was one). 
                    // If the LastAcceptState is -1, then we never found a match and the Error Token is created. Otherwise, a new 
                    // token is created using the Symbol in the Accept State and all the characters that comprise it.

                    if (target > -1) //that means that target state is found
                    {
                        // This code checks whether the target state accepts a token.
                        // If so, it sets the appropiate variables so when the
                        // algorithm in done, it can return the proper token and
                        // number of characters.

                        if (_grammar.FAStates[target].Accept != null)
                        {
                            lastAcceptState = target;
                            lastAcceptPosition = currentPosition;
                        }
                        currentDfa = target;
                        currentPosition++;
                    }
                    else
                    {
                        done = true;
                        if (lastAcceptState == -1)  // Lexer cannot recognize symbol
                        {
                            result.Symbol = getFirstOfType(_grammar, GrammarSymbolType.Error);
                            result.Data = getString(1);
                        }
                        else //Lexer can recognize symbol
                        {
                            result.Symbol = _grammar.FAStates[lastAcceptState].Accept;
                            result.Data = getString(lastAcceptPosition);
                            //Data contains the total number of accept characters
                        }
                    }
                }
            }
            else // End of file reached, create End Token
            {
                result.Data = "";
                result.Symbol = getFirstOfType(_grammar, GrammarSymbolType.End);
            }

            //Set the new token's position information
            //Notice, this is a copy, not a linking of an instance. We don't want the user 
            //to be able to alter the main value indirectly.
            result.Position.Copy(_SysPosition);
            return result;
        }

        /// <summary>
        /// Get a character from _LookaheadBuffer, and return it as string. Uses one-based indexing!
        /// If _LookaheadBuffer is too short, read more chars from _Source TextReader
        /// returns _LookaheadBuffer[charIndex - 1]
        /// </summary>
        /// <param name="charIndex"></param>
        /// <returns></returns>
        string getCharacter(int charIndex)
        {
            //Check if we must read characters from the Stream
            if (charIndex > _LookaheadBuffer.Length)
            {
                for (int i = 0; i < charIndex - _LookaheadBuffer.Length; i++)
                {
                    int x = _Source.Read();
                    char c = (char)x;//char c = Strings.ChrW(x);
                    _LookaheadBuffer += c.ToString();
                }
            }

            //If the buffer is still smaller than the index, we have reached
            //the end of the text. In this case, return a null string - the DFA
            //code will understand.
            if (charIndex <= _LookaheadBuffer.Length)
            {
                return _LookaheadBuffer[charIndex - 1].ToString();
            }
            return "";
        }

        /// <summary>
        /// Get first "count" number of symbols from _LookaheadBuffer.
        /// 
        /// Return Count characters from the lookahead buffer. DO NOT CONSUME
        /// This is used to create the text stored in a token. It is disgarded
        /// separately. Because of the design of the DFA algorithm, count should
        /// never exceed the buffer length. The If-Statement below is fault-tolerate
        /// programming, but not necessary.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        string getString(int length)
        {

            if (length > _LookaheadBuffer.Length)
            {
                length = _LookaheadBuffer.Length;
            }
            return _LookaheadBuffer.Substring(0, length);
        }

        /// <summary>
        /// ConsumeBuffer increments _SysPosition according to the characters in _LookaheadBuffer
        /// and removes those characters from _LookaheadBuffer
        /// </summary>
        /// <param name="count">Number of characters to advance the _SysPosition position</param>
        void trimBuffer(int count)
        {
            if (count > _LookaheadBuffer.Length) return;

            // Count Carriage Returns and increment the internal column and line
            // numbers. This is done for the Developer and is not necessary for the
            // DFA algorithm.
            for (int n = 0; n <= count - 1; n++)
            {
                switch (_LookaheadBuffer[n])
                {
                    case '\n':
                        _SysPosition.Line++;
                        _SysPosition.Column = 0;
                        break;

                    case '\r':                                      //carriage return
                        break;          //Ignore, LF is used to inc line to be UNIX friendly

                    case '\v':                                      //vertical tab			   
                    case '\f':                                      //form feed
                    default:
                        _SysPosition.Column++;
                        break;
                }
            }

            _LookaheadBuffer = _LookaheadBuffer.Remove(0, count);
        }

        GrammarSymbol getFirstOfType(GrammarTables grammar, GrammarSymbolType type)
        {
            return grammar.Symbols.FirstOrDefault(_ => _.Type == type);
        }
    }
}
//Top() is Peek()
//LookaheadDFA() is produceTokenDFA()
//Lookahead(int charIndex) is getCharacter(int charIndex)
//LookaheadBuffer(int count) is getString(int length)
//ConsumeBuffer(int charCount) is trimBuffer(int count)

//TODO: Look at GrammarLists functionality I am omitting
//TODO: Add documentation comments on each grammar object