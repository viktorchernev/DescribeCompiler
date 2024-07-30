namespace DescribeParser.Ast
{
    /// <summary>
    /// The base class for the AST
    /// </summary>
    public abstract class AstNode : IAstNode
    {
        /// <summary>
        /// Get a string representation of an AST object for logging purposes
        /// </summary>
        public abstract new string ToString();

        /// <summary>
        /// Get a JSON string representation of an AST object for logging purposes
        /// </summary>
        public abstract string ToJson();

        /// <summary>
        /// Get a source code string representation of an AST object
        /// </summary>
        public abstract string ToCode();

        /// <summary>
        /// Replaces New line and Tab characters with their escape sequences.
        /// </summary>
        /// <param name="text">The string to be replaced.</param>
        /// <returns>The modified string.</returns>
        protected static string replaceWhitespaceE(string text)
        {
            return text.Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
    }
}
