using GoldParser.Egt;
using GoldParser.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoldParser.Helpers
{
    public static class GrammarToJSON
    {
        private static string _indent;
        static GrammarToJSON()
        {
            Indent = 4;
        }


        /// <summary>
        /// How many spaces to use as indent
        /// </summary>
        public static int Indent
        {
            get
            {
                return _indent.Length;
            }
            set
            {
                _indent = "";
                for (int i = 0; i < value; i++)
                {
                    _indent += " ";
                }
            }
        }


        /// <summary>
        /// Read an EGT file and translate it to grammar in a JSON format. 
        /// </summary>
        /// <param name="path">The path of the .egt file</param>
        /// <returns>Json string</returns>
        public static string ReadFile(string path, bool addPath = false)
        {
            try
            {
                //get the records
                List<EgtRecord> records = EgtContentReager.ReadFileRecords(path);

                //get grammar
                GrammarTables tables = GrammarContentReader.ReadGrammar(records);

                //get json
                string result = readTables(tables, _indent);
                string json = "{" + Environment.NewLine;
                if (addPath)
                {
                    json += _indent + "\"FILE-PATH\":\"" + path + "\"," + Environment.NewLine;
                }
                json += result + Environment.NewLine;
                json += "}";
                return json;
            }
            catch (Exception ex)
            {
                throw new GrammarException(ex.Message, ex, "ReadFile");
            }
        }


        // Grammar
        static string readTables(GrammarTables tables, string indent = "")
        {
            string properties = readProperties(tables.Properties.DocumentedProperties, indent);
            string tableCounts = tableCountsToJSON(tables.TableCounts, indent);
            string initialStates = initialstatesToJSON(tables.InitialStates, indent);
            string characterSets = readCharacterSets(tables.CharacterSets, indent);
            string symbols = readSymbols(tables.Symbols, indent);
            string groups = readGroups(tables.Groups, indent);
            string productions = readProductions(tables.Productions, indent);
            string fastates = readFaStates(tables.FAStates, indent);
            string lrstates = readLrStates(tables.LRStates, indent);

            string json = properties + "," + Environment.NewLine;
            json += tableCounts + "," + Environment.NewLine;
            json += initialStates + "," + Environment.NewLine;
            json += characterSets + "," + Environment.NewLine;
            json += symbols + "," + Environment.NewLine;
            json += groups + "," + Environment.NewLine;
            json += productions + "," + Environment.NewLine;
            json += fastates + "," + Environment.NewLine;
            json += lrstates;

            return json;
        }

        // Properties
        public static string readProperties(List<GrammarProperty> properties, string indent = "")
        {
            string json = indent + "\"properties\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;

            for (int a = 0; a < properties.Count(); a++)
            {
                if (a > 0) json += "," + Environment.NewLine;
                json += propertyToJSON(properties[a], indent + _indent);
            }
            json += Environment.NewLine + indent + "]";
            return json;
        }
        public static string propertyToJSON(GrammarProperty property, string indent = "")
        {
            string json = "";
            //json += indent + "\"grammar-property\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"index\":" + property.Index.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"name\":\"" + property.Name.ToString() + "\"," + Environment.NewLine;
            json += indent + _indent + "\"value\":\"" + property.Value.ToString() + "\"" + Environment.NewLine;
            json += indent + "}";
            return json;
        }

        // Table Counts
        public static string tableCountsToJSON(GrammarTableCounts counts, string indent = "")
        {
            string json = "";
            json += indent + "\"table-counts\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"symbols-table-count\":" + counts.SymbolTableCount.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"character-sets-table-count\":" + counts.CharsetTableCount.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"productions-table-count\":" + counts.ProductionTableCount.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"dfa-states-table-count\":" + counts.DfaTableCount.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"lr-states-table-count\":" + counts.LrStatesTableCount.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"groups-table-count\":" + counts.GroupTableCount.ToString() + Environment.NewLine;
            json += indent + "}";
            return json;
        }

        // Initial States
        public static string initialstatesToJSON(GrammarInitialStates initialStates, string indent = "")
        {
            string json = "";
            json += indent + "\"initial-states\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"dfa-initial-state\":" + initialStates.DfaInitialState.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"lr-initial-state\":" + initialStates.LrInitialState.ToString() + Environment.NewLine;
            json += indent + "}";
            return json;
        }

        // Character Sets
        public static string readCharacterSets(GrammarCharacterSet[] charsets, string indent = "")
        {
            string json = indent + "\"character-sets\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;

            for (int a = 0; a < charsets.Length; a++)
            {
                if (a > 0) json += "," + Environment.NewLine;
                json += characterSetToJSON(charsets[a], indent + _indent);
            }
            json += Environment.NewLine + indent + "]";
            return json;
        }
        public static string characterSetToJSON(GrammarCharacterSet charset, string indent = "")
        {
            //string json = indent + "\"character-set\":" + Environment.NewLine;
            string json = "";
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"table-index\":" + charset.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"character-ranges\":" + Environment.NewLine;
            json += indent + _indent + "[" + Environment.NewLine;
            for (int i = 0; i < charset.Ranges.Count; i++)
            {
                json += characterRangeToJSON(charset.Ranges[i], indent + _indent + _indent);
                if (i < charset.Ranges.Count - 1)
                {
                    json += ",";
                }
                json += Environment.NewLine;
            }
            json += indent + _indent + "]" + Environment.NewLine;
            json += indent + "}";
            return json;
        }
        public static string characterRangeToJSON(GrammarCharacterRange range, string indent = "")
        {
            string json = "";
            //json += indent + "\"character-range\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"start\":" + range.Start.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"end\":" + range.End.ToString() + Environment.NewLine;
            json += indent + "}";
            return json;
        }

        // Symbol
        public static string readSymbols(GrammarSymbol[] symbols, string indent = "")
        {
            string json = indent + "\"symbols\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;

            for (int a = 0; a < symbols.Length; a++)
            {
                if (a > 0) json += "," + Environment.NewLine;
                json += symbolToJSON(symbols[a], indent + _indent);
            }
            json += Environment.NewLine + indent + "]";
            return json;
        }
        public static string symbolToJSON(GrammarSymbol symbol, string indent = "")
        {
            string json = "";
            //json += indent + "\"symbol\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"name\":\"" + symbol.Name.ToString() + "\"," + Environment.NewLine;
            json += indent + _indent + "\"type\":\"" + symbol.Type.ToString() + "\"," + Environment.NewLine;
            json += indent + _indent + "\"table-index\":" + symbol.TableIndex.ToString() + "," + Environment.NewLine;

            string gi = "null";
            if (symbol.Group != null) gi = symbol.Group.TableIndex.ToString();

            json += indent + _indent + "\"group\":" + gi + Environment.NewLine;
            json += indent + "}";
            return json;
        }

        // Group
        public static string readGroups(GrammarGroup[] groups, string indent = "")
        {
            string json = indent + "\"groups\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;

            for (int a = 0; a < groups.Length; a++)
            {
                if (a > 0) json += "," + Environment.NewLine;
                json += groupToJSON(groups[a], indent + _indent);
            }
            json += Environment.NewLine + indent + "]";
            return json;
        }
        public static string groupToJSON(GrammarGroup group, string indent = "")
        {
            string json = "";
            //json += indent + "\"group\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"table-index\":" + group.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"name\":\"" + group.Name + "\"," + Environment.NewLine;

            json += indent + _indent + "\"container-symbol-index\":" + group.ContainerSymbol.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"start-symbol-index\":" + group.StartSymbol.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"end-symbol-index\":" + group.EndSymbol.TableIndex.ToString() + "," + Environment.NewLine;

            json += indent + _indent + "\"advance-mode\":\"" + group.Advance.ToString() + "\"," + Environment.NewLine;
            json += indent + _indent + "\"ending-mode\":\"" + group.Ending.ToString() + "\"," + Environment.NewLine;

            string nest = "[";
            for (int i = 0; i < group.Nesting.Count(); i++)
            {
                nest += group.Nesting[i].ToString();
                if (i < group.Nesting.Count() - 1) nest += ", ";
            }
            nest += "]";
            json += indent + _indent + "\"nesting\":" + nest + Environment.NewLine;

            json += indent + "}";
            return json;
        }

        // Production
        public static string readProductions(GrammarProduction[] productions, string indent = "")
        {
            string json = indent + "\"productions\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;
            for (int i = 0; i < productions.Length; i++)
            {
                json += productionToJSON(productions[i], indent + _indent);
                if (i < productions.Length - 1)
                {
                    json += ",";
                }
                json += Environment.NewLine;
            }
            json += indent + "]";
            return json;
        }
        public static string productionToJSON(GrammarProduction production, string indent = "")
        {
            string json = "";
            //json += indent + "\"production\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"TOTEXT\":\"" + production.Text() + "\"," + Environment.NewLine;
            json += Environment.NewLine;
            json += indent + _indent + "\"table-index\":" + production.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"head-symbol-index\":" + production.Head.TableIndex.ToString() + "," + Environment.NewLine;

            json += indent + _indent + "\"handle-symbol-indexes\": [ ";
            for (int i = 0; i < production.Handle.Count(); i++)
            {
                json += production.Handle[i].TableIndex.ToString();
                if (i < production.Handle.Count() - 1) json += ",";
            }
            json += " ]" + Environment.NewLine;


            json += indent + "}";
            return json;
        }

        // FA State
        public static string readFaStates(GrammarFAState[] states, string indent = "")
        {
            string json = indent + "\"fa-states\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;
            for (int i = 0; i < states.Length; i++)
            {
                json += faStateToJSON(states[i], indent + _indent);
                if (i < states.Length - 1)
                {
                    json += ",";
                }
                json += Environment.NewLine;
            }
            json += indent + "]";
            return json;
        }
        public static string faStateToJSON(GrammarFAState state, string indent = "")
        {
            string json = "";
            //json += indent + "\"fa-state\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;

            json += indent + _indent + "\"table-index\":" + state.TableIndex.ToString() + "," + Environment.NewLine;
            if (state.Accept == null)
            {
                json += indent + _indent + "\"accept-symbol-index\":null," + Environment.NewLine;
            }
            else
            {
                json += indent + _indent + "\"accept-symbol-index\":" + state.Accept.TableIndex.ToString() + "," + Environment.NewLine;
            }

            if (state.Edges.Count == 0)
            {
                json += indent + _indent + "\"edges\":[]" + Environment.NewLine;
            }
            else
            {
                json += indent + _indent + "\"edges\":" + Environment.NewLine;
                json += indent + _indent + "[" + Environment.NewLine;
                for (int i = 0; i < state.Edges.Count; i++)
                {
                    if (i > 0) json += "," + Environment.NewLine;
                    json += faEdgeToJSON(state.Edges[i], indent + _indent + _indent);
                }
                json += Environment.NewLine + indent + _indent + "]" + Environment.NewLine;
            }

            json += indent + "}";
            return json;
        }
        public static string faEdgeToJSON(GrammarFAEdge edge, string indent = "")
        {
            string json = "";
            //json += indent + "\"fa-edge\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;

            json += indent + _indent + "\"character-set\":" + edge.CharacterSet.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"target\":" + edge.Target.ToString() + Environment.NewLine;

            json += indent + "}";
            return json;
        }

        // LR
        public static string readLrStates(GrammarLRState[] states, string indent = "")
        {
            string json = indent + "\"lr-states\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;
            for (int i = 0; i < states.Length; i++)
            {
                json += LrStateToJSON(states[i], indent + _indent);
                if (i < states.Length - 1)
                {
                    json += ",";
                }
                json += Environment.NewLine;
            }
            json += indent + "]";
            return json;
        }
        public static string LrStateToJSON(GrammarLRState state, string indent = "")
        {
            string json = "";
            //json += indent + "\"lr-state\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;

            json += indent + _indent + "\"table-index\":" + state.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"actions\":" + Environment.NewLine;
            json += indent + _indent + "[" + Environment.NewLine;

            for (int i = 0; i < state.Actions.Count(); i++)
            {
                json += lrActionToJSON(state.Actions[i], indent + _indent + _indent);
                if (i < state.Actions.Count - 1)
                {
                    json += ",";
                }
                json += Environment.NewLine;
            }

            json += indent + _indent + "]" + Environment.NewLine;
            json += indent + "}";
            return json;
        }
        public static string lrActionToJSON(GrammarLRAction action, string indent = "")
        {
            string json = "";
            //json += indent + "\"lr-action\":" + Environment.NewLine;
            json += indent + "{" + Environment.NewLine;

            json += indent + _indent + "\"symbol-index\":" + action.Symbol.TableIndex.ToString() + "," + Environment.NewLine;
            json += indent + _indent + "\"type\":\"" + action.Type.ToString() + "\"," + Environment.NewLine;
            json += indent + _indent + "\"value\":" + action.Value.ToString() + Environment.NewLine;

            json += indent + "}";
            return json;
        }
    }
}
//What does it mean that "//The Accept Symbol is not part of the grammar, but is functional" ?