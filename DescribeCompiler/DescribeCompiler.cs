using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;

namespace DescribeCompiler
{
    public enum LogVerbosity
    {
        Low,
        Medium,
        High,
    }
    
    public class DescribeCompiler
    {
        /// <summary>
        /// Get Compiler log
        /// </summary>
        public string Log
        {
            get;
            private set;
        }

        /// <summary>
        /// The logging verbosity level
        /// </summary>
        public LogVerbosity Verbosity
        {
            get
            {
                return logVerbosity;
            }
            set
            {
                logVerbosity = value;
            }
        }

        /// <summary>
        /// Add your method for logging info here
        /// </summary>
        public Action<string> LogInfo;

        /// <summary>
        /// Add your method for logging error here
        /// </summary>
        public Action<string> LogError;

        /// <summary>
        /// Add your method for logging text here
        /// </summary>
        public Action<string> LogText;

        /// <summary>
        /// Add your method for logging parser data here
        /// </summary>
        public Action<string> LogParserInfo;



        /// <summary>
        /// Get the name of the grammar that is currently loaded
        /// in the compiler and will be used for parsing
        /// </summary>
        public string LoadedGrammarName
        {
            get;
            private set;
        }



        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            LogVerbosity verbosity = LogVerbosity.High)
        {
            LogText = log;
            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            LogInfo("Initializing " + COMPILER_NAME);
            LoadedGrammarName = "";

            //init
            try
            {
                _GoldParser = new GoldParser.Parser.Parser();
                LogInfo("GOLD parser engine initialized");

                //set verbosity
                logVerbosity = verbosity;
                LogInfo("Verbosity set to: " + Verbosity.ToString());
            }
            catch (Exception ex)
            {
                LogError("Failed to initialize GOLD parser: " + ex.Message);
                return;
            }
            
            //preload default grammar
            try
            {
                string grammarname = GrammarNameToResourceName(DEFAULT_GRAMMAR);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(DEFAULT_GRAMMAR);
                if (LoadGrammar(grammar))
                {
                    LogInfo("Preloaded grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    LoadedGrammarName = fullname;
                }
                else
                {
                    LogInfo("Failed to preload grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    return;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to preload grammar: " + ex.Message);
                if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                return;
            }
            
            initialized = true;
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="logText">method to log text</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            Action<string> logText, 
            LogVerbosity verbosity = LogVerbosity.High)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            LogInfo("Initializing " + COMPILER_NAME);
            LoadedGrammarName = "";

            //init
            try
            {
                _GoldParser = new GoldParser.Parser.Parser();
                LogInfo("GOLD parser engine initialized");

                //set verbosity
                logVerbosity = verbosity;
                LogInfo("Verbosity set to: " + Verbosity.ToString());
            }
            catch (Exception ex)
            {
                LogError("Failed to initialize GOLD parser: " + ex.Message);
                return;
            }

            //preload default grammar
            try
            {
                string grammarname = GrammarNameToResourceName(DEFAULT_GRAMMAR);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(DEFAULT_GRAMMAR);
                if (LoadGrammar(grammar))
                {
                    LogInfo("Preloaded grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    LoadedGrammarName = fullname;
                }
                else
                {
                    LogInfo("Failed to preload grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    return;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to preload grammar: " + ex.Message);
                if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                return;
            }
            initialized = true;
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="logText">method to log text<</param>
        /// <param name="logError">method to log errors<</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            Action<string> logText, 
            Action<string> logError, 
            LogVerbosity verbosity = LogVerbosity.High)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogParserInfo = log;

            LogInfo("Initializing " + COMPILER_NAME);
            LoadedGrammarName = "";

            //init
            try
            {
                _GoldParser = new GoldParser.Parser.Parser();
                LogInfo("GOLD parser engine initialized");

                //set verbosity
                logVerbosity = verbosity;
                LogInfo("Verbosity set to: " + Verbosity.ToString());
            }
            catch (Exception ex)
            {
                LogError("Failed to initialize GOLD parser: " + ex.Message);
                return;
            }

            //preload default grammar
            try
            {
                string grammarname = GrammarNameToResourceName(DEFAULT_GRAMMAR);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(DEFAULT_GRAMMAR);
                if (LoadGrammar(grammar))
                {
                    LogInfo("Preloaded grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    LoadedGrammarName = fullname;
                }
                else
                {
                    LogInfo("Failed to preload grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    return;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to preload grammar: " + ex.Message);
                if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                return;
            }
            initialized = true;
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            Action<string> logText, 
            Action<string> logError, 
            Action<string> logInfo, 
            LogVerbosity verbosity = LogVerbosity.High)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogInfo += logInfo;

            LogParserInfo = log;

            LogInfo("Initializing " + COMPILER_NAME);
            LoadedGrammarName = "";

            //init
            try
            {
                _GoldParser = new GoldParser.Parser.Parser();
                LogInfo("GOLD parser engine initialized");

                //set verbosity
                logVerbosity = verbosity;
                LogInfo("Verbosity set to: " + Verbosity.ToString());
            }
            catch (Exception ex)
            {
                LogError("Failed to initialize GOLD parser: " + ex.Message);
                return;
            }

            //preload default grammar
            try
            {
                string grammarname = GrammarNameToResourceName(DEFAULT_GRAMMAR);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(DEFAULT_GRAMMAR);
                if (LoadGrammar(grammar))
                {
                    LogInfo("Preloaded grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    LoadedGrammarName = fullname;
                }
                else
                {
                    LogInfo("Failed to preload grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    return;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to preload grammar: " + ex.Message);
                if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                return;
            }
            initialized = true;
        }


        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        /// <param name="logParserInfo">method to log parser output</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            Action<string> logText, 
            Action<string> logError, 
            Action<string> logInfo, 
            Action<string> logParserInfo, 
            LogVerbosity verbosity = LogVerbosity.High)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogInfo += logInfo;

            LogParserInfo = log;
            LogParserInfo += logParserInfo;

            LogInfo("Initializing " + COMPILER_NAME);
            LoadedGrammarName = "";

            //init
            try
            {
                _GoldParser = new GoldParser.Parser.Parser();
                LogInfo("GOLD parser engine initialized");

                //set verbosity
                logVerbosity = verbosity;
                LogInfo("Verbosity set to: " + Verbosity.ToString());
            }
            catch (Exception ex)
            {
                LogError("Failed to initialize GOLD parser: " + ex.Message);
                return;
            }

            //preload default grammar
            try
            {
                string grammarname = GrammarNameToResourceName(DEFAULT_GRAMMAR);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(DEFAULT_GRAMMAR);
                if (LoadGrammar(grammar))
                {
                    LogInfo("Preloaded grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    LoadedGrammarName = fullname;
                }
                else
                {
                    LogInfo("Failed to preload grammar: \"" + fullname + "\"");
                    if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                    return;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to preload grammar: " + ex.Message);
                if (logVerbosity != LogVerbosity.High) LogText("------------------------");
                return;
            }
            initialized = true;
        }





        //wether to parse only .ds files, or all the files in a dir in ParseFolder op
        const bool PARSE_DS_ONLY = true;
        const bool PARSE_TOP_DIRECTORY_ONLY = false;


        /// <summary>
        /// Translate a folder of Describe source files ".ds" to a web page ".html"
        /// </summary>
        /// <param name="dirInfo">Represents the directory of files to be parsed.</param>
        /// <param name="html">The resulted HTML output.</param>
        /// <returns>true if successful, otherwise false.</returns>
        public bool ParseFolder(DirectoryInfo dirInfo, out string html)
        {
            html = null;
            fileCounter = 0;
            reductionCounter = 0;
            bool result = false;
            if (logVerbosity == LogVerbosity.Low)
            {
                result = ParseFolder_LowVerbosity(dirInfo, out html);
            }
            else if (logVerbosity == LogVerbosity.Medium)
            {
                result = ParseFolder_MediumVerbosity(dirInfo, out html);
            }
            else if (logVerbosity == LogVerbosity.High)
            {
                tokenCounter = 0;
                reductionCounter = 0;
                result = ParseFolder_HighVerbosity(dirInfo, out html);
            }
            return result;
        }


        bool ParseFolder_LowVerbosity(DirectoryInfo dirInfo, out string html)
        {
            html = null;

            //initial checks
            if (!initialized)
            {
                LogError("Parser not innitialized.");
                return false;
            }

            string msg = "\"" + dirInfo.FullName + "\" - ";
            if (!Directory.Exists(dirInfo.FullName))
            {
                msg += "does not exist!";
                LogError(msg);
                return false;
            }

            //fetch files
            DescribeUnfold unfold = new DescribeUnfold();
            try
            {
                SearchOption searchOption = SearchOption.AllDirectories;
                if (PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                string searchMask = "*.*";
                if (PARSE_DS_ONLY) searchMask = "*.ds";

                unfold.Files = Directory.GetFiles(dirInfo.FullName, searchMask, searchOption).ToList();
                if (unfold.Files.Count() == 0)
                {
                    msg += "directory is empty";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError(msg + " Failed to read the file contents: " + ex.Message);
                return false;
            }

            //parse files
            while (unfold.Files.Count() > 0)
            {
                string filename = unfold.Files[0];
                unfold.CurFile = filename;
                bool result = ParseFile_LowVerbosity(new FileInfo(filename), unfold);
                if (result)
                {
                    unfold.Files.RemoveAt(0);
                }
                else
                {
                    return false;
                }
            }

            // translate
            try
            {
                string output = Translations.TranslateUnfold(unfold);
                html = output;
                LogText(msg + "Ok");

                LogText("------------------------");
                LogInfo(fileCounter.ToString() + " files parsed.");
                LogInfo("Parser red " + tokenCounter.ToString() +
                    " tokens in " + reductionCounter.ToString() +
                    " reductions.");
                LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                    " productions, containing " + unfold.Translations.Count().ToString() +
                    " entries.");

                return true;
            }
            catch (Exception ex)
            {
                LogError(msg + "Failed to Translate the Unfold : " + ex.Message);
                return false;
            }
        }
        bool ParseFolder_MediumVerbosity(DirectoryInfo dirInfo, out string html)
        {
            html = null;

            //initial checks
            if (!initialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            LogText("------------------------");
            LogText("Starting a parse operation on folder: \"" + dirInfo.FullName + "\"");
            if (!Directory.Exists(dirInfo.FullName))
            {
                LogError("Error - the directory you are trying to parse does not exist");
                LogText("------------------------");
                return false;
            }

            //fetch files
            DescribeUnfold unfold = new DescribeUnfold();
            try
            {
                SearchOption searchOption = SearchOption.AllDirectories;
                if (PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                string searchMask = "*.*";
                if (PARSE_DS_ONLY) searchMask = "*.ds";

                unfold.Files = Directory.GetFiles(dirInfo.FullName, searchMask, searchOption).ToList();
                if (unfold.Files.Count() == 0)
                {
                    LogError("Error - the directory you are trying to parse contains no files that fit the criteria");
                    LogText("------------------------");
                    return false;
                }
                LogInfo("Fetched " + unfold.Files.Count() + " files");
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse files
            while (unfold.Files.Count() > 0)
            {
                string filename = unfold.Files[0];
                unfold.CurFile = filename;
                bool result = ParseFile_MediumVerbosity(new FileInfo(filename), unfold);
                if (result)
                {
                    unfold.Files.RemoveAt(0);
                }
                else
                {
                    return false;
                }
            }

            // translate
            try
            {
                string output = Translations.TranslateUnfold(unfold);
                html = output;

                LogText("Done!");
                LogText("------------------------");

                LogInfo(fileCounter.ToString() + " files parsed.");
                LogInfo("Parser red " + tokenCounter.ToString() +
                    " tokens in " + reductionCounter.ToString() +
                    " reductions.");
                LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                    " productions, containing " + unfold.Translations.Count().ToString() +
                    " entries.");

                return true;
            }
            catch (Exception ex)
            {
                LogError("Failed to Translate the Unfold : " + ex.Message);
                LogText("------------------------");
                return false;
            }
        }
        bool ParseFolder_HighVerbosity(DirectoryInfo dirInfo, out string html)
        {
            html = null;

            //initial checks
            if (!initialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            LogText("------------------------");
            LogText("Starting a parse operation on folder: \"" + dirInfo.FullName + "\"");
            if (!Directory.Exists(dirInfo.FullName))
            {
                LogError("Error - the directory you are trying to parse does not exist");
                LogText("------------------------");
                return false;
            }

            //fetch files
            DescribeUnfold unfold = new DescribeUnfold();
            try
            {
                SearchOption searchOption = SearchOption.AllDirectories;
                if (PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                string searchMask = "*.*";
                if (PARSE_DS_ONLY) searchMask = "*.ds";

                unfold.Files = Directory.GetFiles(dirInfo.FullName, searchMask, searchOption).ToList();
                if (unfold.Files.Count() == 0)
                {
                    LogError("Error - the directory you are trying to parse contains no files that fit the criteria");
                    LogText("------------------------");
                    return false;
                }
                LogInfo("Fetched " + unfold.Files.Count() + " files");
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse files
            while(unfold.Files.Count() > 0)
            {
                string filename = unfold.Files[0];
                unfold.CurFile = filename;
                bool result = ParseFile_HighVerbosity(new FileInfo(filename), unfold);
                if(result)
                {
                    unfold.Files.RemoveAt(0);
                }
                else
                {
                    return false;
                }
            }

            // translate
            try
            {
                string output = Translations.TranslateUnfold(unfold);
                html = output;

                LogParserInfo("Done!");
                LogText("------------------------");

                LogInfo(fileCounter.ToString() + " files parsed.");
                LogInfo("Parser red " + tokenCounter.ToString() +
                    " tokens in " + reductionCounter.ToString() +
                    " reductions.");
                LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                    " productions, containing " + unfold.Translations.Count().ToString() +
                    " entries.");

                return true;
            }
            catch (Exception ex)
            {
                LogError("Failed to Translate the Unfold : " + ex.Message);
                LogText("------------------------");
                return false;
            }
        }

        bool ParseFile_LowVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            fileCounter++;
            if (!initialized)
            {
                LogError("Parser not innitialized.");
                return false;
            }

            string msg = "\"" + fileInfo.FullName + "\" - ";
            if (!File.Exists(fileInfo.FullName))
            {
                msg += "does not exist!";
                LogError("msg");
                return false;
            }
            string source = "";
            try
            {
                source = File.ReadAllText(fileInfo.FullName);
                source = EncodeNonAsciiCharacters(source);
                if (source.Length == 0)
                {
                    msg += "file is empty!";
                    LogError(msg);
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    msg += "file is empty!";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                msg += "failed to read: " + ex.Message;
                LogError(msg);
                return false;
            }

            //parse
            StringReader reader = new StringReader(source);
            Reduction root = null;
            try
            {
                string message = "";
                bool result = Parse_HighVerbosity(reader, out root, out message);
                if (!result)
                {
                    msg += "failed to parse: " + message;
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                msg += "failed to parse: " + ex.Message;
                LogError(msg);
                return false;
            }
            finally
            {
                reader.Dispose();
            }

            //unfold
            try
            {
                bool optimized = Optimizations.DoScripture(unfold, root);
                if (optimized)
                {
                    msg += "Ok";
                    LogText(msg);
                }
                else
                {
                    msg += "failed to unfold tree.";
                    LogError(msg);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                msg += "failed to unfold tree: " + ex.Message;
                LogError(msg);
                return false;
            }

        }
        bool ParseFile_MediumVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            fileCounter++;
            if (!initialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            //LogText("------------------------");
            LogText("Starting a parse operation on file: \"" + fileInfo.FullName + "\"");
            if (!File.Exists(fileInfo.FullName))
            {
                LogError("Error - the file you are trying to parse does not exist");
                LogText("------------------------");
                return false;
            }
            string source = "";
            try
            {
                source = File.ReadAllText(fileInfo.FullName);
                source = EncodeNonAsciiCharacters(source);
                if (source.Length == 0)
                {
                    LogError("Error - the file you are trying to parse is empty");
                    LogText("------------------------");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    LogError("Error - the file you are trying to parse is only white space");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse
            StringReader reader = new StringReader(source);
            Reduction root = null;
            try
            {
                string message = "";
                bool result = Parse_HighVerbosity(reader, out root, out message);

                if (result)
                {
                    LogText("File parsed successfuly");
                }
                else
                {
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    string ugshdhdsshdjhjsdhshjsd = Log;
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to parse the file: " + ex.Message);
                LogText("------------------------");
                return false;
            }
            finally
            {
                reader.Dispose();
            }

            //unfold
            try
            {
                bool optimized = Optimizations.DoScripture(unfold, root);
                if(optimized)
                {
                    LogText("Parse tree unfolded successfuly");
                    LogParserInfo("Done!");
                    LogText("------------------------");
                    return true;
                }
                else
                {
                    LogError("Failed to Unfold the parse tree");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                return false;
            }

        }
        bool ParseFile_HighVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            fileCounter++;
            if (!initialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            LogText("------------------------");
            LogText("Starting a parse operation on file: \"" + fileInfo.FullName + "\"");
            if (!File.Exists(fileInfo.FullName))
            {
                LogError("Error - the file you are trying to parse does not exist");
                LogText("------------------------");
                return false;
            }
            string source = "";
            try
            {
                source = File.ReadAllText(fileInfo.FullName);
                source = EncodeNonAsciiCharacters(source);
                if (source.Length == 0)
                {
                    LogError("Error - the file you are trying to parse is empty");
                    LogText("------------------------");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    LogError("Error - the file you are trying to parse is only white space");
                    LogText("------------------------");
                    return false;
                }
                LogInfo("Fetched file contents - " + source.Length.ToString() + " characters long");
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse
            StringReader reader = new StringReader(source);
            Reduction root = null;
            try
            {
                string message = "";
                bool result = Parse_HighVerbosity(reader, out root, out message);

                if (result)
                {
                    LogParserInfo(Environment.NewLine + "Parsing sequence: " + message + Environment.NewLine);
                    LogText("File parsed successfuly");
                }
                else
                {
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    string ugshdhdsshdjhjsdhshjsd = Log;
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to parse the file: " + ex.Message);
                LogText("------------------------");
                return false;
            }
            finally
            {
                reader.Dispose();
            }

            //unfold
            try
            {
                bool optimized = Optimizations.DoScripture(unfold, root);
                if(optimized)
                {
                    LogText("Parse tree unfolded successfuly");
                    LogParserInfo("Done!");
                    LogText("------------------------");
                    return true;
                }
                else
                {
                    LogError("Failed to Unfold the parse tree");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                return false;
            }

        }

        bool Parse_LowVerbosity(TextReader reader, out Reduction root, out string FailMessage)
        {
            FailMessage = "";
            if (_GoldParser == null)
            {
                root = null;
                FailMessage = "Bug in the describe compiler - GOLD parser instance is null.";
                return false;
            }

            GoldParser.Parser.ParseMessage response;
            bool done = false;
            bool accepted = false;
            root = null;

            _GoldParser.Open(reader);
            _GoldParser.TrimReductions = false;

            while (!done)
            {
                response = _GoldParser.Parse();
                switch (response)
                {
                    case GoldParser.Parser.ParseMessage.LexicalError:
                        //Cannot recognize token
                        FailMessage = "Lexical Error:\n" +
                                      "Position: " + _GoldParser.CurrentPosition.Line + ", " + _GoldParser.CurrentPosition.Column + "\n" +
                                      "Read: " + _GoldParser.CurrentToken.Data;
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.SyntaxError:
                        //Expecting a different token

                        List<string> li = new List<string>();
                        foreach (GrammarSymbol s in _GoldParser.ExpectedSymbols) li.Add(s.ToString());

                        FailMessage = "Syntax Error:\n" +
                                      "Position: " + _GoldParser.CurrentPosition.Line + ", "
                                      + _GoldParser.CurrentPosition.Column + "\n" +
                                      "Read: \"" + _GoldParser.CurrentToken.Data + "\"\n" +
                                      "Expecting: " + String.Join(" ,", li);
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.Reduction:
                        //You don't have to do anything here.
                        break;

                    case GoldParser.Parser.ParseMessage.Accept:
                        //Accepted!
                        root = _GoldParser.CurrentReduction;    //The root node!
                        done = true;
                        accepted = true;
                        break;

                    case GoldParser.Parser.ParseMessage.TokenRead:
                        //You don't have to do anything here.
                        break;

                    case GoldParser.Parser.ParseMessage.InternalError:
                        //INTERNAL ERROR! Something is horribly wrong.
                        FailMessage = "INTERNAL ERROR! Something is horribly wrong";
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.NotLoadedError:
                        //This error occurs if the CGT was not loaded.                   
                        FailMessage = "Tables not loaded";
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.GroupError:
                        //GROUP ERROR! Unexpected end of file
                        FailMessage = "Runaway group";
                        done = true;
                        break;
                }
            }
            if (accepted) FailMessage = "Ok";
            return accepted;
        }
        bool Parse_MediumVerbosity(TextReader reader, out Reduction root, out string FailMessage)
        {
            FailMessage = "";
            if (_GoldParser == null)
            {
                root = null;
                FailMessage = "Bug in the describe compiler - GOLD parser instance is null.";
                return false;
            }

            GoldParser.Parser.ParseMessage response;
            bool done = false;
            bool accepted = false;
            root = null;

            _GoldParser.Open(reader);
            _GoldParser.TrimReductions = false;

            while (!done)
            {
                response = _GoldParser.Parse();
                switch (response)
                {
                    case GoldParser.Parser.ParseMessage.LexicalError:
                        //Cannot recognize token
                        FailMessage = "Lexical Error:\n" +
                                      "Position: " + _GoldParser.CurrentPosition.Line + ", " + _GoldParser.CurrentPosition.Column + "\n" +
                                      "Read: " + _GoldParser.CurrentToken.Data;
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.SyntaxError:
                        //Expecting a different token

                        List<string> li = new List<string>();
                        foreach (GrammarSymbol s in _GoldParser.ExpectedSymbols) li.Add(s.ToString());

                        FailMessage = "Syntax Error:\n" +
                                      "Position: " + _GoldParser.CurrentPosition.Line + ", "
                                      + _GoldParser.CurrentPosition.Column + "\n" +
                                      "Read: \"" + _GoldParser.CurrentToken.Data + "\"\n" +
                                      "Expecting: " + String.Join(" ,", li);
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.Reduction:
                        //You don't have to do anything here.
                        break;

                    case GoldParser.Parser.ParseMessage.Accept:
                        //Accepted!
                        root = _GoldParser.CurrentReduction;    //The root node!
                        done = true;
                        accepted = true;
                        break;

                    case GoldParser.Parser.ParseMessage.TokenRead:
                        //You don't have to do anything here.
                        break;

                    case GoldParser.Parser.ParseMessage.InternalError:
                        //INTERNAL ERROR! Something is horribly wrong.
                        FailMessage = "INTERNAL ERROR! Something is horribly wrong";
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.NotLoadedError:
                        //This error occurs if the CGT was not loaded.                   
                        FailMessage = "Tables not loaded";
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.GroupError:
                        //GROUP ERROR! Unexpected end of file
                        FailMessage = "Runaway group";
                        done = true;
                        break;
                }
            }
            if (accepted) FailMessage = "Accepted";
            return accepted;
        }
        bool Parse_HighVerbosity(TextReader reader, out Reduction root, out string Message)
        {
            if (_GoldParser == null)
            {
                root = null;
                Message = "Bug in the describe compiler - GOLD parser instance is null.";
                return false;
            }

            Message = "";
            GoldParser.Parser.ParseMessage response;
            bool done = false;
            bool accepted = false;
            root = null;

            _GoldParser.Open(reader);
            _GoldParser.TrimReductions = false;

            while (!done)
            {
                response = _GoldParser.Parse();
                switch (response)
                {
                    case GoldParser.Parser.ParseMessage.LexicalError:
                        //Cannot recognize token
                        if (Message != "") Message += " ";
                        Message += "Lexical Error:\n" +
                                      "Position: " + _GoldParser.CurrentPosition.Line + ", " + 
                                      _GoldParser.CurrentPosition.Column + "\n" +
                                      "Read: " + _GoldParser.CurrentToken.Data;
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.SyntaxError:
                        //Expecting a different token

                        List<string> li = new List<string>();
                        foreach (GrammarSymbol s in _GoldParser.ExpectedSymbols) li.Add(s.ToString());
                        
                        if (Message != "") Message += " ";
                        Message += "Syntax Error:\n" +
                                      "Position: " + _GoldParser.CurrentPosition.Line + ", "
                                      + _GoldParser.CurrentPosition.Column + "\n" +
                                      "Read: \"" + _GoldParser.CurrentToken.Data + "\"\n" +
                                      "Expecting: " + String.Join(" ,", li);
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.Reduction:
                        //You don't have to do anything here.
                        reductionCounter++;
                        if (Message != "") Message += " ";
                        Message += "R(" + _GoldParser.CurrentReduction.Production.Head.Name + ");";
                        break;

                    case GoldParser.Parser.ParseMessage.Accept:
                        //Accepted!
                        root = _GoldParser.CurrentReduction;    //The root node!
                        done = true;
                        accepted = true;
                        break;

                    case GoldParser.Parser.ParseMessage.TokenRead:
                        tokenCounter++;
                        //You don't have to do anything here.
                        if (Message != "") Message += " ";
                        Message += "T(" + _GoldParser.CurrentToken.Symbol.Name + ");";
                        break;

                    case GoldParser.Parser.ParseMessage.InternalError:
                        //INTERNAL ERROR! Something is horribly wrong.
                        if (Message != "") Message += " ";
                        Message += "INTERNAL ERROR! Something is horribly wrong;";
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.NotLoadedError:
                        //This error occurs if the CGT was not loaded.                   
                        if (Message != "") Message += " ";
                        Message += "Tables not loaded;";
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.GroupError:
                        //GROUP ERROR! Unexpected end of file
                        if (Message != "") Message += " ";
                        Message += "Runaway group;";
                        done = true;
                        break;
                }
            }

            if(accepted) Message += " Accepted;";
            return accepted;
        }



        //private methods
        /// <summary>
        /// Set different grammar version.
        /// </summary>
        /// <param name="grammarName">The enumerated name of the grammar to be loaded</param>
        /// <returns>true if successful, otherwise false</returns>
        bool ChangeGrammar(GrammarName grammarName)
        {
            try
            {
                string grammarname = GrammarNameToResourceName(grammarName);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(grammarName);
                if (LoadGrammar(grammar))
                {
                    LogInfo("Loaded new grammar: \"" + fullname + "\"");
                    return true;
                }
                else
                {
                    LogError("Failed to preload grammar: \"" + fullname + "\"");
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to load grammar: " + ex.Message);
                return false;
            }
        }
        bool LoadGrammar(byte[] grammar)
        {
            using (MemoryStream memory = new MemoryStream(grammar))
            {
                using (BinaryReader reader = new BinaryReader(memory))
                {
                    bool isLoaded = _GoldParser.LoadTables(reader);
                    return isLoaded;
                }
            }
        }
        enum GrammarName
        {
            Basic,                       //0.6
            Tags,                        //0.7
            Links,                       //0.8
            Decorators,                  //0.9
            Official,                    //1.0
        }
        string GrammarNameToFullGramarName(GrammarName name)
        {
            switch (name)
            {
                case GrammarName.Basic:
                    return "Basic v0.6";
                case GrammarName.Tags:
                    return "Tags v0.7";
                case GrammarName.Links:
                    return "Links v0.8";
                case GrammarName.Decorators:
                    return "Decorators v0.9";
                case GrammarName.Official:
                    return "Official v1.0";
                default:
                    return "Unknown";
            }
        }
        string GrammarNameToResourceName(GrammarName name)
        {
            switch (name)
            {
                case GrammarName.Basic:
                    return "DescribeBasics.egt";
                case GrammarName.Tags:
                    return "DescribeTags.egt";
                case GrammarName.Links:
                    return "DescribeLinks.egt";
                case GrammarName.Decorators:
                    return "DescribeDecorators.egt";
                case GrammarName.Official:
                    return "DescribeOfficial.egt";
                default:
                    return "Unknown";
            }
        }
        private void log(string text)
        {
            if (!string.IsNullOrEmpty(Log)) Log += Environment.NewLine;
            Log += text;
        }
        private string EncodeNonAsciiCharacters(string value)
        {
            //we add a character before and after that we will not use,
            //in order to skip if tests to see if we are not on the first or last char
            //for null reference. The new line we keep, as it is a workaround for the
            //runaway group last comment bug
            value = "." + value + Environment.NewLine;

            //https://stackoverflow.com/questions/1615559/convert-a-unicode-string-to-an-escaped-ascii-string
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < value.Length - 1; i++)
            {
                if (value[i] > 127)
                {
                    // This character is too big for ASCII
                    string encodedValue = "&#x" + ((int)value[i]).ToString("x4") + "\\;";
                    sb.Append(encodedValue);
                }
                else
                {
                    if (value[i] == '-' 
                       && value[i + 1] != '>' 
                       && value[i - 1] != '\\')
                    {
                        sb.Append('\\');
                    }
                    else if (value[i] == '*' 
                          && value[i + 1] != '/' 
                          && value[i - 1] != '\\')
                    {
                        sb.Append('\\');
                    }
                    else if (value[i] == '/'
                          && value[i + 1] != '/'
                          && value[i - 1] != '/'
                          && value[i + 1] != '*'
                          && value[i - 1] != '*'
                          && value[i - 1] != '\\')
                    {
                        sb.Append('\\');
                    }
                    else if (value[i] == '\\'
                          && value[i - 1] != '\\'
                          && value[i + 1] != '\\'
                          && value[i + 1] != '-'
                          && value[i + 1] != '*'
                          && value[i + 1] != '/'
                          && value[i + 1] != '<'
                          && value[i + 1] != '>'
                          && value[i + 1] != '['
                          && value[i + 1] != ']'
                          && value[i + 1] != '{'
                          && value[i + 1] != '}'
                          && value[i + 1] != ','
                          && value[i + 1] != ';')
                    {
                        sb.Append('\\');
                    }

                    sb.Append(value[i]);
                }
            }
            return sb.ToString();
        }


        //private guts
        private GoldParser.Parser.Parser _GoldParser; //the GOLD parser
        bool initialized = false; //if Ctor went wrong, we should not be allowed to continue
        LogVerbosity logVerbosity = LogVerbosity.High;
        int fileCounter = 0;
        int tokenCounter = 0;
        int reductionCounter = 0;


        //private const
        const string COMPILER_NAME = "D#SCRIBE COMPILER v1.0";
        const GrammarName DEFAULT_GRAMMAR = GrammarName.Decorators;
    }
}