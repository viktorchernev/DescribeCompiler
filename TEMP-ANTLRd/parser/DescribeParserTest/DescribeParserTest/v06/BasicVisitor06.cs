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
    /// underlying ANTLR4 parser. The difference here is that the methods
    /// also accumulate the strings that are logged to the console in a 
    /// property - "Log". Also, logging to the console can be turned off 
    /// alltogether.
    /// </summary>
    internal class BasicVisitor06 : Describe06BaseVisitor<object>
    {
        public BasicVisitor06() 
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

        public override object VisitScripture([NotNull] Describe06Parser.ScriptureContext context)
        {
            Log += Environment.NewLine + logItem(context, "scripture");
            return base.VisitScripture(context);
        }

        public override object VisitTerminal(ITerminalNode node)
        {
            Log += Environment.NewLine + logToken(node);
            return base.VisitTerminal(node);
        }

        public override object VisitText_chunk([NotNull] Describe06Parser.Text_chunkContext context)
        {
            Log += Environment.NewLine + logItem(context, "text_chunk");
            return base.VisitText_chunk(context);
        }
        public override object VisitItem([NotNull] Describe06Parser.ItemContext context)
        {
            Log += Environment.NewLine + logItem(context, "item");
            return base.VisitItem(context);
        }
        public override object VisitExpression([NotNull] Describe06Parser.ExpressionContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression");
            return base.VisitExpression(context);
        }
        public override object VisitExpression_list([NotNull] Describe06Parser.Expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "expression_list");
            return base.VisitExpression_list(context);
        }
        public override object VisitItem_or_expression([NotNull] Describe06Parser.Item_or_expressionContext context)
        {
            Log += Environment.NewLine + logItem(context, "item_or_expression");
            return base.VisitItem_or_expression(context);
        }
        public override object VisitItem_or_expression_list([NotNull] Describe06Parser.Item_or_expression_listContext context)
        {
            Log += Environment.NewLine + logItem(context, "item_or_expression_list");
            return base.VisitItem_or_expression_list(context);
        }

        string logItem(ParserRuleContext context, string type, bool logToConsole = true)
        {
            var exception = context.exception;
            List<IParseTree> children = context.children.ToList();
            Interval interval = context.SourceInterval;

            string msg = type + ": ";
            if (exception != null) msg = "! " + msg;

            foreach (var child in children)
            {
                Type t = child.GetType();
                msg += " " + t.Name;
            }
            msg += ";";

            if (logToConsole)
            {
                Console.WriteLine(msg);
                if (exception != null)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine(exception);
                    Console.WriteLine("-------------------------------------------------");
                }
            }
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
