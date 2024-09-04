using DescribeTranspiler;

namespace Tests.Integration.Transpiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printLogo2();

            //TranspilerTests_StringToUnfold.Test_ParseString(LogVerbosity.Low);
            //TranspilerTests_StringToUnfold.Test_ParseString(LogVerbosity.Medium);
            //TranspilerTests_StringToUnfold.Test_ParseString(LogVerbosity.High);

            //TranspilerTests_StringToAst.Test_ParseStringToAst(LogVerbosity.Low);
            //TranspilerTests_StringToAst.Test_ParseStringToAst(LogVerbosity.Medium);
            //TranspilerTests_StringToAst.Test_ParseStringToAst(LogVerbosity.High);

            //TranspilerTests_FileToUnfold.Test_ParseFile(LogVerbosity.Low, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FileToUnfold.Test_ParseFile(LogVerbosity.Medium, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FileToUnfold.Test_ParseFile(LogVerbosity.High, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");

            //TranspilerTests_FileToAst.Test_ParseFile(LogVerbosity.Low, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FileToAst.Test_ParseFile(LogVerbosity.Medium, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FileToAst.Test_ParseFile(LogVerbosity.High, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");

            //TranspilerTests_StringsToUnfold.Test_ParseString_OverloadA(LogVerbosity.Low);
            //TranspilerTests_StringsToUnfold.Test_ParseString_OverloadA(LogVerbosity.Medium);
            //TranspilerTests_StringsToUnfold.Test_ParseString_OverloadA(LogVerbosity.High);

            //TranspilerTests_StringsToUnfold.Test_ParseString_OverloadB(LogVerbosity.Low);
            //TranspilerTests_StringsToUnfold.Test_ParseString_OverloadB(LogVerbosity.Medium);
            //TranspilerTests_StringsToUnfold.Test_ParseString_OverloadB(LogVerbosity.High);

            //TranspilerTests_StringsToUnfolds.Test_ParseString_OverloadA(LogVerbosity.Low);
            //TranspilerTests_StringsToUnfolds.Test_ParseString_OverloadA(LogVerbosity.Medium);
            //TranspilerTests_StringsToUnfolds.Test_ParseString_OverloadA(LogVerbosity.High);

            //TranspilerTests_StringsToUnfolds.Test_ParseString_OverloadB(LogVerbosity.Low);
            //TranspilerTests_StringsToUnfolds.Test_ParseString_OverloadB(LogVerbosity.Medium);
            //TranspilerTests_StringsToUnfolds.Test_ParseString_OverloadB(LogVerbosity.High);

            //TranspilerTests_StringsToAsts.Test_ParseString_OverloadA(LogVerbosity.Low);
            //TranspilerTests_StringsToAsts.Test_ParseString_OverloadA(LogVerbosity.Medium);
            //TranspilerTests_StringsToAsts.Test_ParseString_OverloadA(LogVerbosity.High);

            //TranspilerTests_StringsToAsts.Test_ParseString_OverloadB(LogVerbosity.Low);
            //TranspilerTests_StringsToAsts.Test_ParseString_OverloadB(LogVerbosity.Medium);
            //TranspilerTests_StringsToAsts.Test_ParseString_OverloadB(LogVerbosity.High);

            //TranspilerTests_FolderToUnfold.Test_ParseFolder(LogVerbosity.Low, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FolderToUnfold.Test_ParseFolder(LogVerbosity.Medium, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FolderToUnfold.Test_ParseFolder(LogVerbosity.High, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");

            //TranspilerTests_FolderToUnfolds.Test_ParseFolder(LogVerbosity.Low, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FolderToUnfolds.Test_ParseFolder(LogVerbosity.Medium, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FolderToUnfolds.Test_ParseFolder(LogVerbosity.High, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");

            //TranspilerTests_FolderToAsts.Test_ParseFolder(LogVerbosity.Low, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FolderToAsts.Test_ParseFolder(LogVerbosity.Medium, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");
            //TranspilerTests_FolderToAsts.Test_ParseFolder(LogVerbosity.High, @"C:\Users\Viktor Chernev\Desktop\testing\TestFiles");

            //HtmlPageTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.live_Radio.NovaNews.2024-04-15.ds");
            //HtmlBasicTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.live_Radio.NovaNews.2024-04-15.ds");
            //XmlBasicTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.live_Radio.NovaNews.2024-04-15.ds");
            JsonBasicTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.live_Radio.NovaNews.2024-04-15.ds");
            JsonListiaryTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.live_Radio.NovaNews.2024-04-15.ds");

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
