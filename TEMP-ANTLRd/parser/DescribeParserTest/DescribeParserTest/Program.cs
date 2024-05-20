using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using System.Reflection;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DescribeParserTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestFiles_Describe06();
            //TestFile_Describe06("DescribeParserTest.TestFiles._06.D_double_characters2.ds");
        }


        static void TestLexer()
        {
            string filename = @"C:\Users\Viktor Chernev\Desktop\ANTLRd\testing\testfile - basic 1.ds";
            string text = File.ReadAllText(filename);
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);

            //test lexer
            tokenstream.Fill();
            foreach (var token in tokenstream.GetTokens())
            {
                int tokenType = token.Type;
                string tokenText = token.Text;
                Console.WriteLine("T(" + GetTokenType(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "')");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
            return;
        }
        static void TestParser()
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get source code to test
            string text = getEmbeddedResource("DescribeParserTest.TestFiles._06.A_basic1.ds");

            //construct parser
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);
            Describe06Parser parser = new Describe06Parser(tokenstream);

            //parse
            Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
            LogVisitor06 visitor = new LogVisitor06();
            visitor.Visit(scriptureContext);
            string tree = visitor.Log;

            //IDK really why this is
            parser.BuildParseTree = true;
            ParseInfo pinfo = parser.ParseInfo;

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }


        static void TestFiles_Describe06()
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = @"C:\Users\Viktor Chernev\Desktop\ANTLRd\testing\IntegrationTestingResults\v06";
            string resultTemplateA = getEmbeddedResource(
                "DescribeParserTest.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParserTest.TestFiles.resultTemplates.template_basic_b.md");

            //delete all ".md" files in the directory
            string[] files = Directory.GetFiles(outputdir, "*.md");
            foreach (string file in files) File.Delete(file);

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name.StartsWith("DescribeParserTest.TestFiles._06") == false) continue;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Starting a parse operation on '" + name + "'" + Environment.NewLine);
                
                //get source code to test
                string text = getEmbeddedResource(name);

                //construct parser
                AntlrInputStream inputstream = new AntlrInputStream(text);
                Describe06Lexer lexer = new Describe06Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);
                Describe06Parser parser = new Describe06Parser(tokenstream);

                //parse
                Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
                LogVisitor06 visitor = new LogVisitor06();
                visitor.Visit(scriptureContext);
                string tree = visitor.Log;

                //IDK really why this is
                parser.BuildParseTree = true;
                ParseInfo pinfo = parser.ParseInfo;

                //get text
                string result = resultTemplateA;
                result += text + resultTemplateB;
                result += Environment.NewLine + tree;

                //get save name
                string[] sep = name.Split('.');
                string filename = sep[sep.Length - 2] + ".md";
                if(visitor.LastError != null) 
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
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
            }

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Tests concluded. Press any key to exit.");
            Console.ReadLine();
        }
        static void TestFile_Describe06(string embeddedName)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = @"C:\Users\Viktor Chernev\Desktop\ANTLRd\testing\IntegrationTestingResults\v06";
            string resultTemplateA = getEmbeddedResource(
                "DescribeParserTest.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParserTest.TestFiles.resultTemplates.template_basic_b.md");

            //get source code to test
            string text = getEmbeddedResource(embeddedName);

            //construct parser
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);

            //test lexer
            tokenstream.Fill();
            foreach (var token in tokenstream.GetTokens())
            {
                int tokenType = token.Type;
                string tokenText = token.Text;
                Console.WriteLine("T(" + GetTokenType(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "')");
            }
            Console.WriteLine();

            //construct parser
            inputstream = new AntlrInputStream(text);
            lexer = new Describe06Lexer(inputstream);
            tokenstream = new CommonTokenStream(lexer);
            Describe06Parser parser = new Describe06Parser(tokenstream);

            //parse
            Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
            LogVisitor06 visitor = new LogVisitor06();
            visitor.Visit(scriptureContext);
            string tree = visitor.Log;

            //IDK really why this is
            parser.BuildParseTree = true;
            ParseInfo pinfo = parser.ParseInfo;

            //get text
            string result = resultTemplateA;
            result += text + resultTemplateB;
            result += Environment.NewLine + tree;

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



        static string GetTokenType(int tokenType) //an alternative (possibly slower)
        {
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        static string ReplaceWhitespaceE(string text)
            {
                return text.Replace(Environment.NewLine, "\\n")
                    .Replace("\r", "\\r")
                    .Replace("\t", "\\t");
            }
        static string ReplaceWhitespaceS(string text)
            {
                return text.Replace(Environment.NewLine, "↓")
                    .Replace("\r", "←")
                    .Replace("\t", "→");
            }
        static string getEmbeddedResource(string resourceName)
        {
            string text = "";
            using (Stream stream = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException("Resource not found.");
                }
                using (StreamReader reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }
            }
            return text;
        }
        static string[] getEmbeddedResoucesNames()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resourceNames = assembly.GetManifestResourceNames();
            return resourceNames;
        }
    }
}
