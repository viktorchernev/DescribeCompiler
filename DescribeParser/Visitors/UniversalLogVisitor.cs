using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace DescribeParser.Visitors
{
    /// <summary>
    /// A Log visitor for all Describe Language versions in one class.
    /// </summary>
    public class UniversalLogVisitor
    {
        // Vars
        string _log;
        string? _lerror;
        LogVisitor06 visitor06;
        LogVisitor07 visitor07;
        LogVisitor08 visitor08;
        LogVisitor09 visitor09;
        LogVisitor10 visitor10;
        LogVisitor11 visitor11;

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


        /// <summary>
        /// Visits a <see cref="ParserRuleContext"/>, 
        /// determines the language version of the object by its type, 
        /// and performs the appropriate visit action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitContext(ParserRuleContext context)
        {
            Validators.ValidateParserRuleContext(context);

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

        /// <summary>
        /// Visits a <see cref="ParserRuleContext"/>, 
        /// and performs the appropriate visit action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitContext06(ParserRuleContext context)
        {
            Validators.ValidateParserRuleContext(context);

            string? fullTypeName = context.GetType().FullName;
            visitor06.LastError = null;
            visitor06.Log = "";

            string result = null!;
            if(context is Describe06Parser.ScriptureContext)
                result = visitor06.VisitScripture((context as Describe06Parser.ScriptureContext)!);
            else if(context is Describe06Parser.ExpressionContext)
                result = visitor06.VisitExpression((context as Describe06Parser.ExpressionContext)!);
            else if (context is Describe06Parser.ItemContext)
                result = visitor06.VisitItem((context as Describe06Parser.ItemContext)!);
            else if (context is Describe06Parser.Expression_listContext)
                result = visitor06.VisitExpression_list((context as Describe06Parser.Expression_listContext)!);
            else if (context is Describe06Parser.Item_or_expression_listContext)
                result = visitor06.VisitItem_or_expression_list((context as Describe06Parser.Item_or_expression_listContext)!);
            else if (context is Describe06Parser.Item_or_expression_partContext)
                result = visitor06.VisitItem_or_expression_part((context as Describe06Parser.Item_or_expression_partContext)!);
            else if (context is Describe06Parser.Text_chunkContext)
                result = visitor06.VisitText_chunk((context as Describe06Parser.Text_chunkContext)!);
            else if (context is Describe06Parser.ProducerContext)
                result = visitor06.VisitProducer((context as Describe06Parser.ProducerContext)!);
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

        /// <summary>
        /// Visits a <see cref="ParserRuleContext"/>, 
        /// and performs the appropriate visit action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitContext07(ParserRuleContext context)
        {
            Validators.ValidateParserRuleContext(context);

            string? fullTypeName = context.GetType().FullName;
            visitor07.LastError = null;
            visitor07.Log = "";

            string result = null!;
            if (context is Describe07Parser.ScriptureContext)
                result = visitor07.VisitScripture((context as Describe07Parser.ScriptureContext)!);
            else if (context is Describe07Parser.ExpressionContext)
                result = visitor07.VisitExpression((context as Describe07Parser.ExpressionContext)!);
            else if (context is Describe07Parser.ItemContext)
                result = visitor07.VisitItem((context as Describe07Parser.ItemContext)!);
            else if (context is Describe07Parser.Expression_listContext)
                result = visitor07.VisitExpression_list((context as Describe07Parser.Expression_listContext)!);
            else if (context is Describe07Parser.Item_or_expression_listContext)
                result = visitor07.VisitItem_or_expression_list((context as Describe07Parser.Item_or_expression_listContext)!);
            else if (context is Describe07Parser.Item_or_expression_partContext)
                result = visitor07.VisitItem_or_expression_part((context as Describe07Parser.Item_or_expression_partContext)!);
            else if (context is Describe07Parser.Text_chunkContext)
                result = visitor07.VisitText_chunk((context as Describe07Parser.Text_chunkContext)!);
            else if (context is Describe07Parser.ProducerContext)
                result = visitor07.VisitProducer((context as Describe07Parser.ProducerContext)!);
            else
            {
                LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }

            LastError = visitor07.LastError;
            Log = visitor07.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ParserRuleContext"/>, 
        /// and performs the appropriate visit action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitContext08(ParserRuleContext context)
        {
            Validators.ValidateParserRuleContext(context);

            string? fullTypeName = context.GetType().FullName;
            visitor08.LastError = null;
            visitor08.Log = "";

            string result = null!;
            if (context is Describe08Parser.ScriptureContext)
                result = visitor08.VisitScripture((context as Describe08Parser.ScriptureContext)!);
            else if (context is Describe08Parser.ExpressionContext)
                result = visitor08.VisitExpression((context as Describe08Parser.ExpressionContext)!);
            else if (context is Describe08Parser.ItemContext)
                result = visitor08.VisitItem((context as Describe08Parser.ItemContext)!);
            else if (context is Describe08Parser.Expression_listContext)
                result = visitor08.VisitExpression_list((context as Describe08Parser.Expression_listContext)!);
            else if (context is Describe08Parser.Item_or_expression_listContext)
                result = visitor08.VisitItem_or_expression_list((context as Describe08Parser.Item_or_expression_listContext)!);
            else if (context is Describe08Parser.Item_or_expression_partContext)
                result = visitor08.VisitItem_or_expression_part((context as Describe08Parser.Item_or_expression_partContext)!);
            else if (context is Describe08Parser.Text_chunkContext)
                result = visitor08.VisitText_chunk((context as Describe08Parser.Text_chunkContext)!);
            else if (context is Describe08Parser.ProducerContext)
                result = visitor08.VisitProducer((context as Describe08Parser.ProducerContext)!);
            else
            {
                LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }

            LastError = visitor08.LastError;
            Log = visitor08.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ParserRuleContext"/>, 
        /// and performs the appropriate visit action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitContext09(ParserRuleContext context)
        {
            Validators.ValidateParserRuleContext(context);

            string? fullTypeName = context.GetType().FullName;
            visitor09.LastError = null;
            visitor09.Log = "";

            string result = null!;
            if (context is Describe09Parser.ScriptureContext)
                result = visitor09.VisitScripture((context as Describe09Parser.ScriptureContext)!);
            else if (context is Describe09Parser.ExpressionContext)
                result = visitor09.VisitExpression((context as Describe09Parser.ExpressionContext)!);
            else if (context is Describe09Parser.ItemContext)
                result = visitor09.VisitItem((context as Describe09Parser.ItemContext)!);
            else if (context is Describe09Parser.Expression_listContext)
                result = visitor09.VisitExpression_list((context as Describe09Parser.Expression_listContext)!);
            else if (context is Describe09Parser.Item_or_expression_listContext)
                result = visitor09.VisitItem_or_expression_list((context as Describe09Parser.Item_or_expression_listContext)!);
            else if (context is Describe09Parser.Item_or_expression_partContext)
                result = visitor09.VisitItem_or_expression_part((context as Describe09Parser.Item_or_expression_partContext)!);
            else if (context is Describe09Parser.Text_chunkContext)
                result = visitor09.VisitText_chunk((context as Describe09Parser.Text_chunkContext)!);
            else if (context is Describe09Parser.ProducerContext)
                result = visitor09.VisitProducer((context as Describe09Parser.ProducerContext)!);
            else
            {
                LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }

            LastError = visitor09.LastError;
            Log = visitor09.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ParserRuleContext"/>, 
        /// and performs the appropriate visit action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitContext10(ParserRuleContext context)
        {
            Validators.ValidateParserRuleContext(context);

            string? fullTypeName = context.GetType().FullName;
            visitor10.LastError = null;
            visitor10.Log = "";

            string result = null!;
            if (context is Describe10Parser.ScriptureContext)
                result = visitor10.VisitScripture((context as Describe10Parser.ScriptureContext)!);
            else if (context is Describe10Parser.ExpressionContext)
                result = visitor10.VisitExpression((context as Describe10Parser.ExpressionContext)!);
            else if (context is Describe10Parser.ItemContext)
                result = visitor10.VisitItem((context as Describe10Parser.ItemContext)!);
            else if (context is Describe10Parser.Expression_listContext)
                result = visitor10.VisitExpression_list((context as Describe10Parser.Expression_listContext)!);
            else if (context is Describe10Parser.Item_or_expression_listContext)
                result = visitor10.VisitItem_or_expression_list((context as Describe10Parser.Item_or_expression_listContext)!);
            else if (context is Describe10Parser.Item_or_expression_partContext)
                result = visitor10.VisitItem_or_expression_part((context as Describe10Parser.Item_or_expression_partContext)!);
            else if (context is Describe10Parser.Text_chunkContext)
                result = visitor10.VisitText_chunk((context as Describe10Parser.Text_chunkContext)!);
            else if (context is Describe10Parser.ProducerContext)
                result = visitor10.VisitProducer((context as Describe10Parser.ProducerContext)!);
            else
            {
                LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }

            LastError = visitor10.LastError;
            Log = visitor10.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ParserRuleContext"/>, 
        /// and performs the appropriate visit action on it.
        /// </summary>
        /// <param name="context">The <see cref="ParserRuleContext"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitContext11(ParserRuleContext context)
        {
            Validators.ValidateParserRuleContext(context);

            string? fullTypeName = context.GetType().FullName;
            visitor11.LastError = null;
            visitor11.Log = "";

            string result = null!;
            if (context is Describe11Parser.ScriptureContext)
                result = visitor11.VisitScripture((context as Describe11Parser.ScriptureContext)!);
            else if (context is Describe11Parser.ExpressionContext)
                result = visitor11.VisitExpression((context as Describe11Parser.ExpressionContext)!);
            else if (context is Describe11Parser.ItemContext)
                result = visitor11.VisitItem((context as Describe11Parser.ItemContext)!);
            else if (context is Describe11Parser.Expression_listContext)
                result = visitor11.VisitExpression_list((context as Describe11Parser.Expression_listContext)!);
            else if (context is Describe11Parser.Item_or_expression_listContext)
                result = visitor11.VisitItem_or_expression_list((context as Describe11Parser.Item_or_expression_listContext)!);
            else if (context is Describe11Parser.Item_or_expression_partContext)
                result = visitor11.VisitItem_or_expression_part((context as Describe11Parser.Item_or_expression_partContext)!);
            else if (context is Describe11Parser.Text_chunkContext)
                result = visitor11.VisitText_chunk((context as Describe11Parser.Text_chunkContext)!);
            else if (context is Describe11Parser.ProducerContext)
                result = visitor11.VisitProducer((context as Describe11Parser.ProducerContext)!);
            else
            {
                LastError = "Invalid context - type \"" + fullTypeName + "\" is not valid.";
                throw new Exception("Invalid context - type \"" + fullTypeName + "\" is not valid.");
            }

            LastError = visitor11.LastError;
            Log = visitor11.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }


        /// <summary>
        /// Visits a <see cref="ITerminalNode"/>, in LogVisitor06.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitTerminal(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);
            return VisitTerminal06(node);
        }

        /// <summary>
        /// Visits a <see cref="ITerminalNode"/>, in LogVisitor06.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitTerminal06(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);

            visitor06.LastError = null;
            visitor06.Log = "";

            string result = visitor06.VisitTerminal(node);
            LastError = visitor06.LastError;
            Log = visitor06.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ITerminalNode"/>, in LogVisitor07.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitTerminal07(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);

            visitor07.LastError = null;
            visitor07.Log = "";

            string result = visitor07.VisitTerminal(node);
            LastError = visitor07.LastError;
            Log = visitor07.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ITerminalNode"/>, in LogVisitor08.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitTerminal08(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);

            visitor08.LastError = null;
            visitor08.Log = "";

            string result = visitor08.VisitTerminal(node);
            LastError = visitor08.LastError;
            Log = visitor08.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ITerminalNode"/>, in LogVisitor09.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitTerminal09(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);

            visitor09.LastError = null;
            visitor09.Log = "";

            string result = visitor09.VisitTerminal(node);
            LastError = visitor09.LastError;
            Log = visitor09.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ITerminalNode"/>, in LogVisitor10.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitTerminal10(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);

            visitor10.LastError = null;
            visitor10.Log = "";

            string result = visitor10.VisitTerminal(node);
            LastError = visitor10.LastError;
            Log = visitor10.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }

        /// <summary>
        /// Visits a <see cref="ITerminalNode"/>, in LogVisitor11.
        /// </summary>
        /// <param name="node">The <see cref="ITerminalNode"/> object to visit.</param>
        /// <returns>"success' if successful, "error" if not.</returns>
        public string VisitTerminal11(ITerminalNode node)
        {
            Validators.ValidateTerminalNode(node);

            visitor11.LastError = null;
            visitor11.Log = "";

            string result = visitor11.VisitTerminal(node);
            LastError = visitor11.LastError;
            Log = visitor11.Log;

            if (result == null)
            {
                LastError = "Something went wrong.";
                throw new Exception("Something went wrong.");
            }
            return result;
        }
    }
}
