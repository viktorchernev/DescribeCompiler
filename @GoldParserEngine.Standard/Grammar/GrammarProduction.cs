using System.Collections.Generic;
using System.Linq;

namespace GoldParser.Grammar
{
    /// <summary>
    /// A grammar production
    /// </summary>
    public class GrammarProduction
    {
        /// <summary>
        /// The index of this production in the Production table
        /// </summary>
        public int TableIndex
        {
            get;
            set;
        }

        /// <summary>
        /// The symbol at the left hand side of the production
        /// </summary>
        public GrammarSymbol Head
        {
            get;
            set;
        }

        /// <summary>
        /// The symbols of the right hand side of the production (after the "->")
        /// </summary>
        public List<GrammarSymbol> Handle
        {
            get;
            set;
        }


        /// <summary>
        /// Ctor.
        /// </summary>
        internal GrammarProduction()
        {
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        internal GrammarProduction(GrammarSymbol head, int tableIndex)
        {
            Head = head;
            Handle = new List<GrammarSymbol>();
            TableIndex = tableIndex;
        }


        internal bool ContainsOneNonTerminal()
        {
            bool result = false;
            if (this.Handle.Count() == 1 && this.Handle[0].Type == GrammarSymbolType.Nonterminal)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Gets text representation of the production
        /// </summary>
        public override string ToString()
        {
            return Text(false);
        }

        /// <summary>
        /// Gets text representation of the production
        /// </summary>
        /// <param name="alwaysDelimitTerminals">
        /// Wether to use quotation marks to delimit the terminals
        /// </param>
        public string Text(bool alwaysDelimitTerminals = false)
        {
            return Head.ToString() + " ::= " + symbolListToString(Handle, " ", alwaysDelimitTerminals);
        }
        string symbolListToString(List<GrammarSymbol> list, string separator, bool alwaysDelimitTerminals)
        {
            string result = "";
            for (int n = 0; n <= list.Count - 1; n++)
            {
                GrammarSymbol symbol = list[n];
                result += (n == 0 ? "" : separator) + symbol.ToString(alwaysDelimitTerminals);
            }

            return result;
        }
    }
}
//I have come to the decision not to remove the ToString() and Text(bool) functionality
//from this class, and the similar functionality from the GrammarSymbol class for legasy sake.
//This functionality, however, is be available in GrammarToText.cs