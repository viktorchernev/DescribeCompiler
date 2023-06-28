using System;
using System.Collections;
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
        //compiler settings
        static bool isInputDir = false;                     // is input a file or folder
        static bool isOutputDir = false;                    // is output a file or folder
        static string input = "";                           // file or folder to parse
        static string output = "";                          // output file or folder
        static LogVerbosity verbosity = LogVerbosity.Low;   // verbosity to use
        static string templateName = null;                  // the emplate to use
        

        //main
        static void Main(string[] args)
        {
            //preset
            Messages.presetConsole();
            Messages.SetDarkBlueTheme();
            Messages.printLogo3Bicolor();
            Messages.printCmdLine(args);

            //1 argument mode
            if (args.Length < 1) 
            {
                Messages.printNoArgumentsError();
                return;
            }
            else if (args.Length < 2) 
            { 
                if (args[0].ToLower() == "help")
                {
                    Messages.printHelpMessage();
                    return;
                }
                else if (args[0].ToLower() == "ext")
                {
                    bool result = extTemplates();
                    return;
                }
                else
                {
                    Messages.printArgumentError(args[0], 1);
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
                    Messages.printArgumentError(cur, i, "- what is this?");
                    return;
                }
            }

            //Compile
            compile();
            Console.ReadKey();
        }


        //read args
        private static bool readInputArgument(string arg, int argindex)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(arg);
                input = arg;
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory) isInputDir = true;
                else isInputDir = false;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, "is not a valid file or folder");
                return false;
            }
            return true;
        }
        private static bool readOutputArgument(string arg, int argindex)
        {
            try
            {
                //existing file - ok
                if (File.Exists(arg))
                {
                    output = arg;
                    isOutputDir = false;
                    return true;
                }
                //existing dir - ok
                else if (Directory.Exists(arg))
                {
                    output = arg;
                    isOutputDir = true;
                    return true;
                }
                else
                {
                    // notexisting file or dir - we want parent dir to exist
                    DirectoryInfo di = Directory.GetParent(arg);
                    if(di.Exists)
                    {
                        if (Path.GetFileName(arg) == string.Empty) isOutputDir = true;
                        else isOutputDir = false;
                        output = arg;
                        return true;
                    }
                    else
                    {
                        Messages.printArgumentError(arg,
                            argindex, "is not a valid outpit file or folder path");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }
        private static bool readVerbosityArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "low" || val == "l") verbosity = LogVerbosity.Low;
                else if (val == "medium" || val == "m") verbosity = LogVerbosity.Medium;
                else if (val == "high" || val == "h") verbosity = LogVerbosity.High;
                else
                {
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }
        private static bool readTemplateArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (val == null)
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "Empty value for template name");
                    return false;
                }
                else
                {
                    templateName = val;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
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
                Messages.printExtTemplatesSuccess();
                return true;
            }
            catch(Exception ex)
            {
                Messages.printFatalError(ex.Message);
                return false;
            }
        }
        private static bool compile()
        {
            try
            {
                DescribeCompiler.DescribeCompiler comp =
                new DescribeCompiler.DescribeCompiler(
                    templateName,
                    Messages.ConsoleLog,
                    Messages.ConsoleLogError,
                    Messages.ConsoleLogInfo,
                    Messages.ConsoleLogParseInfo,
                    verbosity);

                string html = "";
                if (isInputDir == false) comp.ParseFile(new FileInfo(input), out html);
                else comp.ParseFolder(new DirectoryInfo(input), out html);

                if (html != null)
                {
                    File.WriteAllText(output, html);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Messages.printFatalError(ex.Message);
                return false;
            }
        }
    }
}
