using Antlr4.Runtime;
using DescribeParser.Unfold;

namespace DescribeParser.Visitors
{
    /// <summary>
    /// An Unfold visitor for all Describe Language versions in one class.
    /// Used to extract data and store it in an <see cref="DescribeUnfold"/>
    /// </summary>
    public class UniversalUnfoldVisitor
    {
        // Vars
        string _log;
        string? _lerror;
        UnfoldVisitor06 visitor06;
        UnfoldVisitor07 visitor07;
        UnfoldVisitor08 visitor08;
        UnfoldVisitor09 visitor09;
        UnfoldVisitor10 visitor10;
        UnfoldVisitor11 visitor11;

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


        /// <summary>
        /// Determines the language version of the <see cref="ParserRuleContext"/> 
        /// object by its type, and performs the translate action on it.
        /// </summary>
        /// <param name="u">The <see cref="DescribeUnfold"/> class that will be populated</param>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public bool TranslateContext(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
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

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in UnfoldVisitor06 (Describe v06).
        /// </summary>
        /// <param name="u">The <see cref="DescribeUnfold"/> class that will be populated.</param>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public bool TranslateContext06(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor06.LastError = null;
            visitor06.Log = "";
            if(context is Describe06Parser.ScriptureContext)
            {
                bool result = visitor06.TranslateScripture(u, (context as Describe06Parser.ScriptureContext)!, filename);
                LastError = visitor06.LastError;
                Log = visitor06.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in UnfoldVisitor07 (Describe v07).
        /// </summary>
        /// <param name="u">The <see cref="DescribeUnfold"/> class that will be populated.</param>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public bool TranslateContext07(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor07.LastError = null;
            visitor07.Log = "";
            if (context is Describe07Parser.ScriptureContext)
            {
                bool result = visitor07.TranslateScripture(u, (context as Describe07Parser.ScriptureContext)!, filename);
                LastError = visitor07.LastError;
                Log = visitor07.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in UnfoldVisitor08 (Describe v08).
        /// </summary>
        /// <param name="u">The <see cref="DescribeUnfold"/> class that will be populated.</param>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public bool TranslateContext08(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor08.LastError = null;
            visitor08.Log = "";
            if (context is Describe08Parser.ScriptureContext)
            {
                bool result = visitor08.TranslateScripture(u, (context as Describe08Parser.ScriptureContext)!, filename);
                LastError = visitor08.LastError;
                Log = visitor08.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in UnfoldVisitor09 (Describe v09).
        /// </summary>
        /// <param name="u">The <see cref="DescribeUnfold"/> class that will be populated.</param>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public bool TranslateContext09(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor09.LastError = null;
            visitor09.Log = "";
            if (context is Describe09Parser.ScriptureContext)
            {
                bool result = visitor09.TranslateScripture(u, (context as Describe09Parser.ScriptureContext)!, filename);
                LastError = visitor09.LastError;
                Log = visitor09.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in UnfoldVisitor10 (Describe v10).
        /// </summary>
        /// <param name="u">The <see cref="DescribeUnfold"/> class that will be populated.</param>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public bool TranslateContext10(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor10.LastError = null;
            visitor10.Log = "";
            if (context is Describe10Parser.ScriptureContext)
            {
                bool result = visitor10.TranslateScripture(u, (context as Describe10Parser.ScriptureContext)!, filename);
                LastError = visitor10.LastError;
                Log = visitor10.Log;
                return result;
            }

            string? fullTypeName = context.GetType().FullName;
            LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
            throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
        }

        /// <summary>
        /// Translates the <see cref="ParserRuleContext"/> object using in UnfoldVisitor11 (Describe v11).
        /// </summary>
        /// <param name="u">The <see cref="DescribeUnfold"/> class that will be populated.</param>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to translate.</param>
        /// <param name="filename">The <see cref="string"/> filename for the operation.</param>
        /// <returns>true if successful, false if not.</returns>
        public bool TranslateContext11(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            visitor11.LastError = null;
            visitor11.Log = "";
            if (context is Describe11Parser.ScriptureContext)
            {
                bool result = visitor11.TranslateScripture(u, (context as Describe11Parser.ScriptureContext)!, filename);
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
