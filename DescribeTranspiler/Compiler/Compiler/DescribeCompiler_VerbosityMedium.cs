using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Ast;
using DescribeParser;
using DescribeParser.Unfold;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        bool ParseFile_MediumVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            //get initial counts
            int initialProductionsCount = unfold.Productions.Count();
            int initialTranslationsCount = unfold.Translations.Count();
            softResetStatistics();

            //initial checks
            if (!_isInitialized)
            {
                _errorCounter++;
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }

            LogText("Starting a parse operation on file: \"" + fileInfo.FullName + "\"");
            if (!File.Exists(fileInfo.FullName))
            {
                _errorCounter++;
                LogError("Error - the file you are trying to parse does not exist");
                LogText("------------------------");
                return false;
            }
            string source = "";
            try
            {
                source = File.ReadAllText(fileInfo.FullName);
                if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    LogError("Error - the file you are trying to parse is empty");
                    LogText("------------------------");
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the file you are trying to parse is only white space");
                    LogText("------------------------");
                    return false;
                }
                source = CurrentPreprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the preprocessor returned empty string");
                    LogText("------------------------");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    LogError("Error - the preprocessor returned only whitespace");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(source, out root, out message);

                if (result)
                {
                    LogText("File parsed successfully");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to parse the file: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //unfold
            try
            {
                bool optimized = TranslateContext(unfold, root);
                if (optimized)
                {
                    LogText("Parse tree unfolded successfully");
                    LogParserInfo("Done!");
                    LogText("------------------------");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to Unfold the parse tree");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                return false;
            }

            LogText("File parsed successfully");
            LogInfo("Parser red " + _characterCounter.ToString() + " characters, into "
                + _tokenCounter.ToString() + " tokens.");
            // This when we implement statistics in the parser's visitors
            // + _tokenCounter.ToString() + " tokens in " 
            // + _reductionCounter.ToString() + " reductions.");
            LogInfo("Those were translated to " + (unfold.Productions.Count() - initialProductionsCount).ToString() +
                " productions, containing " + (unfold.Translations.Count() - initialTranslationsCount).ToString() +
                " entries.");
            return true;
        }
        bool ParseFile_MediumVerbosity(FileInfo fileInfo, out AstScriptureNode? rootNode)
        {
            string? filename = fileInfo.FullName;
            softResetStatistics();

            //initial checks
            if (!_isInitialized)
            {
                _errorCounter++;
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                rootNode = null;
                return false;
            }

            LogText("Starting a parse operation on file: \"" + fileInfo.FullName + "\"");
            if (!File.Exists(fileInfo.FullName))
            {
                _errorCounter++;
                LogError("Error - the file you are trying to parse does not exist");
                LogText("------------------------");
                rootNode = null;
                return false;
            }
            string source = "";
            try
            {
                source = File.ReadAllText(fileInfo.FullName);
                if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    LogError("Error - the file you are trying to parse is empty");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the file you are trying to parse is only white space");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
                source = CurrentPreprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the preprocessor returned empty string");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    LogError("Error - the preprocessor returned only whitespace");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                rootNode = null;
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(source, out root, out message);

                if (result)
                {
                    LogText("File parsed successfully");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to parse the file: " + ex.Message);
                LogText("------------------------");
                rootNode = null;
                return false;
            }

            //unfold
            try
            {
                AstScriptureNode? scriptureNode = TranslateContext(root, filename);
                rootNode = scriptureNode;
                if (scriptureNode == null)
                {
                    _errorCounter++;
                    LogText("Failed to Unfold the parse tree");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                rootNode = null;
                return false;
            }

            LogInfo("Parser red " + _characterCounter.ToString() + " characters, into "
                + _tokenCounter.ToString() + " tokens.");
            // This when we implement statistics in the parser's visitors
            // + _tokenCounter.ToString() + " tokens in " 
            // + _reductionCounter.ToString() + " reductions.");
            LogInfo("Those were translated to an AST.");
            return true;
        }


        bool ParseString_MediumVerbosity(string source, DescribeUnfold unfold)
        {
            string? filename = unfold.ParseJob.LastFile;
            softResetStatistics();

            //get initial counts
            int initialProductionsCount = unfold.Productions.Count();
            int initialTranslationsCount = unfold.Translations.Count();

            //initial checks
            if (!_isInitialized)
            {
                _errorCounter++;
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            if (filename == null)
            {
                _errorCounter++;
                LogError("Null is not a valid filename.");
                return false;
            }
            if (string.IsNullOrEmpty(filename) || string.IsNullOrWhiteSpace(filename))
            {
                _errorCounter++;
                LogError("\"" + filename + "\" is not a valid filename.");
                return false;
            }

            LogText("Starting a parse operation on \"" + filename + "\"");
            try
            {
                source = CurrentPreprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the source code you are trying to parse is empty");
                    LogText("------------------------");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    LogError("Error - the source code you are trying to parse is only white space");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to read the source code: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(source, out root, out message);

                if (result)
                {
                    LogText("Source code parsed successfully");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to parse the source code: " + message);
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to parse the source code: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //unfold
            try
            {
                bool optimized = TranslateContext(unfold, root);
                if (optimized)
                {
                    LogText("Parse tree unfolded successfully");
                    LogParserInfo("Done!");
                    LogText("------------------------");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to Unfold the parse tree");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                return false;
            }


            LogInfo("Parser red " + _characterCounter.ToString() + " characters, into "
                + _tokenCounter.ToString() + " tokens.");
            // This when we implement statistics in the parser's visitors
            // + _tokenCounter.ToString() + " tokens in " 
            // + _reductionCounter.ToString() + " reductions.");
            LogInfo("Those were translated to " + (unfold.Productions.Count() - initialProductionsCount).ToString() +
                " productions, containing " + (unfold.Translations.Count() - initialTranslationsCount).ToString() +
                " entries.");

            return true;
        }
        bool ParseString_MediumVerbosity(string source, IDescribeParseJob job, out AstScriptureNode? rootNode)
        {
            string? filename = job.LastFile;
            softResetStatistics();

            //initial checks
            if (!_isInitialized)
            {
                _errorCounter++;
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                rootNode = null;
                return false;
            }
            if (filename == null)
            {
                _errorCounter++;
                LogError("Null is not a valid filename.");
                rootNode = null;
                return false;
            }
            if (string.IsNullOrEmpty(filename) || string.IsNullOrWhiteSpace(filename))
            {
                _errorCounter++;
                LogError("\"" + filename + "\" is not a valid filename.");
                rootNode = null;
                return false;
            }

            LogText("Starting a parse operation on \"" + filename + "\"");
            try
            {
                source = CurrentPreprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the source code you are trying to parse is empty");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    LogError("Error - the source code you are trying to parse is only white space");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to read the source code: " + ex.Message);
                LogText("------------------------");
                rootNode = null;
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(source, out root, out message);

                if (result)
                {
                    LogText("Source code parsed successfully");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to parse the source code: " + message);
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to parse the source code: " + ex.Message);
                LogText("------------------------");
                rootNode = null;
                return false;
            }

            //unfold
            try
            {
                AstScriptureNode? scriptureNode = TranslateContext(root, filename);
                rootNode = scriptureNode;
                if (scriptureNode != null)
                {
                    LogText("Parse tree unfolded successfully");
                    LogParserInfo("Done!");
                    LogText("------------------------");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to Unfold the parse tree");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to Unfold the parse tree : " + ex.Message);
                LogText("------------------------");
                rootNode = null;
                return false;
            }


            LogInfo("Parser red " + _characterCounter.ToString() + " characters, into "
                + _tokenCounter.ToString() + " tokens.");
            // This when we implement statistics in the parser's visitors
            // + _tokenCounter.ToString() + " tokens in " 
            // + _reductionCounter.ToString() + " reductions.");
            LogInfo("Those were translated to an AST.");
            return true;
        }


        private bool parse_MediumVerbosity(string source, out ParserRuleContext root, out string FailMessage)
        {
            _characterCounter += source.Length;
            switch (LanguageVersion)
            {
                case DescribeVersionNumber.Version06:
                    return parse_MediumVerbosity06(source, out root, out FailMessage);
                case DescribeVersionNumber.Version07:
                    return parse_MediumVerbosity07(source, out root, out FailMessage);
                case DescribeVersionNumber.Version08:
                    return parse_MediumVerbosity08(source, out root, out FailMessage);
                case DescribeVersionNumber.Version09:
                    return parse_MediumVerbosity09(source, out root, out FailMessage);
                case DescribeVersionNumber.Version10:
                    return parse_MediumVerbosity10(source, out root, out FailMessage);
                case DescribeVersionNumber.Version11:
                    return parse_MediumVerbosity11(source, out root, out FailMessage);

                default:
                    root = null;
                    FailMessage = "Unsupported language version - \"" + LanguageVersion.ToString() + "\"";
                    return false;
            }
        }
        private bool parse_MediumVerbosity06(string source, out ParserRuleContext root, out string FailMessage)
        {
            FailMessage = "";
            try
            {
                AntlrInputStream inputstream = new AntlrInputStream(source);
                Describe06Lexer lexer = new Describe06Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);

                // we need this hack before we have implemented
                // statistics in the Parser's visitor classes.
                tokenstream.Fill();
                var tokenList = tokenstream.GetTokens();
                _tokenCounter = tokenList.Count;

                Describe06Parser parser = new Describe06Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage = "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage = ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_MediumVerbosity07(string source, out ParserRuleContext root, out string FailMessage)
        {
            FailMessage = "";
            try
            {
                AntlrInputStream inputstream = new AntlrInputStream(source);
                Describe07Lexer lexer = new Describe07Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);

                // we need this hack before we have implemented
                // statistics in the Parser's visitor classes.
                tokenstream.Fill();
                var tokenList = tokenstream.GetTokens();
                _tokenCounter = tokenList.Count;

                Describe07Parser parser = new Describe07Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe07Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage = "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage = ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_MediumVerbosity08(string source, out ParserRuleContext root, out string FailMessage)
        {
            FailMessage = "";
            try
            {
                AntlrInputStream inputstream = new AntlrInputStream(source);
                Describe08Lexer lexer = new Describe08Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);

                // we need this hack before we have implemented
                // statistics in the Parser's visitor classes.
                tokenstream.Fill();
                var tokenList = tokenstream.GetTokens();
                _tokenCounter = tokenList.Count;

                Describe08Parser parser = new Describe08Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe08Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage = "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage = ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_MediumVerbosity09(string source, out ParserRuleContext root, out string FailMessage)
        {
            FailMessage = "";
            try
            {
                AntlrInputStream inputstream = new AntlrInputStream(source);
                Describe09Lexer lexer = new Describe09Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);

                // we need this hack before we have implemented
                // statistics in the Parser's visitor classes.
                tokenstream.Fill();
                var tokenList = tokenstream.GetTokens();
                _tokenCounter = tokenList.Count;

                Describe09Parser parser = new Describe09Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe09Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage = "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage = ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_MediumVerbosity10(string source, out ParserRuleContext root, out string FailMessage)
        {
            FailMessage = "";
            try
            {
                AntlrInputStream inputstream = new AntlrInputStream(source);
                Describe10Lexer lexer = new Describe10Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);

                // we need this hack before we have implemented
                // statistics in the Parser's visitor classes.
                tokenstream.Fill();
                var tokenList = tokenstream.GetTokens();
                _tokenCounter = tokenList.Count;

                Describe10Parser parser = new Describe10Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage = "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage = ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_MediumVerbosity11(string source, out ParserRuleContext root, out string FailMessage)
        {
            FailMessage = "";
            try
            {
                AntlrInputStream inputstream = new AntlrInputStream(source);
                Describe11Lexer lexer = new Describe11Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);

                // we need this hack before we have implemented
                // statistics in the Parser's visitor classes.
                tokenstream.Fill();
                var tokenList = tokenstream.GetTokens();
                _tokenCounter = tokenList.Count;

                Describe11Parser parser = new Describe11Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe11Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage = "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage = ex.Message;
                root = null;
                return false;
            }
        }
    }
}
