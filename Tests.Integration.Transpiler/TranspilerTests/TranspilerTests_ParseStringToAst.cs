using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Ast;
using DescribeParser.Unfold;
using DescribeParser.Visitors;
using DescribeTranspiler;
using DescribeTranspiler.Translators;
using System.Xml.Linq;


namespace Tests.Integration.Transpiler
{
    internal class TranspilerTests_StringToAst : TranspilerTestsBase
    {
        public static string outputDir = @"C:\Users\Viktor Chernev\Desktop\testing\TranspilerTests\ParseStringToAst";

        internal static void Test_ParseStringToAst(LogVerbosity verbosity)
        {
            string a = verbosity.ToString();
            outputDir = outputDir + "\\" + a + "Verbosity";

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
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                string[] sep = name.Split('.');
                if (sep[4].Contains("live_Radio")) test_ParseStringToAst(verbosity, name, sep[4]);
                else if (sep[4].Contains("TestFilesFor"))
                {
                    if(sep[4].Contains("TestFilesFor06")) test_ParseStringToAst(verbosity, name, sep[4], DescribeVersionNumber.Version06);
                    else if (sep[4].Contains("TestFilesFor07")) test_ParseStringToAst(verbosity, name, sep[4], DescribeVersionNumber.Version07);
                    else if (sep[4].Contains("TestFilesFor08")) test_ParseStringToAst(verbosity, name, sep[4], DescribeVersionNumber.Version08);
                    else if (sep[4].Contains("TestFilesFor09")) test_ParseStringToAst(verbosity, name, sep[4], DescribeVersionNumber.Version09);
                    else if (sep[4].Contains("TestFilesFor10")) test_ParseStringToAst(verbosity, name, sep[4], DescribeVersionNumber.Version10);
                    else if (sep[4].Contains("TestFilesFor11")) test_ParseStringToAst(verbosity, name, sep[4], DescribeVersionNumber.Version11);
                    else test_ParseStringToAst(verbosity, name, sep[4]);
                }
            }
        }
        internal static void Test_ParseStringToAst(LogVerbosity verbosity, string embeddedName, string? folder = null)
        {
            string a = verbosity.ToString();
            outputDir = outputDir + "\\" + a + "Verbosity";

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
            test_ParseStringToAst(verbosity ,embeddedName, folder);
        }
        internal static void test_ParseStringToAst(LogVerbosity verbosity, 
            string embeddedName, string? folder = null, 
            DescribeVersionNumber? langVer = null)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_a.md");
            string resultTemplateB = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_b.md");
            string resultTemplateC = getEmbeddedResource("Tests.Integration.Transpiler.TestResultTemplates.template_unfold_c.md");

            //get source code to test
            string sourceCode = getEmbeddedResource(embeddedName);

            Console.WriteLine("Starting a test on '" + embeddedName + "'");
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
            AstScriptureNode? rootNode;
            bool r = compiler.ParseString(sourceCode, embeddedName, out rootNode);
            if (rootNode == null) r = false;

            //form log file
            string log = compiler.Log;
            string astText = "null"; 
            if (r == true) astText = rootNode!.ToJson();
            string result = resultTemplateA;
            result += sourceCode + resultTemplateB;
            result += log + resultTemplateC.Replace("Produced Unfold", "Produced AST") + Environment.NewLine;
            result += astText;

            //get save name
            string[] sep = embeddedName.Split('.');
            string filename = sep[sep.Length - 2] + ".md";
            if (string.IsNullOrEmpty(folder) == false 
                && string.IsNullOrWhiteSpace(folder) == false)
            {
                outputdir = Path.Combine(outputdir, folder);
                if (Directory.Exists(outputdir) == false) Directory.CreateDirectory(outputdir);
                for (int i = sep.Length - 3; i > 0; i--)
                {
                    if (sep[i] != folder) filename = sep[i] + "." + filename;
                    else break;
                }
            }
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
    }
}
