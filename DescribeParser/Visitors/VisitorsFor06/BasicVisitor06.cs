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
    /// parse operation, in a sequential manner, leaving the order to the
    /// underlying ANTLR4 parser.
    /// </summary>
    public class BasicVisitor06 : Describe06BaseVisitor<object>
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public BasicVisitor06() 
        {
            _log = "";
            _lerror = null;
        }

        // Vars
        string _log;
        string _lerror;

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


        // Methods
        /// <summary>
        /// Visit a <see cref="Describe06Parser.ScriptureContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.ScriptureContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitScripture([NotNull] Describe06Parser.ScriptureContext context)
        {
            Log += Environment.NewLine + logItem(context, "scripture");
            if (_lerror != null) return null;
            return base.VisitScripture(context);
        }

        /// <summary>
        /// Visit an <see cref="ITerminalNode"/> object, and log it.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitTerminal(ITerminalNode node)
        {
            Log += Environment.NewLine + logToken(node);
            return base.VisitTerminal(node);
        }


        /// <summary>
        /// Visit a <see cref="Describe06Parser.ProducerContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.ProducerContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitProducer([NotNull] Describe06Parser.ProducerContext context)
        {
            Log += Environment.NewLine + logItem(context, "producer");
            if (_lerror != null) return null;
            return base.VisitProducer(context);
        }

        /// <summary>
        /// Visit a <see cref="Describe06Parser.Text_chunkContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.Text_chunkContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitText_chunk([NotNull] Describe06Parser.Text_chunkContext context)
        {
            Log += Environment.NewLine + logItem(context, "text_chunk");
            if (_lerror != null) return null;
            return base.VisitText_chunk(context);
        }

        /// <summary>
        /// Visit a <see cref="Describe06Parser.ItemContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.ItemContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitItem([NotNull] Describe06Parser.ItemContext context)
        {
            Log += Environment.NewLine + logItem(context, "item");
            if (_lerror != null) return null;
            return base.VisitItem(context);
        }

        /// <summary>
        /// Visit a <see cref="Describe06Parser.ExpressionContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.ExpressionContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitExpression([NotNull] Describe06Parser.ExpressionContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression");
            if (_lerror != null) return null;
            return base.VisitExpression(context);
        }

        /// <summary>
        /// Visit a <see cref="Describe06Parser.Expression_listContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.Expression_listContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitExpression_list([NotNull] Describe06Parser.Expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression_list");
            if (_lerror != null) return null;
            return base.VisitExpression_list(context);
        }

        /// <summary>
        /// Visit a <see cref="Describe06Parser.Item_or_expression_listContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.Item_or_expression_listContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitItem_or_expression_list([NotNull] Describe06Parser.Item_or_expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "item_or_expression_list");
            if (_lerror != null) return null;
            return base.VisitItem_or_expression_list(context);
        }

        /// <summary>
        /// Visit a <see cref="Describe06Parser.Item_or_expression_partContext"/> object, and log it.
        /// </summary>
        /// <param name="context">The <see cref="Describe06Parser.Item_or_expression_partContext"/> object to visit.</param>
        /// <returns>?</returns>
        public override object VisitItem_or_expression_part([NotNull] Describe06Parser.Item_or_expression_partContext context)
        {
            Log += Environment.NewLine + logItem(context, "item_or_expression_part");
            if (_lerror != null) return null;
            return base.VisitItem_or_expression_part(context);
        }

        string logItem(ParserRuleContext context, string type, bool logToConsole = true)
        {
            var exception = context.exception;

            string msg = "";
            if (exception != null)
            {
                msg = type + ": ";
                if (context.children == null) msg += "NULL;";
                else
                {
                    List<IParseTree> children = context.children.ToList();
                    foreach (var child in children)
                    {
                        Type t = child.GetType();
                        msg += " " + t.Name;
                    }
                    msg += ";";
                }
            }
            else
            {
                _lerror = exception.Message;

                msg = "! " + type + ": ";
                if (context.children == null) msg += "NULL;";
                else
                {
                    List<IParseTree> children = context.children.ToList();
                    foreach (var child in children)
                    {
                        Type t = child.GetType();
                        msg += " " + t.Name;
                    }
                    msg += ";";
                }
                msg += Environment.NewLine + exception.Message + 
                    Environment.NewLine + exception.StackTrace;
            }

            if (logToConsole) Console.WriteLine(msg);
            return msg;
        }
        string logToken(ITerminalNode token, bool logToConsole = true)
        {
            string tokenType = GetTokenType(token.Symbol.Type);
            string? tokenText = token.ToString();
            if (tokenText == null) tokenText = "NULL";
            string msg = "T(" + tokenType + "|'" + ReplaceWhitespaceE(tokenText) + "')";
            if(logToConsole) Console.WriteLine(msg);
            return msg;
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
