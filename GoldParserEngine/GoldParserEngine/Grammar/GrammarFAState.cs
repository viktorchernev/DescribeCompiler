using System.Collections.Generic;

namespace GoldParser.Grammar
{
    /// <summary>
    /// Represents a DFA state
    /// </summary>
    public class GrammarFAState
    {
		private readonly int _tableIndex;

		/// <summary>
		/// All the possible transitions (aka edges) from this state
		/// </summary>
		public List<GrammarFAEdge> Edges
        {
			get;
			set;
        }

		/// <summary>
		/// A symbol that is accepted in this state. If not null, we
		/// could stop parsing and produce a token of that symbol's kind.
		/// </summary>
		public GrammarSymbol Accept
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the index of the state in the FAState Table.
		/// </summary>
		public int TableIndex
		{
			get { return _tableIndex; }
		}


		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarFAState(int tableIndex)
		{
			Accept = null;
			Edges = new List<GrammarFAEdge>();
			_tableIndex = tableIndex;
		}

		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarFAState(GrammarSymbol accept, int tableIndex)
		{
			Accept = accept;
			Edges = new List<GrammarFAEdge>();
			_tableIndex = tableIndex;
		}
	}

	/// <summary>
	/// Represents a DFA transition, aka edge
	/// </summary>
    public class GrammarFAEdge
    {
		/// <summary>
		/// The character set that will allow the transition
		/// </summary>
		public GrammarCharacterSet CharacterSet;

		/// <summary>
		/// The new state to switch to
		/// </summary>
		public int Target;


		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarFAEdge()
		{
		}

		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarFAEdge(GrammarCharacterSet charSet, int target)
		{
			CharacterSet = charSet;
			Target = target;
		}
	}
}
// Characters is CharacterSet