using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldParser.Egt;
using GoldParser.Grammar;

namespace GoldParser.Helpers
{
    public static class GrammarToText
    {
        private static int _columnWidth;
        static GrammarToText()
        {
            _columnWidth = 30;
        }


        /// <summary>
        /// How many spaces wide the first column in the output text is
        /// </summary>
        public static int ColumnWidth
        {
            get
            {
                return _columnWidth;
            }
            set
            {
                _columnWidth = value;
            }
        }






        /// <summary>
        /// Read an EGT file and translate it to grammar in the form of readable text. 
        /// </summary>
        /// <param name="path">The path of the .egt file</param>
        /// <returns>string</returns>
        public static string ReadFile(string path, bool addPath = false)
        {
            try
            {
                //get the records
                List<EgtRecord> records = EgtContentReager.ReadFileRecords(path);

                //get grammar
                GrammarTables tables = GrammarContentReader.ReadGrammar(records);

                //get json
                string result = readTables(tables);
                return result;
            }
            catch (Exception ex)
            {
                throw new GrammarException(ex.Message, ex, "ReadFile");
            }
        }

        // Grammar
        static string readTables(GrammarTables tables, string indent = "")
        {
            string properties = readProperties(tables.Properties.DocumentedProperties);
            string tableCounts = tableCountsToText(tables.TableCounts);
            string initialStates = initialstatesToText(tables.InitialStates);
            string characterSets = readCharacterSets(tables.CharacterSets);
            string symbols = readSymbols(tables.Symbols);
            string groups = readGroups(tables.Groups);
            string productions = readProductions(tables.Productions);
            string fastates = readFaStates(tables.FAStates);
            string lrstates = readLrStates(tables.LRStates);

            string text = properties + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += tableCounts + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += initialStates + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += characterSets + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += symbols + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += groups + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += productions + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += fastates + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            text += lrstates;

            return text;
        }

        // Properties
        public static string readProperties(List<GrammarProperty> properties)
        {
            string text = "PROPERTIES" + Environment.NewLine;
            text += "Index".PadRight(_columnWidth, ' ');
            text += "Name".PadRight(_columnWidth, ' ');
            text += "Value".PadRight(_columnWidth, ' ');
            text += Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-');


            for (int a = 0; a < properties.Count(); a++)
            {
                text += Environment.NewLine;
                text += propertyToText(properties[a]);
            }

            return text;
        }
        public static string propertyToText(GrammarProperty property)
        {
            string text = "";
            //json += indent + "\"grammar-property\":" + Environment.NewLine;
            text += property.Index.ToString().PadRight(_columnWidth, ' ');
            text += property.Name.ToString().PadRight(_columnWidth, ' ');
            text += property.Value.ToString().PadRight(_columnWidth, ' ');
            return text;
        }

        // Table Counts
        public static string tableCountsToText(GrammarTableCounts counts)
        {
            string text = "TABLE COUNTS" + Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            text += "Symbol Count:".PadRight(_columnWidth, ' ');
            text += counts.SymbolTableCount.ToString() + Environment.NewLine;

            text += "Charset Count:".PadRight(_columnWidth, ' ');
            text += counts.CharsetTableCount.ToString() + Environment.NewLine;

            text += "Production Count:".PadRight(_columnWidth, ' ');
            text += counts.ProductionTableCount.ToString() + Environment.NewLine;

            text += "DFA States Count:".PadRight(_columnWidth, ' ');
            text += counts.DfaTableCount.ToString() + Environment.NewLine;

            text += "LR States Count:".PadRight(_columnWidth, ' ');
            text += counts.LrStatesTableCount.ToString() + Environment.NewLine;

            text += "Group Count:".PadRight(_columnWidth, ' ');
            text += counts.GroupTableCount.ToString();

            return text;
        }

        // Initial States
        public static string initialstatesToText(GrammarInitialStates initialStates)
        {
            string text = "INITIAL STATES" + Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            text += "DFA:".PadRight(_columnWidth, ' ');
            text += initialStates.DfaInitialState.ToString() + Environment.NewLine;

            text += "LR:".PadRight(_columnWidth, ' ');
            text += initialStates.LrInitialState.ToString() + Environment.NewLine;

            return text;
        }

