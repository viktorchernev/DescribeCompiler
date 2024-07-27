using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Unfold;
using DescribeParser.Visitors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DescribeParser.IntegrationTests
{
    internal class UnfoldTestsFor10 : ParserTestsBase
    {
        public static string outputDir = @"C:\Users\Viktor Chernev\Desktop\ANTLRd\testing\IntegrationTestingResults\UnfoldTests\v10";
        public static string[] skipFilesFor06 = new string[]
        {
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.A_basic3.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.C_empty1.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.C_empty2.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.C_empty3.ds"
        };
        public static string[] skipFilesFor07 = new string[]
        {
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.A_basic3.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.C_empty1.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.C_empty2.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor07.C_empty3.ds"
        };
        public static string[] skipFilesFor08 = new string[]
        {
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor08.A_basic3.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor08.C_empty1.ds",
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor08.C_empty2.ds"
        };
        public static string[] skipFilesFor09 = new string[]
        {
            "DescribeParser.IntegrationTests.TestFiles.TestFilesFor09.A_basic3.ds"
        };



        /// <summary>
        /// Preprocessor method for 10
        /// </summary>
        static string PredictTerminators(string text)
        {
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe10Lexer lexer = new Describe10Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);
            tokenstream.Fill();

            //auto-closer
            bool wasHyphen = false;
            int counter = 0;
            var tokenList = tokenstream.GetTokens();
            foreach (var token in tokenList)
            {
                int tokenType = token.Type;
                string type = GetTokenType(tokenType);

                if (type == "HYPHEN") wasHyphen = true;
                else
                {
                    if (type == "PRODUCTION_ARROW")
                    {
                        if (wasHyphen) counter++;
                    }
                    else if (type == "TERMINATOR") counter--;
                    wasHyphen = false;
                }
            }

            //we want to be creating tokens `Antlr4.Runtime.CommonToken` and passing
            //the same token list as token stream or smth, and not having to run the
            //lexer again later on.
            //var li = tokenList[26];
            //Type t = li.GetType();
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string json = JsonSerializer.Serialize(t, options);
            //var tokenList = tokenstream.GetTokens();
            //int index = GetTokenTypeIndex("TERMINATOR");

            //insert at correct index.
            //we do this because there might be a thrilling comment in our file.
            if (counter < 1) return text;
            string repeatedString = String.Concat(Enumerable.Repeat(";\n", counter));
            string tail = '\n' + repeatedString;
            int insertionIndex = tokenList[tokenList.Count - 2].StopIndex;
            string output = text;
            if (insertionIndex == text.Length - 1) output += tail;
            else output = output.Insert(insertionIndex + 1, tail);
            return output;
        }



        internal static void TestFile(string embeddedName, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //get source code to test
            string text = getEmbeddedResource(embeddedName);
            if (insertMissingTerminators) text = PredictTerminators(text);

            Console.WriteLine("Starting a parse operation on '" + embeddedName + "'" + Environment.NewLine);
            Console.WriteLine("-------------------------------------------------");

            //construct parser
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe10Lexer lexer = new Describe10Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);
            Describe10Parser parser = new Describe10Parser(tokenstream);

            //parse
            Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
            UnfoldVisitor10 visitor = new UnfoldVisitor10();
            DescribeUnfold u = new DescribeUnfold();
            visitor.TranslateScripture(u, scriptureContext, embeddedName);
            string tree = u.ToString();
            Console.WriteLine(tree);
            //string tree = visitor.Log;

            //IDK really why this is
            parser.BuildParseTree = true;
            ParseInfo pinfo = parser.ParseInfo;

            //get text
            string result = resultTemplateA;
            result += text + resultTemplateB;
            result += Environment.NewLine + Environment.NewLine + tree;

            //get save name
            string[] sep = embeddedName.Split('.');
            string filename = sep[sep.Length - 2] + ".md";
            if (visitor.LastError != null)
            {
                filename = "~" + filename;
            }
            filename = Path.Combine(outputdir, filename);
            File.WriteAllText(filename, result);

            Console.WriteLine("-------------------------------------------------");
            if (visitor.LastError == null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
                Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!");
                Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
        }
        internal static void TestFiles(bool pressKey = true, bool insertMissingTerminators = true)
        {
            TestFilesFor06(pressKey, insertMissingTerminators);
            TestFilesFor07(pressKey, insertMissingTerminators);
            TestFilesFor08(pressKey, insertMissingTerminators);
            TestFilesFor09(pressKey, insertMissingTerminators);
            TestFilesFor10(pressKey, insertMissingTerminators);
        }
        static void TestFilesFor06(bool pressKey = true, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //delete all ".md" files in the directory
            string[] files = Directory.GetFiles(outputdir, "*.md");
            foreach (string file in files) File.Delete(file);

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name.StartsWith("DescribeParser.IntegrationTests.TestFiles.TestFilesFor06") == false) continue;
                if (skipFilesFor06.Contains(name)) continue;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Starting a parse operation on '" + name + "'" + Environment.NewLine);

                //get source code to test
                string text = getEmbeddedResource(name);
                if (insertMissingTerminators) text = PredictTerminators(text);

                //construct parser
                AntlrInputStream inputstream = new AntlrInputStream(text);
                Describe10Lexer lexer = new Describe10Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);
                Describe10Parser parser = new Describe10Parser(tokenstream);

                //set timer
                Stopwatch fullwatch = new Stopwatch();
                fullwatch.Start();

                //parse
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                UnfoldVisitor10 visitor = new UnfoldVisitor10();
                DescribeUnfold u = new DescribeUnfold();
                visitor.TranslateScripture(u, scriptureContext, name);
                fullwatch.Stop();
                string tree = u.ToString();
                Console.WriteLine(tree);

                //IDK really why this is
                parser.BuildParseTree = true;
                ParseInfo pinfo = parser.ParseInfo;

                //get text
                string result = resultTemplateA;
                result += text + resultTemplateB;
                result += Environment.NewLine + tree;

                //get save name
                string[] sep = name.Split('.');
                string filename = "(06)" + sep[sep.Length - 2] + ".md";
                if (visitor.LastError != null)
                {
                    filename = "~" + filename;
                }
                filename = Path.Combine(outputdir, filename);
                File.WriteAllText(filename, result);

                Console.WriteLine("-------------------------------------------------");
                if (visitor.LastError == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string formattedElapsedTime = GetElapsedTime(fullwatch);
                    Console.WriteLine("Success! - took: " + formattedElapsedTime);
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
            }

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Tests for 06 concluded. Press any key to continue with 07.");
            if (pressKey) Console.ReadLine();
        }
        static void TestFilesFor07(bool pressKey = true, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name.StartsWith("DescribeParser.IntegrationTests.TestFiles.TestFilesFor07") == false) continue;
                if (skipFilesFor07.Contains(name)) continue;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Starting a parse operation on '" + name + "'" + Environment.NewLine);

                //get source code to test
                string text = getEmbeddedResource(name);
                if (insertMissingTerminators) text = PredictTerminators(text);

                //construct parser
                AntlrInputStream inputstream = new AntlrInputStream(text);
                Describe10Lexer lexer = new Describe10Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);
                Describe10Parser parser = new Describe10Parser(tokenstream);

                //set timer
                Stopwatch fullwatch = new Stopwatch();
                fullwatch.Start();

                //parse
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                UnfoldVisitor10 visitor = new UnfoldVisitor10();
                DescribeUnfold u = new DescribeUnfold();
                visitor.TranslateScripture(u, scriptureContext, name);
                fullwatch.Stop();
                string tree = u.ToString();
                Console.WriteLine(tree);

                //IDK really why this is
                parser.BuildParseTree = true;
                ParseInfo pinfo = parser.ParseInfo;

                //get text
                string result = resultTemplateA;
                result += text + resultTemplateB;
                result += Environment.NewLine + tree;

                //get save name
                string[] sep = name.Split('.');
                string filename = "(07)" + sep[sep.Length - 2] + ".md";
                if (visitor.LastError != null)
                {
                    filename = "~" + filename;
                }
                filename = Path.Combine(outputdir, filename);
                File.WriteAllText(filename, result);

                Console.WriteLine("-------------------------------------------------");
                if (visitor.LastError == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string formattedElapsedTime = GetElapsedTime(fullwatch);
                    Console.WriteLine("Success! - took: " + formattedElapsedTime);
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
            }

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Tests for 07 concluded. Press any key to continue with 08.");
            if (pressKey) Console.ReadLine();
        }
        static void TestFilesFor08(bool pressKey = true, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name.StartsWith("DescribeParser.IntegrationTests.TestFiles.TestFilesFor08") == false) continue;
                if (skipFilesFor08.Contains(name)) continue;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Starting a parse operation on '" + name + "'" + Environment.NewLine);

                //get source code to test
                string text = getEmbeddedResource(name);
                if (insertMissingTerminators) text = PredictTerminators(text);

                //construct parser
                AntlrInputStream inputstream = new AntlrInputStream(text);
                Describe10Lexer lexer = new Describe10Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);
                Describe10Parser parser = new Describe10Parser(tokenstream);

                //set timer
                Stopwatch fullwatch = new Stopwatch();
                fullwatch.Start();

                //parse
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                UnfoldVisitor10 visitor = new UnfoldVisitor10();
                DescribeUnfold u = new DescribeUnfold();
                visitor.TranslateScripture(u, scriptureContext, name);
                fullwatch.Stop();
                string tree = u.ToString();
                Console.WriteLine(tree);

                //IDK really why this is
                parser.BuildParseTree = true;
                ParseInfo pinfo = parser.ParseInfo;

                //get text
                string result = resultTemplateA;
                result += text + resultTemplateB;
                result += Environment.NewLine + tree;

                //get save name
                string[] sep = name.Split('.');
                string filename = "(08)" + sep[sep.Length - 2] + ".md";
                if (visitor.LastError != null)
                {
                    filename = "~" + filename;
                }
                filename = Path.Combine(outputdir, filename);
                File.WriteAllText(filename, result);

                Console.WriteLine("-------------------------------------------------");
                if (visitor.LastError == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string formattedElapsedTime = GetElapsedTime(fullwatch);
                    Console.WriteLine("Success! - took: " + formattedElapsedTime);
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
            }

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Tests for 08 concluded. Press any key to continue with 09.");
            if (pressKey) Console.ReadLine();
        }
        static void TestFilesFor09(bool pressKey = true, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name.StartsWith("DescribeParser.IntegrationTests.TestFiles.TestFilesFor09") == false) continue;
                if (skipFilesFor09.Contains(name)) continue;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Starting a parse operation on '" + name + "'" + Environment.NewLine);

                //get source code to test
                string text = getEmbeddedResource(name);
                if (insertMissingTerminators) text = PredictTerminators(text);

                //construct parser
                AntlrInputStream inputstream = new AntlrInputStream(text);
                Describe10Lexer lexer = new Describe10Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);
                Describe10Parser parser = new Describe10Parser(tokenstream);

                //set timer
                Stopwatch fullwatch = new Stopwatch();
                fullwatch.Start();

                //parse
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                UnfoldVisitor10 visitor = new UnfoldVisitor10();
                DescribeUnfold u = new DescribeUnfold();
                visitor.TranslateScripture(u, scriptureContext, name);
                fullwatch.Stop();
                string tree = u.ToString();
                Console.WriteLine(tree);

                //IDK really why this is
                parser.BuildParseTree = true;
                ParseInfo pinfo = parser.ParseInfo;

                //get text
                string result = resultTemplateA;
                result += text + resultTemplateB;
                result += Environment.NewLine + tree;

                //get save name
                string[] sep = name.Split('.');
                string filename = "(09)" + sep[sep.Length - 2] + ".md";
                if (visitor.LastError != null)
                {
                    filename = "~" + filename;
                }
                filename = Path.Combine(outputdir, filename);
                File.WriteAllText(filename, result);

                Console.WriteLine("-------------------------------------------------");
                if (visitor.LastError == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string formattedElapsedTime = GetElapsedTime(fullwatch);
                    Console.WriteLine("Success! - took: " + formattedElapsedTime);
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
            }

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Tests for 09 concluded. Press any key to continue with 10.");
            if (pressKey) Console.ReadLine();
        }
        static void TestFilesFor10(bool pressKey = true, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name.StartsWith("DescribeParser.IntegrationTests.TestFiles.TestFilesFor10") == false) continue;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Starting a parse operation on '" + name + "'" + Environment.NewLine);

                //get source code to test
                string text = getEmbeddedResource(name);
                if (insertMissingTerminators) text = PredictTerminators(text);

                //construct parser
                AntlrInputStream inputstream = new AntlrInputStream(text);
                Describe10Lexer lexer = new Describe10Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);
                Describe10Parser parser = new Describe10Parser(tokenstream);

                //set timer
                Stopwatch fullwatch = new Stopwatch();
                fullwatch.Start();

                //parse
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                UnfoldVisitor10 visitor = new UnfoldVisitor10();
                DescribeUnfold u = new DescribeUnfold();
                visitor.TranslateScripture(u, scriptureContext, name);
                fullwatch.Stop();
                string tree = u.ToString();
                Console.WriteLine(tree);

                //IDK really why this is
                parser.BuildParseTree = true;
                ParseInfo pinfo = parser.ParseInfo;

                //get text
                string result = resultTemplateA;
                result += text + resultTemplateB;
                result += Environment.NewLine + tree;

                //get save name
                string[] sep = name.Split('.');
                string filename = "(10)" + sep[sep.Length - 2] + ".md";
                if (visitor.LastError != null)
                {
                    filename = "~" + filename;
                }
                filename = Path.Combine(outputdir, filename);
                File.WriteAllText(filename, result);

                Console.WriteLine("-------------------------------------------------");
                if (visitor.LastError == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    string formattedElapsedTime = GetElapsedTime(fullwatch);
                    Console.WriteLine("Success! - took: " + formattedElapsedTime);
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
            }

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Tests concluded. Press any key to continue/exit.");
            if (pressKey) Console.ReadLine();
        }


        static string GetElapsedTime(Stopwatch watch)
        {
            // Old - millisecond range
            //string formattedElapsedTime = string.Format("{0:0}.{1:000} seconds", elapsed.TotalSeconds, elapsed.Milliseconds);
            //return formattedElapsedTime

            // New - 100 Nanosecond range
            TimeSpan elapsed = watch.Elapsed;

            // Convert ticks to nanoseconds
            double totalNanoseconds = elapsed.Ticks * 100.0;

            // Calculate milliseconds, microseconds, and nanoseconds
            int milliseconds = (int)(totalNanoseconds / 1_000_000);
            int microseconds = (int)((totalNanoseconds % 1_000_000) / 1_000);
            int nanoseconds = (int)(totalNanoseconds % 1_000);

            // Format the elapsed time to include milliseconds, microseconds, and nanoseconds
            string formattedElapsedTime = string.Format("{0:0}.{1:000}.{2:000}.{3:0} seconds",
                Math.Floor(elapsed.TotalSeconds), milliseconds, microseconds, nanoseconds / 100);

            //return
            return formattedElapsedTime;
        }
        static string GetTokenType(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe10Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        static int GetTokenTypeIndex(string tokenName)
        {
            var i = 1;
            while (true)
            {
                var nameIndex = Describe10Lexer.DefaultVocabulary.GetSymbolicName(i);
                if (nameIndex == null) return -1;
                if (nameIndex == tokenName) return i;
                i++;
            }
        }
    }
}
