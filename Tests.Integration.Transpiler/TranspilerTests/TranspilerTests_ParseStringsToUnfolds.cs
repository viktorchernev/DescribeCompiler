using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Unfold;
using DescribeParser.Visitors;
using DescribeTranspiler;
using DescribeTranspiler.Translators;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;


namespace Tests.Integration.Transpiler
{
    internal class TranspilerTests_StringsToUnfolds : TestsBase
    {
        public static string outputDir = @"C:\Users\Viktor Chernev\Desktop\testing\TranspilerTests\ParseStringsToUnfolds";

        internal static void Test_ParseString_OverloadA(LogVerbosity verbosity)
        {
            string a = verbosity.ToString();
            outputDir = outputDir + "-A\\" + a + "Verbosity";

            //set console
            Console.ForegroundColor = ConsoleColor.White;

            // Delete all ".md" files in each directory within outputDir
            string[] directories = Directory.GetDirectories(outputDir);
            foreach (string dir in directories)
            {
                // Get all ".md" files in the current directory
                string[] files = Directory.GetFiles(dir, "*.md");
                foreach (string file in files)
                {
                    File.Delete(file); // Delete each file
                }

                // After all files have been deleted, the directory can be deleted
                Directory.Delete(dir);
            }

            // Also delete any ".md" files directly in the outputDir
            string[] filesInOutputDir = Directory.GetFiles(outputDir, "*.md");
            foreach (string file in filesInOutputDir)
            {
                File.Delete(file);
            }

            //get test files
            List<SourceCode> live_Radio = new List<SourceCode>();
            List<SourceCode> TestFilesFor06 = new List<SourceCode>();
            List<SourceCode> TestFilesFor07 = new List<SourceCode>();
            List<SourceCode> TestFilesFor08 = new List<SourceCode>();
            List<SourceCode> TestFilesFor09 = new List<SourceCode>();
            List<SourceCode> TestFilesFor10 = new List<SourceCode>();
            List<SourceCode> TestFilesFor11 = new List<SourceCode>();

            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                string[] sep = name.Split('.');
                string sourceCode = getEmbeddedResource(name);
                SourceCode sc = new SourceCode();
                sc.FileName = name;
                sc.SourceText = sourceCode;

                if (sep[4].Contains("live_Radio")) live_Radio.Add(sc);
                else if(sep[4].Contains("TestFilesFor06")) TestFilesFor06.Add(sc);
                else if (sep[4].Contains("TestFilesFor07")) TestFilesFor07.Add(sc);
                else if (sep[4].Contains("TestFilesFor08")) TestFilesFor08.Add(sc);
                else if (sep[4].Contains("TestFilesFor09")) TestFilesFor09.Add(sc);
                else if (sep[4].Contains("TestFilesFor10")) TestFilesFor10.Add(sc);
                else if (sep[4].Contains("TestFilesFor11")) TestFilesFor11.Add(sc);
            }

            // Parse
            test_ParseStringA(verbosity, live_Radio, "live_Radio");
            test_ParseStringA(verbosity, TestFilesFor06, "TestFilesFor06", DescribeVersionNumber.Version06);
            test_ParseStringA(verbosity, TestFilesFor07, "TestFilesFor07", DescribeVersionNumber.Version07);
            test_ParseStringA(verbosity, TestFilesFor08, "TestFilesFor08", DescribeVersionNumber.Version08);
            test_ParseStringA(verbosity, TestFilesFor09, "TestFilesFor09", DescribeVersionNumber.Version09);
            test_ParseStringA(verbosity, TestFilesFor10, "TestFilesFor10", DescribeVersionNumber.Version10);
            test_ParseStringA(verbosity, TestFilesFor11, "TestFilesFor11", DescribeVersionNumber.Version11);
        }
        internal static void Test_ParseString_OverloadB(LogVerbosity verbosity)
        {
            string a = verbosity.ToString();
            outputDir = outputDir + "-B\\" + a + "Verbosity";

            //set console
            Console.ForegroundColor = ConsoleColor.White;

            // Delete all ".md" files in each directory within outputDir
            string[] directories = Directory.GetDirectories(outputDir);
            foreach (string dir in directories)
            {
                // Get all ".md" files in the current directory
                string[] files = Directory.GetFiles(dir, "*.md");
                foreach (string file in files)
                {
                    File.Delete(file); // Delete each file
                }

                // After all files have been deleted, the directory can be deleted
                Directory.Delete(dir);
            }

            // Also delete any ".md" files directly in the outputDir
            string[] filesInOutputDir = Directory.GetFiles(outputDir, "*.md");
            foreach (string file in filesInOutputDir)
            {
                File.Delete(file);
            }

            //get test files
            List<string> live_Radio = new List<string>();
            List<string> TestFilesFor06 = new List<string>();
            List<string> TestFilesFor07 = new List<string>();
            List<string> TestFilesFor08 = new List<string>();
            List<string> TestFilesFor09 = new List<string>();
            List<string> TestFilesFor10 = new List<string>();
            List<string> TestFilesFor11 = new List<string>();

            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                string[] sep = name.Split('.');
                string sourceCode = getEmbeddedResource(name);

                if (sep[4].Contains("live_Radio")) live_Radio.Add(sourceCode);
                else if (sep[4].Contains("TestFilesFor06")) TestFilesFor06.Add(sourceCode);
                else if (sep[4].Contains("TestFilesFor07")) TestFilesFor07.Add(sourceCode);
                else if (sep[4].Contains("TestFilesFor08")) TestFilesFor08.Add(sourceCode);
                else if (sep[4].Contains("TestFilesFor09")) TestFilesFor09.Add(sourceCode);
                else if (sep[4].Contains("TestFilesFor10")) TestFilesFor10.Add(sourceCode);
                else if (sep[4].Contains("TestFilesFor11")) TestFilesFor11.Add(sourceCode);
            }

