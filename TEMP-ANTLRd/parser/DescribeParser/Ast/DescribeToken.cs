using Antlr4.Runtime.Tree;
using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.AST
{
    public class DescribeToken : AstNode
    {
        /// <summary>
        /// The text of the token that was red from the source code
        /// </summary>
        public new string Text
        { 
            get; 
            set; 
        }

        /// <summary>
        /// The type of the token, as defined in the grammar.
        /// </summary>
        public DesctibeTokenType TokenType
        {
            get;
            set;
        }

        /// <summary>
        /// The position of the Token in the source code
        /// </summary>
        public DescribeSourcePosition Position
        {
            get;
            set;
        }



        public DescribeToken(ITerminalNode token)
        {
            DescribeSourcePosition pos = new DescribeSourcePosition(Line, Start, Line, End);
            Position = pos;

            Line = token.Symbol.Line;
            Start = token.Symbol.StartIndex;
            End = token.Symbol.StopIndex;
            Text = token.Symbol.Text;

            string tokenType = GetTokenType(token.Symbol.Type);
            switch (tokenType)
            {
                case "LINE_COMMENT":
                    TokenType = DesctibeTokenType.LineComment;
                    break;
                case "BLOCK_COMMENT":
                    TokenType = DesctibeTokenType.BlockComment;
                    break;
                case "NEWLINE":
                    TokenType = DesctibeTokenType.NewLine;
                    break;
                case "HYPHEN":
                    TokenType = DesctibeTokenType.Hyphen;
                    break;
                case "RIGHT_ARROW":
                    TokenType = DesctibeTokenType.RightArrow;
                    break;
                case "SEPARATOR":
                    TokenType = DesctibeTokenType.Separator;
                    break;
                case "TERMINATOR":
                    TokenType = DesctibeTokenType.Terminator;
                    break;
                case "FIRWARD_SLASH":                                           //Fix this
                    TokenType = DesctibeTokenType.ForewardSlash;
                    break;
                case "ESCAPE_ESCAPE":
                    TokenType = DesctibeTokenType.EscapeEscape;
                    break;
                case "ESCAPE_HYPHEN":
                    TokenType = DesctibeTokenType.EscapeHyphen;
                    break;
                case "ESCAPE_RIGHT_ARROW":
                    TokenType = DesctibeTokenType.EscapeRightArrow;
                    break;
                case "ESCAPE_SEPARATOR":
                    TokenType = DesctibeTokenType.EscapeSeparator;
                    break;
                case "ESCAPE_TERMINATOR":
                    TokenType = DesctibeTokenType.EscapeTerminator;
                    break;
                case "ESCAPE_LCOMMENT":
                    TokenType = DesctibeTokenType.EscapeLineComment;
                    break;
                case "ESCAPE_BCOMMENT":
                    TokenType = DesctibeTokenType.EscapeBlockComment;
                    break;
                case "DATA":
                    TokenType = DesctibeTokenType.Data;
                    break;
                default: 
                    TokenType = DesctibeTokenType.Unknown;
                    break;
            }
        }



        public override string ToString()
        {
            string message = "T(" + TokenType + "|'" + ReplaceWhitespaceE(Text) + "')";
            return message;
        }
        public string ToCode()
        {
            return Text;
        }


        static string GetTokenType(int tokenType)
        {
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        static string ReplaceWhitespaceE(string text)
        {
            return text.Replace(Environment.NewLine, "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
    }
}
