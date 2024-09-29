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
                Messages.ConsoleLog("--------------------------------------------------");

                //read args
                if (args.Length < 1)
                {
                    Messages.printNoArgumentsError();
                }

                //DescribeCompilerCLI help | -h
                else if (args[0].ToLower() == "help" || args[0].ToLower() == "-help" || args[0].ToLower() == "-h")
                {
                    Messages.printHelpMessage();
                }

                //DescribeCompilerCLI parse-file PARSE_PATH RESULT_PATH
                //[ input-password=PASSWORD ][ output-password=PASSWORD ][ log-password=PASSWORD ]
                //[ language-version=<verb> | lang-ver=<verb> ][ translator = ( TARGET_LANGUAGE | TRANSLATOR_NAME )] [ beautify=<verb> ]
                //[ verbosity=<verb> | log-verbosity=<verb> ][ logfile=LOG_PATH | log-file=LOG_PATH ] [ theme=<verb> ]
                else if (args[0].ToLower() == "parse-file")
                {
                    parseFile(args);
                }

                //DescribeCompilerCLI parse-folder PARSE_PATH RESULT_PATH
                //[ dsonly=<verb> ][ toponly=<verb> ][ onerror= ( stop | ignore )]
                //[ input-password=PASSWORD ][ output-password=PASSWORD ][ log-password=PASSWORD ]
                //[ language-version=<verb> | lang-ver=<verb> ][ translator = ( TARGET_LANGUAGE | TRANSLATOR_NAME )] [ beautify=<verb> ]
                //[ verbosity=<verb> | log-verbosity=<verb> ][ logfile=LOG_PATH | log-file=LOG_PATH ] [ theme=<verb> ]
                else if (args[0].ToLower() == "parse-folder")
                {
                    parseFolder(args);
                }

                //DescribeCompilerCLI parse-many PARSE_PATH RESULT_PATH
                //[ dsonly=<verb> ][ toponly=<verb> ][ onerror= ( stop | ignore )]
                //[ input-password=PASSWORD ][ output-password=PASSWORD ][ log-password=PASSWORD ]
                //[ language-version=<verb> | lang-ver=<verb> ][ translator = ( TARGET_LANGUAGE | TRANSLATOR_NAME )] [ beautify=<verb> ]
                //[ verbosity=<verb> | log-verbosity=<verb> ][ logfile=LOG_PATH | log-file=LOG_PATH ] [ theme=<verb> ]
                else if (args[0].ToLower() == "parse-many")
                {
                    Messages.printParseManyNotImplemented();
                }

                //DescribeCompilerCLI encrypt-file PLAIN_PATH ENCRYPTED_PATH [ theme=<verb> ]
                else if (args[0].ToLower() == "encrypt-file")
                {
                    encryptFile(args);
                }

                //DescribeCompilerCLI decrypt-file PLAIN_PATH ENCRYPTED_PATH [ theme=<verb> ]
                else if (args[0].ToLower() == "decrypt-file")
                {
                    decryptFile(args);
                }

                //DescribeCompilerCLI recrypt-file PLAIN_PATH ENCRYPTED_PATH [ theme=<verb> ]
                else if (args[0].ToLower() == "recrypt-file")
                {
                    recryptFile(args);
                }

                //DescribeCompilerCLI encrypt-folder PLAIN_PATH ENCRYPTED_PATH [ theme=<verb> ]
                else if (args[0].ToLower() == "encrypt-folder")
                {
                    encryptFolder(args);
                }

                //DescribeCompilerCLI decrypt-folder PLAIN_PATH ENCRYPTED_PATH [ theme=<verb> ]
                else if (args[0].ToLower() == "decrypt-folder")
                {
                    decryptFolder(args);
                }

                //DescribeCompilerCLI recrypt-folder PLAIN_PATH ENCRYPTED_PATH [ theme=<verb> ]
                else if (args[0].ToLower() == "recrypt-folder")
                {
                    recryptFolder(args);
                }

                //Unknown command
                else
                {
                    Messages.printArgumentError(args[0], 1);
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
                Messages.printFatalError(message, false);

                //save log to file
                if (Datnik.logToFile)
                {
                    if (Datnik.encryptLog == true)
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
                Console.Read();
            }
            finally
            {
                Messages.RevertConsoleColors();
            }
        }
        static void encryptFile(string[] args)
        {
            //read input output
            if (Arguments.readInputFileArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFileArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("password=") && cur.Length > "password=".Length)
                {
                    if (Arguments.readInputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(args[i], i, "what is this?");
                    return;
                }
            }

            //Encrypt
            MainFunctions.EncryptFile();
            Messages.ConsoleLog("--------------------------------------------------");
            Messages.printEncryptionSuccess(true);
        }
        static void decryptFile(string[] args)
        {
            //read input output
            if (Arguments.readInputFileArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFileArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("password=") && cur.Length > "password=".Length)
                {
                    if (Arguments.readInputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(args[i], i, "what is this?");
                    return;
                }
            }

            //Decrypt
            MainFunctions.DecryptFile();
            Messages.ConsoleLog("--------------------------------------------------");
            Messages.printEncryptionSuccess(true);
        }
        static void recryptFile(string[] args)
        {
            //read input output
            if (Arguments.readInputFileArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFileArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("input-password=") && cur.Length > "input-password=".Length)
                {
                    if (Arguments.readInputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("output-password=") && cur.Length > "output-password=".Length)
                {
                    if (Arguments.readOutputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(args[i], i, "what is this?");
                    return;
                }
            }

            //Recrypt
            MainFunctions.RecryptFile();
            Messages.ConsoleLog("--------------------------------------------------");
            Messages.printEncryptionSuccess(true);
        }
        static void encryptFolder(string[] args)
        {
            //read input output
            if (Arguments.readInputFolderArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFolderArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("password=") && cur.Length > "password=".Length)
                {
                    if (Arguments.readInputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(args[i], i, "what is this?");
                    return;
                }
            }

            //Encrypt
            MainFunctions.EncryptFolder();
            Messages.ConsoleLog("--------------------------------------------------");
            Messages.printEncryptionSuccess(true);
        }
        static void decryptFolder(string[] args)
        {
            //read input output
            if (Arguments.readInputFolderArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFolderArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("password=") && cur.Length > "password=".Length)
                {
                    if (Arguments.readInputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(args[i], i, "what is this?");
                    return;
                }
            }

            //Encrypt
            MainFunctions.DecryptFolder();
            Messages.ConsoleLog("--------------------------------------------------");
            Messages.printEncryptionSuccess(true);
        }
        static void recryptFolder(string[] args)
        {
            //read input output
            if (Arguments.readInputFolderArgument(args[1], 1) == false) return;
            if (Arguments.readOutputFolderArgument(args[2], 2) == false) return;

            //read other options
            for (int i = 3; i < args.Length; i++)
            {
                string cur = args[i].ToLower();

                if (cur.StartsWith("input-password=") && cur.Length > "input-password=".Length)
                {
                    if (Arguments.readInputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("output-password=") && cur.Length > "output-password=".Length)
                {
                    if (Arguments.readOutputPasswordArgument(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(args[i], i, "what is this?");
                    return;
                }
            }

            //Recrypt
            MainFunctions.RecryptFolder();
            Messages.ConsoleLog("--------------------------------------------------");
            Messages.printEncryptionSuccess(true);
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
                else if (cur.StartsWith("beautify=") && cur.Length > "beautify=".Length)
                {
                    if (Arguments.readBeautifyArgument(cur, i) == false) return;
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
                else if (cur.StartsWith("log-file=") && cur.Length > "log-file=".Length)
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
                else if (cur.StartsWith("lang-ver=") && cur.Length > "lang-ver=".Length)
                {
                    if (Arguments.readLanguageVersion(args[i], i) == false) return;
                }
                else if (cur.StartsWith("language-version=") && cur.Length > "language-version=".Length)
                {
                    if (Arguments.readLanguageVersion(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(args[i], i, "what is this?");
                    return;
                }
            }

            //Compile
            MainFunctions.Compile();
            Messages.ConsoleLog("--------------------------------------------------");
            Messages.printCompilationSuccess(false);

            //save log to file
            if (Datnik.logToFile)
            {
                if (Datnik.encryptLog == true)
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
            Console.Read();
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
                else if (cur.StartsWith("beautify=") && cur.Length > "beautify=".Length)
                {
                    if (Arguments.readBeautifyArgument(cur, i) == false) return;
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
                else if (cur.StartsWith("log-file=") && cur.Length > "log-file=".Length)
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
                else if (cur.StartsWith("lang-ver=") && cur.Length > "lang-ver=".Length)
                {
                    if (Arguments.readLanguageVersion(args[i], i) == false) return;
                }
                else if (cur.StartsWith("language-version=") && cur.Length > "language-version=".Length)
                {
                    if (Arguments.readLanguageVersion(args[i], i) == false) return;
                }
                else if (cur.StartsWith("theme="))
                {
                    continue;
                }
                else
                {
                    Messages.printArgumentError(cur, i, "what is this?");
                    return;
                }
            }

            //Compile
            MainFunctions.Compile();
            Messages.printCompilationSuccess(false);

            //save log to file
            if (Datnik.logToFile)
            {
                if (Datnik.encryptLog == true)
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
            Console.Read();
        }
    }
}