            // Parse
            test_ParseStringB(verbosity, live_Radio, "live_Radio");
            test_ParseStringB(verbosity, TestFilesFor06, "TestFilesFor06", DescribeVersionNumber.Version06);
            test_ParseStringB(verbosity, TestFilesFor07, "TestFilesFor07", DescribeVersionNumber.Version07);
            test_ParseStringB(verbosity, TestFilesFor08, "TestFilesFor08", DescribeVersionNumber.Version08);
            test_ParseStringB(verbosity, TestFilesFor09, "TestFilesFor09", DescribeVersionNumber.Version09);
            test_ParseStringB(verbosity, TestFilesFor10, "TestFilesFor10", DescribeVersionNumber.Version10);
            test_ParseStringB(verbosity, TestFilesFor11, "TestFilesFor11", DescribeVersionNumber.Version11);
        }


        internal static void Test_ParseString_OverloadA(LogVerbosity verbosity, string embeddedName, string? folder = null)
        {
            string a = verbosity.ToString();
            outputDir = outputDir + "-A\\" + a + "Verbosity";

            //set console
            Console.ForegroundColor = ConsoleColor.White;

            // Delete all ".md" files in each directory within outputDir
            string[] directories = Directory.GetDirectories(outputDir);
            foreach (string dir in directories)
            {
                // Get all ".md" files in the current directory
                string[] files = Directory.GetFiles(dir, "*.md");
                foreach (string file in files)
                {
                    File.Delete(file); // Delete each file
                }

                // After all files have been deleted, the directory can be deleted
                Directory.Delete(dir);
            }

            // Also delete any ".md" files directly in the outputDir
            string[] filesInOutputDir = Directory.GetFiles(outputDir, "*.md");
            foreach (string file in filesInOutputDir)
            {
                File.Delete(file);
            }

            //get test file
            List<SourceCode> testList = new List<SourceCode>();
            string foldr = "";
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name != embeddedName) continue;

                string[] sep = name.Split('.');
                string sourceCode = getEmbeddedResource(name);
                foldr = sep[4];

                SourceCode sc = new SourceCode();
                sc.FileName = name;
                sc.SourceText = sourceCode;
                testList.Add(sc);
                break;
            }

            // Parse
            test_ParseStringA(verbosity, testList, foldr);
        }
        internal static void Test_ParseString_OverloadB(LogVerbosity verbosity, string embeddedName, string? folder = null)
        {
            string a = verbosity.ToString();
            outputDir = outputDir + "-A\\" + a + "Verbosity";

            //set console
            Console.ForegroundColor = ConsoleColor.White;

            // Delete all ".md" files in each directory within outputDir
            string[] directories = Directory.GetDirectories(outputDir);
            foreach (string dir in directories)
            {
                // Get all ".md" files in the current directory
                string[] files = Directory.GetFiles(dir, "*.md");
                foreach (string file in files)
                {
                    File.Delete(file); // Delete each file
                }

                // After all files have been deleted, the directory can be deleted
                Directory.Delete(dir);
            }

            // Also delete any ".md" files directly in the outputDir
            string[] filesInOutputDir = Directory.GetFiles(outputDir, "*.md");
            foreach (string file in filesInOutputDir)
            {
                File.Delete(file);
            }

            //get test file
            List<string> testList = new List<string>();
            string foldr = "";
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name != embeddedName) continue;

                string[] sep = name.Split('.');
                string sourceCode = getEmbeddedResource(name);
                foldr = sep[4];

                testList.Add(sourceCode);
                break;
            }

            // Parse
            test_ParseStringB(verbosity, testList, foldr);
        }


        internal static void test_ParseStringA(LogVerbosity verbosity,
            List<SourceCode> sources, string folder, 
            DescribeVersionNumber? langVer = null)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_a.md");
            resultTemplateA = resultTemplateA.Replace("Source Code (between the arrows)", "Source Code File Names (between the arrows)");
            string resultTemplateB = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_b.md");
            string resultTemplateC = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_c.md");

            //get source code to test
            Console.WriteLine("Starting a test on multiple source codes");
            Console.WriteLine("-------------------------------------------------");

            //construct compiler
            DescribeCompiler compiler;
            if (langVer == null)
            {
                compiler = new DescribeCompiler(
                verbosity, ConsoleLog, ConsoleLogError,
                ConsoleLogInfo, ConsoleLogParseInfo);
            }
            else
            {
                compiler = new DescribeCompiler(langVer.Value,
                verbosity, ConsoleLog, ConsoleLogError,
                ConsoleLogInfo, ConsoleLogParseInfo);
            }

            //compile
            List<DescribeUnfold> ul;
            bool r = compiler.ParseStrings(sources, out ul);

            //form log file
            string log = compiler.Log;
            string unfoldText = "";
            for (int i = 0; i < ul.Count; i++)
            {
                if (unfoldText != "")
                {
                    unfoldText += Environment.NewLine + Environment.NewLine +
                        "---------------------------------------------"
                        + Environment.NewLine;
                    unfoldText += ul[i].ToString();
                }
            }
            string result = resultTemplateA;

            string scrl = "";
            foreach (SourceCode source in sources)
            {
                if (scrl.Length > 0) scrl += Environment.NewLine;
                scrl += source.FileName;
            }

            result += scrl + resultTemplateB;
            result += log + resultTemplateC + Environment.NewLine;
            result += unfoldText;

            //get save name
            string filename = folder + ".md";
            if (r == false) filename = "~" + filename;
            filename = Path.Combine(outputdir, filename);
            File.WriteAllText(filename, result);
            Console.WriteLine("-------------------------------------------------");
            if (r == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!" + Environment.NewLine);
                //Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                //Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!" + Environment.NewLine);
                //Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                //Console.ReadLine();
            }
        }
        internal static void test_ParseStringB(LogVerbosity verbosity,
            List<string> sources, string folder,
            DescribeVersionNumber? langVer = null)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_a.md");
            resultTemplateA = resultTemplateA.Replace("Source Code (between the arrows)", "Source Code File Names (between the arrows)");
            string resultTemplateB = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_b.md");
            string resultTemplateC = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_c.md");

            //get source code to test
            Console.WriteLine("Starting a test on multiple source codes");
            Console.WriteLine("-------------------------------------------------");

            //construct compiler
            DescribeCompiler compiler;
            if (langVer == null)
            {
                compiler = new DescribeCompiler(
                verbosity, ConsoleLog, ConsoleLogError,
                ConsoleLogInfo, ConsoleLogParseInfo);
            }
            else
            {
                compiler = new DescribeCompiler(langVer.Value,
                verbosity, ConsoleLog, ConsoleLogError,
                ConsoleLogInfo, ConsoleLogParseInfo);
            }

            //compile
            List<DescribeUnfold> ul;
            bool r = compiler.ParseStrings(sources, out ul);

            //form log file
            string log = compiler.Log;
            string unfoldText = "";
            for (int i = 0; i < ul.Count; i++)
            {
                if (unfoldText != "")
                {
                    unfoldText += Environment.NewLine + Environment.NewLine +
                        "---------------------------------------------"
                        + Environment.NewLine;
                    unfoldText += ul[i].ToString();
                }
            }
            string result = resultTemplateA;

            string scrl = "";
            foreach (string source in sources)
            {
                if (scrl.Length > 0) scrl += Environment.NewLine;
                scrl += _createMD5(source, 16);
            }

            result += scrl + resultTemplateB;
            result += log + resultTemplateC + Environment.NewLine;
            result += unfoldText;

            //get save name
            string filename = folder + ".md";
            if (r == false) filename = "~" + filename;
            filename = Path.Combine(outputdir, filename);
            File.WriteAllText(filename, result);
            Console.WriteLine("-------------------------------------------------");
            if (r == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!" + Environment.NewLine);
                //Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                //Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!" + Environment.NewLine);
                //Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                //Console.ReadLine();
            }
        }



        //settings
        public static bool ONE_BASED_ARG_INDEX = true;
        public static ConsoleColor INFO_COLOR = ConsoleColor.DarkGray;
        public static ConsoleColor TEXT_COLOR = ConsoleColor.White;
        public static ConsoleColor ERROR_COLOR = ConsoleColor.Red;
        public static ConsoleColor MOREINFO_COLOR = ConsoleColor.Green;

        //log
        public static string Log
        {
            get;
            private set;
        }
        public static void ConsoleLog(string text)
        {
            Log += text + Environment.NewLine;
            Console.WriteLine(text);
        }
        public static void ConsoleLogInfo(string text)
        {
            Log += text + Environment.NewLine;
            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine(text);
            Console.ForegroundColor = TEXT_COLOR;
        }
        public static void ConsoleLogError(string text)
        {
            Log += text + Environment.NewLine;
            Console.ForegroundColor = ERROR_COLOR;
            Console.WriteLine(text);
            Console.ForegroundColor = TEXT_COLOR;
        }
        public static void ConsoleLogParseInfo(string text)
        {
            Log += text + Environment.NewLine;
            Console.ForegroundColor = MOREINFO_COLOR;
            Console.WriteLine(text);
            Console.ForegroundColor = TEXT_COLOR;
        }
        private static string _createMD5(string input, int length)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                string hash = sb.ToString();

                if (length < 4 || length > 32) length = 16;
                string shortHash = hash.Substring(0, length);
                return shortHash;
            }
        }
    }
}
