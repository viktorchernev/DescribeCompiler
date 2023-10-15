using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler
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

                unfold.InitialDir = dirInfo.FullName;
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
                bool result = parseFile_LowVerbosity(new FileInfo(filename), unfold);
                if (result)
                {
                    unfold.ParsedFiles.Add(filename);
                    unfold.Files.RemoveAt(0);
                }
                else
                {
                    unfold.FailedFiles.Add(filename);
                    return false;
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
                bool result = parse_LowVerbosity(reader, out root, out message);
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
                bool optimized = Optimizer.DoScripture(unfold, root);
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
                bool result = parse_LowVerbosity(reader, out root, out message);
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
                bool optimized = Optimizer.DoScripture(unfold, root);
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
        private bool parse_LowVerbosity(TextReader reader, out Reduction root, out string FailMessage)
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
            if (accepted) FailMessage = "Ok";
            return accepted;
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
                          && value[i - 1] != '/'
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
    }
}