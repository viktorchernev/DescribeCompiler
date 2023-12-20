using System.Collections.Generic;

namespace GoldParser.Grammar
{
    /// <summary>
    /// Lexer specific stuff
    /// </summary>
    public enum GrammarGroupAdvanceMode
    {
        Token,
        Character
    }

    /// <summary>
    /// Closed GroupEndingMode means to add the group ending
    /// token to the data, while Open means to discard it.
    /// </summary>
    public enum GrammarGroupEndingMode
    {
        Open,
        Closed
    }

    /// <summary>
    /// Groups are a special mode in the Lexer that starts with a Token 
    /// of a given symbol type, ends with one, and everything else is ignored
    /// and all is outputted as a single token
    /// </summary>
    public class GrammarGroup
    {
        /// <summary>
        /// The index of the group in the Group table
        /// </summary>
        public int TableIndex
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the group
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The symbol that represent the group - For example Comment
        /// </summary>
        public GrammarSymbol ContainerSymbol
        {
            get;
            set;
        }

        /// <summary>
        /// The starting symbol - For example CommentStart - "/*"
        /// </summary>
        public GrammarSymbol StartSymbol
        {
            get;
            set;
        }

        /// <summary>
        /// The ending symbol - For example CommentEnd - "*/"
        /// </summary>
        public GrammarSymbol EndSymbol
        {
            get;
            set;
        }

        /// <summary>
        /// The Lexer advance mode for the group
        /// </summary>
        public GrammarGroupAdvanceMode Advance
        {
            get;
            set;
        }

        /// <summary>
        /// The Lexer ending mode for the group
        /// </summary>
        public GrammarGroupEndingMode Ending
        {
            get;
            set;
        }

        /// <summary>
        /// List of the indexes (in the Group table) of all the 
        /// groups that can be nested inside of this one
        /// </summary>
        public List<int> Nesting
        {
            get;
            private set;
        }


        /// <summary>
        /// Ctor.
        /// </summary>
        public GrammarGroup()
        {
            Advance = GrammarGroupAdvanceMode.Character;
            Ending = GrammarGroupEndingMode.Closed;
            Nesting = new List<int>();
        }
    }
}
