using DescribeTranspiler.CLI;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace DescribeTranspiler.Cli
{
    internal class Program
    {
        public static readonly bool LOG_STACK_TRACES = true;
        public static CryptoUtil CryptoUtil = new CryptoUtil_Implementation1();

        static void Main(string[] args)
        {
            try
            {
                //preset
                Messages.presetConsole();
                bool setted = false;
                for(int i = 0; i < args.Length; i++)
                {
                    string arg = args[i];
                    if (arg.StartsWith("theme=") && arg.Length > "theme=".Length)
                    {
                        if (Arguments.readThemeArgument(args[i], i) == false) return;
                        else
                        {
                            setted = true;
                            break;
                        }
                    }
                    else continue;
                }
                if(setted == false) Messages.SetGreenTheme();
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

                //DescribeCompilerCLI parse-file PARSE_PATH RESULT_PATH [ password=PASSWORD ][ encrypt-log=false ]
                //[ language-version=<verb> | lang-ver=<verb> ][ translator = ( TARGET_LANGUAGE | TRANSLATOR_NAME )]
                //[ verbosity=<verb> | log-verbosity=<verb> ][ logfile=LOG_PATH | log-file=LOG_PATH ]
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
                    if(Datnik.encryptLog == true)
                    {
                        string log = Messages.Log;
                        string encryptedLog = CryptoUtil.EncryptString(log, Datnik.logPassword!);
                        File.WriteAllText(Datnik.logFilePath!, encryptedLog);
                    }
                    else
                    {
                        File.WriteAllText(Datnik.logFilePath!, Messages.Log);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + Environment.NewLine;
                }
                Messages.printFatalError(message);
            }
            finally
            {
                Messages.RevertConsoleColors();
            }
        }
        static void parseFile(string[] args)
        {
            //read input output
            if (Arguments.readInputFileArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFileArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("translator=") && cur.Length > "translator=".Length)
                {
                    if (Arguments.readTranslatorArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("verbosity=") && cur.Length > "verbosity=".Length)
                {
                    if (Arguments.readVerbosityArgument(cur, i) == false) return;
                }
                else if (cur.StartsWith("log-verbosity=") && cur.Length > "log-verbosity=".Length)
                {
                    if (Arguments.readVerbosityArgument(cur, i) == false) return;
                }
                else if (cur.StartsWith("logfile=") && cur.Length > "logfile=".Length)
                {
                    if (Arguments.readLogfileArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("input-password=") && cur.Length > "input-password=".Length)
                {
                    if (Arguments.readInputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("output-password=") && cur.Length > "output-password=".Length)
                {
                    if (Arguments.readOutputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("log-password=") && cur.Length > "log-password=".Length)
                {
                    if (Arguments.readLogPasswordArgument(args[i], i) == false) return;
                }
                else
                {
                    Messages.printArgumentError(cur, i, "what is this?");
                    return;
                }
            }

            //Compile
            MainFunctions.Compile();
            Messages.printCompilationSuccess();
        }
        static void parseFolder(string[] args)
        {
            //read input output
            if (Arguments.readInputFolderArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFileArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("translator=") && cur.Length > "translator=".Length)
                {
                    if (Arguments.readTranslatorArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("dsonly"))
                {
                    if (cur.Length > "dsonly=".Length)
                    {
                        if (Arguments.readDsonlyArgument(cur, i) == false) return;
                    }
                    else
                    {
                        Datnik.dsOnly = true;
                    }
                }
                else if (cur.StartsWith("toponly"))
                {
                    if (cur.Length > "toponly=".Length)
                    {
                        if (Arguments.readToponlyArgument(cur, i) == false) return;
                    }
                    else
                    {
                        Datnik.topOnly = true;
                    }
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
                else if (cur.StartsWith("logfile=") && cur.Length > "logfile=".Length)
                {
                    if (Arguments.readLogfileArgument(args[i], i) == false) return;
                }
                else
                {
                    Messages.printArgumentError(cur, i, "what is this?");
                    return;
                }
            }

            //Compile
            MainFunctions.Compile();
            Messages.printCompilationSuccess();
        }
    }
}
