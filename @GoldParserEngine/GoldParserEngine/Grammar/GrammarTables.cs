using System.Linq;

namespace GoldParser.Grammar
{
    /// <summary>
    /// A class to hold all the grammar.
    /// Originally not in the parser.
    /// </summary>
    public class GrammarTables
	{
		/// <summary>
		/// The properties or metadata about the grammar
		/// </summary>
		public GrammarProperties Properties
        {
			get;
			set;
        }

		/// <summary>
		/// Table counts in the grammar
		/// </summary>
		public GrammarTableCounts TableCounts
		{
			get;
			set;
		}

		/// <summary>
		/// The DFA and LALR initial states
		/// </summary>
		public GrammarInitialStates InitialStates
		{
			get;
			set;
		}

		/// <summary>
		/// The character set table
		/// </summary>
		public GrammarCharacterSet[] CharacterSets
		{
			get;
			set;
		}

		/// <summary>
		/// The symbol table
		/// </summary>
		public GrammarSymbol[] Symbols
		{
			get;
			set;
		}

		/// <summary>
		/// The group table
		/// </summary>
		public GrammarGroup[] Groups
		{
			get;
			set;
		}

		/// <summary>
		/// The production table
		/// </summary>
		public GrammarProduction[] Productions
		{
			get;
			set;
		}

		/// <summary>
		/// The FA aka DFA state table
		/// </summary>
		public GrammarFAState[] FAStates
		{
			get;
			set;
		}

		/// <summary>
		/// The LR aka LALR state table
		/// </summary>
		public GrammarLRState[] LRStates
		{
			get;
			set;
		}

		/// <summary>
		/// Wether a grammar has been loaded
		/// </summary>
		public bool TablesLoaded
        {
			get;
			internal set;
        }



		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarTables()
		{
			TablesLoaded = false;
		}
	}
}