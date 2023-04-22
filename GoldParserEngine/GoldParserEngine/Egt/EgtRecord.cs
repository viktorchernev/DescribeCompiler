using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.Egt
{
	/* 
	 * Disasmembler
	 * GOLD Engine, Version=5.0.4337.25397, Culture=neutral, PublicKeyToken=null
	 * GOLD.Parser.LoadTables(string Path)
	 * ->LoadTables(new BinaryReader(File.Open(Path, FileMode.Open, FileAccess.Read)));
	 */

	//records appear in order as follows.
	//No record groups appear twice.
	//This is for my own custom grammar, though.
	//
	//"value":"0x70" Property					8 records
	//"value":"0x74" TableCounts				1 record
	//"value":"0x49" InitialStates				1 record
	//"value":"0x63" CharRanges					19 records
	//"value":"0x53" Symbol						42 records
	//"value":"0x67" Group						2 records
	//"value":"0x52" Production					38 records
	//"value":"0x44" DFAState					39 records
	//"value":"0x4C" LRState					53 records
	//GroupNesting is not used


	public enum EgtRecordType : byte
	{
		InitialStates = 0x49,       //73 in dec
		Symbol = 0x53,              //83 in dec
		Production = 0x52,          //82 in dec
		DFAState = 0x44,            //68 in dec
		LRState = 0x4C,             //76 in dec
		Property = 0x70,            //112 in dec
		CharRanges = 0x63,          //99 in dec
		Group = 0x67,               //103 in dec
		GroupNesting = 0x6E,        //110 in dec
		TableCounts = 0x74          //116 in dec
	}
	public class EgtRecord
	{
		private int _entriesCount;
		public List<EgtEntry> Entries;

		public int EntriesCount
        {
			get
            {
				return _entriesCount;
            }
        }

		public EgtRecord(int ecount, List<EgtEntry> entries)
		{
			_entriesCount = ecount;
			Entries = entries;
		}
	}
}
