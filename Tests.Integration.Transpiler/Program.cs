using DescribeTranspiler;

namespace Tests.Integration.Transpiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HtmlPageTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.NovaNews.2024-04-15.ds");
            //Console.WriteLine("HtmlPageTranslatorTests done. Press any key to continue.");
            //Console.ReadLine();

            //HtmlBasicTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.NovaNews.2024-04-15.ds");
            //Console.WriteLine("HtmlPageTranslatorTests done. Press any key to continue.");
            //Console.ReadLine();

            //JsonTranslatorTests.TestFile("Tests.Integration.Transpiler.TestFiles.NovaNews.2024-04-15.ds");
            //Console.WriteLine("Tests done. Press any key to exit.");
            //Console.ReadLine();

            //TranspilerTests.Test_ParseString(LogVerbosity.Low,
            //"Tests.Integration.Transpiler.TestFiles.live_Radio.NovaNews.2024-04-15.ds", "live_Radio");
            //TranspilerTests.Test_ParseString(LogVerbosity.Low,
            //"Tests.Integration.Transpiler.TestFiles.TestFilesFor06.A_basic3.ds", "TestFilesFor06");
            //TranspilerTests.Test_ParseString(LogVerbosity.Low);
            TranspilerTests.Test_ParseString(LogVerbosity.Medium);
            Console.WriteLine("Tests done. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
