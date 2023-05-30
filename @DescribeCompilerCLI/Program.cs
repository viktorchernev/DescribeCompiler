using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using DescribeCompiler;



namespace DescribeCompilerCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //get cmd arguments
            string thisName = Assembly.GetExecutingAssembly().GetName().Name;
            if (args.Length < 1) 
            {
                ConsoleLogError("Invalid argument count.");
                ConsoleLog("usage: " + thisName + " help");
                ConsoleLog("usage: " + thisName + " INPUT_PATH [ verbosity=<verb> ] OUTPUT_PATH");
                ConsoleLogInfo("Press any key to exit.");
                Console.ReadLine();
                return;
            }
            else if (args.Length < 2) 
            { 
                if (args[0].ToLower() != "help")
                {
                    ConsoleLogError("Invalid argument 1 - " + args[0]);
                    ConsoleLog("usage: " + thisName + " help");
                    ConsoleLog("usage: " + thisName + " INPUT_PATH [ verbosity=<verb> ] OUTPUT_PATH");
                    ConsoleLogInfo("Press any key to exit.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    ConsoleLog("usage: " + thisName + " help");
                    ConsoleLog("usage: " + thisName + " INPUT_PATH [ verbosity=<verb> ] OUTPUT_PATH");
                    ConsoleLog("-----------------------------------------------------------------");
                    ConsoleLog("verbosity - set the log verbosity of the parser:");
                    Console.WriteLine();
                    ConsoleLog("    l, low - low verbosity");
                    ConsoleLog("    m, medium - medium verbosity");
                    ConsoleLog("    h, high - high verbosity");
                    Console.WriteLine();
                    ConsoleLog("help - display this message");
                    ConsoleLog("-----------------------------------------------------------------");
                    ConsoleLogInfo("Press any key to exit.");
                    Console.ReadLine();
                    return;
                }
            }

            bool isdir = false;
            string input = args[0];
            string output = args[args.Length - 1];
            LogVerbosity verb = LogVerbosity.Low;

            try
            {
                FileAttributes attr = File.GetAttributes(input);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory) isdir = true;
            }
            catch (Exception ex)
            {
                ConsoleLogError("Invalid argument 1 - \"" + args[0] + "\" is not a valid file or folder");
                ConsoleLogInfo("Press any key to exit.");
                Console.ReadLine();
                return;
            }
            try
            {
                FileInfo finfo = new FileInfo(output);
            }
            catch (Exception ex)
            {
                ConsoleLogError("Invalid argument " + args.Length + " - " + ex.Message);
                ConsoleLogInfo("Press any key to exit.");
                Console.ReadLine();
                return;
            }
            for (int i = 1; i < args.Length - 1; i++) 
            {
                string cur = args[i].ToLower();
                if(cur.StartsWith("verbosity=") && cur.Length > "verbosity=".Length)
                {
                    string val = cur.Substring(cur.IndexOf("=") + 1);
                    if(val == null)
                    {
                        ConsoleLogError("Invalid argument " + (i + 1).ToString() + " - \"" + cur + "\"");
                        ConsoleLogInfo("Press any key to exit.");
                        Console.ReadLine();
                        return;
                    }
                    else if(val == "low" || val == "l") verb = LogVerbosity.Low;
                    else if (val == "medium" || val == "m") verb = LogVerbosity.Medium;
                    else if (val == "high" || val == "h") verb = LogVerbosity.High;
                }
                else
                {
                    ConsoleLogError("Invalid argument " + (i + 1).ToString() + " - what is \"" + cur + "\"?");
                    ConsoleLogInfo("Press any key to exit.");
                    Console.ReadLine();
                    return;
                }
            }

            DescribeCompiler.DescribeCompiler comp = 
                new DescribeCompiler.DescribeCompiler(
                    ConsoleLog, 
                    ConsoleLogError, 
                    ConsoleLogInfo,
                    ConsoleLogParseInfo,
                    verb);


            string html = "";
            if(isdir == false) comp.ParseFile(new FileInfo(input), out html);
            else comp.ParseFolder(new DirectoryInfo(input), out html);
            if (html != null)
            {
                File.WriteAllText(output, html);
            }
            Console.ReadLine();
        }
        private static void ConsoleLog(string text)
        {
            Console.WriteLine(text);
        }
        private static void ConsoleLogInfo(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void ConsoleLogError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void ConsoleLogParseInfo(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
