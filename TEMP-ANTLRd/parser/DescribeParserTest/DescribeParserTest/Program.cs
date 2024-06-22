using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using DescribeParser.Visitors;

namespace DescribeParser.IntegrationTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test 06
            //IntegrationTestsFor06.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.A_basic1.ds");
            //IntegrationTestsFor06.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.F_production_in_production2.ds");
            IntegrationTestsFor06.TestFiles(false, true);
            Console.ReadLine();

            //test 07
            //IntegrationTestsFor07.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.B_comments4.ds");
            //IntegrationTestsFor07.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.F_production_in_production2.ds");
            IntegrationTestsFor07.TestFiles(false, true);
            Console.ReadLine();

            //test 08
            //IntegrationTestsFor08.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor08.A_basic1.ds");
            //IntegrationTestsFor08.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor08.A_basic1.ds");
            IntegrationTestsFor08.TestFiles(false, true);
            Console.ReadLine();

            //test 09
            //IntegrationTestsFor09.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.D_escaped_double_characters1.ds");
            //IntegrationTestsFor09.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.D_escaped_double_characters1.ds");
            IntegrationTestsFor09.TestFiles(false, true);
            Console.ReadLine();

            //test 10
            //IntegrationTestsFor10.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor10.E_escaped_double_producers.ds");
            //IntegrationTestsFor10.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor10.A_tilde.ds");
            IntegrationTestsFor10.TestFiles(false, true);
            Console.ReadLine();

            //test 11
            //IntegrationTestsFor11.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds");
            //IntegrationTestsFor11.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor11.A_tags2.ds");
            IntegrationTestsFor11.TestFiles(false, true);
            Console.ReadLine();
        }
    }
}
