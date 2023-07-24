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
        //main
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
