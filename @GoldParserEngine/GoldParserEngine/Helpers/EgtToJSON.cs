using System;
using System.Collections.Generic;
using System.IO;
using GoldParser.Egt;


namespace GoldParser.Helpers
{
    public static class EgtToJSON
    {
        private static string _indent;
        static EgtToJSON()
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
        /// Read an EGT file and translate it to JSON. 
        /// 
        /// Using this method will produce JSON that has a file header field, 
        /// while other methods in this class will produce JSON without that field.
        /// </summary>
        /// <param name="path"></param>
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
                string result = readRecords(file.Records, _indent);


                string json = "{" + Environment.NewLine;
                json += _indent + "\"header\":\"" + file.Header + "\"," + Environment.NewLine;
                json += result + Environment.NewLine;
                json += "}";

                return json;
            }
            catch(Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadFile");
            }
        }

        /// <summary>
        /// Translate a list of records to JSON.
        /// </summary>
        /// <param name="records">The list to be translated</param>
        /// <returns>JSON string</returns>
        public static string ReadRecords(List<EgtRecord> records)
        {
            try
            {
                return "{" + Environment.NewLine + 
                    readRecords(records, _indent) + 
                    Environment.NewLine + "}";
            }
            catch(Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadRecords");
            }
        }

        /// <summary>
        /// Translate a Record to JSON.
        /// </summary>
        /// <param name="records">The Record to be translated</param>
        /// <returns>JSON string</returns>
        public static string ReadRecord(EgtRecord record)
        {
            try
            {
                return "{" + Environment.NewLine +
                    _indent + "\"record\":" + Environment.NewLine +
                    readRecord(record, _indent) +
                    Environment.NewLine + "}";
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadRecord");
            }
        }

        /// <summary>
        /// Translate a list of entries to JSON.
        /// </summary>
        /// <param name="records">The list to be translated</param>
        /// <returns>JSON string</returns>
        public static string ReadEntries(List<EgtEntry> entries)
        {
            try
            {
                return "{" + Environment.NewLine +
                    readEntries(entries, _indent) +
                    Environment.NewLine + "}";
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadEntries");
            }
        }

        /// <summary>
        /// Translate an Entry to JSON.
        /// </summary>
        /// <param name="records">The Entry to be translated</param>
        /// <returns>JSON string</returns>
        public static string ReadEntry(EgtEntry entry)
        {
            try
            {
                return "{" + Environment.NewLine +
                    _indent + "\"entry\":" + Environment.NewLine +
                    readEntry(entry, _indent) +
                    Environment.NewLine + "}";
            }
            catch (Exception ex)
            {
                throw new EgtException(ex.Message, ex, "ReadEntry");
            }
        }



        static string readRecords(List<EgtRecord> records, string indent = "")
        {
            string result = "";
            foreach (EgtRecord record in records)
            {
                if (result.Length > 0) result += "," + Environment.NewLine;
                result += readRecord(record, indent + _indent);
            }

            string json = indent + "\"records\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;
            json += result + Environment.NewLine;
            json += indent + "]";

            return json;
        }
        static string readRecord(EgtRecord record, string indent = "")
        {
            string result = readEntries(record.Entries, indent + _indent);

            string json = indent + "{" + Environment.NewLine;
            json += indent + _indent + "\"entry count\":" + record.EntriesCount.ToString() + "," + Environment.NewLine;
            json += result + Environment.NewLine;
            json += indent + "}";

            return json;
        }
        static string readEntries(List<EgtEntry> entries, string indent = "")
        {
            string result = "";
            foreach (EgtEntry entry in entries)
            {
                if (result.Length > 0) result += "," + Environment.NewLine;
                result += readEntry(entry, indent + _indent);
            }

            string json = indent + "\"entries\":" + Environment.NewLine;
            json += indent + "[" + Environment.NewLine;
            json += result + Environment.NewLine;
            json += indent + "]";

            return json;
        }
        static string readEntry(EgtEntry entry, string indent = "")
        {
            string result = indent + _indent + "\"type\":\"" + entry.Type.ToString() + "\"";
            result += "," + Environment.NewLine;
            switch(entry.Type)
            {
                case EgtEntryType.Error:
                    result += indent + _indent + "\"value\":\"\"";
                    break;
                case EgtEntryType.Empty:
                    result += indent + _indent + "\"value\":\"\"";
                    break;
                case EgtEntryType.UInt16:
                    result += indent + _indent + "\"value\":" + entry.GetInt().ToString();
                    break;
                case EgtEntryType.Boolean:
                    string bval = (entry.GetBool() == true ? "true" : "false");
                    result += indent + _indent + "\"value\":" + bval;
                    break;
                case EgtEntryType.Byte:
                    byte b = entry.GetByte().Value;
                    result += indent + _indent + "\"value\":\"0x" + b.ToString("x") + "\"";
                    break;
                case EgtEntryType.String:
                    result += indent + _indent + "\"value\":\"" + entry.GetString() + "\"";
                    break;
            }

            string json = indent + "{" + Environment.NewLine;
            json += result + Environment.NewLine;
            json += indent + "}";

            return json;
        }
    }
}