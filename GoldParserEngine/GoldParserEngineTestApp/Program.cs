using GoldParser.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParserEngineTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/meziantou/GoldParser-Engine/
            //http://www.goldparser.org/doc/index.htm

            string filepath = @"C:\Users\vikto\Desktop\A.egt";

            //string toparse = @"C:\Users\vikto\Desktop\PORT\smartphone-locks.ds";
            //Parser parser = new Parser();
            //parser.LoadTables(filepath);
            //parser.Parse();

            string text = GrammarToText.ReadFile(filepath);
            bool breakpointer = true;
        }
    }
}
