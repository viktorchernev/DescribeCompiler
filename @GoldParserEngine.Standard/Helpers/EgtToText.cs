using GoldParser.Egt;
using System;
using System.Collections.Generic;
using System.IO;

namespace GoldParser.Helpers
{
    public static class EgtToText
    {
        private static int _columnWidth;
        static EgtToText()
        {
            _columnWidth = 20;
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
        /// Read an EGT file and translate it to readable text. 
        /// 
        /// Using this method will produce text that has a file header, 
        /// while other methods in this class will produce JSON without that field.
        /// </summary>
        /// <param name="path">The path of the file to translate</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            try
            {
                //open file reader
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                Utf16Reader reader = new Utf16Reader(stream);


                //If the header don't start with "GOLD", then it is not valid
                EgtFile file = EgtContentReager.ReadFile(reader);
                if (!file.Header.StartsWith("GOLD"))
                {
                    throw new EgtException("File header is invalid");
                }
                string result = file.Header + Environment.NewLine + Environment.NewLine;
                result += readRecords(file.Records);
                return result;
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadFile");
            }
        }

        /// <summary>
        /// Translate a list of records to readable text.
        /// </summary>
        /// <param name="records">The list to be translated</param>
        /// <returns>string</returns>
        public static string ReadRecords(List<EgtRecord> records)
        {
            try
            {
                return readRecords(records);
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadRecords");
            }
        }

        /// <summary>
        /// Translate a Record to readable text.
        /// </summary>
        /// <param name="records">The Record to be translated</param>
        /// <returns>string</returns>
        public static string ReadRecord(EgtRecord record)
        {
            try
            {
                return readRecord(record);
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadRecord");
            }
        }

        /// <summary>
        /// Translate a list of entries to readable text.
        /// </summary>
        /// <param name="records">The list to be translated</param>
        /// <returns>string</returns>
        public static string ReadEntries(List<EgtEntry> entries)
        {
            try
            {
                return readEntries(entries);
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadEntries");
            }
        }

        /// <summary>
        /// Translate an Entry to readable text.
        /// </summary>
        /// <param name="records">The Entry to be translated</param>
        /// <returns>string</returns>
        public static string ReadEntry(EgtEntry entry)
        {
            try
            {
                return readEntry(entry);
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadEntry");
            }
        }



        static string readRecords(List<EgtRecord> records)
        {
            string result = "";
            foreach (EgtRecord record in records)
            {
                if (result.Length > 0) result += Environment.NewLine + Environment.NewLine;
                result += readRecord(record);
            }

            return result;
        }
        static string readRecord(EgtRecord record)
        {
            string result = record.EntriesCount.ToString() +
                Environment.NewLine +
                readEntries(record.Entries);
            return result;
        }
        static string readEntries(List<EgtEntry> entries)
        {
            string result = "";
            foreach (EgtEntry entry in entries)
            {
                if (result.Length > 0) result += Environment.NewLine;
                result += readEntry(entry);
            }

            return result;
        }
        static string readEntry(EgtEntry entry)
        {
            string result = "{" + entry.Type.ToString() + "}";
            result = result.PadRight(_columnWidth);

            switch (entry.Type)
            {
                case EgtEntryType.Error:
                    result += "\"\"";
                    break;
                case EgtEntryType.Empty:
                    result += "\"\"";
                    break;
                case EgtEntryType.UInt16:
                    result += entry.GetInt().ToString();
                    break;
                case EgtEntryType.Boolean:
                    string bval = (entry.GetBool() == true ? "true" : "false");
                    result += bval;
                    break;
                case EgtEntryType.Byte:
                    byte b = entry.GetByte().Value;
                    result += "0x" + b.ToString("x");
                    break;
                case EgtEntryType.String:
                    result += "\"" + entry.GetString() + "\"";
                    break;
            }

            return result;
        }
    }
}
