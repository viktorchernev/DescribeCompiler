using Antlr4.Runtime;
using DescribeParser.Ast;

namespace DescribeParser.Visitors
{
    /// <summary>
    /// An Ast visitor for all Describe Language versions in one class.
    /// Used to build Abstract Syntax Tree.
    /// </summary>
    public class UniversalAstVisitor
    {
        // Vars
        string _log;
        string? _lerror;
        AstVisitor06 visitor06;
        AstVisitor07 visitor07;
        AstVisitor08 visitor08;
        AstVisitor09 visitor09;
        AstVisitor10 visitor10;
        AstVisitor11 visitor11;

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
                Validators.ValidateString(value);
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


        // Ctor
        /// <summary>
        /// Ctor.
        /// </summary>
        public UniversalAstVisitor()
        {
            _log = "";
            _lerror = null;

            visitor06 = new AstVisitor06();
            visitor07 = new AstVisitor07();
            visitor08 = new AstVisitor08();
            visitor09 = new AstVisitor09();
            visitor10 = new AstVisitor10();
            visitor11 = new AstVisitor11();
        }


        /// <summary>
        /// Determines the language version of the <see cref="ParserRuleContext"/> 
        /// object by its type, and performs the translate action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public AstScriptureNode TranslateContext(ParserRuleContext context, string filename = "")
        {
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

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
                case "Describe06Parser": return TranslateContext06(context, filename);
                case "Describe07Parser": return TranslateContext07(context, filename);
                case "Describe08Parser": return TranslateContext08(context, filename);
                case "Describe09Parser": return TranslateContext09(context, filename);
                case "Describe10Parser": return TranslateContext10(context, filename);
                case "Describe11Parser": return TranslateContext11(context, filename);
                default:
                    LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                    throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in LogVisitor06 (Describe v06).
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public AstScriptureNode TranslateContext06(ParserRuleContext context, string filename = "")
        {
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor06.LastError = null;
            visitor06.Log = "";
            if(context is Describe06Parser.ScriptureContext)
            {
                AstScriptureNode result = visitor06.TranslateScripture((context as Describe06Parser.ScriptureContext)!, filename);
                LastError = visitor06.LastError;
                Log = visitor06.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in LogVisitor07 (Describe v07).
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public AstScriptureNode TranslateContext07(ParserRuleContext context, string filename = "")
        {
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor07.LastError = null;
            visitor07.Log = "";
            if (context is Describe07Parser.ScriptureContext)
            {
                AstScriptureNode result = visitor07.TranslateScripture((context as Describe07Parser.ScriptureContext)!, filename);
                LastError = visitor07.LastError;
                Log = visitor07.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in LogVisitor08 (Describe v08).
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public AstScriptureNode TranslateContext08(ParserRuleContext context, string filename = "")
        {
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor08.LastError = null;
            visitor08.Log = "";
            if (context is Describe08Parser.ScriptureContext)
            {
                AstScriptureNode result = visitor08.TranslateScripture((context as Describe08Parser.ScriptureContext)!, filename);
                LastError = visitor08.LastError;
                Log = visitor08.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in LogVisitor09 (Describe v09).
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public AstScriptureNode TranslateContext09(ParserRuleContext context, string filename = "")
        {
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor09.LastError = null;
            visitor09.Log = "";
            if (context is Describe09Parser.ScriptureContext)
            {
                AstScriptureNode result = visitor09.TranslateScripture((context as Describe09Parser.ScriptureContext)!, filename);
                LastError = visitor09.LastError;
                Log = visitor09.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in LogVisitor10 (Describe v10).
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public AstScriptureNode TranslateContext10(ParserRuleContext context, string filename = "")
        {
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor10.LastError = null;
            visitor10.Log = "";
            if (context is Describe10Parser.ScriptureContext)
            {
                AstScriptureNode result = visitor10.TranslateScripture((context as Describe10Parser.ScriptureContext)!, filename);
                LastError = visitor10.LastError;
                Log = visitor10.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in LogVisitor11 (Describe v11).
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public AstScriptureNode TranslateContext11(ParserRuleContext context, string filename = "")
        {
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor11.LastError = null;
            visitor11.Log = "";
            if (context is Describe11Parser.ScriptureContext)
            {
                AstScriptureNode result = visitor11.TranslateScripture((context as Describe11Parser.ScriptureContext)!, filename);
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
