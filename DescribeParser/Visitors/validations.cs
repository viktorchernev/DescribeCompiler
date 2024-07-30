using Antlr4.Runtime;
using DescribeParser.Ast;
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
        /// <param name="text">The string to validate</param>
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
        /// <param name="context">The ParserRuleContext to validate</param>
        public static void ValidateParserRuleContext(ParserRuleContext context)
        {
            ArgumentNullException.ThrowIfNull(context, nameof(context));
        }
    }
}
