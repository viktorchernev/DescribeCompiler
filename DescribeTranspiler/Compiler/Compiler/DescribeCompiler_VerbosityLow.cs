using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser;
using DescribeParser.Ast;
using DescribeParser.Unfold;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        bool ParseFile_LowVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            //get initial counts
            int initialProductionsCount = unfold.Productions.Count();
            int initialTranslationsCount = unfold.Translations.Count();
            softResetStatistics();

            //initial checks
            if (!_isInitialized)
            {
                _errorCounter++;
                LogError("Parser not innitialized.");
                return false;
            }

            string msg = "\"" + fileInfo.FullName + "\" - ";
            if (!File.Exists(fileInfo.FullName))
            {
                _errorCounter++;
                msg += "does not exist!";
                LogError("msg");
                return false;
            }
            string source = "";
            try
            {
                source = File.ReadAllText(fileInfo.FullName);
                if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    msg += "source code is empty!";
                    LogError(msg);
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "source code is empty!";
                    LogError(msg);
                    return false;
                }
                source = CurrentPreprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "file is empty!";
                    LogError(msg);
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    msg += "file is empty!";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to read: " + ex.Message;
                LogError(msg);
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_LowVerbosity(source, out root, out message);
                if (!result)
                {
                    _errorCounter++;
                    msg += "failed to parse: " + message;
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to parse: " + ex.Message;
                LogError(msg);
                return false;
            }

            //unfold
            try
            {
                bool optimized = TranslateContext(unfold, root);
                if (!optimized)
                {
                    _errorCounter++;
                    msg += "failed to unfold tree.";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to unfold tree: " + ex.Message;
                LogError(msg);
                return false;
            }

            LogText(msg + "parsed successfully");
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
        bool ParseFile_LowVerbosity(FileInfo fileInfo, out AstScriptureNode? rootNode)
        {
            string? filename = fileInfo.FullName;
            softResetStatistics();

            //initial checks
            if (!_isInitialized)
            {
                _errorCounter++;
                LogError("Parser not innitialized.");
                rootNode = null;
                return false;
            }

            string msg = "\"" + fileInfo.FullName + "\" - ";
            if (!File.Exists(fileInfo.FullName))
            {
                _errorCounter++;
                msg += "does not exist!";
                LogError("msg");
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
                    msg += "source code is empty!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "source code is empty!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
                source = CurrentPreprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "file is empty!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    msg += "file is empty!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to read: " + ex.Message;
                LogError(msg);
                rootNode = null;
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_LowVerbosity(source, out root, out message);
                if (!result)
                {
                    _errorCounter++;
                    msg += "failed to parse: " + message;
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to parse: " + ex.Message;
                LogError(msg);
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
                    msg += "failed to unfold tree.";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to unfold tree: " + ex.Message;
                LogError(msg);
                rootNode = null;
                return false;
            }

            LogText(msg + "parsed successfully");
            LogInfo("Parser red " + _characterCounter.ToString() + " characters, into "
                + _tokenCounter.ToString() + " tokens.");
            // This when we implement statistics in the parser's visitors
            // + _tokenCounter.ToString() + " tokens in " 
            // + _reductionCounter.ToString() + " reductions.");
            LogInfo("Those were translated to an AST.");
            return true;
        }


        bool ParseString_LowVerbosity(string source, DescribeUnfold unfold)
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
                LogError("Parser not innitialized.");
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
                LogError("Invalid filename.");
                return false;
            }

            string msg = filename + " - ";
            try
            {
                if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    msg += "source code is empty!";
                    LogError(msg);
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "source code is empty!";
                    LogError(msg);
                    return false;
                }
                source = CurrentPreprocessor.ProcessSource(source);
                if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    msg += "failed to preprocess source code!";
                    LogError(msg);
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "failed to preprocess source code!";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to preprocess source code: " + ex.Message;
                LogError(msg);
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_LowVerbosity(source, out root, out message);
                if (!result)
                {
                    _errorCounter++;
                    msg += "failed to parse: " + message;
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to parse: " + ex.Message;
                LogError(msg);
                return false;
            }

            //unfold
            try
            {
                bool optimized = TranslateContext(unfold, root);
                if (!optimized)
                {
                    _errorCounter++;
                    msg += "failed to unfold tree.";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to unfold tree: " + ex.Message;
                LogError(msg);
                return false;
            }

            LogText(msg + "parsed successfully");
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
        bool ParseString_LowVerbosity(string source, IDescribeParseJob job, out AstScriptureNode? rootNode)
        {
            string? filename = job.LastFile;
            softResetStatistics();

            //initial checks
            if (!_isInitialized)
            {
                _errorCounter++;
                LogError("Parser not innitialized.");
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
                LogError("Invalid filename.");
                rootNode = null;
                return false;
            }

            string msg = filename + " - ";
            try
            {
                if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    msg += "source code is empty!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "source code is empty!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
                source = CurrentPreprocessor.ProcessSource(source);
                if (string.IsNullOrWhiteSpace(source))
                {
                    _errorCounter++;
                    msg += "failed to preprocess source code!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
                else if (source.Length == 0)
                {
                    _errorCounter++;
                    msg += "failed to preprocess source code!";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to preprocess source code: " + ex.Message;
                LogError(msg);
                rootNode = null;
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_LowVerbosity(source, out root, out message);
                if (!result)
                {
                    _errorCounter++;
                    msg += "failed to parse: " + message;
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to parse: " + ex.Message;
                LogError(msg);
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
                    msg += "failed to unfold tree.";
                    LogError(msg);
                    rootNode = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                _errorCounter++;
                msg += "failed to unfold tree: " + ex.Message;
                LogError(msg);
                rootNode = null;
                return false;
            }

            LogText(msg + "parsed successfully");
            LogInfo("Parser red " + _characterCounter.ToString() + " characters, into "
                + _tokenCounter.ToString() + " tokens.");
                // This when we implement statistics in the parser's visitors
                // + _tokenCounter.ToString() + " tokens in " 
                // + _reductionCounter.ToString() + " reductions.");
            LogInfo("Those were translated to an AST.");
            return true;
        }


        private bool parse_LowVerbosity(string source, out ParserRuleContext root, out string FailMessage)
        {
            _characterCounter += source.Length;
            switch (LanguageVersion)
            {
                case DescribeVersionNumber.Version06:
                    return parse_LowVerbosity06(source, out root, out FailMessage);
                case DescribeVersionNumber.Version07:
                    return parse_LowVerbosity07(source, out root, out FailMessage);
                case DescribeVersionNumber.Version08:
                    return parse_LowVerbosity08(source, out root, out FailMessage);
                case DescribeVersionNumber.Version09:
                    return parse_LowVerbosity09(source, out root, out FailMessage);
                case DescribeVersionNumber.Version10:
                    return parse_LowVerbosity10(source, out root, out FailMessage);
                case DescribeVersionNumber.Version11:
                    return parse_LowVerbosity11(source, out root, out FailMessage);

                default:
                    root = null;
                    FailMessage = "Unsupported language version - \"" + LanguageVersion.ToString() + "\"";
                    return false;
            }
        }
        private bool parse_LowVerbosity06(string source, out ParserRuleContext root, out string FailMessage)
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
            catch(Exception ex)
            {
                FailMessage = ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_LowVerbosity07(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity08(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity09(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity10(string source, out ParserRuleContext root, out string FailMessage)
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
                //parser.BuildParseTree = true;

                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                if(scriptureContext.exception != null) throw scriptureContext.exception;
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
        private bool parse_LowVerbosity11(string source, out ParserRuleContext root, out string FailMessage)
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


        bool TranslateContext(DescribeUnfold u, ParserRuleContext context)
        {
            switch (LanguageVersion)
            {
                case DescribeVersionNumber.Version06:
                    return UnfoldVisitor.TranslateContext06(u, context, u.ParseJob.LastFile);
                case DescribeVersionNumber.Version07:
                    return UnfoldVisitor.TranslateContext07(u, context, u.ParseJob.LastFile);
                case DescribeVersionNumber.Version08:
                    return UnfoldVisitor.TranslateContext08(u, context, u.ParseJob.LastFile);
                case DescribeVersionNumber.Version09:
                    return UnfoldVisitor.TranslateContext09(u, context, u.ParseJob.LastFile);
                case DescribeVersionNumber.Version10:
                    return UnfoldVisitor.TranslateContext10(u, context, u.ParseJob.LastFile);
                case DescribeVersionNumber.Version11:
                    return UnfoldVisitor.TranslateContext11(u, context, u.ParseJob.LastFile);
                default:
                    return false;
            }
        }
        AstScriptureNode? TranslateContext(ParserRuleContext context, string filename)
        {
            switch (LanguageVersion)
            {
                case DescribeVersionNumber.Version06:
                    return AstVisitor.TranslateContext06(context, filename);
                case DescribeVersionNumber.Version07:
                    return AstVisitor.TranslateContext07(context, filename);
                case DescribeVersionNumber.Version08:
                    return AstVisitor.TranslateContext08(context, filename);
                case DescribeVersionNumber.Version09:
                    return AstVisitor.TranslateContext09(context, filename);
                case DescribeVersionNumber.Version10:
                    return AstVisitor.TranslateContext10(context, filename);
                case DescribeVersionNumber.Version11:
                    return AstVisitor.TranslateContext11(context, filename);
                default:
                    return null;
            }
        }
    }
}
