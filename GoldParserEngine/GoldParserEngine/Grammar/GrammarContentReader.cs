using GoldParser.Egt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.Grammar
{
    public class GrammarContentReader
    {
		public static GrammarTables ReadGrammar(EgtFile file)
		{
			List<EgtRecord> records = file.Records;
			GrammarTables g = ReadGrammar(records);
			return g;
		}
		public static GrammarTables ReadGrammar(List<EgtRecord> records)
		{
			GrammarTables grammar = new GrammarTables();
			grammar.Properties = new GrammarProperties();
			grammar.TableCounts = new GrammarTableCounts();
			grammar.InitialStates = new GrammarInitialStates();

			for (int i = 0; i < records.Count; i++)
			{
				EgtRecord record = records[i];
				EgtRecordType type = (EgtRecordType)record.Entries[0].GetByte();
				switch (type)
				{
					case EgtRecordType.Property:
						loadProperty(grammar, record);
						continue;
					case EgtRecordType.TableCounts:
						loadTableCounts(grammar, record);
						continue;
					case EgtRecordType.InitialStates:
						loadInitialStates(grammar, record);
						continue;
					case EgtRecordType.CharRanges:
						loadCharRange(grammar, record);
						continue;
					case EgtRecordType.Symbol:
						loadSymbol(grammar, record);
						continue;
					case EgtRecordType.Group:
						loadGroup(grammar, record);
						continue;
					case EgtRecordType.Production:
						loadProduction(grammar, record);
						continue;
					case EgtRecordType.DFAState:
						loadDfaState(grammar, record);
						continue;
					case EgtRecordType.LRState:
						loadLrState(grammar, record);
						continue;
				}
			}

			grammar.TablesLoaded = true;
			return grammar;
		}

		static void loadProperty(GrammarTables grammar, EgtRecord record)
		{
			int index = record.Entries[1].GetInt().Value;
			string name = record.Entries[2].GetString();
			string value = record.Entries[3].GetString();

			if (grammar.Properties == null) grammar.Properties = new GrammarProperties();
			grammar.Properties.SetValue(index, name, value);
		}
		static void loadTableCounts(GrammarTables grammar, EgtRecord record)
		{
			grammar.TableCounts.SymbolTableCount = record.Entries[1].GetInt().Value;
			grammar.TableCounts.CharsetTableCount = record.Entries[2].GetInt().Value;
			grammar.TableCounts.ProductionTableCount = record.Entries[3].GetInt().Value;
			grammar.TableCounts.DfaTableCount = record.Entries[4].GetInt().Value;
			grammar.TableCounts.LrStatesTableCount = record.Entries[5].GetInt().Value;
			grammar.TableCounts.GroupTableCount = record.Entries[6].GetInt().Value;

			grammar.CharacterSets = new GrammarCharacterSet[grammar.TableCounts.CharsetTableCount];
			grammar.Symbols = new GrammarSymbol[grammar.TableCounts.SymbolTableCount];
			grammar.Groups = new GrammarGroup[grammar.TableCounts.GroupTableCount];
			grammar.Productions = new GrammarProduction[grammar.TableCounts.ProductionTableCount];
			grammar.FAStates = new GrammarFAState[grammar.TableCounts.DfaTableCount];
			grammar.LRStates = new GrammarLRState[grammar.TableCounts.LrStatesTableCount];
		}
		static void loadInitialStates(GrammarTables grammar, EgtRecord record)
		{
			grammar.InitialStates.DfaInitialState = record.Entries[1].GetInt().Value;
			grammar.InitialStates.LrInitialState = record.Entries[2].GetInt().Value;
		}
		static void loadCharRange(GrammarTables grammar, EgtRecord record)
		{
			int rangesIndex = record.Entries[1].GetInt().Value;
			//record.Entries[2] is skipped
			//record.Entries[3] is skipped
			//record.Entries[4] is skipped

			grammar.CharacterSets[rangesIndex] = new GrammarCharacterSet(rangesIndex);
			for (int k = 5; k < record.EntriesCount; k += 2)
			{
				int start = record.Entries[k].GetInt().Value;
				int end = record.Entries[k + 1].GetInt().Value;
				GrammarCharacterRange range = new GrammarCharacterRange(start, end);
				grammar.CharacterSets[rangesIndex].Add(range);
			}
		}
		static void loadSymbol(GrammarTables grammar, EgtRecord record)
		{
			int symbolTableIndex = record.Entries[1].GetInt().Value;
			string symbolname = record.Entries[2].GetString();
			GrammarSymbolType symboltype = (GrammarSymbolType)record.Entries[3].GetInt().Value;
			GrammarSymbol symbol = new GrammarSymbol(symbolname, symboltype, symbolTableIndex);
			grammar.Symbols[symbolTableIndex] = symbol;
		}
		static void loadGroup(GrammarTables grammar, EgtRecord record)
		{
			GrammarGroup group = new GrammarGroup();
			int groupTableIndex = record.Entries[1].GetInt().Value;

			group.TableIndex = groupTableIndex;
			group.Name = record.Entries[2].GetString();
			group.ContainerSymbol = grammar.Symbols[record.Entries[3].GetInt().Value];
			group.StartSymbol = grammar.Symbols[record.Entries[4].GetInt().Value];
			group.EndSymbol = grammar.Symbols[record.Entries[5].GetInt().Value];
			group.Advance = (GrammarGroupAdvanceMode)record.Entries[6].GetInt().Value;
			group.Ending = (GrammarGroupEndingMode)record.Entries[7].GetInt().Value;
			//record.Entries[8] is skipped
			int num = record.Entries[9].GetInt().Value;
			for (int j = 1; j <= num; j++)
			{
				int nest = record.Entries[9 + j].GetInt().Value;
				group.Nesting.Add(nest);
			}
			group.ContainerSymbol.Group = group;
			group.StartSymbol.Group = group;
			group.EndSymbol.Group = group;

			grammar.Groups[groupTableIndex] = group;
		}
		static void loadProduction(GrammarTables grammar, EgtRecord record)
		{
			int prodTableIndex = record.Entries[1].GetInt().Value;
			int symbol = record.Entries[2].GetInt().Value;
			//record.Entries[3] is skipped

			grammar.Productions[prodTableIndex] = new GrammarProduction(grammar.Symbols[symbol], prodTableIndex);
			for (int l = 4; l < record.EntriesCount; l++)
			{
				int x = record.Entries[l].GetInt().Value;
				grammar.Productions[prodTableIndex].Handle.Add(grammar.Symbols[x]);
			}
		}
		static void loadDfaState(GrammarTables grammar, EgtRecord record)
		{
			int dfaIndex = record.Entries[1].GetInt().Value;
			bool flag = record.Entries[2].GetBool().Value;
			int symbolIndex = record.Entries[3].GetInt().Value;
			//record.Entries[4] is skipped

			if (flag)
			{
				grammar.FAStates[dfaIndex] = new GrammarFAState(grammar.Symbols[symbolIndex], dfaIndex);
			}
			else
			{
				grammar.FAStates[dfaIndex] = new GrammarFAState(dfaIndex);
			}
			for (int m = 5; m < record.EntriesCount; m += 3)
			{
				int y = record.Entries[m].GetInt().Value;
				int target = record.Entries[m + 1].GetInt().Value;
				//record.Entries[m + 2] is skipped
				GrammarFAEdge edge = new GrammarFAEdge(grammar.CharacterSets[y], target);
				grammar.FAStates[dfaIndex].Edges.Add(edge);
			}
		}
		static void loadLrState(GrammarTables grammar, EgtRecord record)
		{
			int z = record.Entries[1].GetInt().Value;
			//record.Entries[2] is skipped
			grammar.LRStates[z] = new GrammarLRState(z);

			for (int o = 3; o < record.EntriesCount; o += 4)
			{
				int gsymbol = record.Entries[o].GetInt().Value;
				int type = record.Entries[o + 1].GetInt().Value;
				int gvalue = record.Entries[o + 2].GetInt().Value;
				//record.Entries[o + 3] is skipped
				grammar.LRStates[z].Add(
					new GrammarLRAction(
						grammar.Symbols[gsymbol],
						(LRActionType)type,
						gvalue));
			}
		}
	}
}
