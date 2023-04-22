namespace GoldParser.Grammar
{
    /// <summary>
    /// Stores the counts of all other tables, except Properties,
    /// and InitialStates. We need that count because those tables are
    /// represented by arrays and we need to know how many elements
    /// these arrays will hold.
    /// </summary>
    public class GrammarTableCounts
    {
		/// <summary>
		/// Number of symbol entries
		/// </summary>
		public int SymbolTableCount
		{
			get; 
			set; 
		}

		/// <summary>
		/// Number of character set entries
		/// </summary>
		public int CharsetTableCount
		{
			get;
			set;
		}

		/// <summary>
		/// Number of production entries
		/// </summary>
		public int ProductionTableCount
		{
			get;
			set;
		}

		/// <summary>
		/// Number of DFA entries
		/// </summary>
		public int DfaTableCount
		{
			get;
			set;
		}

		/// <summary>
		/// Number of LR state entries
		/// </summary>
		public int LrStatesTableCount
		{
			get;
			set;
		}

		/// <summary>
		/// Number of group entries
		/// </summary>
		public int GroupTableCount
		{
			get;
			set;
		}



		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarTableCounts()
		{
			SymbolTableCount = 0;
			CharsetTableCount = 0;
			ProductionTableCount = 0;
			DfaTableCount = 0;
			LrStatesTableCount = 0;
			GroupTableCount = 0;
		}
	}
}