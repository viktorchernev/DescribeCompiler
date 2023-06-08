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
            Messages.printLogo3(ConsoleColor.DarkBlue);

            //get cmd arguments
            string thisName = Assembly.GetExecutingAssembly().GetName().Name;
            if (args.Length < 1) 
            {
                Messages.printNoArgumentsError(thisName);
                return;
            }
            else if (args.Length < 2) 
            { 
                if (args[0].ToLower() != "help")
                {
                    Messages.printArgumentError(thisName, args[0], 1);
                    return;
                }
                else
                {
                    Messages.printHelpMessage(thisName);
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
                Messages.printArgumentError(thisName, args[0], 1, "is not a valid file or folder");
                return;
            }
            try
            {
                FileInfo finfo = new FileInfo(output);
                DirectoryInfo di = finfo.Directory;
                if(di.Exists == false)
                {
                    Messages.printArgumentError(thisName, 
                        args[args.Length - 1], 
                        args.Length, "is not a valid outpit file path");
                    return;
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(thisName, args[args.Length - 1], args.Length, ex.Message);
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
                        Messages.printArgumentError(thisName, cur, i + 1, "");
                        return;
                    }
                    else if(val == "low" || val == "l") verb = LogVerbosity.Low;
                    else if (val == "medium" || val == "m") verb = LogVerbosity.Medium;
                    else if (val == "high" || val == "h") verb = LogVerbosity.High;
                }
                else
                {
                    Messages.printArgumentError(thisName, cur, i + 1, "- what is this?");
                    return;
                }
            }



            //Compile
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
