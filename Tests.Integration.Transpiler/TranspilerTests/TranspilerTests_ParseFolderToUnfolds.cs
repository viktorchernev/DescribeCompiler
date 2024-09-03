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
    internal class TranspilerTests_FolderToUnfolds : TranspilerTestsBase
    {
        public static string outputDir = @"C:\Users\Viktor Chernev\Desktop\testing\TranspilerTests\ParseFolderToUnfolds";

        internal static void Test_ParseFolder(LogVerbosity verbosity, string folderPath)
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

            //get test folders
            DirectoryInfo live_Radio = new DirectoryInfo(Path.Combine(folderPath, "live_Radio"));
            DirectoryInfo TestFilesFor06 = new DirectoryInfo(Path.Combine(folderPath, "TestFilesFor06"));
            DirectoryInfo TestFilesFor07 = new DirectoryInfo(Path.Combine(folderPath, "TestFilesFor07"));
            DirectoryInfo TestFilesFor08 = new DirectoryInfo(Path.Combine(folderPath, "TestFilesFor08"));
            DirectoryInfo TestFilesFor09 = new DirectoryInfo(Path.Combine(folderPath, "TestFilesFor09"));
            DirectoryInfo TestFilesFor10 = new DirectoryInfo(Path.Combine(folderPath, "TestFilesFor10"));
            DirectoryInfo TestFilesFor11 = new DirectoryInfo(Path.Combine(folderPath, "TestFilesFor11"));

            // Parse
            test_ParseFolder(verbosity, live_Radio, "live_Radio");
            test_ParseFolder(verbosity, TestFilesFor06, "TestFilesFor06", DescribeVersionNumber.Version06);
            test_ParseFolder(verbosity, TestFilesFor07, "TestFilesFor07", DescribeVersionNumber.Version07);
            test_ParseFolder(verbosity, TestFilesFor08, "TestFilesFor08", DescribeVersionNumber.Version08);
            test_ParseFolder(verbosity, TestFilesFor09, "TestFilesFor09", DescribeVersionNumber.Version09);
            test_ParseFolder(verbosity, TestFilesFor10, "TestFilesFor10", DescribeVersionNumber.Version10);
            test_ParseFolder(verbosity, TestFilesFor11, "TestFilesFor11", DescribeVersionNumber.Version11);
        }
        internal static void Test_ParseFolder(LogVerbosity verbosity, string folderPath, string folder)
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

            //get test folders
            DirectoryInfo dirInfo = new DirectoryInfo(Path.Combine(folderPath, folder));

            // Parse
            test_ParseFolder(verbosity, dirInfo, folder);
        }

        internal static void test_ParseFolder(LogVerbosity verbosity,
            DirectoryInfo dir, string folder, 
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
            bool r = compiler.ParseFolder(dir, out ul);

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
            string scrl = dir.FullName;
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