        // Character Sets
        public static string readCharacterSets(GrammarCharacterSet[] charsets)
        {
            string text = "CHARACTER SETS" + Environment.NewLine;
            text += "Index".PadRight(_columnWidth, ' ') + "Ranges" + Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            for (int a = 0; a < charsets.Length; a++)
            {
                if (a > 0) text += Environment.NewLine;
                text += characterSetToText(charsets[a]);
            }
            return text;
        }
        public static string characterSetToText(GrammarCharacterSet charset)
        {
            string text = "";
            text += charset.TableIndex.ToString().PadRight(_columnWidth, ' ');
            for (int i = 0; i < charset.Ranges.Count; i++)
            {
                text += characterRangeToText(charset.Ranges[i]);
                if (i < charset.Ranges.Count - 1)
                {
                    text += ", ";
                }
            }
            return text;
        }
        public static string characterRangeToText(GrammarCharacterRange range)
        {
            string text = "";
            if(range.Start == range.End)
            {
                text = range.Start.ToString();
            }
            else
            {
                text += range.Start.ToString() + "-" + range.End.ToString();
            }
            return text;
        }

        // Symbol
        public static string readSymbols(GrammarSymbol[] symbols)
        {
            string text = "SYMBOLS" + Environment.NewLine;
            text += "Index".PadRight(_columnWidth, ' ') + "Name".PadRight(_columnWidth, ' ') + 
                "Type".PadRight(_columnWidth, ' ') + "Group".PadRight(_columnWidth, ' ') +
                Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            for (int a = 0; a < symbols.Length; a++)
            {
                if (a > 0) text += Environment.NewLine;
                text += symbolToText(symbols[a]);
            }
            return text;
        }
        public static string symbolToText(GrammarSymbol symbol)
        {
            string text = "";

            text += symbol.TableIndex.ToString().PadRight(_columnWidth, ' ');
            text += symbol.Name.ToString().PadRight(_columnWidth, ' ');
            text += symbol.Type.ToString().PadRight(_columnWidth, ' ');

            string gi = "-";
            if (symbol.Group != null) gi = symbol.Group.TableIndex.ToString();
            text += gi;

            return text;
        }

        // Group
        public static string readGroups(GrammarGroup[] groups)
        {
            string text = "GROUPS" + Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            for (int a = 0; a < groups.Length; a++)
            {
                if (a > 0) text += Environment.NewLine;
                text += groupToText(groups[a]);
            }
            return text;
        }
        public static string groupToText(GrammarGroup group)
        {
            string text = "";

            text += "Index:".PadRight(_columnWidth, ' ') + group.TableIndex.ToString() + Environment.NewLine;
            text += "Name:".PadRight(_columnWidth, ' ') + group.Name.ToString() + Environment.NewLine;

            string container = "{" + group.ContainerSymbol.Name + "}";
            string start = "{" + group.StartSymbol.Name + "}";
            string end = "{" + group.EndSymbol.Name + "}";
            text += "Container Symbol:".PadRight(_columnWidth, ' ') + group.ContainerSymbol.TableIndex.ToString() + container + Environment.NewLine;
            text += "Start Symbol:".PadRight(_columnWidth, ' ') + group.StartSymbol.TableIndex.ToString() + start + Environment.NewLine;
            text += "End Symbol:".PadRight(_columnWidth, ' ') + group.EndSymbol.TableIndex.ToString() + end + Environment.NewLine;

            text += "Advance Mode:".PadRight(_columnWidth, ' ') + group.Advance.ToString() + Environment.NewLine;
            text += "Ending Mode:".PadRight(_columnWidth, ' ') + group.Ending.ToString() + Environment.NewLine;

            string nest = "";
            for (int i = 0; i < group.Nesting.Count(); i++)
            {
                nest += group.Nesting[i].ToString();
                if (i < group.Nesting.Count() - 1) nest += ", ";
            }
            if (nest == "") nest = "-";

            text += "Nesting:".PadRight(_columnWidth, ' ') + nest;
            text += Environment.NewLine;
            return text;
        }

