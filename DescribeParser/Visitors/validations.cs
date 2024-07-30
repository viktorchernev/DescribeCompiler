using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using DescribeParser.Ast;
using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DescribeParser
{
    /// <summary>
    /// This class contains methods that are used for null checking.
    /// </summary>
    public static class Validators
    {
        /// <summary>
        /// Validates a string is not null.
        /// </summary>
        /// <param name="text">The string to validate.</param>
        /// <exception cref="ArgumentNullException">Thrown if the string is null</exception>
        public static void ValidateString(string text)
        {
            if(text == null)
            {
                throw new ArgumentNullException(nameof(text), "The string cannot be null.");
            }
        }

        /// <summary>
        /// Validates that a ParserRuleContext is not null.
        /// </summary>
        /// <param name="context">The ParserRuleContext to validate.</param>
        public static void ValidateParserRuleContext(ParserRuleContext context)
        {
            ArgumentNullException.ThrowIfNull(context, nameof(context));
        }

        /// <summary>
        /// Validates that a DescribeUnfold is not null.
        /// </summary>
        /// <param name="u">The DescribeUnfold to validate.</param>
        public static void ValidateUnfold(DescribeUnfold u)
        {
            ArgumentNullException.ThrowIfNull(u, nameof(u));
        }

        /// <summary>
        /// Validates that an ITerminalNode is not null.
        /// </summary>
        /// <param name="node">The ITerminalNode to validate.</param>
        public static void ValidateTerminalNode(ITerminalNode node)
        {
            ArgumentNullException.ThrowIfNull(node, nameof(node));
        }
    }
}
