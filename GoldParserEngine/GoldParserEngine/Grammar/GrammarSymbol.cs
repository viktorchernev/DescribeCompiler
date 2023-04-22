namespace GoldParser.Grammar
{
    /// <summary>
    /// Types of symbols.
    /// </summary>
	public enum GrammarSymbolType
	{
		Nonterminal,
		Terminal,
		Noise,
		End,
		GroupStart,
		GroupEnd,
		Error = 7
	}

    /// <summary>
    /// A Grammar Symbol.
    /// </summary>
	public class GrammarSymbol
    {
        private readonly int _tableIndex;
        private readonly GrammarSymbolType _type;
        private readonly string _name;
        internal GrammarGroup Group;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="name">The name of the Symbol</param>
        /// <param name="type">The type of the Symbol</param>
        /// <param name="tableIndex">The index of the Symbol</param>
        internal GrammarSymbol(string name, GrammarSymbolType type, int tableIndex)
        {
            _name = name;
            _type = type;
            _tableIndex = tableIndex;
        }



        /// <summary>
        /// Getss the index of the symbol in the Symbol Table.
        /// </summary>
        /// <returns></returns>
        public int TableIndex
        {
            get { return _tableIndex; }
        }

        /// <summary>
        /// Gets the type of the symbol.
        /// </summary>
        public GrammarSymbolType Type
        {
            get { return _type; }
        }

        /// <summary>
        /// Gets the name of the symbol.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }


        /// <summary>
        /// Get string representation of the Symbol
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return ToString(false);
        }

        /// <summary>
        /// Get string representation of the Symbol
        /// </summary>
        /// <param name="alwaysDelimitTerminals">
        /// Wether to use quotation marks
        /// </param>
        /// <returns>string</returns>
        public string ToString(bool alwaysDelimitTerminals)
        {
            switch (_type)
            {
                case GrammarSymbolType.Nonterminal:
                    return "<" + Name + ">";
                case GrammarSymbolType.Terminal:
                    return formatLiteral(Name, alwaysDelimitTerminals);
                default:
                    return "(" + Name + ")";
            }
        }
        string formatLiteral(string source, bool forceDelimit)
        {
            if (source == "'") return "''";
            for (int i = 0; i < source.Length && !forceDelimit; i++)
            {
                char ch = source[i];
                forceDelimit = !(char.IsLetter(ch) || ch == '.' || ch == '_' || ch == '-');
            }
            if (forceDelimit) return "'" + source + "'";
            return source;
        }
    }
}
//SymbolType.Content is SymbolType.Terminal
//short TableIndex is int TableIndex
//Text() is ToString()
//TODO: Add tableIndex-es to @book texts