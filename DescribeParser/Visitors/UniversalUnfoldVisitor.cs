using Antlr4.Runtime;
using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Visitors
{
    public class UniversalUnfoldVisitor
    {
        // Vars
        string _log;
        string _lerror;
        UnfoldVisitor06 visitor06;
        UnfoldVisitor07 visitor07;
        UnfoldVisitor08 visitor08;
        UnfoldVisitor09 visitor09;
        UnfoldVisitor10 visitor10;
        UnfoldVisitor11 visitor11;

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
        public UniversalUnfoldVisitor()
        {
            _log = "";
            _lerror = null;

            visitor06 = new UnfoldVisitor06();
            visitor07 = new UnfoldVisitor07();
            visitor08 = new UnfoldVisitor08();
            visitor09 = new UnfoldVisitor09();
            visitor10 = new UnfoldVisitor10();
            visitor11 = new UnfoldVisitor11();
        }


        public bool TranslateContext(DescribeUnfold u, ParserRuleContext context, string filename = "")
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
                case "Describe06Parser": return TranslateContext06(u, context, filename);
                case "Describe07Parser": return TranslateContext07(u, context, filename);
                case "Describe08Parser": return TranslateContext08(u, context, filename);
                case "Describe09Parser": return TranslateContext09(u, context, filename);
                case "Describe10Parser": return TranslateContext10(u, context, filename);
                case "Describe11Parser": return TranslateContext11(u, context, filename);
                default:
                    LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                    throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }
        }
        public bool TranslateContext06(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            visitor06.LastError = null;
            visitor06.Log = "";
            if(context is Describe06Parser.ScriptureContext)
            {
                bool result = visitor06.TranslateScripture(u, context as Describe06Parser.ScriptureContext, filename);
                LastError = visitor06.LastError;
                Log = visitor06.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public bool TranslateContext07(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            visitor07.LastError = null;
            visitor07.Log = "";
            if (context is Describe07Parser.ScriptureContext)
            {
                bool result = visitor07.TranslateScripture(u, context as Describe07Parser.ScriptureContext, filename);
                LastError = visitor07.LastError;
                Log = visitor07.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public bool TranslateContext08(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            visitor08.LastError = null;
            visitor08.Log = "";
            if (context is Describe08Parser.ScriptureContext)
            {
                bool result = visitor08.TranslateScripture(u, context as Describe08Parser.ScriptureContext, filename);
                LastError = visitor08.LastError;
                Log = visitor08.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public bool TranslateContext09(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            visitor09.LastError = null;
            visitor09.Log = "";
            if (context is Describe09Parser.ScriptureContext)
            {
                bool result = visitor09.TranslateScripture(u, context as Describe09Parser.ScriptureContext, filename);
                LastError = visitor09.LastError;
                Log = visitor09.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public bool TranslateContext10(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            visitor10.LastError = null;
            visitor10.Log = "";
            if (context is Describe10Parser.ScriptureContext)
            {
                bool result = visitor10.TranslateScripture(u, context as Describe10Parser.ScriptureContext, filename);
                LastError = visitor10.LastError;
                Log = visitor10.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }
        public bool TranslateContext11(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            visitor11.LastError = null;
            visitor11.Log = "";
            if (context is Describe11Parser.ScriptureContext)
            {
                bool result = visitor11.TranslateScripture(u, context as Describe11Parser.ScriptureContext, filename);
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
