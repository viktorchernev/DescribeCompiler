﻿using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Ast;
using DescribeParser;
using DescribeParser.Unfold;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        bool ParseFile_HighVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
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
            LogText("------------------------");
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
                if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the file you are trying to parse is empty");
                    LogText("------------------------");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
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
                    LogError("Error - the preprocessor returned only white spaces");
                    LogText("------------------------");
                    return false;
                }
                LogInfo("Fetched file contents - " + source.Length.ToString() + " characters long");
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
                bool result = parse_HighVerbosity(source, out root, out message);

                if (result)
                {
                    LogParserInfo(Environment.NewLine + "Parsing sequence: " + message + Environment.NewLine);
                    LogText("File parsed successfully");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    string ugshdhdsshdjhjsdhshjsd = Log;
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
        bool ParseFile_HighVerbosity(FileInfo fileInfo, out AstScriptureNode? rootNode)
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
            LogText("------------------------");
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
                if (source.Length == 0)
                {
                    _errorCounter++;
                    LogError("Error - the file you are trying to parse is empty");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
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
                    LogError("Error - the preprocessor returned only white spaces");
                    LogText("------------------------");
                    rootNode = null;
                    return false;
                }
                LogInfo("Fetched file contents - " + source.Length.ToString() + " characters long");
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
                bool result = parse_HighVerbosity(source, out root, out message);

                if (result)
                {
                    LogParserInfo(Environment.NewLine + "Parsing sequence: " + message + Environment.NewLine);
                    LogText("File parsed successfully");
                }
                else
                {
                    _errorCounter++;
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    string ugshdhdsshdjhjsdhshjsd = Log;
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


        bool ParseString_HighVerbosity(string source, DescribeUnfold unfold)
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
            LogText("------------------------");
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
                LogInfo("Preprocessed source code - " + source.Length.ToString() + " characters long");
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to read the source code contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_HighVerbosity(source, out root, out message);

                if (result)
                {
                    LogParserInfo(Environment.NewLine + "Parsing sequence: " + message + Environment.NewLine);
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
        bool ParseString_HighVerbosity(string source, IDescribeParseJob job, out AstScriptureNode? rootNode)
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
            LogText("------------------------");
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
                LogInfo("Preprocessed source code - " + source.Length.ToString() + " characters long");
            }
            catch (Exception ex)
            {
                _errorCounter++;
                LogError("Failed to read the source code contents: " + ex.Message);
                LogText("------------------------");
                rootNode = null;
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_HighVerbosity(source, out root, out message);

                if (result)
                {
                    LogParserInfo(Environment.NewLine + "Parsing sequence: " + message + Environment.NewLine);
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


        private bool parse_HighVerbosity(string source, out ParserRuleContext root, out string FailMessage)
        {
            _characterCounter += source.Length;
            switch (LanguageVersion)
            {
                case DescribeVersionNumber.Version06:
                    return parse_HighVerbosity06(source, out root, out FailMessage);
                case DescribeVersionNumber.Version07:
                    return parse_HighVerbosity07(source, out root, out FailMessage);
                case DescribeVersionNumber.Version08:
                    return parse_HighVerbosity08(source, out root, out FailMessage);
                case DescribeVersionNumber.Version09:
                    return parse_HighVerbosity09(source, out root, out FailMessage);
                case DescribeVersionNumber.Version10:
                    return parse_HighVerbosity10(source, out root, out FailMessage);
                case DescribeVersionNumber.Version11:
                    return parse_HighVerbosity11(source, out root, out FailMessage);

                default:
                    root = null;
                    FailMessage = "Unsupported language version - \"" + LanguageVersion.ToString() + "\"";
                    return false;
            }
        }
        private bool parse_HighVerbosity06(string source, out ParserRuleContext root, out string FailMessage)
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
                foreach (var token in tokenList)
                {
                    int tokenType = token.Type;
                    string tokenText = token.Text;
                    FailMessage += "T(" + GetTokenType06(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "') ";
                }

                Describe06Parser parser = new Describe06Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage += "Ok";
                root = scriptureContext;
                return true;
            }
            catch(Exception ex)
            {
                FailMessage += ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_HighVerbosity07(string source, out ParserRuleContext root, out string FailMessage)
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
                foreach (var token in tokenList)
                {
                    int tokenType = token.Type;
                    string tokenText = token.Text;
                    FailMessage += "T(" + GetTokenType07(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "') ";
                }

                Describe07Parser parser = new Describe07Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe07Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage += "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage += ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_HighVerbosity08(string source, out ParserRuleContext root, out string FailMessage)
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
                foreach (var token in tokenList)
                {
                    int tokenType = token.Type;
                    string tokenText = token.Text;
                    FailMessage += "T(" + GetTokenType08(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "') ";
                }

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage += "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage += ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_HighVerbosity09(string source, out ParserRuleContext root, out string FailMessage)
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
                foreach (var token in tokenList)
                {
                    int tokenType = token.Type;
                    string tokenText = token.Text;
                    FailMessage += "T(" + GetTokenType09(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "') ";
                }

                Describe09Parser parser = new Describe09Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe09Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage += "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage += ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_HighVerbosity10(string source, out ParserRuleContext root, out string FailMessage)
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
                foreach ( var token in tokenList)
                {
                    int tokenType = token.Type;
                    string tokenText = token.Text;
                    FailMessage += "T(" + GetTokenType10(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "') ";
                }

                Describe10Parser parser = new Describe10Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage += "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage += ex.Message;
                root = null;
                return false;
            }
        }
        private bool parse_HighVerbosity11(string source, out ParserRuleContext root, out string FailMessage)
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
                foreach (var token in tokenList)
                {
                    int tokenType = token.Type;
                    string tokenText = token.Text;
                    FailMessage += "T(" + GetTokenType11(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "') ";
                }

                Describe11Parser parser = new Describe11Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe11Parser.ScriptureContext scriptureContext = parser.scripture();
                if (scriptureContext.exception != null) throw scriptureContext.exception;

                //ParseInfo can provide insight into the parsing process
                //ParseInfo pinfo = parser.ParseInfo;

                FailMessage += "Ok";
                root = scriptureContext;
                return true;
            }
            catch (Exception ex)
            {
                FailMessage += ex.Message;
                root = null;
                return false;
            }
        }


        private string GetTokenType06(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        private string GetTokenType07(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe07Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        private string GetTokenType08(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe08Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        private string GetTokenType09(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe09Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        private string GetTokenType10(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe10Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        private string GetTokenType11(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe11Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        private string ReplaceWhitespaceE(string text)
        {
            return text.Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
    }
}
