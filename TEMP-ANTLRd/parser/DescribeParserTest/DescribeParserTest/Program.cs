﻿using Antlr4.Runtime;
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
            //IntegrationTestsFor07.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.A_basic1.ds");
            //IntegrationTestsFor06.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.F_production_in_production7.ds");
            //IntegrationTestsFor06.TestFiles();

            //test 07
            //IntegrationTestsFor07.TestLexer("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.A_basic1.ds");
            //IntegrationTestsFor07.TestFile("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.A_basic1.ds");
            IntegrationTestsFor07.TestFiles();
        }
    }
}