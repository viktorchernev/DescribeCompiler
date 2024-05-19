using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParserTest
{
    /// <summary>
    /// This visitor class is used to log to the console the result of a 
    /// parse poeration, in a sequential manner, leaving the order to the
    /// underlying ANTLR4 parser.
    /// </summary>
    internal class LogVisitor06 : Describe06BaseVisitor<object>
    {
        public LogVisitor06()
        {
            _log = "";
        }
        
        string _log;
        public string Log
        {
            get
            {
                return _log;
            }
            set
            {
                _log = value;
            }
        }

        List<bool> _booliary = new List<bool>();

        void visitChildren(ParserRuleContext context)
        {
            int childCount = context.ChildCount;

            for (int i = 0; i < childCount; i++)
            {
                bool isLastChild = false;
                if (i == childCount - 1) isLastChild = true;
                _booliary.Add(isLastChild);

                IParseTree child = context.GetChild(i);
                if (child is ITerminalNode terminalNode)
                {
                    VisitTerminal(terminalNode);
                }
                else if (child is ParserRuleContext childContext)
                {
                    if (child is Describe06Parser.ExpressionContext)
                        VisitExpression((Describe06Parser.ExpressionContext)child);
                    else if (child is Describe06Parser.Expression_listContext)
                        VisitExpression_list((Describe06Parser.Expression_listContext)child);
                    else if (child is Describe06Parser.ItemContext)
                        VisitItem((Describe06Parser.ItemContext)child);
                    else if (child is Describe06Parser.Item_or_expressionContext)
                        VisitItem_or_expression((Describe06Parser.Item_or_expressionContext)child);
                    else if (child is Describe06Parser.Item_or_expression_listContext)
                        VisitItem_or_expression_list((Describe06Parser.Item_or_expression_listContext)child);
                    else if (child is Describe06Parser.Text_chunkContext)
                        VisitText_chunk((Describe06Parser.Text_chunkContext)child);
                }

                _booliary.RemoveAt(_booliary.Count - 1);
            }
        }
        public override string VisitScripture([NotNull] Describe06Parser.ScriptureContext context)
        {
            logItem(context, "scripture");
            visitChildren(context);
            return "success";
        }

        public override string VisitTerminal(ITerminalNode node)
        {
            logToken(node);
            return "success";
        }

        public override string VisitText_chunk([NotNull] Describe06Parser.Text_chunkContext context)
        {
            logItem(context, "text_chunk");
            visitChildren(context);
            return "success";
        }
        public override string VisitItem([NotNull] Describe06Parser.ItemContext context)
        {
            logItem(context, "item");
            visitChildren(context);
            return "success";
        }
        public override string VisitExpression([NotNull] Describe06Parser.ExpressionContext context)
        {
            logItem(context, "expression");
            visitChildren(context);
            return "success";
        }
        public override string VisitExpression_list([NotNull] Describe06Parser.Expression_listContext context)
        {
            logItem(context, "expression_list");
            visitChildren(context);
            return "success";
        }
        public override string VisitItem_or_expression([NotNull] Describe06Parser.Item_or_expressionContext context)
        {
            logItem(context, "item_or_expression");
            visitChildren(context);
            return "success";
        }
        public override string VisitItem_or_expression_list([NotNull] Describe06Parser.Item_or_expression_listContext context)
        {
            logItem(context, "item_or_expression_list");
            visitChildren(context);
            return "success";
        }



        private string getIndent()
        {
            var indent = string.Empty;
            for (int i = 0; i < _booliary.Count; i++)
            {
                if (i < _booliary.Count - 1)
                {
                    if (_booliary[i] == true) indent += "    ";
                    else indent += "│   ";
                }
                else
                {
                    if (_booliary[i] == true) indent += "└── ";
                    else indent += "├── ";
                }
            }
            return indent;
        }
        void logItem(ParserRuleContext context, string type)
        {
            string indent = getIndent();

            var exception = context.exception;
            List<IParseTree> children = context.children.ToList();
            Interval interval = context.SourceInterval;

            string msg = type + ": ";
            if (exception != null) msg = "! " + msg;
            msg = indent + msg;
            
            Console.WriteLine(msg);
            if (exception != null)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine(exception);
                Console.WriteLine("-------------------------------------------------");
            }
        }
        void logToken(ITerminalNode token)
        {
            string indent = getIndent();

            string tokenType = GetTokenType(token.Symbol.Type);
            string? tokenText = token.ToString();
            if (tokenText == null) tokenText = "NULL";


            string msg = indent;
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            msg = "T(" + tokenType + "|'";
            Console.Write(msg);
            msg = ReplaceWhitespaceE(tokenText);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("')");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            msg = indent + msg;
        }



        static string GetTokenType(int type)
        {
            switch (type)
            {
                case 1: return "LINE_COMMENT";
                case 2: return "BLOCK_COMMENT";
                case 3: return "NEWLINE";
                case 4: return "PRODUCER";
                case 5: return "SEPARATOR";
                case 6: return "TERMINATOR";
                case 7: return "ESCAPE_ESCAPE";
                case 8: return "ESCAPE_PRODUCER";
                case 9: return "ESCAPE_SEPARATOR";
                case 10: return "ESCAPE_TERMINATOR";
                case 11: return "ESCAPE_LCOMMENT";
                case 12: return "ESCAPE_BCOMMENT";
                case 13: return "DATA";
                case -1: return "EOF";
                default: return type.ToString() + " is unknown";
            }
        }
        static string GetTokenType2(int tokenType) //an alternative (possibly slower)
        {
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        static string ReplaceWhitespaceE(string text)
        {
            return text.Replace(Environment.NewLine, "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
        static string ReplaceWhitespaceS(string text)
        {
            return text.Replace(Environment.NewLine, "↓")
                .Replace("\r", "←")
                .Replace("\t", "→");
        }
    }
}
