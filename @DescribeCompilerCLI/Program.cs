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
        static void Main(string[] args)
        {
            //preset
            FunctionsMessages.presetConsole();
            FunctionsMessages.SetVioletTheme();
            FunctionsMessages.printLogo3Bicolor();
            FunctionsMessages.printCmdLine(args);

            //1 argument mode
            if (args.Length < 1) 
            {
                FunctionsMessages.printNoArgumentsError();
                return;
            }
            else if (args.Length < 2) 
            { 
                if (args[0].ToLower() == "help")
                {
                    FunctionsMessages.printHelpMessage();
                    return;
                }
                else if (args[0].ToLower() == "ext")
                {
                    bool result = FunctionsMain.ExtTemplates();
                    return;
                }
                else
                {
                    FunctionsMessages.printArgumentError(args[0], 1);
                    return;
                }
            }

            //else - 2 argument mode
            //read input output
            if (FunctionsArguments.readInputArgument(args[0], 0) == false) return;
            if (FunctionsArguments.readOutputArgument(args[args.Length - 1], args.Length) == false) return;

            //read other options
            for (int i = 1; i < args.Length - 1; i++) 
            {
                string cur = args[i].ToLower();
                if(cur.StartsWith("verbosity=") && cur.Length > "verbosity=".Length)
                {
                    if (FunctionsArguments.readVerbosityArgument(cur, i) == false) return;
                }
                else if(cur.StartsWith("template=") && cur.Length > "template=".Length)
                {
                    if (FunctionsArguments.readTemplateArgument(args[i], i) == false) return;
                }
                else
                {
                    FunctionsMessages.printArgumentError(cur, i, "- what is this?");
                    return;
                }
            }

            //Compile
            FunctionsMain.Compile();
            Console.ReadKey();
        }
    }
}

//help
//ext
//parse-file
//parse-folder
	
//help
//DescribeCompiler help
//DescribeCompiler -h
	
//ext
//DescribeCompiler ext
//DescribeCompiler ext RESULT_PATH
	
//extone
//DescribeCompiler extone TEMPLATE_NAME
//DescribeCompiler extone TEMPLATE_NAME RESULT_PATH
	
//parse-file
//DescribeCompiler parse-file PARSE_PATH RESULT_PATH
//DescribeCompiler parse-file PARSE_PATH dsonly RESULT_PATH
//DescribeCompiler parse-file PARSE_PATH [dsonly[=true|=false]] RESULT_PATH
//DescribeCompiler parse-file PARSE_PATH [dsonly[=true|=false]] [verbosity(=high|=h|=medium|=m|=low|=l)|log-verbosity(=high|=h|=medium|=m|=low|=l)] RESULT_PATH
//DescribeCompiler parse-file PARSE_PATH [dsonly[=true|=false]] [verbosity(=high|=h|=medium|=m|=low|=l)|log-verbosity(=high|=h|=medium|=m|=low|=l)] [(make-artifacts[=true|=false]|take-artifacts[=true|=false]|use-artifacts[=true|=false]) artifacts-path=PATH] RESULT_PATH
	
//parse-folder
//DescribeCompiler parse-folder PARSE_PATH RESULT_PATH
//DescribeCompiler parse-folder PARSE_PATH [dsonly[=true|=false]] RESULT_PATH
//DescribeCompiler parse-folder PARSE_PATH [dsonly[=true|=false]][toponly[=true|=false]] RESULT_PATH
//DescribeCompiler parse-folder PARSE_PATH [dsonly[=true|=false]][toponly[=true|=false]] [verbosity(=high|=h|=medium|=m|=low|=l)|log-verbosity(=high|=h|=medium|=m|=low|=l)] RESULT_PATH
//DescribeCompiler parse-folder PARSE_PATH [dsonly[=true|=false]][toponly[=true|=false]] [verbosity(=high|=h|=medium|=m|=low|=l)|log-verbosity(=high|=h|=medium|=m|=low|=l)] [(make-artifacts[=true|=false]|take-artifacts[=true|=false]|use-artifacts[=true|=false]) artifacts-path=PATH] RESULT_PATH
	
////[grammar-name(=basic|=b|=tags|=t|=links|=l|=decorators|=d|=official|=o)]
//[verbosity(=high|=h|=medium|=m|=low|=l)|log-verbosity(=high|=h|=medium|=m|=low|=l)]
//[(make-artifacts[=true|=false]|take-artifacts[=true|=false]|use-artifacts[=true|=false]) artifacts-path=PATH]