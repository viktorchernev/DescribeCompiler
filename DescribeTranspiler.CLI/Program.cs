using System;
using System.IO;
using System.Reflection;

namespace DescribeTranspiler.Cli
{
    internal class Program
    {
        public static readonly bool LOG_STACK_TRACES = true;


        static void Main(string[] args)
        {
            try
            {
                                    args = new string[8];
                                    args[0] = "parse-folder";
                                    args[1] = "C:\\Users\\Viktor Chernev\\Desktop\\dbs\\2024.02.15-205423065\\Public\\files";
                                    args[2] = "C:\\Users\\Viktor Chernev\\Desktop\\dbs\\AAA";
                                    args[3] = "translator=JSON_WORLD_OF_LISTS";
                                    args[4] = "dsonly=true";
                                    args[5] = "toponly=false";
                                    args[6] = "onerror=ignore";
                                    args[7] = "verbosity=l";
                
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
            bool haveArtifactsArgument = false;
            bool haveArtifactsPath = false;
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
                else if (cur.StartsWith("artifacts=") && cur.Length > "artifacts=".Length)
                {
                    if (Arguments.readArtifactsArgument(cur, i) == false) return;
                    haveArtifactsArgument = true;
                }
                else if (cur.StartsWith("artifacts-path=") && cur.Length > "artifacts-path=".Length)
                {
                    if (Arguments.readArtifactsPathArgument(args[i], i) == false) return;
                    haveArtifactsPath = true;
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
            if (haveArtifactsArgument && haveArtifactsPath == false)
            {
                string? dir = Assembly.GetExecutingAssembly().Location;
                dir = Path.GetDirectoryName(dir);
                Datnik.artifactsFolderPath = Path.Combine(dir + "\\Artifacts");
                Messages.ConsoleLogInfo(
                    "Artifacts folder path have not been specified. Current directory \"" +
                    Datnik.artifactsFolderPath + "\" will be used. " +
                    "Note that Artifacts are not yet supported by the CLI");
            }
            else if (haveArtifactsArgument == false && haveArtifactsPath)
            {
                Messages.ConsoleLogInfo(
                    "Artifacts folder path have been specified, without artifacts argument. \"u | use\" will be used. " +
                    "Note that Artifacts are not yet supported by the CLI");
                Datnik.artifactMode = DescribeTranspiler.Compiler.ArtifactMode.Use;
            }
            else if (haveArtifactsArgument || haveArtifactsPath)
            {
                Messages.ConsoleLogInfo(
                    "Note that Artifacts are not yet supported by the CLI");
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
            bool haveArtifactsArgument = false;
            bool haveArtifactsPath = false;
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
                else if (cur.StartsWith("artifacts=") && cur.Length > "artifacts=".Length)
                {
                    if (Arguments.readArtifactsArgument(cur, i) == false) return;
                    haveArtifactsArgument = true;
                }
                else if (cur.StartsWith("artifacts-path=") && cur.Length > "artifacts-path=".Length)
                {
                    if (Arguments.readArtifactsPathArgument(args[i], i) == false) return;
                    haveArtifactsPath = true;
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
            if (haveArtifactsArgument && haveArtifactsPath == false)
            {
                string? dir = Assembly.GetExecutingAssembly().Location;
                dir = Path.GetDirectoryName(dir);
                Datnik.artifactsFolderPath = Path.Combine(dir + "\\Artifacts");
                Messages.ConsoleLogInfo(
                    "Artifacts folder path have not been specified. Current directory \"" +
                    Datnik.artifactsFolderPath + "\" will be used. " +
                    "Note that Artifacts are not yet supported by the CLI");
            }
            else if (haveArtifactsArgument == false && haveArtifactsPath)
            {
                Messages.ConsoleLogInfo(
                    "Artifacts folder path have been specified, without artifacts argument. \"u | use\" will be used. " +
                    "Note that Artifacts are not yet supported by the CLI");
                Datnik.artifactMode = DescribeTranspiler.Compiler.ArtifactMode.Use;
            }
            else if (haveArtifactsArgument || haveArtifactsPath)
            {
                Messages.ConsoleLogInfo(
                    "Note that Artifacts are not yet supported by the CLI");
            }

            //Compile
            MainFunctions.Compile();
            Messages.printCompilationSuccess();
        }
    }
}
