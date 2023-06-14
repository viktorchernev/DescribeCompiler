using System;
using System.Collections.Generic;
using System.Linq;
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
        internal static void setConsole()
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
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
        internal static void printSpitSuccess()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Templates outputted!");
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        internal static void printHelpMessage(string exeName)
        {
            Console.WriteLine("usage: " + exeName + " help");
            Console.WriteLine("usage: " + exeName + " INPUT_PATH [ verbosity=<verb> ] OUTPUT_PATH");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("verbosity - set the log verbosity of the parser:");
            Console.WriteLine();
            Console.WriteLine("    l, low - low verbosity");
            Console.WriteLine("    m, medium - medium verbosity");
            Console.WriteLine("    h, high - high verbosity");
            Console.WriteLine();
            Console.WriteLine("help - display this message");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        internal static void printNoArgumentsError(string exeName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid argument count.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("usage: " + exeName + " help");
            Console.WriteLine("usage: " + exeName + " INPUT_PATH [ verbosity=<verb> ] OUTPUT_PATH");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        internal static void printArgumentError(string exeName, string arg, int argIndex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\"");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("usage: " + exeName + " help");
            Console.WriteLine("usage: " + exeName + " INPUT_PATH [ verbosity=<verb> ] OUTPUT_PATH");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        internal static void printArgumentError(string exeName, string arg, int argIndex, string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\" " + message);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        internal static void printFatalError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fatal error: " + message);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press any key to exit.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
