using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DescribeCompiler;



namespace DescribeCompilerCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get cmd argument path


            Console.BufferHeight = Int16.MaxValue - 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            DescribeCompiler.DescribeCompiler comp = 
                new DescribeCompiler.DescribeCompiler(
                    ConsoleLog, 
                    ConsoleLogError, 
                    ConsoleLogInfo,
                    ConsoleLogParseInfo,
                    LogVerbosity.Low);


            string html = "";
            comp.ParseFile(new FileInfo(@"C:\Users\Viktor Chernev\Desktop\DataLists\Lists\0_root.ds"), out html);
            if(html != null)
            {
                File.WriteAllText(@"C:\Users\Viktor Chernev\Desktop\sss.html", html);
            }
            Console.ReadLine();
            //string s = comp.Log;
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
