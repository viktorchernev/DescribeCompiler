using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Visitors
{
    /// <summary>
    /// This visitor class is used to log to the console the result of a 
    /// parse operation.
    /// </summary>
    public class LogVisitor06 : Describe06BaseVisitor<object>
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public LogVisitor06()
        {
            _log = "";
            _lerror = null;
        }
        
        string _log;
        string? _lerror;

        /// <summary>
        /// Gets or sets all the logs for this instance.
        /// </summary>
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

        /// <summary>
        /// Gets the last error for this instance. 
        /// If there was an error, this string contains the message, 
        /// and if there weren't any errors, this will be `null`.
        /// </summary>
        public string? LastError
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



        private List<bool> _booliary = new List<bool>();
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
                    else if (child is Describe06Parser.Item_or_expression_listContext)
                        VisitItem_or_expression_list((Describe06Parser.Item_or_expression_listContext)child);
                    else if (child is Describe06Parser.Item_or_expression_partContext)
                        VisitItem_or_expression_part((Describe06Parser.Item_or_expression_partContext)child);
                    else if (child is Describe06Parser.Text_chunkContext)
                        VisitText_chunk((Describe06Parser.Text_chunkContext)child);
                    else if (child is Describe06Parser.ProducerContext)
                        VisitProducer((Describe06Parser.ProducerContext)child);
                }

                _booliary.RemoveAt(_booliary.Count - 1);
            }
        }


        /// <summary>
        /// Visits the Scripture node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Scripture node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitScripture([NotNull] Describe06Parser.ScriptureContext context)
        {
            Validators.ValidateParserRuleContext(context);

            Log += Environment.NewLine + logItem(context, "scripture");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }


        /// <summary>
        /// Visits a terminal node in the Describe06 parse tree.
        /// </summary>
        /// <param name="node">The terminal node to visit.</param>
        /// <returns>A string indicating the success of the visit.</returns>
        public override string VisitTerminal(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);
            Log += Environment.NewLine + logToken(node);
            return "success";
        }


        /// <summary>
        /// Visits the Producer node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Producer node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitProducer([NotNull] Describe06Parser.ProducerContext context)
        {
            Validators.ValidateParserRuleContext(context);

            Log += Environment.NewLine + logItem(context, "producer");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }

        /// <summary>
        /// Visits the Text_chunk node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Text_chunk node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitText_chunk([NotNull] Describe06Parser.Text_chunkContext context)
        {
            Validators.ValidateParserRuleContext(context);

            Log += Environment.NewLine + logItem(context, "text_chunk");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }

        /// <summary>
        /// Visits the Item node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Item node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitItem([NotNull] Describe06Parser.ItemContext context)
        {
            Validators.ValidateParserRuleContext(context);

            Log += Environment.NewLine + logItem(context, "item");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }

        /// <summary>
        /// Visits the Expression node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Expression node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitExpression([NotNull] Describe06Parser.ExpressionContext context)
        {
            Validators.ValidateParserRuleContext(context);

            Log += Environment.NewLine + logItem(context, "expression");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }

        /// <summary>
        /// Visits the Expression_list node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Expression_list node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitExpression_list([NotNull] Describe06Parser.Expression_listContext context)
        {
            Validators.ValidateParserRuleContext(context);

            Log += Environment.NewLine + logItem(context, "expression_list");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }

        /// <summary>
        /// Visits the Item_or_expression_list node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Item_or_expression_list node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitItem_or_expression_list([NotNull] Describe06Parser.Item_or_expression_listContext context)
        {
            Validators.ValidateParserRuleContext(context);

            Log += Environment.NewLine + logItem(context, "item_or_expression_list");
            if (_lerror != null) return "error";
            visitChildren(context);
            return "success";
        }

        /// <summary>
        /// Visits the Item_or_expression_part node in the Describe06 parse tree.
        /// </summary>
        /// <param name="context">The context of the Item_or_expression_part node.</param>
        /// <returns>A string indicating the success or failure of the visit.</returns>
        public override string VisitItem_or_expression_part([NotNull] Describe06Parser.Item_or_expression_partContext context)
        {
            Validators.ValidateParserRuleContext(context);

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
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
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
