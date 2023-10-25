using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompilerCLI
{
    //https://patorjk.com/software/taag/#p=display&f=Alpha&t=DESCRIBE
    //cool - 3D Diagonal, Alpha, Impossible, Isometric1
    //Isometric2, Isometric3, Isometric4, Slant Relief, Small Isometric1
    //minimalist - Bulbhead, Graceful, Modular, Ogre, Slant, Small
    //Small Slant, Standard, Twisted, ANSI Shadow

    internal static class Messages
    {
        //settings
        static bool ONE_BASED_ARG_INDEX = true;
        static ConsoleColor INFO_COLOR = ConsoleColor.DarkGray;
        static ConsoleColor TEXT_COLOR = ConsoleColor.White;
        static ConsoleColor ERROR_COLOR = ConsoleColor.Red;
        static ConsoleColor MOREINFO_COLOR = ConsoleColor.Green;

        static string thisName;
        static Messages()
        {
            thisName = Assembly.GetExecutingAssembly().GetName().Name;
        }


        //themes
        internal static void SetDefaultTheme()
        {
            INFO_COLOR = ConsoleColor.DarkGray;
            TEXT_COLOR = ConsoleColor.White;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.Green;
        }
        internal static void SetVioletTheme()
        {
            INFO_COLOR = ConsoleColor.DarkMagenta;
            TEXT_COLOR = ConsoleColor.White;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkGray;
        }
        internal static void SetCyanTheme()
        {
            INFO_COLOR = ConsoleColor.DarkMagenta;
            TEXT_COLOR = ConsoleColor.Cyan;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkCyan;
        }
        internal static void SetLightBlueTheme()
        {
            INFO_COLOR = ConsoleColor.White;
            TEXT_COLOR = ConsoleColor.Blue;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkCyan;
        }
        internal static void SetDarkBlueTheme()
        {
            INFO_COLOR = ConsoleColor.DarkGray;
            TEXT_COLOR = ConsoleColor.DarkBlue;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkCyan;
        }


        //presets
        internal static void presetConsole()
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        internal static void printLogo3()
        {
            printLogo3(TEXT_COLOR);
        }
        internal static void printLogo3(ConsoleColor logoColor)
        {
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
        internal static void printLogo2()
        {
            printLogo2(TEXT_COLOR);
        }
        internal static void printLogo2(ConsoleColor logoColor)
        {
            ConsoleColor col = Console.ForegroundColor;
            Console.ForegroundColor = logoColor;
            Console.WriteLine();
            Console.WriteLine(@"   /\\\     /\\\     /\\\     /\\\     /\\\     /\\\     /\\\     /\\\  ");
            Console.WriteLine(@"  /  \\\   /  \\\   /  \\\   /  \\\   /  \\\   _\ \\\   /  \\\   /  \\\ ");
            Console.WriteLine(@" / /\ \\\ /  \ \\\ /\ \ \\\ / /\ \\\ /  \ \\\ /\/  \\\ /  \ \\\ /  \ \\\");
            Console.WriteLine(@" \ \/ /// \ \ \/// \ \ \/// \ \\\/// \|   /// \  /\/// \ \  /// \ \ \///");
            Console.WriteLine(@"  \  ///   \ \///   \  ///   \ \\\    | \///   \ \\\    \  ///   \ \/// ");
            Console.WriteLine(@"   \///     \///     \///     \///     \|||     \///     \///     \///  ");
            Console.WriteLine();
            Console.ForegroundColor = col;
        }
        internal static void printLogo3Bicolor()
        {
            printLogo3Bicolor(TEXT_COLOR, INFO_COLOR);
        }
        internal static void printLogo3Bicolor(ConsoleColor colorA, ConsoleColor colorB)
        {
            ConsoleColor col = Console.ForegroundColor;
            Console.WriteLine();

            Console.ForegroundColor = colorA;
            Console.Write(@"   /\\\\     ");//D
            Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\     ");//E
            Console.ForegroundColor = colorA;
            Console.Write(@"/\\\\     ");//S
            Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\     ");//C
            Console.ForegroundColor = colorA;
            Console.Write(@"/\\\\     ");//R
            Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\     ");//I
            Console.ForegroundColor = colorA;
            Console.Write(@"/\\\\     ");//B
            Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\  ");//E
            Console.WriteLine();

            Console.ForegroundColor = colorA;
            Console.Write(@"  /  \\\\   ");//D
            Console.ForegroundColor = colorB;
            Console.Write(@"/  \\\\   ");//E
            Console.ForegroundColor = colorA;
            Console.Write(@"/  \\\\   ");//S
            Console.ForegroundColor = colorB;
            Console.Write(@"/  \\\\   ");//C
            Console.ForegroundColor = colorA;
            Console.Write(@"/  \\\\   ");//R
            Console.ForegroundColor = colorB;
            Console.Write(@"_\ \\\\   ");//I
            Console.ForegroundColor = colorA;
            Console.Write(@"/  \\\\   ");//B
            Console.ForegroundColor = colorB;
            Console.Write(@"/  \\\\ ");//E
            Console.WriteLine();

            Console.ForegroundColor = colorA;
            Console.Write(@" / /\ \\\\ ");//D
            Console.ForegroundColor = colorB;
            Console.Write(@"/  \ \\\\ ");//E
            Console.ForegroundColor = colorA;
            Console.Write(@"/\ \ \\\\ ");//S
            Console.ForegroundColor = colorB;
            Console.Write(@"/ /\ \\\\ ");//C
            Console.ForegroundColor = colorA;
            Console.Write(@"/  \ \\\\ ");//R
            Console.ForegroundColor = colorB;
            Console.Write(@"/\/  \\\\ ");//I
            Console.ForegroundColor = colorA;
            Console.Write(@"/  \ \\\\ ");//B
            Console.ForegroundColor = colorB;
            Console.Write(@"/  \ \\\\");//E
            Console.WriteLine();

            Console.ForegroundColor = colorA;
            Console.Write(@" \ \/ //// ");//D
            Console.ForegroundColor = colorB;
            Console.Write(@"\ \ \//// ");//E
            Console.ForegroundColor = colorA;
            Console.Write(@"\ \ \//// ");//S
            Console.ForegroundColor = colorB;
            Console.Write(@"\ \\\//// ");//C
            Console.ForegroundColor = colorA;
            Console.Write(@"\|   //// ");//R
            Console.ForegroundColor = colorB;
            Console.Write(@"\  /\//// ");//I
            Console.ForegroundColor = colorA;
            Console.Write(@"\ \  //// ");//B
            Console.ForegroundColor = colorB;
            Console.Write(@"\ \ \////");//E
            Console.WriteLine();

            Console.ForegroundColor = colorA;
            Console.Write(@"  \  ////   ");//D
            Console.ForegroundColor = colorB;
            Console.Write(@"\ \////   ");//E
            Console.ForegroundColor = colorA;
            Console.Write(@"\  ////   ");//S
            Console.ForegroundColor = colorB;
            Console.Write(@"\ \\\\    ");//C
            Console.ForegroundColor = colorA;
            Console.Write(@"| \////   ");//R
            Console.ForegroundColor = colorB;
            Console.Write(@"\ \\\\    ");//I
            Console.ForegroundColor = colorA;
            Console.Write(@"\  ////   ");//B
            Console.ForegroundColor = colorB;
            Console.Write(@"\ \//// ");//E
            Console.WriteLine();

            Console.ForegroundColor = colorA;
            Console.Write(@"   \////     ");//D
            Console.ForegroundColor = colorB;
            Console.Write(@"\////     ");//E
            Console.ForegroundColor = colorA;
            Console.Write(@"\////     ");//S
            Console.ForegroundColor = colorB;
            Console.Write(@"\////     ");//C
            Console.ForegroundColor = colorA;
            Console.Write(@"\||||     ");//R
            Console.ForegroundColor = colorB;
            Console.Write(@"\////     ");//I
            Console.ForegroundColor = colorA;
            Console.Write(@"\////     ");//B
            Console.ForegroundColor = colorB;
            Console.Write(@"\////  ");//E
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = col;
        }


        //errors
        internal static void printCmdLine(string[] args)
        {
            string s = "> ";

            if(args.Length > 0)
            {
                if (args[0].Contains(" ")) s = s + "\"" + args[0] + "\"";
                else s = s + args[0];

                if(args.Length > 1)
                {
                    for(int i = 1; i < args.Length - 1; i++)
                    {
                        s = s + " " + args[i];
                    }
                    if (args[args.Length - 1].Contains(" ")) s = s + " \"" + args[args.Length - 1] + "\"";
                    else s = s + " " + args[args.Length - 1];
                }
            }

            ConsoleLogInfo(s);
        }
        internal static void printExtTemplatesSuccess(string path)
        {
            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Templates outputted to \"" + path + "\"");
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.ReadKey();
        }
        internal static void printHelpMessage()
        {
            ConsoleLogInfo("-----------------------------------------------------------------");
            Console.WriteLine("usage: " + thisName + " help | -h");
            ConsoleLogInfo("Display this help message");
            Console.WriteLine();
            ConsoleLogInfo("-----------------------------------------------------------------");
            Console.WriteLine("usage: " + thisName + " ext [ RESULT_PATH ]");
            ConsoleLogInfo("externalize all the templates");
            ConsoleLogInfo("* RESULT_PATH (optionally) - specify path to write the template folders to. Current folder will be used otherwise");
            Console.WriteLine();
            ConsoleLogInfo("-----------------------------------------------------------------");
            Console.WriteLine("usage: " + thisName + " extone TEMPLATE_NAME [ RESULT_PATH ]");
            ConsoleLogInfo("externalize a specific template set");
            ConsoleLogInfo("TEMPLATE_NAME - the template set to be externalized: \"HTML_PARACORD\" or \"JSON_COMMONER\"");
            ConsoleLogInfo("* RESULT_PATH (optionally) - specify path to write the template folders to. Current folder will be used otherwise");
            Console.WriteLine();
            ConsoleLogInfo("-----------------------------------------------------------------");
            Console.WriteLine("usage: " + thisName + " parse-file PARSE_PATH RESULT_PATH [ template=(TEMPLATE_NAME|TEMPLATE_PATH) ]\n[ dsonly[=true|=false] ] [ verbosity=<verb> | log-verbosity=<verb> ] [ onerror=<verb> ] \n[ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]");
            ConsoleLogInfo("template - the name (inbuilt) or path (external) of the template set to use");
            ConsoleLogInfo("PARSE_PATH - the path of the file to parse");
            ConsoleLogInfo("RESULT_PATH - the path of the file to write the result to (existing file or not)");
            ConsoleLogInfo("* dsonly - weather to omit files that are not Describe source files (\".DS\"). (default is true): \"true\", \"false\"");
            ConsoleLogInfo("* verbosity - set the log verbosity of the parser (default is high): \"l\", \"low\", \"m\", \"medium\", \"h\", \"high\"");
            ConsoleLogInfo("* log-verbosity - can be used instead of verbosity");
            ConsoleLogInfo("* onerror - what to do when there is an error in source code. (default is stop): \"stop\", \"ignore\", \"dart-stop\", \"dart-ignore\"");
            ConsoleLogInfo("* artifacts - weather to use artifacts (default is no): \"m\", \"makeonly\", \"t\", \"takeonly\", \"u\", \"use\", \"n\", \"no\"");
            ConsoleLogInfo("** ARTIFACTS_PATH - specify path of directory to store artifacts in");
            ConsoleLogInfo("* LOG_PATH - specify path of directory or file to output logs to");
            Console.WriteLine();
            ConsoleLogInfo("-----------------------------------------------------------------");
            Console.WriteLine("usage: " + thisName + " parse-folder PARSE_PATH RESULT_PATH [ template=(TEMPLATE_NAME|TEMPLATE_PATH) ]\n[ dsonly[=<verb>] ] [ toponly[=true|=false] ] [ verbosity=<verb> | log-verbosity=<verb> ]\n[ onerror=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]");
            ConsoleLogInfo("template - the name (inbuilt) or path (external) of the template set to use");
            ConsoleLogInfo("PARSE_PATH - the path of the file to parse");
            ConsoleLogInfo("RESULT_PATH - the path of the folder to write the result to (existing or not)");
            ConsoleLogInfo("* dsonly - weather to omit files that are not Describe source files (\".DS\"). (default is true): \"true\", \"false\"");
            ConsoleLogInfo("* toponly - weather to parse files in child directories or not. (default is false): \"true\", \"false\"");
            ConsoleLogInfo("* verbosity - set the log verbosity of the parser (default is high): \"l\", \"low\", \"m\", \"medium\", \"h\", \"high\"");
            ConsoleLogInfo("* log-verbosity - can be used instead of verbosity");
            ConsoleLogInfo("* onerror - what to do when there is an error in source code. (default is stop): \"stop\", \"ignore\", \"dart-stop\", \"dart-ignore\"");
            ConsoleLogInfo("* artifacts - weather to use artifacts (default is no): \"m\", \"makeonly\", \"t\", \"takeonly\", \"u\", \"use\", \"n\", \"no\"");
            ConsoleLogInfo("** ARTIFACTS_PATH - specify path of directory to store artifacts in");
            ConsoleLogInfo("* LOG_PATH - specify path of directory or file to output logs to");
            Console.WriteLine();
            ConsoleLogInfo("-----------------------------------------------------------------");
            Console.WriteLine("about: " + DescribeCompiler.DescribeCompiler.COMPILER_NAME);
            ConsoleLogInfo("Describe is a domain specific language used to write and maintain complex data lists");
            ConsoleLogInfo("that are compiled on demand to html, xaml, xml, sql, json and any other language needed.");
            ConsoleLogInfo("Describe is licensed under the GNU Affero General Public License v3.0");
            ConsoleLogInfo("For more information visit https://github.com/viktorchernev/DescribeCompiler");
            ConsoleLogInfo("-----------------------------------------------------------------");
             

            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Press any key to exit.");
            Console.ForegroundColor = TEXT_COLOR;
            Console.ReadKey();
        }
        internal static void printWarning(string message)
        {
            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Warning: " + message);
            Console.WriteLine("Press any key to continue.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.ReadKey();
        }
        internal static void printNoArgumentsError()
        {
            Console.ForegroundColor = ERROR_COLOR;
            Console.WriteLine("No arguments or invalid argument count.");

            Console.ForegroundColor = TEXT_COLOR;
            printHelpMessage();

            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.ReadKey();
        }
        internal static void printArgumentError(string arg, int argIndex)
        {
            Console.ForegroundColor = ERROR_COLOR;
            if (ONE_BASED_ARG_INDEX) argIndex++;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\"");

            Console.ForegroundColor = TEXT_COLOR;
            printHelpMessage();

            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.ReadKey();
        }
        internal static void printArgumentError(string arg, int argIndex, string message)
        {
            Console.ForegroundColor = ERROR_COLOR;
            if (ONE_BASED_ARG_INDEX) argIndex++;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\" - " + message);

            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.ReadKey();
        }
        internal static void printFatalError(string message)
        {
            Console.ForegroundColor = ERROR_COLOR;
            Console.WriteLine("Fatal error: " + message);

            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.ReadKey();
        }


        //log
        internal static void ConsoleLog(string text)
        {
            Console.WriteLine(text);
        }
        internal static void ConsoleLogInfo(string text)
        {
            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine(text);
            Console.ForegroundColor = TEXT_COLOR;
        }
        internal static void ConsoleLogError(string text)
        {
            Console.ForegroundColor = ERROR_COLOR;
            Console.WriteLine(text);
            Console.ForegroundColor = TEXT_COLOR;
        }
        internal static void ConsoleLogParseInfo(string text)
        {
            Console.ForegroundColor = MOREINFO_COLOR;
            Console.WriteLine(text);
            Console.ForegroundColor = TEXT_COLOR;
        }
    }
}