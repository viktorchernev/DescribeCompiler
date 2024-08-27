using DescribeTranspiler;

namespace Tests.Integration.Transpiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printLogo2();

            //HtmlPageTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.NovaNews.2024-04-15.ds");
            //Console.WriteLine("HtmlPageTranslatorTests done. Press any key to continue.");
            //Console.ReadLine();

            //HtmlBasicTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.NovaNews.2024-04-15.ds");
            //Console.WriteLine("HtmlPageTranslatorTests done. Press any key to continue.");
            //Console.ReadLine();

            //JsonTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.NovaNews.2024-04-15.ds");
            //Console.WriteLine("Tests done. Press any key to exit.");
            //Console.ReadLine();



            //TranspilerTests_StringToUnfold.Test_ParseString(LogVerbosity.Low);
            //TranspilerTests_StringToUnfold.Test_ParseString(LogVerbosity.Medium);
            //TranspilerTests_StringToUnfold.Test_ParseString(LogVerbosity.High);

            //TranspilerTests_StringToAst.Test_ParseStringToAst(LogVerbosity.Low);
            //TranspilerTests_StringToAst.Test_ParseStringToAst(LogVerbosity.Medium);
            //TranspilerTests_StringToAst.Test_ParseStringToAst(LogVerbosity.High);

            //TranspilerTests_FileToUnfold.Test_ParseFile(LogVerbosity.Low, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FileToUnfold.Test_ParseFile(LogVerbosity.Medium, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            TranspilerTests_FileToUnfold.Test_ParseFile(LogVerbosity.High, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");

            Console.WriteLine("Tests done. Press any key to exit.");
            Console.ReadLine();
        }
        public static void printLogo2()
        {
            ConsoleColor logoColor = ConsoleColor.Green;
            ConsoleColor col = Console.ForegroundColor;
            Console.ForegroundColor = logoColor;
            Console.WriteLine();
            Console.WriteLine(@"   /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\  ");
            Console.WriteLine(@"  /  \\\\   /  \\\\   /  \\\\   /  \\\\   /  \\\\   _\ \\\\   /  \\\\   /  \\\\ ");
            Console.WriteLine(@" / /\ \\\\ /  \ \\\\ /\ \ \\\\ / /\ \\\\ /  \ \\\\ /\/  \\\\ /  \ \\\\ /  \ \\\\");
            Console.WriteLine(@" \ \/ //// \ \ \//// \ \ \//// \ \\\//// \|   //// \  /\//// \ \  //// \ \ \////");
            Console.WriteLine(@"  \  ////   \ \////   \  ////   \ \\\\    | \////   \ \\\\    \  ////   \ \//// ");
            Console.WriteLine(@"   \////     \////     \////     \////     \||||     \////     \////     \////  ");
            Console.WriteLine();
            Console.ForegroundColor = col;
        }
    }
}
