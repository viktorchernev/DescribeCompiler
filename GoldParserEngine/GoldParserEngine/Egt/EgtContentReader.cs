using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GoldParser;

namespace GoldParser.Egt
{
	/// <summary>
	/// Reads .EGT file containing grammar tables for the gold parser
	/// engine v 5.0
	/// 
	/// My reader is slightly different from the original - the
	/// original will show position when error occurs, however I find
	/// that unnecessairy in a binary file, where you most likely won't
	/// go in with a hex editor but debug the code anyway.
	/// </summary>
	public static class EgtContentReager
	{
		/// <summary>
		/// Read EGT file containing grammar tables for the GOLD
		/// parser engine v 5.0
		/// </summary>
		/// <param name="filepath">Path to the EGT file</param>
		/// <returns>EgtFile object containing List of Egt Records</returns>
		public static EgtFile ReadFile(string filepath)
		{
			try
			{
				Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				Utf16Reader reader = new Utf16Reader(stream, Encoding.Unicode);
				EgtFile file = readEgtFile(reader);
				return file;
			}
			catch (Exception ex)
			{
				throw new EgtException(ex.Message, ex, "ReadEgtFile");
			}
		}

		/// <summary>
		/// Read EGT file containing grammar tables for the GOLD
		/// parser engine v 5.0
		/// </summary>
		/// <param name="binreader">
		/// Reader from a stream that contains EGT file data
		/// </param>
		/// <returns>EgtFile object containing List of Egt Records</returns>
		public static EgtFile ReadFile(BinaryReader binreader)
		{
			try
			{
				Utf16Reader reader = new Utf16Reader(binreader.BaseStream, Encoding.Unicode);
				EgtFile file = readEgtFile(reader);
				return file;
			}
			catch (Exception ex)
			{
				throw new EgtException(ex.Message, ex, "ReadEgtFile");
			}
		}

		/// <summary>
		/// Read EGT file containing grammar tables for the GOLD
		/// parser engine v 5.0
		/// </summary>
		/// <param name="filepath">Path to the EGT file</param>
		/// <returns>List of Egt Records</returns>
		public static List<EgtRecord> ReadFileRecords(string filepath)
		{
			try
            {
				Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				Utf16Reader reader = new Utf16Reader(stream, Encoding.Unicode);
				List<EgtRecord> records = readEgtFileRecords(reader);
				return records;
			}
			catch (Exception ex)
            {
				throw new EgtException(ex.Message, ex, "ReadEgtFile");
			}
		}

		/// <summary>
		/// Read EGT file containing grammar tables for the GOLD
		/// parser engine v 5.0
		/// </summary>
		/// <param name="binreader">
		/// Reader from a stream that contains EGT file data
		/// </param>
		/// <returns>List of Egt Records</returns>
		public static List<EgtRecord> ReadFileRecords(BinaryReader binreader)
		{
			try
			{
				Utf16Reader reader = new Utf16Reader(binreader.BaseStream, Encoding.Unicode);
				List<EgtRecord> records = readEgtFileRecords(reader);
				return records;
			}
			catch (Exception ex)
			{
				throw new EgtException(ex.Message, ex, "ReadEgtFile");
			}
		}



