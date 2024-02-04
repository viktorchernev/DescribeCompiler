namespace GoldParser.Grammar
{
    /// <summary>
    /// Stores the initial state numbers for the DFA and the LALR
    /// </summary>
    public class GrammarInitialStates
    {
        /// <summary>
        /// The initial state of the DFA
        /// </summary>
        public int DfaInitialState
        {
            get;
            set;
        }

        /// <summary>
        /// The initial state of the LALR
        /// </summary>
        public int LrInitialState
        {
            get;
            set;
        }



        /// <summary>
        /// Ctor.
        /// </summary>
        public GrammarInitialStates()
        {
            DfaInitialState = 0;
            LrInitialState = 0;
        }
    }
}