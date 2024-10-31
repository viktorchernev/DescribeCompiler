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
        public static bool MANUAL_MODE = true;
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
            Log = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) Platform = OS.WINDOWS;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) Platform = OS.LINUX;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) Platform = OS.OSX;
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)) Platform = OS.FREEBSD;

            thisName = Assembly.GetExecutingAssembly().GetName().Name!;
            if (MANUAL_MODE) beforeForeground = Console.ForegroundColor;
            if (MANUAL_MODE) beforeBackground = Console.BackgroundColor;
        }


        //themes chatGPT
        public static void SetGreenTheme()
        {
            INFO_COLOR = ConsoleColor.Green;
            TEXT_COLOR = ConsoleColor.Yellow;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.DarkGray;
        }
        public static void SetPastelTheme()
        {
            INFO_COLOR = ConsoleColor.DarkCyan;
            TEXT_COLOR = ConsoleColor.Magenta;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.Cyan;
        }
        public static void SetEarthTheme()
        {
            INFO_COLOR = ConsoleColor.DarkYellow;
            TEXT_COLOR = ConsoleColor.DarkGreen;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.Gray;
        }
        public static void SetHighContrastTheme()
        {
            INFO_COLOR = ConsoleColor.White;
            TEXT_COLOR = ConsoleColor.Yellow;
            ERROR_COLOR = ConsoleColor.Red;
            MOREINFO_COLOR = ConsoleColor.Green;
        }

        //themes mine
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
            if (MANUAL_MODE) Console.ForegroundColor = beforeForeground;
            if (MANUAL_MODE) Console.BackgroundColor = beforeBackground;
        }


        //presets
        public static void presetConsole()
        {
            if (MANUAL_MODE && Platform == OS.WINDOWS)
            {
                Console.BufferHeight = Int16.MaxValue - 1;
            }
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

            ConsoleColor? col = null;
            if (MANUAL_MODE)  col = Console.ForegroundColor;
            if (MANUAL_MODE) Console.ForegroundColor = logoColor;
            Console.WriteLine();
            Console.WriteLine(@"   /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\     /\\\\  ");
            Console.WriteLine(@"  /  \\\\   /  \\\\   /  \\\\   /  \\\\   /  \\\\   _\ \\\\   /  \\\\   /  \\\\ ");
            Console.WriteLine(@" / /\ \\\\ /  \ \\\\ /\ \ \\\\ / /\ \\\\ /  \ \\\\ /\/  \\\\ /  \ \\\\ /  \ \\\\");
            Console.WriteLine(@" \ \/ //// \ \ \//// \ \ \//// \ \\\//// \|   //// \  /\//// \ \  //// \ \ \////");
            Console.WriteLine(@"  \  ////   \ \////   \  ////   \ \\\\    | \////   \ \\\\    \  ////   \ \//// ");
            Console.WriteLine(@"   \////     \////     \////     \////     \||||     \////     \////     \////  ");
            Console.WriteLine();
            if (MANUAL_MODE) Console.ForegroundColor = col!.Value;
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

            ConsoleColor? col = null;
            if (MANUAL_MODE) col = Console.ForegroundColor;
            if (MANUAL_MODE) Console.ForegroundColor = logoColor;
            Console.WriteLine();
            Console.WriteLine(@"   /\\\     /\\\     /\\\     /\\\     /\\\     /\\\     /\\\     /\\\  ");
            Console.WriteLine(@"  /  \\\   /  \\\   /  \\\   /  \\\   /  \\\   _\ \\\   /  \\\   /  \\\ ");
            Console.WriteLine(@" / /\ \\\ /  \ \\\ /\ \ \\\ / /\ \\\ /  \ \\\ /\/  \\\ /  \ \\\ /  \ \\\");
            Console.WriteLine(@" \ \/ /// \ \ \/// \ \ \/// \ \\\/// \|   /// \  /\/// \ \  /// \ \ \///");
            Console.WriteLine(@"  \  ///   \ \///   \  ///   \ \\\    | \///   \ \\\    \  ///   \ \/// ");
            Console.WriteLine(@"   \///     \///     \///     \///     \|||     \///     \///     \///  ");
            Console.WriteLine();
            if (MANUAL_MODE) Console.ForegroundColor = col!.Value;
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

            ConsoleColor? col = null;
            if (MANUAL_MODE) col = Console.ForegroundColor;
            Console.WriteLine();

            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"   /\\\\     ");//D
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\     ");//E
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/\\\\     ");//S
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\     ");//C
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/\\\\     ");//R
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\     ");//I
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/\\\\     ");//B
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/\\\\  ");//E
            Console.WriteLine();

            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"  /  \\\\   ");//D
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/  \\\\   ");//E
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/  \\\\   ");//S
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/  \\\\   ");//C
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/  \\\\   ");//R
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"_\ \\\\   ");//I
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/  \\\\   ");//B
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/  \\\\ ");//E
            Console.WriteLine();

            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@" / /\ \\\\ ");//D
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/  \ \\\\ ");//E
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/\ \ \\\\ ");//S
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/ /\ \\\\ ");//C
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/  \ \\\\ ");//R
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/\/  \\\\ ");//I
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"/  \ \\\\ ");//B
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"/  \ \\\\");//E
            Console.WriteLine();

            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@" \ \/ //// ");//D
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\ \ \//// ");//E
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\ \ \//// ");//S
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\ \\\//// ");//C
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\|   //// ");//R
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\  /\//// ");//I
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\ \  //// ");//B
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\ \ \////");//E
            Console.WriteLine();

            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"  \  ////   ");//D
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\ \////   ");//E
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\  ////   ");//S
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\ \\\\    ");//C
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"| \////   ");//R
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\ \\\\    ");//I
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\  ////   ");//B
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\ \//// ");//E
            Console.WriteLine();

            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"   \////     ");//D
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\////     ");//E
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\////     ");//S
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\////     ");//C
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\||||     ");//R
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\////     ");//I
            if (MANUAL_MODE) Console.ForegroundColor = colorA;
            Console.Write(@"\////     ");//B
            if (MANUAL_MODE) Console.ForegroundColor = colorB;
            Console.Write(@"\////  ");//E
            Console.WriteLine();

            Console.WriteLine();
            if (MANUAL_MODE) Console.ForegroundColor = col!.Value;
        }


        //errors
        public static void printCmdLine(string[] args)
        {
            string s = "> ";

            if (args.Length > 0)
            {
                s = s + args[0];
                if (args.Length == 1)
                {
                    ConsoleLogInfo(s); 
                    return;
                }

                s = s + " \"" + args[1] + "\"";
                if (args.Length == 2)
                {
                    ConsoleLogInfo(s);
                    return;
                }

                s = s + " \"" + args[2] + "\"";

                for (int i = 3; i < args.Length; i++)
                {
                    if (args[i].StartsWith("password="))
                    {
                        s = s + " password=\"" + args[i].Substring("password=".Length) + "\"";
                    }
                    else if (args[i].StartsWith("input-password="))
                    {
                        s = s + " input-password=\"" + args[i].Substring("input-password=".Length) + "\"";
                    }
                    else if (args[i].StartsWith("output-password="))
                    {
                        s = s + " output-password=\"" + args[i].Substring("output-password=".Length) + "\"";
                    }
                    else if (args[i].StartsWith("log-password="))
                    {
                        s = s + " log-password=\"" + args[i].Substring("log-password=".Length) + "\"";
                    }
                    else if (args[i].StartsWith("log-file="))
                    {
                        s = s + " log-file=\"" + args[i].Substring("log-file=".Length) + "\"";
                    }
                    else if (args[i].StartsWith("logfile="))
                    {
                        s = s + " logfile=\"" + args[i].Substring("logfile=".Length) + "\"";
                    }
                    else
                    {
                        s = s + " " + args[i];
                    }
                }
            }

            ConsoleLogInfo(s);
        }
        public static void printCompilationSuccess(bool block = true)
        {
            //add to log
            Log += "Task completed successfully. Press any key to exit." + Environment.NewLine;

            //add to console
            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Task completed successfully. Press any key to exit.");
            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if(block && MANUAL_MODE) Console.Read();
        }
        public static void printEncryptionSuccess(bool block = true)
        {
            //add to log
            Log += "Task completed successfully. Press any key to exit." + Environment.NewLine;

            //add to console
            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine("Task completed successfully. Press any key to exit.");
            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
        }
        public static void printHelpMessage(bool block = true)
        {
            ConsoleLog("about: " + DescribeTranspiler.DescribeCompiler.CompilerName);
            ConsoleLogInfo("Describe is a domain specific language used to write and maintain complex data lists");
            ConsoleLogInfo("that are compiled on demand to html, xaml, xml, sql, json and any other language needed.");
            ConsoleLogInfo("Describe is licensed under the GNU Affero General Public License v3.0");
            ConsoleLogInfo("For more information visit https://github.com/viktorchernev/DescribeCompiler");
            ConsoleLog("");
            ConsoleLogInfo("Describe Markup Language Transpiler CLI Interface v 1.0");
            ConsoleLogInfo("Running Describe Transpiler v 1.0 beta");
            ConsoleLogInfo("Running Describe Parser v 1.0");
            ConsoleLogInfo("Powered by ANTLR v 4.13.1 (C# Runtime for DotNet Standart)");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " help [ auto ] | -h [ auto ]");
            ConsoleLogInfo("Display this help message");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " parse-file PARSE_PATH RESULT_PATH\n[ input-password=INPUT_PASSWORD ][ output-password=OUTPUT_PASSWORD ][ log-password=LOG_PASSWORD ]\n[ language-version=<verb> | lang-ver=<verb> ][ translator=(TARGET_LANGUAGE|TRANSLATOR_NAME) ]\n[ beautify=<verb> ][ verbosity=<verb> | log-verbosity=<verb> ][ logfile=LOG_PATH | log-file=LOG_PATH ][ theme=<verb> ][ censor ][ auto ]");
            ConsoleLogInfo("TARGET_LANGUAGE - the desired output language: \"JSON\", \"HTML\", \"XML\", \"SQL\"");
            ConsoleLogInfo("TRANSLATOR_NAME - the name of the translator to be used :  \"HTML_PLAIN\", \"HTML_PAGE\", \"XML_PLAIN\", \"SQL_FILEFILL\", \"JSON_BASIC\", \"JSON_LISTIARY\"");
            ConsoleLogInfo("PARSE_PATH - the path of the file to parse");
            ConsoleLogInfo("RESULT_PATH - the path of the file to write the result to (existing file or not)");
            ConsoleLogInfo("* verbosity - set the log verbosity of the parser (default is high): \"l\", \"low\", \"m\", \"medium\", \"h\", \"high\"");
            ConsoleLogInfo("* log-verbosity - can be used instead of verbosity");
            ConsoleLogInfo("* language-version - 0.6, 06, 0.7, 07, 0.8, 08, 0.9, 09, 1.0, 10, 1.1, 11");
            ConsoleLogInfo("* lang-ver - same as language-version - 0.6, 06, 0.7, 07, 0.8, 08, 0.9, 09, 1.0, 10, 1.1, 11");
            ConsoleLogInfo("* LOG_PATH - specify path of directory or file to output logs to");
            ConsoleLogInfo("* beautify - true, false");
            ConsoleLogInfo("* theme - \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " parse-folder PARSE_PATH RESULT_PATH\n[ dsonly=<verb> ][ toponly=<verb> ][ onerror= ( stop | ignore )]\n[ input-password=INPUT_PASSWORD ][ output-password=OUTPUT_PASSWORD ][ log-password=LOG_PASSWORD ]\n[ language-version=<verb> | lang-ver=<verb> ][ translator=(TARGET_LANGUAGE | TRANSLATOR_NAME) ]\n[ beautify=<verb> ][ verbosity=<verb> | log-verbosity=<verb> ]\n[ logfile=LOG_PATH | log-file=LOG_PATH ][ theme=<verb> ][ censor ][ auto ]");
            ConsoleLogInfo("TARGET_LANGUAGE - the desired output language: \"JSON\", \"HTML\", \"XML\", \"SQL\"");
            ConsoleLogInfo("TRANSLATOR_NAME - the name of the translator to be used :  \"HTML_PLAIN\", \"HTML_PAGE\", \"XML_PLAIN\", \"SQL_FILEFILL\", \"JSON_BASIC\", \"JSON_LISTIARY\"");
            ConsoleLogInfo("PARSE_PATH - the path of the file to parse");
            ConsoleLogInfo("RESULT_PATH - the path of the file to write the result to (existing file or not)");
            ConsoleLogInfo("* dsonly - true, false");
            ConsoleLogInfo("* onerror - stop, ignore");
            ConsoleLogInfo("* verbosity - set the log verbosity of the parser (default is high): \"l\", \"low\", \"m\", \"medium\", \"h\", \"high\"");
            ConsoleLogInfo("* log-verbosity - can be used instead of verbosity");
            ConsoleLogInfo("* language-version - 0.6, 06, 0.7, 07, 0.8, 08, 0.9, 09, 1.0, 10, 1.1, 11");
            ConsoleLogInfo("* lang-ver - same as language-version - 0.6, 06, 0.7, 07, 0.8, 08, 0.9, 09, 1.0, 10, 1.1, 11");
            ConsoleLogInfo("* LOG_PATH - specify path of directory or file to output logs to");
            ConsoleLogInfo("* beautify - true, false");
            ConsoleLogInfo("* theme - \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " encrypt-file PLAIN_PATH ENCRYPTED_PATH password=PASSWORD\n[ theme=<verb> ][ auto ]");
            ConsoleLogInfo("PLAIN_PATH - the path of the .DS file to be encrypted");
            ConsoleLogInfo("ENCRYPTED_PATH - the path of the encrypted file (cannot be the same as the PLAIN_PATH)");
            ConsoleLogInfo("PASSWORD - the encryption password");
            ConsoleLogInfo("* theme - console color theme: \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " decrypt-file ENCRYPTED_PATH PLAIN_PATH password=PASSWORD\n[ theme=<verb> ][ auto ]");
            ConsoleLogInfo("ENCRYPTED_PATH - the path of the encrypted file (cannot be the same as the PLAIN_PATH)");
            ConsoleLogInfo("PLAIN_PATH - the path of the resulted file");
            ConsoleLogInfo("PASSWORD - the encryption password");
            ConsoleLogInfo("* theme - console color theme: \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " recrypt-file ENCRYPTED_PATH1 ENCRYPTED_PATH2 password=PASSWORD\n[ theme=<verb> ][ auto ]");
            ConsoleLogInfo("ENCRYPTED_PATH1 - the path of the encrypted file (cannot be the same as the PLAIN_PATH2)");
            ConsoleLogInfo("ENCRYPTED_PATH2 - the path of the result encrypted file (cannot be the same as the PLAIN_PATH1)");
            ConsoleLogInfo("PASSWORD - the encryption password");
            ConsoleLogInfo("* theme - console color theme: \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " encrypt-folder PLAIN_PATH ENCRYPTED_PATH password=PASSWORD\n[ theme=<verb> ][ auto ]");
            ConsoleLogInfo("PLAIN_PATH - the path of the .DS folder to be encrypted");
            ConsoleLogInfo("ENCRYPTED_PATH - the path of the encrypted folder (cannot be the same as the PLAIN_PATH)");
            ConsoleLogInfo("PASSWORD - the encryption password");
            ConsoleLogInfo("* theme - console color theme: \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " decrypt-folder ENCRYPTED_PATH PLAIN_PATH password=PASSWORD\n[ theme=<verb> ][ auto ]");
            ConsoleLogInfo("ENCRYPTED_PATH - the path of the encrypted folder (cannot be the same as the PLAIN_PATH)");
            ConsoleLogInfo("PLAIN_PATH - the path of the resulted folder");
            ConsoleLogInfo("PASSWORD - the encryption password");
            ConsoleLogInfo("* theme - console color theme: \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("usage: " + thisName + " recrypt-folder ENCRYPTED_PATH1 ENCRYPTED_PATH2 password=PASSWORD\n[ theme=<verb> ][ auto ]");
            ConsoleLogInfo("ENCRYPTED_PATH1 - the path of the encrypted folder (cannot be the same as the PLAIN_PATH2)");
            ConsoleLogInfo("ENCRYPTED_PATH2 - the path of the result encrypted folder (cannot be the same as the PLAIN_PATH1)");
            ConsoleLogInfo("PASSWORD - the encryption password");
            ConsoleLogInfo("* theme - console color theme: \"DBLUE\", \"LBLUE\", \"GREEN\", \"PASTEL\", \"EARTH\", \"CONTRAST\", \"DEFAULT\", \"VIOLET\", \"CYAN\"");
            ConsoleLog("");
            ConsoleLogInfo("-----------------------------------------------------------------");


            if(MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            if (block && MANUAL_MODE)
            {
                Log += "Press any key to exit." + Environment.NewLine;
                Console.WriteLine("Press any key to exit.");
            }
            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
        }
        public static void printParseManyNotImplemented(bool block = true)
        {
            ConsoleLog("The command you are trying to use - \"parse-many\" has not been implemented yet.");
            ConsoleLog("This message will be removed once it has been implemented.");
            ConsoleLog("Meanwhile, why not try to parse single files multiple times?");
            ConsoleLog("");

            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");
            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
        }
        public static void printWarning(string message, bool block = true)
        {
            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Log += "Warning: " + message + Environment.NewLine;
            if (block) Log += "Press any key to continue." + Environment.NewLine;
            Console.WriteLine("Warning: " + message);
            if (block) Console.WriteLine("Press any key to continue.");

            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
        }
        public static void printNoArgumentsError(bool block = true)
        {
            if (MANUAL_MODE) Console.ForegroundColor = ERROR_COLOR;
            Log += "No arguments or invalid argument count." + Environment.NewLine;
            if (MANUAL_MODE) Console.WriteLine("No arguments or invalid argument count.");

            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            printHelpMessage(false);

            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
        }
        public static void printArgumentError(string arg, int argIndex, bool block = true)
        {
            if (MANUAL_MODE) Console.ForegroundColor = ERROR_COLOR;
            if (ONE_BASED_ARG_INDEX) argIndex++;
            Log += "Invalid argument " + argIndex.ToString() + " - \"" + arg + "\"" + Environment.NewLine;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\"");

            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            printHelpMessage(false);

            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
        }
        public static void printArgumentError(string arg, int argIndex, string message, bool block = true)
        {
            if (MANUAL_MODE) Console.ForegroundColor = ERROR_COLOR;
            if (ONE_BASED_ARG_INDEX) argIndex++;
            Log += "Invalid argument " + argIndex.ToString() +
                " - \"" + arg + "\" - " + message + Environment.NewLine;
            Console.WriteLine("Invalid argument " + argIndex.ToString() + " - \"" + arg + "\" - " + message);

            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
        }
        public static void printFatalError(string message, bool block = true)
        {
            if (MANUAL_MODE) Console.ForegroundColor = ERROR_COLOR;
            Log += "Fatal error: " + message + Environment.NewLine;
            Console.WriteLine("Fatal error: " + message);

            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Log += "Press any key to exit." + Environment.NewLine;
            Console.WriteLine("Press any key to exit.");

            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
            if (block && MANUAL_MODE) Console.Read();
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
            if (MANUAL_MODE) Console.ForegroundColor = INFO_COLOR;
            Console.WriteLine(text);
            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
        }
        public static void ConsoleLogError(string text)
        {
            Log += text + Environment.NewLine;
            if (MANUAL_MODE) Console.ForegroundColor = ERROR_COLOR;
            Console.WriteLine(text);
            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
        }
        public static void ConsoleLogParseInfo(string text)
        {
            Log += text + Environment.NewLine;
            if (MANUAL_MODE) Console.ForegroundColor = MOREINFO_COLOR;
            Console.WriteLine(text);
            if (MANUAL_MODE) Console.ForegroundColor = TEXT_COLOR;
        }
    }
}
