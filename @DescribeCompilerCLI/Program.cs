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
            Messages.presetConsole();
            Messages.SetDarkBlueTheme();
            Messages.printLogo3Bicolor();
            Messages.printCmdLine(args);

            //read args
            if (args.Length < 1) 
            {
                Messages.printNoArgumentsError();
            }
            //DescribeCompilerCLI help | -h
            else if (args[0].ToLower() == "help" || args[0] == "-h")
            {
                Messages.printHelpMessage();
            }
            //DescribeCompilerCLI ext [ RESULT_PATH ]
            else if (args[0].ToLower() == "ext")
            {
                ext(args);
            }
            //DescribeCompilerCLI extone TEMPLATE_NAME [ RESULT_PATH ]
            else if (args[0].ToLower() == "extone")
            {
                extone(args);
            }
            //DescribeCompilerCLI parse-file PARSE_PATH RESULT_PATH
            //[dsonly[=<verb>]] [verbosity=<verb> | log-verbosity=<verb> ] [onerror=<verb> ]
            //[artifacts=<verb> [artifacts-path=ARTIFACTS_PATH]] [logfile=LOG_PATH ]
            else if (args[0].ToLower() == "parse-file")
            {
                parseFile(args);
            }
            //DescribeCompilerCLI parse-folder PARSE_PATH RESULT_PATH
            //[ dsonly[=<verb>] ] [ toponly[=true|=false] ] [ verbosity=<verb> | log-verbosity=<verb> ]
            //[ onerror=<verb> ] [ artifacts=<verb> [artifacts-path=ARTIFACTS_PATH ]] [ logfile=LOG_PATH ]
            else if (args[0].ToLower() == "parse-folder")
            {
                parseFolder(args);
            }
            else
            {
                Messages.printArgumentError(args[0], 1);
            }

            //save log to file
            if (Datnik.logToFile)
            {
                File.WriteAllText(Datnik.logFilePath, Messages.Log);
            }
        }
        static void ext(string[] args)
        {
            bool result;
            if (args.Length > 1)
            {
                result = Arguments.readTemplateFolderPathArgument(args[1], 1);
            }
            else
            {
                string dir = Assembly.GetExecutingAssembly().Location;
                dir = Path.GetDirectoryName(dir);
                Datnik.extOutputDir = dir;
                result = true;
            }

            if (result)
            {
                MainFunctions.ExtTemplates(Datnik.extOutputDir);
            }
        }
        static void extone(string[] args)
        {
            if (args.Length < 2)
            {
                Messages.printFatalError("extone takes at least 1 argument - \"TEMPLATE_NAME\"");
            }
            Datnik.templateName = args[1];

            bool result;
            if (args.Length > 2)
            {
                result = Arguments.readTemplateFolderPathArgument(args[2], 2);
            }
            else
            {
                string dir = Assembly.GetExecutingAssembly().Location;
                dir = Path.GetDirectoryName(dir);
                Datnik.extOutputDir = dir;
                result = true;
            }

            if (result)
            {
                MainFunctions.ExtTemplate(Datnik.extOutputDir, Datnik.templateName);
            }
        }
        static void parseFile(string[] args)
        {
            //read input output
            if (Arguments.readInputFileArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFileArgument(args[2], 2) == false) return;

            //read other options
            bool haveArtifactsArgument = false;
            bool haveArtifactsPath = false;
            for (int i = 3; i < args.Length - 1; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("template=") && cur.Length > "template=".Length)
                {
                    if (Arguments.readTemplateArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("dsonly="))
                {
                    if(cur.Length > "dsonly=".Length)
                        if (Arguments.readDsonlyArgument(cur, i) == false) return;
                    else Datnik.dsOnly = true;
                }
                else if (cur.StartsWith("verbosity=") && cur.Length > "verbosity=".Length)
                {
                    if (Arguments.readVerbosityArgument(cur, i) == false) return;
                }
                else if (cur.StartsWith("log-verbosity=") && cur.Length > "log-verbosity=".Length)
                {
                    if (Arguments.readVerbosityArgument(cur, i) == false) return;
                }
                else if (cur.StartsWith("artifacts=") && cur.Length > "artifacts=".Length)
                {
                    if (Arguments.readArtifactsArgument(cur, i) == false) return;
                    haveArtifactsArgument = true;
                }
                else if (cur.StartsWith("artifacts-path=") && cur.Length > "artifacts-path=".Length)
                {
                    if (Arguments.readArtifactsPathArgument(cur, i) == false) return;
                    haveArtifactsPath = true;
                }
                else if (cur.StartsWith("logfile=") && cur.Length > "logfile=".Length)
                {
                    if (Arguments.readLogfileArgument(cur, i) == false) return;
                }
                else
                {
                    Messages.printArgumentError(cur, i, "- what is this?");
                    return;
                }
            }
            if(haveArtifactsArgument == false && haveArtifactsPath)
            {
                Messages.printWarning(
                    "Artifacts folder path have been specified, without artifacts argument. No artifacts will be used");
            }

            //Compile
            MainFunctions.Compile();
            Console.ReadKey();
        }
        static void parseFolder(string[] args)
        {
            //read input output
            if (Arguments.readInputFolderArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFolderArgument(args[2], 2) == false) return;
            
            //read other options
            bool haveArtifactsArgument = false;
            bool haveArtifactsPath = false;
            for (int i = 3; i < args.Length - 1; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("template=") && cur.Length > "template=".Length)
                {
                    if (Arguments.readTemplateArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("dsonly"))
                {
                    if (cur.Length > "dsonly=".Length)
                        if (Arguments.readDsonlyArgument(cur, i) == false) return;
                        else Datnik.dsOnly = true;
                }
                else if (cur.StartsWith("toponly"))
                {
                    if (cur.Length > "toponly=".Length)
                        if (Arguments.readToponlyArgument(cur, i) == false) return;
                        else Datnik.topOnly = true;
                }
                else if (cur.StartsWith("verbosity=") && cur.Length > "verbosity=".Length)
                {
                    if (Arguments.readVerbosityArgument(cur, i) == false) return;
                }
                else if (cur.StartsWith("log-verbosity=") && cur.Length > "log-verbosity=".Length)
                {
                    if (Arguments.readVerbosityArgument(cur, i) == false) return;
                }
                else if (cur.StartsWith("onerror=") && cur.Length > "onerror=".Length)
                {
                    if (Arguments.readOnerrorArgument(cur, i) == false) return;
                }
                else if (cur.StartsWith("artifacts=") && cur.Length > "artifacts=".Length)
                {
                    if (Arguments.readArtifactsArgument(cur, i) == false) return;
                    haveArtifactsArgument = true;
                }
                else if (cur.StartsWith("artifacts-path=") && cur.Length > "artifacts-path=".Length)
                {
                    if (Arguments.readArtifactsPathArgument(cur, i) == false) return;
                    haveArtifactsPath = true;
                }
                else if (cur.StartsWith("logfile=") && cur.Length > "logfile=".Length)
                {
                    if (Arguments.readLogfileArgument(cur, i) == false) return;
                }
                else
                {
                    Messages.printArgumentError(cur, i, "- what is this?");
                    return;
                }
            }
            if (haveArtifactsArgument == false && haveArtifactsPath)
            {
                Messages.printWarning(
                    "Artifacts folder path have been specified, without artifacts argument. No artifacts will be used");
            }

            //Compile
            MainFunctions.Compile();
            Console.ReadKey();
        }
    }
}