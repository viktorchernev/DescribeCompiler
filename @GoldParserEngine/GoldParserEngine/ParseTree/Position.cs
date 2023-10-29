namespace GoldParser.ParseTree
{
    /// <summary>
    /// Represents a position of a symbol in a text
    /// </summary>
    public class Position
    {
        /// <summary>
        /// The line in the text
        /// </summary>
        public int Line
        {
            get;
            set;
        }

        /// <summary>
        /// The column in the text
        /// </summary>
        public int Column
        {
            get;
            set;
        }

        internal Position()
        {
            Line = 0;
            Column = 0;
        }

        /// <summary>
        /// Copy values from another position object.
        /// </summary>
        /// <param name="pos">The position to be copied</param>
        internal void Copy(Position pos)
        {
            Column = pos.Column;
            Line = pos.Line;
        }
    }
}
