using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DescribeParserTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestParser();
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
            string resourceName = "DescribeParserTest.TestFiles._06.A_basic1.ds";
            string text = "";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
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



        static string GetTokenType(int type)
            {
                switch(type)
                {
                    case 1: return "LINE_COMMENT";
                    case 2: return "BLOCK_COMMENT";
                    case 3: return "NEWLINE";
                    case 4: return "PRODUCER";
                    case 5: return "SEPARATOR";
                    case 6: return "TERMINATOR";
                    case 7: return "ESCAPE_ESCAPE";
                    case 8: return "ESCAPE_PRODUCER";
                    case 9: return "ESCAPE_SEPARATOR";
                    case 10: return "ESCAPE_TERMINATOR";
                    case 11: return "ESCAPE_LCOMMENT";
                    case 12: return "ESCAPE_BCOMMENT";
                    case 13: return "DATA";
                    case -1: return "EOF";
                    default: return type.ToString() + " is unknown";
                }
            }
        static string GetTokenType2(int tokenType) //an alternative (possibly slower)
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
    }
}