        // Production
        public static string readProductions(GrammarProduction[] productions, string indent = "")
        {
            string text = "PRODUCTIONS" + Environment.NewLine;
            text += "Index".PadRight(_columnWidth, ' ') + "Text Representation" + Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            for (int i = 0; i < productions.Length; i++)
            {
                text += productionToText(productions[i]) + Environment.NewLine;
            }

            return text;
        }
        public static string productionToText(GrammarProduction production)
        {
            string text = "";
            text += production.TableIndex.ToString().PadRight(_columnWidth, ' ');
            text += productionToText(production, false).PadRight(_columnWidth, ' ');
            return text;
        }
        public static string productionToText(GrammarProduction production, bool alwaysDelimitTerminals)
        {
            return production.Head.ToString() + " ::= " + symbolListToString(production.Handle, " ", alwaysDelimitTerminals);
        }
        public static string symbolListToString(List<GrammarSymbol> list, string separator, bool alwaysDelimitTerminals)
        {
            string result = "";
            for (int n = 0; n <= list.Count - 1; n++)
            {
                GrammarSymbol symbol = list[n];
                result += (n == 0 ? "" : separator) + symbol.ToString(alwaysDelimitTerminals);
            }

            return result;
        }
        public static string symbolToText(GrammarSymbol symbol, bool alwaysDelimitTerminals)
        {
            switch (symbol.Type)
            {
                case GrammarSymbolType.Nonterminal:
                    return "<" + symbol.Name + ">";
                case GrammarSymbolType.Terminal:
                    return symbolFormatLiteral(symbol.Name, alwaysDelimitTerminals);
                default:
                    return "(" + symbol.Name + ")";
            }
        }
        public static string symbolFormatLiteral(string source, bool forceDelimit)
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

        // FA State
        public static string readFaStates(GrammarFAState[] states)
        {
            string text = "DFA STATES" + Environment.NewLine;
            text += "Index".PadRight(_columnWidth, ' ') + "Accept".PadRight(_columnWidth, ' ') +
                "Edges:CharacterSet-Target".PadRight(_columnWidth, ' ') + Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            for (int i = 0; i < states.Length; i++)
            {
                text += faStateToText(states[i]) + Environment.NewLine;
            }

            return text;
        }
        public static string faStateToText(GrammarFAState state)
        {
            string text = "";
            text += state.TableIndex.ToString().PadRight(_columnWidth, ' ');

            string accept = "";
            if (state.Accept == null) accept = "-";
            else accept = "{" + state.Accept.TableIndex.ToString() + "}";
            accept = accept.PadRight(_columnWidth, ' ');
            text += accept;

            string edges = "";
            if (state.Edges.Count == 0) edges = "-";
            else
            {
                for (int i = 0; i < state.Edges.Count; i++)
                {
                    edges += faEdgeToText(state.Edges[i]);
                    if (i < state.Edges.Count - 1) edges += ", ";
                }
            }
            text += edges; 

            return text;
        }
        public static string faEdgeToText(GrammarFAEdge edge)
        {
            string text = "";
            text += edge.CharacterSet.TableIndex.ToString() + "-" + edge.Target.ToString();
            return text;
        }

        // LR
        public static string readLrStates(GrammarLRState[] states)
        {
            string text = "LALR STATES" + Environment.NewLine;
            text += "-".PadRight(_columnWidth * 4, '-') + Environment.NewLine;

            for (int i = 0; i < states.Length; i++)
            {
                text += LrStateToText(states[i]);
                if (i < states.Length - 1)
                {
                    text += Environment.NewLine + "=".PadRight(_columnWidth * 4, '=');
                    text += Environment.NewLine;
                }
            }

            return text;
        }
        public static string LrStateToText(GrammarLRState state)
        {
            string text = "";
            text += "Index: " + state.TableIndex.ToString() + Environment.NewLine;
            text += "Actions:Symbol".PadRight(_columnWidth, ' ') + "Type".PadRight(_columnWidth, ' ') +
                "Value" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < state.Actions.Count(); i++)
            {
                text += lrActionToText(state.Actions[i]);
                if(i < state.Actions.Count() - 1) text += Environment.NewLine;
            }

            return text;
        }
        public static string lrActionToText(GrammarLRAction action, string indent = "")
        {
            string text = "";

            text += ("{" + action.Symbol.TableIndex.ToString() + "}").PadRight(_columnWidth, ' ');
            text += action.Type.ToString().PadRight(_columnWidth, ' ');
            text += action.Value.ToString();

            return text;
        }
    }
}
//Groups have symbols but lrActions have merely symbol indexes. Better to implement instances then indexes
//Rename GrammarToText and GrammarToJson methods to be consistent - read and ToText used in names both
//add method that produces multiple new lines