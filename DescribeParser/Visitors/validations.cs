using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new ArgumentNullException(nameof(text), "The string cannot be null.");
        }
    }
}
