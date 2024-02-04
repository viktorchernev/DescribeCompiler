using GoldParser.Egt;
using System.Collections.Generic;
using System.IO;

namespace GoldParser.Helpers
{
    public static class TestEgtToJSON
    {
        public static void TestReadFile()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            string json = EgtToJSON.ReadFile(filepath);
        }
        public static void TestReadRecords()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string json = EgtToJSON.ReadRecords(records);
        }
        public static void TestReadRecord()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string json = EgtToJSON.ReadRecord(records[0]);
        }
        public static void TestReadEntries()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string json = EgtToJSON.ReadEntries(records[0].Entries);
        }
        public static void TestReadEntry()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string json = EgtToJSON.ReadEntry(records[0].Entries[0]);
        }
    }
}