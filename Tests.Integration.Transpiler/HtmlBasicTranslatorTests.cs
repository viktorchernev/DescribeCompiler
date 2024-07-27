using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Unfold;
using DescribeParser.Visitors;
using DescribeTranspiler;
using DescribeTranspiler.Translators;


namespace Tests.Integration.Transpiler
{
    internal class HtmlBasicTranslatorTests : TranspilerTestsBase
    {
        public static string outputDir = @"C:\Users\Viktor Chernev\Desktop\testing\HtmlBasicTranslatorTests";

        internal static void TestFile(string embeddedName)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "Tests.Integration.Transpiler.TestResultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "Tests.Integration.Transpiler.TestResultTemplates.template_basic_b.md");

            //get source code to test
            string text = getEmbeddedResource(embeddedName);

            Console.WriteLine("Starting a parse operation on '" + embeddedName + "'" + Environment.NewLine);
            Console.WriteLine("-------------------------------------------------");

            //construct compiler
            DescribeCompiler compiler = new DescribeCompiler(
                LogVerbosity.Low, ConsoleLog, ConsoleLogError, 
                ConsoleLogInfo, ConsoleLogParseInfo);

            //construct translator
            HtmlBasicTranslator translator = new HtmlBasicTranslator();
            translator.LogText = ConsoleLog;
            translator.LogError = ConsoleLogError;
            translator.LogInfo = ConsoleLogInfo;

            //compile
            DescribeUnfold unfold = new DescribeUnfold();
            bool r = compiler.ParseString(text, embeddedName, unfold);

            //translate
            string translated = translator.TranslateUnfold(unfold);
            string result = resultTemplateA;
            result += text + resultTemplateB;
            result += Environment.NewLine + Environment.NewLine + translated;

            //get save name
            string[] sep = embeddedName.Split('.');
            string filename = sep[sep.Length - 2] + ".md";
            string htmlname = sep[sep.Length - 2] + ".html";
            if (translated == null) filename = "~" + filename;
            filename = Path.Combine(outputdir, filename);
            htmlname = Path.Combine(outputdir, htmlname);
            File.WriteAllText(filename, result);
            Console.WriteLine("-------------------------------------------------");
            if (translated != null)
            {
                File.WriteAllText(htmlname, translated);
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
