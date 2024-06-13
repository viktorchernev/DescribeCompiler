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
    /// parse poeration, in a sequential manner, leaving the order to the
    /// underlying ANTLR4 parser. The difference here is that the methods
    /// also accumulate the strings that are logged to the console in a 
    /// property - "Log". Also, logging to the console can be turned off 
    /// alltogether.
    /// </summary>
    public class BasicVisitor06 : Describe06BaseVisitor<object>
    {
        public BasicVisitor06() 
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


        public override object VisitScripture([NotNull] Describe06Parser.ScriptureContext context)
        {
            Log += Environment.NewLine + logItem(context, "scripture");
            if (_lerror != null) return null;
            return base.VisitScripture(context);
        }

        public override object VisitTerminal(ITerminalNode node)
        {
            Log += Environment.NewLine + logToken(node);
            return base.VisitTerminal(node);
        }

        public override object VisitProducer([NotNull] Describe06Parser.ProducerContext context)
        {
            Log += Environment.NewLine + logItem(context, "producer");
            if (_lerror != null) return null;
            return base.VisitProducer(context);
        }
        public override object VisitText_chunk([NotNull] Describe06Parser.Text_chunkContext context)
        {
            Log += Environment.NewLine + logItem(context, "text_chunk");
            if (_lerror != null) return null;
            return base.VisitText_chunk(context);
        }
        public override object VisitItem([NotNull] Describe06Parser.ItemContext context)
        {
            Log += Environment.NewLine + logItem(context, "item");
            if (_lerror != null) return null;
            return base.VisitItem(context);
        }
        public override object VisitExpression([NotNull] Describe06Parser.ExpressionContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression");
            if (_lerror != null) return null;
            return base.VisitExpression(context);
        }
        public override object VisitExpression_list([NotNull] Describe06Parser.Expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression_list");
            if (_lerror != null) return null;
            return base.VisitExpression_list(context);
        }
        public override object VisitItem_or_expression_list([NotNull] Describe06Parser.Item_or_expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "item_or_expression_list");
            if (_lerror != null) return null;
            return base.VisitItem_or_expression_list(context);
        }
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



        static string GetTokenType(int tokenType) //an alternative (possibly slower)
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
