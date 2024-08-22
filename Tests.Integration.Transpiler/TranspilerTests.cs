using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Unfold;
using DescribeParser.Visitors;
using DescribeTranspiler;
using DescribeTranspiler.Translators;


namespace Tests.Integration.Transpiler
{
    internal class TranspilerTests : TranspilerTestsBase
    {
        public static string outputDir = @"C:\Users\Viktor Chernev\Desktop\testing\TranspilerTests\ParseStringToUnfold";

        internal static void Test_ParseString()
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //delete all ".md" files in the directory
            string[] files = Directory.GetFiles(outputDir, "*.md");
            foreach (string file in files) File.Delete(file);

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                string[] sep = name.Split('.');
                if (sep[4].Contains("live_Radio")) Test_ParseString(name, sep[4]);
                else if (sep[4].Contains("TestFilesFor")) Test_ParseString(name, sep[4]);
            }
        }
        internal static void Test_ParseString(string embeddedName, string folder = null)
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
            DescribeCompiler compiler = new DescribeCompiler(
                LogVerbosity.Low, ConsoleLog, ConsoleLogError, 
                ConsoleLogInfo, ConsoleLogParseInfo);

            //compile
            DescribeUnfold unfold = new DescribeUnfold();
            bool r = compiler.ParseString(sourceCode, embeddedName, ref unfold);

            //form log file
            string log = compiler.Log;
            string unfoldText = unfold.ToString();
            string result = resultTemplateA;
            result += sourceCode + resultTemplateB;
            result += log + resultTemplateC + Environment.NewLine;
            result += unfoldText;

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
