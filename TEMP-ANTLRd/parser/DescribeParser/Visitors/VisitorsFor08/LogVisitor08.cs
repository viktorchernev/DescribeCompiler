using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DescribeParser.AST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Visitors
{
    /// <summary>
    /// This visitor class is used to log to the console the result of a 
    /// parse poeration, in a sequential manner, leaving the order to the
    /// underlying ANTLR4 parser.
    /// </summary>
    public class LogVisitor08 : Describe08BaseVisitor<object>
    {
        public LogVisitor08()
        {
            _log = "";
            _lerror = null;
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

        string _lerror;
        public string LastError
        {
            get
            {
                return _lerror;
            }
            set
            {
                _lerror = value;
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
                    if (child is Describe08Parser.ExpressionContext)
                        VisitExpression((Describe08Parser.ExpressionContext)child);
                    else if (child is Describe08Parser.Expression_listContext)
                        VisitExpression_list((Describe08Parser.Expression_listContext)child);
                    else if (child is Describe08Parser.ItemContext)
                        VisitItem((Describe08Parser.ItemContext)child);
                    else if (child is Describe08Parser.Item_or_expression_listContext)
                        VisitItem_or_expression_list((Describe08Parser.Item_or_expression_listContext)child);
                    else if (child is Describe08Parser.Item_or_expression_partContext)
                        VisitItem_or_expression_part((Describe08Parser.Item_or_expression_partContext)child);
                    else if (child is Describe08Parser.Text_chunkContext)
                        VisitText_chunk((Describe08Parser.Text_chunkContext)child);
                    else if (child is Describe08Parser.ProducerContext)
                        VisitProducer((Describe08Parser.ProducerContext)child);
                }

                _booliary.RemoveAt(_booliary.Count - 1);
            }
        }
        public override string VisitScripture([NotNull] Describe08Parser.ScriptureContext context)
        {
            Log += Environment.NewLine + logItem(context, "scripture");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }

        public override string VisitTerminal(ITerminalNode node)
        {
            Log += Environment.NewLine + logToken(node);
            return "success";
        }

        public override string VisitProducer([NotNull] Describe08Parser.ProducerContext context)
        {
            Log += Environment.NewLine + logItem(context, "producer");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }
        public override string VisitText_chunk([NotNull] Describe08Parser.Text_chunkContext context)
        {
            Log += Environment.NewLine + logItem(context, "text_chunk");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }
        public override string VisitItem([NotNull] Describe08Parser.ItemContext context)
        {
            Log += Environment.NewLine + logItem(context, "item");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }
        public override string VisitExpression([NotNull] Describe08Parser.ExpressionContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }
        public override string VisitExpression_list([NotNull] Describe08Parser.Expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression_list");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }
        public override string VisitItem_or_expression_list([NotNull] Describe08Parser.Item_or_expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "item_or_expression_list");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }
        public override string VisitItem_or_expression_part([NotNull] Describe08Parser.Item_or_expression_partContext context)
        {
            Log += Environment.NewLine + logItem(context, "item_or_expression_part");
            if (_lerror != null) return "error";
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
        string logItem(ParserRuleContext context, string type, bool logToConsole = true)
        {
            string indent = getIndent();
            var exception = context.exception;

            string msg = "";
            if (exception != null)
            {
                _lerror = exception.Message;
                msg = exception.Message + Environment.NewLine + exception.StackTrace;
            }
            else
            {
                msg = indent + type;
            }
            
            
            if(logToConsole) Console.WriteLine(msg);
            return msg;
        }
        string logToken(ITerminalNode token, bool logToConsole = true)
        {
            string indent = getIndent();

            string tokenType = GetTokenType(token.Symbol.Type);
            string? tokenText = token.ToString();
            if (tokenText == null) tokenText = "NULL";

            if(logToConsole)
            {
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
            }

            string message = indent + "T(" + tokenType + "|'" + ReplaceWhitespaceE(tokenText) + "')";
            return message;
        }



        static string GetTokenType(int tokenType)
        {
            return Describe08Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        static string ReplaceWhitespaceE(string text)
        {
            return text.Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
        static string ReplaceWhitespaceS(string text)
        {
            return text.Replace("\n", "↓")
                .Replace("\r", "←")
                .Replace("\t", "→");
        }
    }
}
