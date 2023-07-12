using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFill
{
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
