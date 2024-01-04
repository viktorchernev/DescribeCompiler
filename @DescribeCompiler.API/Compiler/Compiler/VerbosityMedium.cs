using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;


namespace DescribeCompiler
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

                unfold.InitialDir = dirInfo.FullName;
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
                bool result = parseFile_MediumVerbosity(new FileInfo(filename), unfold);
                if (result)
                {
                    unfold.ParsedFiles.Add(filename);
                    unfold.Files.RemoveAt(0);
                }
                else
                {
                    unfold.FailedFiles.Add(filename);
                    if(STOP_ON_ERROR) return false;
                    else
                    {
                        unfold.Files.RemoveAt(0);
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
            StringReader reader = new StringReader(source);
            Reduction root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(reader, out root, out message);

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
                bool optimized = _Optimizer.DoScripture(unfold, root);
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
                    unfold.Files.Add(nameCodeList[i].Key);
                    dict.Add(nameCodeList[i].Key, nameCodeList[i].Value);
                }
                LogInfo("Fetched " + unfold.Files.Count() + " files");
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file names: " + ex.Message);
                LogText("------------------------");
                return false;
            }

            //parse files
            while (unfold.Files.Count() > 0)
            {
                string filename = unfold.Files[0];
                unfold.CurFile = filename;
                bool result = parseString_MediumVerbosity(filename, dict[filename], unfold);
                if (result)
                {
                    unfold.ParsedFiles.Add(filename);
                    unfold.Files.RemoveAt(0);
                }
                else
                {
                    unfold.FailedFiles.Add(filename);
                    if (STOP_ON_ERROR) return false;
                    else
                    {
                        unfold.Files.RemoveAt(0);
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
            StringReader reader = new StringReader(source);
            Reduction root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(reader, out root, out message);

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
            finally
            {
                reader.Dispose();
            }

            //unfold
            try
            {
                unfold.CurFile = filename;
                bool optimized = _Optimizer.DoScripture(unfold, root);
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

        bool parseString_MediumVerbosity(string filename, string source, DescribeUnfold unfold)
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
            StringReader reader = new StringReader(code);
            Reduction root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(reader, out root, out message);

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
            finally
            {
                reader.Dispose();
            }

            //unfold
            try
            {
                bool optimized = _Optimizer.DoScripture(unfold, root);
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
        bool parseFile_MediumVerbosity(FileInfo fileInfo, DescribeUnfold unfold)
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
            StringReader reader = new StringReader(source);
            Reduction root = null;
            try
            {
                string message = "";
                bool result = parse_MediumVerbosity(reader, out root, out message);

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
            finally
            {
                reader.Dispose();
            }

            //unfold
            try
            {
                bool optimized = _Optimizer.DoScripture(unfold, root);
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
        bool parse_MediumVerbosity(TextReader reader, out Reduction root, out string FailMessage)
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
                                      "Position: " + (_GoldParser.CurrentPosition.Line + 1) + ", " + (_GoldParser.CurrentPosition.Column + 1) + "\n" +
                                      "Read: " + _GoldParser.CurrentToken.Data;
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.SyntaxError:
                        //Expecting a different token

                        List<string> li = new List<string>();
                        foreach (GrammarSymbol s in _GoldParser.ExpectedSymbols) li.Add(s.ToString());

                        FailMessage = "Syntax Error:\n" +
                                      "Position: " + (_GoldParser.CurrentPosition.Line + 1) + ", "
                                      + (_GoldParser.CurrentPosition.Column + 1) + "\n" +
                                      "Read: \"" + _GoldParser.CurrentToken.Data + "\"\n" +
                                      "Expecting: " + String.Join(" ,", li);
                        done = true;
                        break;

                    case GoldParser.Parser.ParseMessage.Reduction:
                        ReductionCounter++;
                        //You don't have to do anything here.
                        break;

                    case GoldParser.Parser.ParseMessage.Accept:
                        //Accepted!
                        root = _GoldParser.CurrentReduction;    //The root node!
                        done = true;
                        accepted = true;
                        break;

                    case GoldParser.Parser.ParseMessage.TokenRead:
                        TokenCounter++;
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
    }
}