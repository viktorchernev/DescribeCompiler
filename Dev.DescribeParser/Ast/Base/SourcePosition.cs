namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast SourcePosition object 
    /// </summary>
    public class SourcePosition
    {
        /// <summary>
        /// The zero-based index in the source code string
        /// of the first character in this SourcePosition object.
        /// </summary>
        public int FirstIndex
        {
            get; 
            internal set;
        }

        /// <summary>
        /// The zero-based line number in the source code
        /// of the first character in this SourcePosition object.
        /// </summary>
        public int FirstLine
        {
            get; 
            internal set;
        }

        /// <summary>
        /// The zero-based column number in the current line, 
        /// in the source code of the first character in this SourcePosition object.
        /// </summary>
        public int FirstColumn
        {
            get;
            internal set;
        }

        /// <summary>
        /// The zero-based index in the source code string
        /// of the last character in this SourcePosition object.
        /// </summary>
        public int LastIndex
        {
            get;
            internal set;
        }

        /// <summary>
        /// The zero-based line number in the source code
        /// of the last character in this SourcePosition object.
        /// </summary>
        public int LastLine
        {
            get;
            internal set;
        }

        /// <summary>
        /// The zero-based column number in the current line, 
        /// in the source code of the last character in this SourcePosition object.
        /// </summary>
        public int LastColumn
        {
            get;
            internal set;
        }
    }
}
