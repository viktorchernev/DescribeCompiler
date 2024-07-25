using Antlr4.Runtime;
using DescribeParser.Ast;
using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Visitors
{
    public class UniversalLogVisitor
    {
        // Vars
        string _log;
        string _lerror;
        LogVisitor06 visitor06;
        LogVisitor07 visitor07;
        LogVisitor08 visitor08;
        LogVisitor09 visitor09;
        LogVisitor10 visitor10;
        LogVisitor11 visitor11;

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


        // Ctor
        public UniversalLogVisitor()
        {
            _log = "";
            _lerror = null;

            visitor06 = new LogVisitor06();
            visitor07 = new LogVisitor07();
            visitor08 = new LogVisitor08();
            visitor09 = new LogVisitor09();
            visitor10 = new LogVisitor10();
            visitor11 = new LogVisitor11();
        }


        public string VisitContext(ParserRuleContext context)
        {
            string? fullTypeName = context.GetType().FullName;
            if (fullTypeName == null)
            {
                LastError = "Invalid context type.";
                throw new Exception("Invalid context type.");
            }
            string[] parts = fullTypeName.Split('.');
            if (parts.Length < 2)
            {
                LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }
            string ver = parts[parts.Length - 2];

            switch(ver)
            {
                case "Describe06Parser": return VisitContext06(context);
                case "Describe07Parser": return VisitContext07(context);
                case "Describe08Parser": return VisitContext08(context);
                case "Describe09Parser": return VisitContext09(context);
                case "Describe10Parser": return VisitContext10(context);
                case "Describe11Parser": return VisitContext11(context);
                default:
                    LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                    throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }
        }
        public string VisitContext06(ParserRuleContext context)
        {
            string? fullTypeName = context.GetType().FullName;
            visitor06.LastError = null;
            visitor06.Log = "";

            string result = null;
            if(context is Describe06Parser.ScriptureContext)
                result = visitor06.VisitScripture(context as Describe06Parser.ScriptureContext);
            else if(context is Describe06Parser.ExpressionContext)
                result = visitor06.VisitExpression(context as Describe06Parser.ExpressionContext);
            else if (context is Describe06Parser.ItemContext)
                result = visitor06.VisitItem(context as Describe06Parser.ItemContext);
            else if (context is Describe06Parser.Expression_listContext)
                result = visitor06.VisitExpression_list(context as Describe06Parser.Expression_listContext);
            else if (context is Describe06Parser.Item_or_expression_listContext)
                result = visitor06.VisitItem_or_expression_list(context as Describe06Parser.Item_or_expression_listContext);
            else if (context is Describe06Parser.Item_or_expression_partContext)
                result = visitor06.VisitItem_or_expression_part(context as Describe06Parser.Item_or_expression_partContext);
            else if (context is Describe06Parser.Text_chunkContext)
                result = visitor06.VisitText_chunk(context as Describe06Parser.Text_chunkContext);
            else if (context is Describe06Parser.ProducerContext)
                result = visitor06.VisitProducer(context as Describe06Parser.ProducerContext);
            else
            {
                LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }

            LastError = visitor06.LastError;
            Log = visitor06.Log;

            if(result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }
        public string VisitContext07(ParserRuleContext context)
        {
            visitor07.LastError = null;
            visitor07.Log = "";
            if (context is Describe07Parser.ScriptureContext)
            {
                string result = visitor07.VisitScripture(context as Describe07Parser.ScriptureContext);
                LastError = visitor07.LastError;
                Log = visitor07.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public string VisitContext08(ParserRuleContext context)
        {
            visitor08.LastError = null;
            visitor08.Log = "";
            if (context is Describe08Parser.ScriptureContext)
            {
                string result = visitor08.VisitScripture(context as Describe08Parser.ScriptureContext);
                LastError = visitor08.LastError;
                Log = visitor08.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public string VisitContext09(ParserRuleContext context)
        {
            visitor09.LastError = null;
            visitor09.Log = "";
            if (context is Describe09Parser.ScriptureContext)
            {
                string result = visitor09.VisitScripture(context as Describe09Parser.ScriptureContext);
                LastError = visitor09.LastError;
                Log = visitor09.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public string VisitContext10(ParserRuleContext context)
        {
            visitor10.LastError = null;
            visitor10.Log = "";
            if (context is Describe10Parser.ScriptureContext)
            {
                string result = visitor10.VisitScripture(context as Describe10Parser.ScriptureContext);
                LastError = visitor10.LastError;
                Log = visitor10.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public string VisitContext11(ParserRuleContext context)
        {
            visitor11.LastError = null;
            visitor11.Log = "";
            if (context is Describe11Parser.ScriptureContext)
            {
                string result = visitor11.VisitScripture(context as Describe11Parser.ScriptureContext);
                LastError = visitor11.LastError;
                Log = visitor11.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
    }
}
