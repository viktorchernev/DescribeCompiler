using System.Collections.Generic;

namespace GoldParser.Grammar
{
	/// <summary>
	/// Types of LALR parser actions
	/// </summary>
    public enum LRActionType
	{
		Shift = 1,
		Reduce,
		Goto,
		Accept,
		Error
	}

	/// <summary>
	/// Represents a LALR parser state
	/// </summary>
	public class GrammarLRState
    {
		/// <summary>
		/// Getss the index of the symbol in the LR State Table.
		/// </summary>
		public int TableIndex
		{
			get;
			private set;
		}

		/// <summary>
		/// All the possible actions in this state
		/// </summary>
		public List<GrammarLRAction> Actions
        {
			get;
			private set;
        }

		/// <summary>
		/// Get action by its index
		/// </summary>
		/// <param name="index">The action's index in this state's action list</param>
		public GrammarLRAction this[int index]
		{
			get
			{
				return Actions[index];
			}
			set
			{
				Actions[index] = value;
			}
		}

		/// <summary>
		/// Get action by a symbol that triggers it
		/// </summary>
		/// <param name="sym">The symbol</param>
		public GrammarLRAction this[GrammarSymbol sym]
		{
			get
			{
				int x = IndexOf(sym);
				if (x != -1)
				{
					return Actions[x];
				}
				else
				{
					return null;
				}
			}
			set
			{
				int x = IndexOf(sym);
				if (x != -1)
				{
					Actions[x] = value;
				}
			}
		}


		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarLRState(int tableIndex)
        {
			TableIndex = tableIndex;
			Actions = new List<GrammarLRAction>();
        }



		/// <summary>
		/// Get the index of an action via a symbol that triggers it
		/// </summary>
		/// <param name="item">The symbol</param>
		public int IndexOf(GrammarSymbol item)
		{
			for (int i = 0; i < Actions.Count; i++)
			{
				if (item == Actions[i].Symbol) return i;
			}
			return -1;
		}

		/// <summary>
		/// Add an action
		/// </summary>
		/// <param name="Action">The action to add</param>
		public void Add(GrammarLRAction Action)
		{
			Actions.Add(Action);
		}

		/// <summary>
		/// Count the actions
		/// </summary>
		/// <returns></returns>
		public int Count()
		{
			return Actions.Count;
		}
	}

	/// <summary>
	/// Represents a LALR parser action
	/// </summary>
	public class GrammarLRAction
	{
		/// <summary>
		/// The Symbol that triggers this action to be chosen to be 
		/// executed
		/// </summary>
		public GrammarSymbol Symbol
		{
			get;
			set;
		}

		/// <summary>
		/// The type of the action
		/// </summary>
		public LRActionType Type
		{
			get;
			set;
		}

		/// <summary>
		/// The value of the action. The value means a different thing
		/// depending on the type of action - if SHIFT, it is the index
		/// of the new state. If REDUCE, it is the index of the production.
		/// </summary>
		public int Value
		{
			get;
			set;
		}

		/// <summary>
		/// Ctor.
		/// </summary>
		public GrammarLRAction(GrammarSymbol symbol, LRActionType type, int value)
		{
			Symbol = symbol;
			Type = type;
			Value = value;
		}
	}
}
