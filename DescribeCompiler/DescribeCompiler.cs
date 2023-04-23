using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;

namespace DescribeCompiler
{
    public enum GrammarName
    {
        Basic,                          //1.0
        Tags,                           //1.1
        Links,                          //1.2
        Decorators,                     //1.3
    }
    public enum LogVerbosity
    {
        Low,
        Medium,
        High,
    }
    
    public class DescribeCompiler
    {
        //public properties
        /// <summary>
        /// Get Compiler log
        /// </summary>
        public string Log
        {
            get;
            private set;
        }

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




        /// <summary>
        /// Set different grammar version.
        /// </summary>
        /// <param name="grammarName">The enumerated name of the grammar to be loaded</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ChageGrammar(GrammarName grammarName)
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

        /// <summary>
        /// Translate a Describe source file ".ds" to a web page ".html"
        /// </summary>
        /// <param name="fileInfo">Represents the file to be parsed</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFile(FileInfo fileInfo, out string html)
        {
            html = null;
            if(!initialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            if (logVerbosity == LogVerbosity.High)  LogText("------------------------");
            LogText("Starting a parse operation on: \"" + fileInfo.FullName + "\"");
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
                if(source.Length == 0)
                {
                    LogError("Error - the file you are trying to parse is empty");
                    LogText("------------------------");
                    return false;
                }
                else if(string.IsNullOrWhiteSpace(source))
                {
                    LogError("Error - the file you are trying to parse is only white space");
                    LogText("------------------------");
                    return false;
                }
                if(logVerbosity == LogVerbosity.High)
                {
                    LogInfo("Fetched file contents - " + source.Length.ToString() + " characters long");
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
                bool result = false;
                if (logVerbosity == LogVerbosity.Low)
                {
                    result = Parse_MediumVerbosity(reader, out root, out message);
                }
                else if (logVerbosity == LogVerbosity.Medium)
                {
                    result = Parse_MediumVerbosity(reader, out root, out message);
                }
                else
                {
                    result = Parse_HighVerbosity(reader, out root, out message);
                }
                
                if(result)
                {
                    if (logVerbosity == LogVerbosity.High)
                    {
                        LogParserInfo(Environment.NewLine + "Parsing sequence: " + message + Environment.NewLine);
                    }
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
            DescribeUnfold unfold = new DescribeUnfold();
            unfold.CurrentFolder = Path.GetDirectoryName(fileInfo.FullName);
            try
            {
                bool optimized = Optimizations.DoScripture(unfold, root);
                LogText("Parse tree unfolded successfuly");
            }
            catch (Exception ex)
            {
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse more files here
            if (unfold.Files.Contains(fileInfo.FullName))
            {
                unfold.Files.Remove(fileInfo.FullName);
            }
            if (logVerbosity != LogVerbosity.High && unfold.Files.Count > 0)
            {
                LogText("------------------------");
            }
            while (unfold.Files.Count > 0)
            {
                FileInfo nextFile = new FileInfo(unfold.Files[0]);

                unfold.CurrentFolder = Path.GetDirectoryName(nextFile.FullName);
                bool result = ParseFile(nextFile, unfold);
                unfold.Files.Remove(nextFile.FullName);
                if (result == false)
                {
                    return false;
                }
            }

            //translate
            try
            {
                string output = Translations.TranslateUnfold(unfold);
                html = output;
                if (logVerbosity == LogVerbosity.Medium)
                {
                    LogParserInfo("Done!");
                }
                else
                {
                    LogText("Unfold translated successfuly");
                    LogText("Done!");
                }
                LogText("------------------------");
                return true;
            }
            catch (Exception ex)
            {
                LogError("Failed to Translate the Unfold : " + ex.Message);
                LogText("------------------------");
                return false;
            }
        }
        bool ParseFile(FileInfo fileInfo, DescribeUnfold unfold)
        {
            if (!initialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            if (logVerbosity == LogVerbosity.High) LogText("------------------------");
            LogText("Starting a parse operation on: \"" + fileInfo.FullName + "\"");
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
                if (logVerbosity == LogVerbosity.High)
                {
                    LogInfo("Fetched file contents - " + source.Length.ToString() + " characters long");
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
                bool result = false;
                if (logVerbosity == LogVerbosity.Low)
                {
                    result = Parse_MediumVerbosity(reader, out root, out message);
                }
                else if (logVerbosity == LogVerbosity.Medium)
                {
                    result = Parse_MediumVerbosity(reader, out root, out message);
                }
                else
                {
                    result = Parse_HighVerbosity(reader, out root, out message);
                }

                if (result)
                {
                    if (logVerbosity == LogVerbosity.High)
                    {
                        LogParserInfo(Environment.NewLine + "Parsing sequence: " + message + Environment.NewLine);
                    }
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
                bool optimized = Optimizations.DoScripture(unfold, root, false);
                LogText("Parse tree unfolded successfuly");
                if (logVerbosity == LogVerbosity.Medium)
                {
                    LogParserInfo("Done!");
                }
                else
                {
                    LogText("Done!");
                }
                LogText("------------------------");
                return true;
            }
            catch (Exception ex)
            {
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                return false;
            }

        }
        bool Parse_MediumVerbosity(TextReader reader, out Reduction root, out string FailMessage)
        {
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
            else FailMessage = "Failed";
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
        string GrammarNameToFullGramarName(GrammarName name)
        {
            switch (name)
            {
                case GrammarName.Basic:
                    return "Basic v1.0";
                case GrammarName.Tags:
                    return "Tags v1.1";
                case GrammarName.Links:
                    return "Links v1.2";
                case GrammarName.Decorators:
                    return "Decorators v1.3";
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
                default:
                    return "Unknown";
            }
        }
        private void log(string text)
        {
            if (!string.IsNullOrEmpty(Log)) Log += Environment.NewLine;
            Log += text;
        }

        //private guts
        private GoldParser.Parser.Parser _GoldParser; //the GOLD parser
        bool initialized = false; //if Ctor went wrong, we should not be allowed to continue
        LogVerbosity logVerbosity = LogVerbosity.High;

        //private const
        const string COMPILER_NAME = "D#SCRIBE COMPILER v1.0";
        const GrammarName DEFAULT_GRAMMAR = GrammarName.Decorators;
    }
}


//1. Load grammar
//A grammar is loaded by default, so we don't need to do anything if we don't like to
//use another one of the embedded grammar files. The last version needs to be used -
//older versions are mostly for test purposes.