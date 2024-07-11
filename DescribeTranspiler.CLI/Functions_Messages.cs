using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler.Cli
{
    //https://patorjk.com/software/taag/#p=display&f=Alpha&t=DESCRIBE
    //cool - 3D Diagonal, Alpha, Impossible, Isometric1
    //Isometric2, Isometric3, Isometric4, Slant Relief, Small Isometric1
    //minimalist - Bulbhead, Graceful, Modular, Ogre, Slant, Small
    //Small Slant, Standard, Twisted, ANSI Shadow

    public enum OS
    {
        FREEBSD,
        LINUX,
        OSX,
        WINDOWS
    }

    public static class Messages
    {
        //settings
        public static OS Platform;
        public static bool ONE_BASED_ARG_INDEX = true;
        public static ConsoleColor INFO_COLOR = ConsoleColor.DarkGray;
        public static ConsoleColor TEXT_COLOR = ConsoleColor.White;
        public static ConsoleColor ERROR_COLOR = ConsoleColor.Red;
        public static ConsoleColor MOREINFO_COLOR = ConsoleColor.Green;
        static ConsoleColor beforeForeground;
        static ConsoleColor beforeBackground;

        static string thisName;
        static Messages()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) Platform = OS.WINDOWS;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) Platform = OS.LINUX;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) Platform = OS.OSX;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)) Platform = OS.FREEBSD;

            thisName = Assembly.GetExecutingAssembly().GetName().Name;
            beforeForeground = Console.ForegroundColor;
            beforeBackground = Console.BackgroundColor;
        }


        //themes
        public static void SetDefaultTheme()
        {
            INFO_COLOR = ConsoleColor.DarkGray;
            TEXT_COLOR = ConsoleColor.White;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.Green;
        }
        public static void SetVioletTheme()
        {
            INFO_COLOR = ConsoleColor.DarkMagenta;
            TEXT_COLOR = ConsoleColor.White;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkGray;
        }
        public static void SetCyanTheme()
        {
            INFO_COLOR = ConsoleColor.DarkMagenta;
            TEXT_COLOR = ConsoleColor.Cyan;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkCyan;
        }
        public static void SetLightBlueTheme()
        {
            INFO_COLOR = ConsoleColor.White;
            TEXT_COLOR = ConsoleColor.Blue;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkCyan;
        }
        public static void SetDarkBlueTheme()
        {
            INFO_COLOR = ConsoleColor.DarkGray;
            TEXT_COLOR = ConsoleColor.DarkBlue;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkCyan;
        }
        public static void RevertConsoleColors()
        {
            Console.ForegroundColor = beforeForeground;
            Console.BackgroundColor = beforeBackground;
        }


        //presets
        public static void presetConsole()
        {

            if (Platform == OS.WINDOWS)
            {
                Console.BufferHeight = Int16.MaxValue - 1;
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public static void printLogo3()
        {
            printLogo3(TEXT_COLOR);
        }
        public static void printLogo3(ConsoleColor logoColor)
        {
            Log += @"   /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\  " + Environment.NewLine;
            Log += @"  /  \\\\   /  \\\\   /  \\\\   /  \\\\   /  \\\\   _\ \\\\   /  \\\\   /  \\\\ " + Environment.NewLine;
            Log += @" / /\ \\\\ /  \ \\\\ /\ \ \\\\ / /\ \\\\ /  \ \\\\ /\/  \\\\ /  \ \\\\ /  \ \\\\" + Environment.NewLine;
            Log += @" \ \/ //// \ \ \//// \ \ \//// \ \\\//// \|   //// \  /\//// \ \  //// \ \ \////" + Environment.NewLine;
            Log += @"  \  ////   \ \////   \  ////   \ \\\\    | \////   \ \\\\    \  ////   \ \//// " + Environment.NewLine;
            Log += @"   \////     \////     \////     \////     \||||     \////     \////     \////  " + Environment.NewLine;
            Log += Environment.NewLine;

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
        public static void printLogo2()
        {
            printLogo2(TEXT_COLOR);
        }
        public static void printLogo2(ConsoleColor logoColor)
        {
            Log += @"   /\\\     /\\\     /\\\     /\\\     /\\\     /\\\     /\\\     /\\\  " + Environment.NewLine;
            Log += @"  /  \\\   /  \\\   /  \\\   /  \\\   /  \\\   _\ \\\   /  \\\   /  \\\ " + Environment.NewLine;
            Log += @" / /\ \\\ /  \ \\\ /\ \ \\\ / /\ \\\ /  \ \\\ /\/  \\\ /  \ \\\ /  \ \\\" + Environment.NewLine;
            Log += @" \ \/ /// \ \ \/// \ \ \/// \ \\\/// \|   /// \  /\/// \ \  /// \ \ \///" + Environment.NewLine;
            Log += @"  \  ///   \ \///   \  ///   \ \\\    | \///   \ \\\    \  ///   \ \/// " + Environment.NewLine;
            Log += @"   \///     \///     \///     \///     \|||     \///     \///     \///  " + Environment.NewLine;
            Log += Environment.NewLine;

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
        public static void printLogo3Bicolor()
        {
            printLogo3Bicolor(TEXT_COLOR, INFO_COLOR);
        }
        public static void printLogo3Bicolor(ConsoleColor colorA, ConsoleColor colorB)
        {
            Log += @"   /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\  " + Environment.NewLine;
            Log += @"  /  \\\\   /  \\\\   /  \\\\   /  \\\\   /  \\\\   _\ \\\\   /  \\\\   /  \\\\ " + Environment.NewLine;
            Log += @" / /\ \\\\ /  \ \\\\ /\ \ \\\\ / /\ \\\\ /  \ \\\\ /\/  \\\\ /  \ \\\\ /  \ \\\\" + Environment.NewLine;
            Log += @" \ \/ //// \ \ \//// \ \ \//// \ \\\//// \|   //// \  /\//// \ \  //// \ \ \////" + Environment.NewLine;
            Log += @"  \  ////   \ \////   \  ////   \ \\\\    | \////   \ \\\\    \  ////   \ \//// " + Environment.NewLine;
            Log += @"   \////     \////     \////     \////     \||||     \////     \////     \////  " + Environment.NewLine;
            Log += Environment.NewLine;

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
        public static void printCmdLine(string[] args)
        {
            string s = "> ";

            if (args.Length > 0)
            {
                if (args[0].Contains(" ")) s = s + "\"" + args[0] + "\"";
                else s = s + args[0];

                if (args.Length > 1)
                {
                    for (int i = 1; i < args.Length - 1; i++)
                    {
                        s = s + " " + args[i];
                    }
                    if (args[args.Length - 1].Contains(" ")) s = s + " \"" + args[args.Length - 1] + "\"";
                    else s = s + " " + args[args.Length - 1];
                }
            }

            ConsoleLogInfo(s);
        }
        public static void printCompilationSuccess()
        {
            //add to log
            Log += "Task completed successfully. Press any key to exit." + Environment.NewLine;

            //add to console
            Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Task completed successfully. Press any key to exit.");
            Console.ForegroundColor = TEXT_COLOR;
            Console.Read();
        }
        public static void printHelpMessage()
        {
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " help | -h");
            ConsoleLogInfo("Display this help message");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " parse-file PARSE_PATH RESULT_PATH [ translator=(TARGET_LANGUAGE|TRANSLATOR_NAME) ]\n[ verbosity=<verb> | log-verbosity=<verb> ]\n[ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]");
            ConsoleLogInfo("TARGET_LANGUAGE - the desired output language");
            ConsoleLogInfo("TRANSLATOR_NAME - the name of the translator to be used");
            ConsoleLogInfo("PARSE_PATH - the path of the file to parse");
            ConsoleLogInfo("RESULT_PATH - the path of the file to write the result to (existing file or not)");
            ConsoleLogInfo("* verbosity - set the log verbosity of the parser (default is high): \"l\", \"low\", \"m\", \"medium\", \"h\", \"high\"");
            ConsoleLogInfo("* log-verbosity - can be used instead of verbosity");
            ConsoleLogInfo("* artifacts - whether to use artifacts (default is no): \"m\", \"makeonly\", \"t\", \"takeonly\", \"u\", \"use\", \"n\", \"no\"");
            ConsoleLogInfo("** ARTIFACTS_PATH - specify path of directory to store artifacts in");
            ConsoleLogInfo("* LOG_PATH - specify path of directory or file to output logs to");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " parse-folder PARSE_PATH RESULT_PATH [ translator=(TARGET_LANGUAGE|TRANSLATOR_NAME) ]\n[ dsonly[=<verb>] ] [ toponly[=true|=false] ] [ verbosity=<verb> | log-verbosity=<verb> ]\n[ onerror=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]");
            ConsoleLogInfo("TARGET_LANGUAGE - the desired output language");
            ConsoleLogInfo("TRANSLATOR_NAME - the name of the translator to be used");
            ConsoleLogInfo("PARSE_PATH - the path of the file to parse");
            ConsoleLogInfo("RESULT_PATH - the path of the folder to write the result to (existing or not)");
            ConsoleLogInfo("* dsonly - whether to omit files that are not Describe source files (\".DS\"). (default is true): \"true\", \"false\"");
            ConsoleLogInfo("* toponly - whether to parse files in child directories or not. (default is false): \"true\", \"false\"");
            ConsoleLogInfo("* verbosity - set the log verbosity of the parser (default is high): \"l\", \"low\", \"m\", \"medium\", \"h\", \"high\"");
            ConsoleLogInfo("* log-verbosity - can be used instead of verbosity");
            ConsoleLogInfo("* onerror - what to do when there is an error in source code. (default is stop): \"stop\", \"ignore\"");
            ConsoleLogInfo("* artifacts - whether to use artifacts (default is no): \"m\", \"makeonly\", \"t\", \"takeonly\", \"u\", \"use\", \"n\", \"no\"");
            ConsoleLogInfo("** ARTIFACTS_PATH - specify path of directory to store artifacts in");
            ConsoleLogInfo("* LOG_PATH - specify path of directory or file to output logs to");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("about: " + DescribeTranspiler.DescribeCompiler.COMPILER_NAME);
            ConsoleLogInfo("Describe is a domain specific language used to write and maintain complex data lists");
            ConsoleLogInfo("that are compiled on demand to html, xaml, xml, sql, json and any other language needed.");
            ConsoleLogInfo("Describe is licensed under the GNU Affero General Public License v3.0");
            ConsoleLogInfo("For more information visit https://github.com/viktorchernev/DescribeCompiler");
            ConsoleLogInfo("-----------------------------------------------------------------");


            Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");
            Console.ForegroundColor = TEXT_COLOR;
            Console.Read();
        }
        public static void printWarning(string message)
        {
            Console.ForegroundColor = INFO_COLOR;
            Log += "Warning: " + message + Environment.NewLine;
            Log += "Press any key to continue." + Environment.NewLine;
            Console.WriteLine("Warning: " + message);
            Console.WriteLine("Press any key to continue.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.Read();
        }
        public static void printNoArgumentsError()
        {
            Console.ForegroundColor = ERROR_COLOR;
            Log += "No arguments or invalid argument count." + Environment.NewLine;
            Console.WriteLine("No arguments or invalid argument count.");

            Console.ForegroundColor = TEXT_COLOR;
            printHelpMessage();

            Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.Read();
        }
        public static void printArgumentError(string arg, int argIndex)
        {
            Console.ForegroundColor = ERROR_COLOR;
            if (ONE_BASED_ARG_INDEX) argIndex++;
            Log += "Invalid argument " + argIndex.ToString() + " - \"" + arg + "\"" + Environment.NewLine;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\"");

            Console.ForegroundColor = TEXT_COLOR;
            printHelpMessage();

            Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.Read();
        }
        public static void printArgumentError(string arg, int argIndex, string message)
        {
            Console.ForegroundColor = ERROR_COLOR;
            if (ONE_BASED_ARG_INDEX) argIndex++;
            Log += "Invalid argument " + argIndex.ToString() +
                " - \"" + arg + "\" - " + message + Environment.NewLine;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\" - " + message);

            Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.Read();
        }
        public static void printFatalError(string message)
        {
            Console.ForegroundColor = ERROR_COLOR;
            Log += "Fatal error: " + message + Environment.NewLine;
            Console.WriteLine("Fatal error: " + message);

            Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = TEXT_COLOR;
            Console.Read();
        }


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
