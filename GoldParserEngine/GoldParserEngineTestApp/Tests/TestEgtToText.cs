using GoldParser.Egt;
using GoldParser.Helpers;
using System.Collections.Generic;
using System.IO;

namespace GoldParser.Tests
{
    public static class TestEgtToText
    {
        public static void TestReadFile()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            string text = EgtToText.ReadFile(filepath);
        }
        public static void TestReadRecords()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string text = EgtToText.ReadRecords(records);
        }
        public static void TestReadRecord()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string text = EgtToText.ReadRecord(records[0]);
        }
        public static void TestReadEntries()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string text = EgtToText.ReadEntries(records[0].Entries);
        }
        public static void TestReadEntry()
        {
            string filepath = @"C:\Users\user\Desktop\A.egt";
            Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            List<EgtRecord> records = EgtContentReager.ReadFileRecords(reader);
            string text = EgtToText.ReadEntry(records[0].Entries[0]);
        }
    }
}