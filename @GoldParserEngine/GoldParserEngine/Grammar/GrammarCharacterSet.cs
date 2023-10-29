using System.Collections.Generic;

namespace GoldParser.Grammar
{
    /// <summary>
    /// A set of character ranges
    /// </summary>
    public class GrammarCharacterSet
    {
        private readonly int _tableIndex;

        /// <summary>
        /// The ranges in this set
        /// </summary>
        public List<GrammarCharacterRange> Ranges
        {
            get;
            set;
        }

        /// <summary>
        /// Get one of the ranges in this set
        /// </summary>
        /// <param name="index">The index of the range</param>
        /// <returns>A character range</returns>
        public GrammarCharacterRange this[int index]
        {
            get
            {
                return Ranges[index];
            }
            set
            {
                Ranges[index] = value;
            }
        }

        /// <summary>
        /// Returns the index of the Set in the CharacterSet Table.
        /// </summary>
        public int TableIndex
        {
            get { return _tableIndex; }
        }


        /// <summary>
        /// Ctor.
        /// </summary>
        public GrammarCharacterSet(int tableIndex)
        {
            Ranges = new List<GrammarCharacterRange>();
            _tableIndex = tableIndex;
        }


        /// <summary>
        /// Add a range to the current CharacterSet
        /// </summary>
        /// <param name="range">The range to add</param>
        public void Add(GrammarCharacterRange range)
        {
            Ranges.Add(range);
        }

        /// <summary>
        /// Wether the current CharacterSet contains the specified character
        /// in some of its ranges
        /// </summary>
        /// <param name="charCode">the char code of the character</param>
        /// <returns>true if the CharacterSet contains it</returns>
        public bool Contains(int charCode)
        {
            bool flag = false;
            int x = 0;
            while (x < Ranges.Count && flag == false)
            {
                GrammarCharacterRange characterRange = Ranges[x];
                flag = (charCode >= characterRange.Start && charCode <= characterRange.End);
                x++;
            }
            return flag;
        }
    }

    /// <summary>
    /// Stores a range of characters. If start and end are the same, 
    /// it is a single character, while otherwise it is a true range.
    /// </summary>
    public class GrammarCharacterRange
    {
        /// <summary>
        /// Char-code. First character in the range
        /// </summary>
        public int Start
        {
            get;
            set;
        }

        /// <summary>
        /// Char-code. Last character in the range
        /// </summary>
        public int End
        {
            get;
            set;
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="start">first character</param>
        /// <param name="end">last character</param>
        public GrammarCharacterRange(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
