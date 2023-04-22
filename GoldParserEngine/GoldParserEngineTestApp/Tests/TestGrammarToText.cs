using GoldParser.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.Tests
{
    public class TestGrammarToText
    {
        public static void TestReadFile()
        {
            string filepath = @"C:\Users\vikto\Desktop\A.egt";
            string json = GrammarToText.ReadFile(filepath);
        }
    }
}