		private static EgtFile readEgtFile(Utf16Reader reader)
		{
			//create CGTStructure from the file. this happens in the CGTReader class
			//in the main dir in "Reader.cs". First we read the file header like so
			string header = reader.ReadUnicodeString();


			//If the header don't start with "GOLD", then it is not valid
			if (!header.StartsWith("GOLD")) return null;

			//after reading the header, we read records till the end of the stream
			List<EgtRecord> records = new List<EgtRecord>();
			while (reader.BaseStream.Position != reader.BaseStream.Length)
			{
				//we read record header first, and it must be 77 which is 'M'
				byte entriesHeader = reader.ReadByte();
				if (entriesHeader != 77) return null;

				//next is count of entries in the record
				ushort entriesCount = reader.ReadUInt16();

				//then we deal with the entries by using the EntryFactory class
				//in the structure namespace
				List<EgtEntry> entries = new List<EgtEntry>();
				for (int i = 0; i < entriesCount; i++)
				{
					byte entryType = reader.ReadByte();
					switch (entryType)
					{
						case 69: // 'E'
							var eentry = new EgtEntry();
							entries.Add(eentry);
							break;
						case 98: // 'b'
							byte b = reader.ReadByte();
							var bentry = new EgtEntry(EgtEntryType.Byte, b);
							entries.Add(bentry);
							break;
						case 66: // 'B'
							bool a = reader.ReadBoolean();
							var aentry = new EgtEntry(EgtEntryType.Boolean, a);
							entries.Add(aentry);
							break;
						case 73: // 'I'
							ushort v = reader.RawReadUInt16();
							var ientry = new EgtEntry(EgtEntryType.UInt16, v);
							entries.Add(ientry);
							break;
						case 83: // 'S'
							string s = reader.ReadUnicodeString();
							var sentry = new EgtEntry(EgtEntryType.String, s);
							entries.Add(sentry);
							break;
						default: //Unknown
							var rentry = new EgtEntry(EgtEntryType.Error, string.Empty);
							entries.Add(rentry);
							break;
					}
				}

				EgtRecord r = new EgtRecord(entriesCount, entries);
				records.Add(r);
			}
			return new EgtFile(records, header);
		}
		private static List<EgtRecord> readEgtFileRecords(Utf16Reader reader)
		{
			//create CGTStructure from the file. this happens in the CGTReader class
			//in the main dir in "Reader.cs". First we read the file header like so
			string header = reader.ReadUnicodeString();


			//If the header don't start with "GOLD", then it is not valid
			if (!header.StartsWith("GOLD")) return null;

			//after reading the header, we read records till the end of the stream
			List<EgtRecord> records = new List<EgtRecord>();
			while (reader.BaseStream.Position != reader.BaseStream.Length)
			{
				//we read record header first, and it must be 77 which is 'M'
				byte entriesHeader = reader.ReadByte();
				if (entriesHeader != 77) return null;

				//next is count of entries in the record
				ushort entriesCount = reader.ReadUInt16();

				//then we deal with the entries by using the EntryFactory class
				//in the structure namespace
				List<EgtEntry> entries = new List<EgtEntry>();
				for (int i = 0; i < entriesCount; i++)
				{
					byte entryType = reader.ReadByte();
					switch (entryType)
					{
						case 69: // 'E'
							var eentry = new EgtEntry();
							entries.Add(eentry);
							break;
						case 98: // 'b'
							byte b = reader.ReadByte();
							var bentry = new EgtEntry(EgtEntryType.Byte, b);
							entries.Add(bentry);
							break;
						case 66: // 'B'
							bool a = reader.ReadBoolean();
							var aentry = new EgtEntry(EgtEntryType.Boolean, a);
							entries.Add(aentry);
							break;
						case 73: // 'I'
							ushort v = reader.RawReadUInt16();
							var ientry = new EgtEntry(EgtEntryType.UInt16, v);
							entries.Add(ientry);
							break;
						case 83: // 'S'
							string s = reader.ReadUnicodeString();
							var sentry = new EgtEntry(EgtEntryType.String, s);
							entries.Add(sentry);
							break;
						default: //Unknown
							var rentry = new EgtEntry(EgtEntryType.Error, string.Empty);
							entries.Add(rentry);
							break;
					}
				}

				EgtRecord r = new EgtRecord(entriesCount, entries);
				records.Add(r);
			}
			return records;
		}


		//Read a uint in little endian. This is the format already used
		//by the .NET BinaryReader. However, it is good to specificially
		//define this given byte order can change depending on platform.
		private static ushort RawReadUInt16(Utf16Reader reader)
		{
			int b0 = reader.ReadByte();
			int b1 = reader.ReadByte();

			return (ushort)((b1 << 8) + b0);
		}
		private static string RawReadCString(Utf16Reader reader)
		{
			string text = string.Empty;
			bool done = false;

			while (!done)
			{
				ushort char16 = RawReadUInt16(reader);
				if (char16 == 0)
				{
					done = true;
				}
				else
				{
					text += (char)char16;
				}
			}

			return text;
		}
	}
}