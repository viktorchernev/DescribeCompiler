using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser;
using DescribeParser.Unfold;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        bool ParseFolder_MediumVerbosity(DirectoryInfo dirInfo, DescribeUnfold unfold)
        {
            //initial checks
            if (!isInitialized)
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
            try
            {
                SearchOption searchOption = SearchOption.AllDirectories;
                if (PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                string searchMask = "*.*";
                if (PARSE_DS_ONLY) searchMask = "*.ds";

                //unfold.InitialDir = dirInfo.FullName;
                unfold.AllFiles = Directory.GetFiles(dirInfo.FullName, searchMask, searchOption).ToList();
                if (unfold.AllFiles.Count() == 0)
                {
                    LogError("Error - the directory you are trying to parse contains no files that fit the criteria");
                    LogText("------------------------");
                    return false;
                }
                LogInfo("Fetched " + unfold.AllFiles.Count() + " files");
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse files
            while (unfold.AllFiles.Count() > 0)
            {
                string filename = unfold.AllFiles[0];
                unfold.ParseJob.LastFile = filename;
                bool result = parseFile_MediumVerbosity(new FileInfo(filename), unfold);
                if (result)
                {
                    unfold.ParsedFiles.Add(filename);
                    unfold.AllFiles.RemoveAt(0);
                }
                else
                {
                    unfold.FailedFiles.Add(filename);
                    if (STOP_ON_ERROR) return false;
                    else
                    {
                        unfold.AllFiles.RemoveAt(0);
                    }
                }
            }

            LogText("Done!");
            LogText("------------------------");

            LogInfo(FileCounter.ToString() + " files parsed.");
            LogInfo("Parser red " + TokenCounter.ToString() +
                " tokens in " + ReductionCounter.ToString() +
                " reductions.");
            LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                " productions, containing " + unfold.Translations.Count().ToString() +
                " entries.");
            return true;
        }
        bool ParseFile_MediumVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            //initial checks
            FileCounter++;
            if (!isInitialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }

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
                source = _Preprocessor.ProcessSource(source);
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
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(source, out root, out message);

                if (result)
                {
                    LogText("File parsed successfuly");
                }
                else
                {
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
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
                    LogText("Parse tree unfolded successfuly");
                    LogParserInfo("Done!");
                    LogText("------------------------");
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

            LogInfo(FileCounter.ToString() + " files parsed.");
            LogInfo("Parser red " + TokenCounter.ToString() +
                " tokens in " + ReductionCounter.ToString() +
                " reductions.");
            LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                " productions, containing " + unfold.Translations.Count().ToString() +
                " entries.");

            return true;
        }
        bool ParseMultiString_MediumVerbosity(List<KeyValuePair<string, string>> nameCodeList, DescribeUnfold unfold)
        {
            //initial checks
            if (!isInitialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            LogText("------------------------");
            LogText("Starting a parse operation on multiple strings.");

            //fetch files
            Dictionary<string, string> dict = new Dictionary<string, string>();
            try
            {
                if (nameCodeList.Count == 0)
                {
                    LogError("Error - the source code list you are trying to parse contains no source codes");
                    LogText("------------------------");
                    return false;
                }
                for (int i = 0; i < nameCodeList.Count; i++)
                {
                    unfold.AllFiles.Add(nameCodeList[i].Key);
                    dict.Add(nameCodeList[i].Key, nameCodeList[i].Value);
                }
                LogInfo("Fetched " + unfold.AllFiles.Count() + " files");
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file names: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse files
            while (unfold.AllFiles.Count() > 0)
            {
                string filename = unfold.AllFiles[0];
                unfold.ParseJob.LastFile = filename;
                bool result = parseString_MediumVerbosity(filename, dict[filename], unfold);
                if (result)
                {
                    unfold.ParsedFiles.Add(filename);
                    unfold.AllFiles.RemoveAt(0);
                }
                else
                {
                    unfold.FailedFiles.Add(filename);
                    if (STOP_ON_ERROR) return false;
                    else
                    {
                        unfold.AllFiles.RemoveAt(0);
                    }
                }
            }

            //log result
            LogText("Done!");
            LogText("------------------------");

            LogInfo(FileCounter.ToString() + " files parsed.");
            LogInfo("Parser red " + TokenCounter.ToString() +
                " tokens in " + ReductionCounter.ToString() +
                " reductions.");
            LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                " productions, containing " + unfold.Translations.Count().ToString() +
                " entries.");
            return true;
        }
        bool ParseString_MediumVerbosity(string source, string filename, DescribeUnfold unfold)
        {
            //initial checks
            if (!isInitialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }
            if (filename == null)
            {
                LogError("Null is not a valid filename.");
                return false;
            }
            if (string.IsNullOrEmpty(filename) || string.IsNullOrWhiteSpace(filename))
            {
                LogError("\"" + filename + "\" is not a valid filename.");
                return false;
            }

            LogText("Starting a parse operation on \"" + filename + "\"");
            try
            {
                source = _Preprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    LogError("Error - the source code you are trying to parse is empty");
                    LogText("------------------------");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    LogError("Error - the source code you are trying to parse is only white space");
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
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
                    LogText("Source code parsed successfuly");
                }
                else
                {
                    LogError("Failed to parse the source code: " + message);
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to parse the source code: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //unfold
            try
            {
                unfold.ParseJob.LastFile = filename;
                bool optimized = TranslateContext(unfold, root);
                if (optimized)
                {
                    LogText("Parse tree unfolded successfuly");
                    LogParserInfo("Done!");
                    LogText("------------------------");
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

            LogInfo("Parser red " + TokenCounter.ToString() +
                " tokens in " + ReductionCounter.ToString() +
                " reductions.");
            LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                " productions, containing " + unfold.Translations.Count().ToString() +
                " entries.");

            return true;
        }



        private bool parseString_MediumVerbosity(string filename, string source, DescribeUnfold unfold)
        {
            FileCounter++;
            if (!isInitialized)
            {
                LogError("This parser isn't innitialized, and cannot be used. Create a new instance.");
                return false;
            }

            //LogText("------------------------");
            LogText("Starting a parse operation on file: \"" + filename + "\"");
            string code = null;
            try
            {
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
                code = _Preprocessor.ProcessSource(source);
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(code, out root, out message);

                if (result)
                {
                    LogText("File parsed successfuly");
                }
                else
                {
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
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
        private bool parseFile_MediumVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            FileCounter++;
            if (!isInitialized)
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
                source = _Preprocessor.ProcessSource(source);
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
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(source, out root, out message);

                if (result)
                {
                    LogText("File parsed successfuly");
                }
                else
                {
                    LogError("Failed to parse the file: " + message);
                    LogText("------------------------");
                    return false;
                }
            }
            catch (Exception ex)
            {
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
        private bool parse_MediumVerbosity(string source, out ParserRuleContext root, out string FailMessage)
        {
            switch (LanguageVersion)
            {
                case DescribeVersion.Version06:
                    return parse_LowVerbosity06(source, out root, out FailMessage);
                case DescribeVersion.Version07:
                    return parse_LowVerbosity07(source, out root, out FailMessage);
                case DescribeVersion.Version08:
                    return parse_LowVerbosity08(source, out root, out FailMessage);
                case DescribeVersion.Version09:
                    return parse_LowVerbosity09(source, out root, out FailMessage);
                case DescribeVersion.Version10:
                    return parse_LowVerbosity10(source, out root, out FailMessage);
                case DescribeVersion.Version11:
                    return parse_LowVerbosity11(source, out root, out FailMessage);

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
                Describe06Parser parser = new Describe06Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
                ParseInfo pinfo = parser.ParseInfo;

                //deal with pinfo and return error messages
                //very important to do appropriate error handling here

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
                Describe07Parser parser = new Describe07Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe07Parser.ScriptureContext scriptureContext = parser.scripture();
                ParseInfo pinfo = parser.ParseInfo;

                //deal with pinfo and return error messages if needed

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
                Describe08Parser parser = new Describe08Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe08Parser.ScriptureContext scriptureContext = parser.scripture();
                ParseInfo pinfo = parser.ParseInfo;

                //deal with pinfo and return error messages if needed

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
                Describe09Parser parser = new Describe09Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe09Parser.ScriptureContext scriptureContext = parser.scripture();
                ParseInfo pinfo = parser.ParseInfo;

                //deal with pinfo and return error messages if needed

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
                Describe10Parser parser = new Describe10Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe10Parser.ScriptureContext scriptureContext = parser.scripture();
                ParseInfo pinfo = parser.ParseInfo;

                //deal with pinfo and return error messages if needed

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
                Describe11Parser parser = new Describe11Parser(tokenstream);
                parser.BuildParseTree = true;
                Describe11Parser.ScriptureContext scriptureContext = parser.scripture();
                ParseInfo pinfo = parser.ParseInfo;

                //deal with pinfo and return error messages if needed

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
