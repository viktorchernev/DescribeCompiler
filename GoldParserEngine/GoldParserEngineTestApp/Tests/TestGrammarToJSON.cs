using GoldParser.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.Tests
{
    public class TestGrammarToJSON
    {
        public static void TestReadFile()
        {
            string filepath = @"C:\Users\vikto\Desktop\A.egt";
            string json = GrammarToJSON.ReadFile(filepath);
        }
    }
}
