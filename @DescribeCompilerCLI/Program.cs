using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using DescribeCompiler;



namespace DescribeCompilerCLI
{
    internal class Program
    {
        static string thisName = "";

        static string input = "";                           // file or folder to parse
        static bool isdir = false;                          // is input a file or folder
        static string output = "";                          // output file or folder
        static LogVerbosity verb = LogVerbosity.Low;        // verbosity to use
        static string templateName = null;                  // the emplate to use
        

        static void Main(string[] args)
        {
            Messages.setConsole();
            Messages.printLogo3(ConsoleColor.DarkBlue);
            ConsoleLogInfo(string.Join(" ", args));

            //get cmd arguments
            thisName = Assembly.GetExecutingAssembly().GetName().Name;

            //1 argument mode
            if (args.Length < 1) 
            {
                Messages.printNoArgumentsError(thisName);
                return;
            }
            else if (args.Length < 2) 
            { 
                if (args[0].ToLower() == "help")
                {
                    Messages.printHelpMessage(thisName);
                    return;
                }
                else if (args[0].ToLower() == "ext")
                {
                    bool result = extTemplates();
                    return;
                }
                else
                {
                    Messages.printArgumentError(thisName, args[0], 1);
                    return;
                }
            }

            //else - 2 argument mode
            //read input output
            if (readInputArgument(args[0], 0) == false) return;
            if (readOutputArgument(args[args.Length - 1], args.Length) == false) return;

            //read other options
            for (int i = 1; i < args.Length - 1; i++) 
            {
                string cur = args[i].ToLower();
                if(cur.StartsWith("verbosity=") && cur.Length > "verbosity=".Length)
                {
                    if (readVerbosityArgument(cur, i) == false) return;
                }
                else if(cur.StartsWith("template=") && cur.Length > "template=".Length)
                {
                    if (readTemplateArgument(args[i], i) == false) return;
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
                    templateName,
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

        //read args
        private static bool readInputArgument(string arg, int argindex)
        {
            isdir = false;
            input = arg;

            try
            {
                FileAttributes attr = File.GetAttributes(arg);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory) isdir = true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(thisName, arg, argindex + 1, "is not a valid file or folder");
                return false;
            }
            return true;
        }
        private static bool readOutputArgument(string arg, int argindex)
        {
            output = arg;
            try
            {
                FileInfo finfo = new FileInfo(output);
                DirectoryInfo di = finfo.Directory;
                if (di.Exists == false)
                {
                    Messages.printArgumentError(thisName,
                        arg, argindex, "is not a valid outpit file path");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(thisName, arg, argindex, ex.Message);
                return false;
            }
            return true;
        }
        private static bool readVerbosityArgument(string arg, int argindex)
        {
            string val = arg.Substring(arg.IndexOf("=") + 1);
            if (val == null)
            {
                Messages.printArgumentError(thisName, arg, argindex + 1, "");
                return false;
            }
            else if (val == "low" || val == "l") verb = LogVerbosity.Low;
            else if (val == "medium" || val == "m") verb = LogVerbosity.Medium;
            else if (val == "high" || val == "h") verb = LogVerbosity.High;
            else
            {
                Messages.printArgumentError(thisName, 
                    arg, 
                    argindex + 1, 
                    "invalid value \"" + val + "\"");
                return false;
            }

            return true;
        }
        private static bool readTemplateArgument(string arg, int argindex)
        {
            string val = arg.Substring(arg.IndexOf("=") + 1);
            if (val == null)
            {
                Messages.printArgumentError(thisName, arg, argindex + 1, "");
                return false;
            }
            else if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
            {
                Messages.printArgumentError(thisName, arg, argindex + 1, "Empty value for template name");
                return false;
            }
            else
            {
                templateName = val;
                return true;
            }
        }


        //func
        private static bool extTemplates()
        {
            try
            {
                string dir = Assembly.GetExecutingAssembly().Location;
                dir = Path.GetDirectoryName(dir);
                string[] names = ResourceUtil.extractResourceNames();
                foreach (string s in names)
                {
                    if (s.StartsWith("DescribeCompiler.Templates."))
                    {
                        string[] sep = s.Split('.');
                        string folder = dir + "\\Templates\\" + sep[2];
                        string filename = sep[3];
                        for (int i = 4; i < sep.Length; i++)
                        {
                            filename += "." + sep[i];
                        }
                        if (Directory.Exists(folder) == false)
                        {
                            Directory.CreateDirectory(folder);
                        }
                        string template = 
                            ResourceUtil.ExtractResourceByFileName_String(sep[sep.Length - 3], sep[sep.Length - 2]);
                        File.WriteAllText(folder + "\\" + filename, template);
                    }
                }
                Messages.printSpitSuccess();
                return true;
            }
            catch(Exception ex)
            {
                Messages.printFatalError(ex.Message);
                return false;
            }
        }


        //logs
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
