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
        bool ParseFolder_LowVerbosity(DirectoryInfo dirInfo, DescribeUnfold unfold)
        {
            //initial checks
            if (!isInitialized)
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
            while (unfold.AllFiles.Count() > 0)
            {
                string filename = unfold.AllFiles[0];
                unfold.ParseJob.LastFile = filename;
                bool result = parseFile_LowVerbosity(new FileInfo(filename), unfold);
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

            LogText(msg + "Ok");

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
        bool ParseFile_LowVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            //initial checks
            FileCounter++;
            if (!isInitialized)
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
                source = _Preprocessor.ProcessSource(source);
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
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_LowVerbosity(source, out root, out message);
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

            //unfold
            try
            {
                bool optimized = TranslateContext(unfold, root);
                if (!optimized)
                {
                    msg += "failed to unfold tree.";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                msg += "failed to unfold tree: " + ex.Message;
                LogError(msg);
                return false;
            }

            LogText(msg + "parsed successfuly");
            LogInfo(FileCounter.ToString() + " files parsed.");
            LogInfo("Parser red " + TokenCounter.ToString() +
                " tokens in " + ReductionCounter.ToString() +
                " reductions.");
            LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                " productions, containing " + unfold.Translations.Count().ToString() +
                " entries.");
            return true;
        }
        bool ParseMultiString_LowVerbosity(List<KeyValuePair<string, string>> nameCodeList, DescribeUnfold unfold)
        {
            //initial checks
            if (!isInitialized)
            {
                LogError("Parser not innitialized.");
                return false;
            }

            //fetch files
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string msg = "Parsing multiple strings - ";
            try
            {
                if (nameCodeList.Count == 0)
                {
                    msg += "no strings to parse.";
                    LogError(msg);
                    return false;
                }
                for (int i = 0; i < nameCodeList.Count; i++)
                {
                    unfold.AllFiles.Add(nameCodeList[i].Key);
                    dict.Add(nameCodeList[i].Key, nameCodeList[i].Value);
                }
            }
            catch (Exception ex)
            {
                LogError(msg + " Failed to read the file names: " + ex.Message);
                return false;
            }


            //parse files
            while (unfold.AllFiles.Count() > 0)
            {
                string filename = unfold.AllFiles[0];
                unfold.ParseJob.LastFile = filename;
                bool result = parseString_LowVerbosity(filename, dict[filename], unfold);
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

            LogText(msg + "Ok");

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
        bool ParseString_LowVerbosity(string source, string filename, DescribeUnfold unfold)
        {
            //initial checks
            if (!isInitialized)
            {
                LogError("Parser not innitialized.");
                return false;
            }
            if (filename == null)
            {
                LogError("Null is not a valid filename.");
                return false;
            }
            if (string.IsNullOrEmpty(filename) || string.IsNullOrWhiteSpace(filename))
            {
                LogError("Invalid filename.");
                return false;
            }

            string msg = filename + " - ";
            try
            {
                source = _Preprocessor.ProcessSource(source);
                if (source.Length == 0)
                {
                    msg += "source code is empty!";
                    LogError(msg);
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(source))
                {
                    msg += "source code is empty!";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                msg += "failed to read source code: " + ex.Message;
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

            //unfold
            try
            {
                unfold.ParseJob.LastFile = filename;
                bool optimized = TranslateContext(unfold, root);
                if (!optimized)
                {
                    msg += "failed to unfold tree.";
                    LogError(msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                msg += "failed to unfold tree: " + ex.Message;
                LogError(msg);
                return false;
            }

            LogText(msg + "parsed successfuly");
            LogInfo("Parser red " + TokenCounter.ToString() +
                " tokens in " + ReductionCounter.ToString() +
                " reductions.");
            LogInfo("Those were translated to " + unfold.Productions.Count().ToString() +
                " productions, containing " + unfold.Translations.Count().ToString() +
                " entries.");
            return true;
        }


        bool TranslateContext(DescribeUnfold u, ParserRuleContext context, string filename = "")
        {
            switch (LanguageVersion)
            {
                case DescribeVersion.Version06:
                    return _Visitor.TranslateContext06(u, context, filename);
                case DescribeVersion.Version07:
                    return _Visitor.TranslateContext07(u, context, filename);
                case DescribeVersion.Version08:
                    return _Visitor.TranslateContext08(u, context, filename);
                case DescribeVersion.Version09:
                    return _Visitor.TranslateContext09(u, context, filename);
                case DescribeVersion.Version10:
                    return _Visitor.TranslateContext10(u, context, filename);
                case DescribeVersion.Version11:
                    return _Visitor.TranslateContext11(u, context, filename);
                default:
                    return false;
            }
        }


        private bool parseFile_LowVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
        {
            FileCounter++;
            if (!isInitialized)
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

            //read source code
            try
            {
                source = File.ReadAllText(fileInfo.FullName);
                source = _Preprocessor.ProcessSource(source);
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
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_LowVerbosity(source, out root, out message);
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

            //unfold
            try
            {
                bool optimized = TranslateContext(unfold, root);
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
        private bool parseString_LowVerbosity(string filename, string source, DescribeUnfold unfold)
        {
            FileCounter++;
            if (!isInitialized)
            {
                LogError("Parser not innitialized.");
                return false;
            }

            string msg = "\"" + filename + "\" - ";
            string code = null;
            try
            {
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
                code = _Preprocessor.ProcessSource(source);
            }
            catch (Exception ex)
            {
                msg += "failed to read: " + ex.Message;
                LogError(msg);
                return false;
            }

            //parse
            ParserRuleContext? root = null;
            try
            {
                string message = "";
                bool result = parse_LowVerbosity(code, out root, out message);
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

            //unfold
            try
            {
                bool optimized = TranslateContext(unfold, root);
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
        private bool parse_LowVerbosity(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity06(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity08(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity09(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity10(string source, out ParserRuleContext root, out string FailMessage)
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
        private bool parse_LowVerbosity11(string source, out ParserRuleContext root, out string FailMessage)
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
