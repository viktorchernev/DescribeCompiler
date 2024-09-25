using DescribeTranspiler.Preprocessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescribeParser.Visitors;
using Antlr4.Runtime;
using DescribeParser;
using DescribeParser.Unfold;
using DescribeParser.Ast;
using System.Security.Cryptography;
using System.Runtime;


namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// Change the current version of Describe we parse against.
        /// </summary>
        /// <param name="version">The desired new version</param>
        /// <returns>True if successful</returns>
        public bool ChangeLanguageVersion(DescribeVersionNumber version)
        {
            try
            {
                LanguageVersion = version;
                LogInfo("Language version set to: " + GrammarFullName);
                return true;
            }
            catch (Exception ex)
            {
                LogError("Failed to set Describe version for the Transpiler: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Change the current version of Describe we parse against.
        /// </summary>
        /// <param name="version">The desired new version name</param>
        /// <returns>True if successful</returns>
        public bool ChangeLanguageVersion(DescribeVersionName versionName)
        {
            try
            {
                LanguageName = versionName;
                return true;
            }
            catch (Exception ex)
            {
                LogError("Failed to set Describe version for the Transpiler: " + ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Translate a folder of Describe source files to an Unfold
        /// </summary>
        /// <param name="dirInfo">Represents the directory of files to be parsed</param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFolder(DirectoryInfo dirInfo, ref DescribeUnfold unfold)
        {
            LogText("Starting a 'Directory -> Unfold' operation...");
            LogText("\"" + dirInfo.FullName + "\"");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            LogText("PARSE_DS_ONLY - " + PARSE_DS_ONLY);
            LogText("PARSE_TOP_DIRECTORY_ONLY - " + PARSE_TOP_DIRECTORY_ONLY);

            unfold.ParseJob = CurrentJob;
            unfold.ParseJob.InitialDir = dirInfo.FullName;

            // Check parameters 
            if (!Directory.Exists(dirInfo.FullName))
            {
                LogError("Directory does not exist!");
                return false;
            }

            //fetch files
            List<string> sourceFiles;
            try
            {
                SearchOption searchOption = SearchOption.AllDirectories;
                if (PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                string searchMask = "*.*";
                if (PARSE_DS_ONLY) searchMask = "*.ds";

                //unfold.InitialDir = dirInfo.FullName;
                sourceFiles = Directory.GetFiles(dirInfo.FullName, searchMask, searchOption).ToList();
                if (sourceFiles.Count() == 0)
                {
                    LogError("Directory is empty");
                    return false;
                }

                //figure out a rootfile
                List<string> topSourceFiles = Directory.GetFiles(dirInfo.FullName, searchMask, SearchOption.TopDirectoryOnly).ToList();
                foreach (string topfile in topSourceFiles)
                {
                    if (Path.GetFileName(topfile).StartsWith('.'))
                    {
                        unfold.ParseJob.RootFile = topfile;
                        break;
                    }
                }
                if(string.IsNullOrEmpty(unfold.ParseJob.RootFile))
                {
                    if (topSourceFiles.Count > 0) unfold.ParseJob.RootFile = topSourceFiles[0];
                    else unfold.ParseJob.RootFile = sourceFiles[0];
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents of the directory: " + ex.Message);
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceFiles.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                FileInfo file = new FileInfo(sourceFiles[i]);
                unfold.ParseJob.LastFile = sourceFiles[i];
                bool result = false;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseFile_LowVerbosity(file, unfold);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseFile_MediumVerbosity(file, unfold);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseFile_HighVerbosity(file, unfold);
                }

                _fileCounter++;
                if (result == true)
                {
                    _parsedFileCounter++;
                    unfold.ParsedFiles.Add(sourceFiles[i]);
                }
                else
                {
                    unfold.FailedFiles.Add(sourceFiles[i]);
                    _failedFileCounter++;
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }

        /// <summary>
        /// Translate a folder of Describe source files to a list of Unfolds
        /// </summary>
        /// <param name="dirInfo">Represents the directory of files to be parsed</param>
        /// <param name="unfolds">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFolder(DirectoryInfo dirInfo, out List<DescribeUnfold> unfolds)
        {
            LogText("Starting a 'Directory -> Unfold' operation...");
            LogText("\"" + dirInfo.FullName + "\"");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            LogText("PARSE_DS_ONLY - " + PARSE_DS_ONLY);
            LogText("PARSE_TOP_DIRECTORY_ONLY - " + PARSE_TOP_DIRECTORY_ONLY);
            unfolds = new List<DescribeUnfold>();
            CurrentJob.InitialDir = dirInfo.FullName;

            // Check parameters 
            if (!Directory.Exists(dirInfo.FullName))
            {
                LogError("Directory does not exist!");
                return false;
            }

            //fetch files
            List<string> sourceFiles;
            try
            {
                SearchOption searchOption = SearchOption.AllDirectories;
                if (PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                string searchMask = "*.*";
                if (PARSE_DS_ONLY) searchMask = "*.ds";

                //unfold.InitialDir = dirInfo.FullName;
                sourceFiles = Directory.GetFiles(dirInfo.FullName, searchMask, searchOption).ToList();
                if (sourceFiles.Count() == 0)
                {
                    LogError("Directory is empty");
                    return false;
                }

                //figure out a rootfile
                List<string> topSourceFiles = Directory.GetFiles(dirInfo.FullName, searchMask, SearchOption.TopDirectoryOnly).ToList();
                foreach (string topfile in topSourceFiles)
                {
                    if (Path.GetFileName(topfile).StartsWith('.'))
                    {
                        CurrentJob.RootFile = topfile;
                        break;
                    }
                }
                if (string.IsNullOrEmpty(CurrentJob.RootFile))
                {
                    if (topSourceFiles.Count > 0) CurrentJob.RootFile = topSourceFiles[0];
                    else CurrentJob.RootFile = sourceFiles[0];
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents of the directory: " + ex.Message);
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceFiles.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                DescribeUnfold unfold = new DescribeUnfold();
                unfold.ParseJob = CurrentJob;
                unfold.ParseJob.LastFile = sourceFiles[i];
                FileInfo file = new FileInfo(sourceFiles[i]);
                bool result = false;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseFile_LowVerbosity(file, unfold);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseFile_MediumVerbosity(file, unfold);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseFile_HighVerbosity(file, unfold);
                }

                _fileCounter++;
                if (result == true)
                {
                    unfolds.Add(unfold);
                    _parsedFileCounter++;
                }
                else
                {
                    _failedFileCounter++;
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }

        /// <summary>
        /// Translate a folder of Describe source files to a list of AstScriptureNode
        /// </summary>
        /// <param name="dirInfo">Represents the directory of files to be parsed</param>
        /// <param name="roots">The AstScriptureNode list that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFolder(DirectoryInfo dirInfo, out List<AstScriptureNode> roots)
        {
            LogText("Starting a 'Directory -> Unfold' operation...");
            LogText("\"" + dirInfo.FullName + "\"");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            LogText("PARSE_DS_ONLY - " + PARSE_DS_ONLY);
            LogText("PARSE_TOP_DIRECTORY_ONLY - " + PARSE_TOP_DIRECTORY_ONLY);
            roots = new List<AstScriptureNode>();

            // Check parameters 
            if (!Directory.Exists(dirInfo.FullName))
            {
                LogError("Directory does not exist!");
                return false;
            }

            //fetch files
            List<string> sourceFiles;
            try
            {
                SearchOption searchOption = SearchOption.AllDirectories;
                if (PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                string searchMask = "*.*";
                if (PARSE_DS_ONLY) searchMask = "*.ds";

                //unfold.InitialDir = dirInfo.FullName;
                sourceFiles = Directory.GetFiles(dirInfo.FullName, searchMask, searchOption).ToList();
                if (sourceFiles.Count() == 0)
                {
                    LogError("Directory is empty");
                    return false;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to read the file contents of the directory: " + ex.Message);
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceFiles.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                AstScriptureNode? scripture = null;
                FileInfo file = new FileInfo(sourceFiles[i]);
                bool result = false;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseFile_LowVerbosity(file, out scripture);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseFile_MediumVerbosity(file, out scripture);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseFile_HighVerbosity(file, out scripture);
                }

                _fileCounter++;
                if (result == true && scripture != null)
                {
                    roots.Add(scripture!);
                    _parsedFileCounter++;
                }
                else
                {
                    _failedFileCounter++;
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }



        /// <summary>
        /// Parse multiple Describe source code strings to an Unfold
        /// </summary>
        /// <param name="sourceCodes">
        /// The list of source code strings to be parsed.
        /// Keys are the filenames. Values are the sources.
        /// </param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseStrings(List<SourceCode> sourceCodes, ref DescribeUnfold unfold)
        {
            LogText("Starting a 'String[] -> Unfold' operation...");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            unfold.ParseJob = CurrentJob;

            // Check parameters 
            if (sourceCodes.Count == 0)
            {
                LogError("no strings to parse");
                return false;
            }

            //figure out a rootfile
            unfold.ParseJob.RootFile = sourceCodes[0].FileName;

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceCodes.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                string filename = sourceCodes[i].FileName;
                unfold.ParseJob.LastFile = filename;
                string source = sourceCodes[i].SourceText;
                bool result = false;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseString_LowVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseString_MediumVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseString_HighVerbosity(source, unfold);
                }

                _fileCounter++;
                if (result == true)
                {
                    _parsedFileCounter++;
                    unfold.ParsedFiles.Add(sourceCodes[i].FileName);
                }
                else
                {
                    _failedFileCounter++;
                    unfold.FailedFiles.Add(sourceCodes[i].FileName);
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }

        /// <summary>
        /// Parse multiple Describe source code strings to an Unfold
        /// </summary>
        /// <param name="nameCodeList">
        /// The list of source code strings to be parsed.
        /// Keys are the filenames. Values are the sources.
        /// </param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseStrings(List<string> sourceCodes, ref DescribeUnfold unfold)
        {
            LogText("Starting a 'String[] -> Unfold' operation...");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            unfold.ParseJob = CurrentJob;

            // Check parameters 
            if (sourceCodes.Count == 0)
            {
                LogError("no strings to parse");
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceCodes.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                string filename = _createMD5(sourceCodes[i], 16);
                unfold.ParseJob.LastFile = filename;
                string source = sourceCodes[i];
                bool result = false;

                //figure out a rootfile
                if(i == 0) unfold.ParseJob.RootFile = filename;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseString_LowVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseString_MediumVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseString_HighVerbosity(source, unfold);
                }

                _fileCounter++;
                if (result == true)
                {
                    _parsedFileCounter++;
                    unfold.ParsedFiles.Add(filename);
                }
                else
                {
                    _failedFileCounter++;
                    unfold.FailedFiles.Add(filename);
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }

        /// <summary>
        /// Parse multiple Describe source code strings to multiple Unfolds.
        /// This is basically the same as running ParseString multiple times.
        /// </summary>
        /// <param name="sourceCodes">The list of source codes to be parsed.</param>
        /// <param name="unfolds">The unfold that will receive the data.</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseStrings(List<SourceCode> sourceCodes, out List<DescribeUnfold> unfolds)
        {
            LogText("Starting a 'String[] -> Unfold[]' operation...");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            unfolds = new List<DescribeUnfold>();

            // Check parameters 
            if (sourceCodes.Count == 0)
            {
                LogError("no strings to parse");
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceCodes.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                DescribeUnfold unfold = new DescribeUnfold();
                unfold.ParseJob = CurrentJob;
                string filename = sourceCodes[i].FileName;
                unfold.ParseJob.LastFile = filename;
                string source = sourceCodes[i].SourceText;
                bool result = false;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseString_LowVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseString_MediumVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseString_HighVerbosity(source, unfold);
                }

                _fileCounter++;
                if (result == true)
                {
                    unfolds.Add(unfold);
                    _parsedFileCounter++;
                }
                else
                {
                    _failedFileCounter++;
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }

        /// <summary>
        /// Parse multiple Describe source code strings to multiple Unfolds.
        /// This is basically the same as running ParseString multiple times.
        /// </summary>
        /// <param name="sourceCodes">The list of source codes to be parsed.</param>
        /// <param name="unfolds">The unfold that will receive the data.</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseStrings(List<string> sourceCodes, out List<DescribeUnfold> unfolds)
        {
            LogText("Starting a 'String[] -> Unfold[]' operation...");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            unfolds = new List<DescribeUnfold>();

            // Check parameters 
            if (sourceCodes.Count == 0)
            {
                LogError("no strings to parse");
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceCodes.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                DescribeUnfold unfold = new DescribeUnfold();
                unfold.ParseJob = CurrentJob;
                string filename = _createMD5(sourceCodes[i], 16);
                unfold.ParseJob.LastFile = filename;
                string source = sourceCodes[i];
                bool result = false;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseString_LowVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseString_MediumVerbosity(source, unfold);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseString_HighVerbosity(source, unfold);
                }

                _fileCounter++;
                if (result == true)
                {
                    unfolds.Add(unfold);
                    _parsedFileCounter++;
                }
                else
                {
                    _failedFileCounter++;
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }

        /// <summary>
        /// Parse multiple Describe source code strings to multiple Unfolds.
        /// This is basically the same as running ParseString multiple times.
        /// </summary>
        /// <param name="sourceCodes">The list of source codes to be parsed.</param>
        /// <param name="roots">The list of AstScriptureNode's that will receive the data.</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseStrings(List<SourceCode> sourceCodes, out List<AstScriptureNode> roots)
        {
            LogText("Starting a 'String[] -> Unfold[]' operation...");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            roots = new List<AstScriptureNode>();

            // Check parameters 
            if (sourceCodes.Count == 0)
            {
                LogError("no strings to parse");
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceCodes.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                string filename = sourceCodes[i].FileName;
                string source = sourceCodes[i].SourceText;
                bool result = false;

                AstScriptureNode? scripture = null;
                SimpleParseJob job = new SimpleParseJob();
                job.LastFile = filename;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseString_LowVerbosity(source, job, out scripture);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseString_MediumVerbosity(source, job, out scripture);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseString_HighVerbosity(source, job, out scripture);
                }

                _fileCounter++;
                if (result == true)
                {
                    roots.Add(scripture!);
                    _parsedFileCounter++;
                }
                else
                {
                    _failedFileCounter++;
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }

        /// <summary>
        /// Parse multiple Describe source code strings to multiple Unfolds.
        /// This is basically the same as running ParseString multiple times.
        /// </summary>
        /// <param name="sourceCodes">The list of source codes to be parsed.</param>
        /// <param name="roots">The list of AstScriptureNode's that will receive the data.</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseStrings(List<string> sourceCodes, out List<AstScriptureNode> roots)
        {
            LogText("Starting a 'String[] -> Unfold[]' operation...");
            LogText("STOP_ON_ERROR - " + STOP_ON_ERROR);
            roots = new List<AstScriptureNode>();

            // Check parameters 
            if (sourceCodes.Count == 0)
            {
                LogError("no strings to parse");
                return false;
            }

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }

            bool opresult = true;
            DescribeVersionNumber version = LanguageVersion;
            for (int i = 0; i < sourceCodes.Count; i++)
            {
                if (LanguageVersion != version) LanguageVersion = version;
                string filename = _createMD5(sourceCodes[i], 16);
                string source = sourceCodes[i];
                bool result = false;

                AstScriptureNode? scripture = null;
                SimpleParseJob job = new SimpleParseJob();
                job.LastFile = filename;

                // Pick an appropriate parse method, based on verbosity level
                if (Verbosity == LogVerbosity.Low)
                {
                    result = ParseString_LowVerbosity(source, job, out scripture);
                }
                else if (Verbosity == LogVerbosity.Medium)
                {
                    result = ParseString_MediumVerbosity(source, job, out scripture);
                }
                else if (Verbosity == LogVerbosity.High)
                {
                    result = ParseString_HighVerbosity(source, job, out scripture);
                }

                _fileCounter++;
                if (result == true)
                {
                    roots.Add(scripture!);
                    _parsedFileCounter++;
                }
                else
                {
                    _failedFileCounter++;
                    if (STOP_ON_ERROR)
                    {
                        opresult = false;
                        break;
                    }
                }
            }

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            _isUsed = true;
            return opresult;
        }



        /// <summary>
        /// Parse a Describe source file to an Unfold
        /// </summary>
        /// <param name="fileInfo">Represents the file to be parsed</param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFile(FileInfo fileInfo, ref DescribeUnfold unfold)
        {
            LogText("Starting a 'File -> Unfold' operation...");
            unfold.ParseJob = CurrentJob;
            unfold.ParseJob.LastFile = fileInfo.FullName;
            unfold.ParseJob.RootFile = fileInfo.FullName;

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }
            bool result = false;

            // Pick an appropriate parse method, based on verbosity level
            if (Verbosity == LogVerbosity.Low)
            {
                result = ParseFile_LowVerbosity(fileInfo, unfold);
            }
            else if (Verbosity == LogVerbosity.Medium)
            {
                result = ParseFile_MediumVerbosity(fileInfo, unfold);
            }
            else if (Verbosity == LogVerbosity.High)
            {
                result = ParseFile_HighVerbosity(fileInfo, unfold);
            }

            // Set stats
            _isUsed = true;
            _fileCounter++;
            if (result == true) _parsedFileCounter++;
            else _failedFileCounter++;

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            return result;
        }

        /// <summary>
        /// Parse a Describe source file to an AST
        /// </summary>
        /// <param name="fileInfo">Represents the file to be parsed</param>
        /// <param name="root">The resulting AST tree</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFile(FileInfo fileInfo, out AstScriptureNode? root)
        {
            LogText("Starting a 'File -> AST' operation...");
            CurrentJob.LastFile = fileInfo.FullName;
            CurrentJob.RootFile = fileInfo.FullName;

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }
            bool result = false;

            // Pick an appropriate parse method, based on verbosity level
            if (Verbosity == LogVerbosity.Low)
            {
                result = ParseFile_LowVerbosity(fileInfo, out root);
            }
            else if (Verbosity == LogVerbosity.Medium)
            {
                result = ParseFile_MediumVerbosity(fileInfo, out root);
            }
            else if (Verbosity == LogVerbosity.High)
            {
                result = ParseFile_HighVerbosity(fileInfo, out root);
            }
            else
            {
                result = false;
                root = null;
            }

            // Set stats
            _isUsed = true;
            _fileCounter++;
            if (result == true) _parsedFileCounter++;
            else _failedFileCounter++;

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            return result;
        }



        /// <summary>
        /// Parse a Describe source code string to an Unfold
        /// </summary>
        /// <param name="source">The describe source code to be parsed</param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseString(string source, string filename, ref DescribeUnfold unfold)
        {
            LogText("Starting a 'String -> Unfold' operation...");
            unfold.ParseJob = CurrentJob;
            unfold.ParseJob.LastFile = filename;
            unfold.ParseJob.RootFile = filename;

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }
            bool result = false;

            // Pick an appropriate parse method, based on verbosity level
            if (Verbosity == LogVerbosity.Low)
            {
                result = ParseString_LowVerbosity(source, unfold);
            }
            else if (Verbosity == LogVerbosity.Medium)
            {
                result = ParseString_MediumVerbosity(source, unfold);
            }
            else if (Verbosity == LogVerbosity.High)
            {
                result = ParseString_HighVerbosity(source, unfold);
            }

            // Set stats
            _isUsed = true;
            _fileCounter++;
            if(result == true) _parsedFileCounter++;
            else _failedFileCounter++;

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            return result;
        }

        /// <summary>
        /// Parse a Describe source code string to an AST
        /// </summary>
        /// <param name="source">The describe source code to be parsed</param>
        /// <param name="filename">The filename of the source string</param>
        /// <param name="root">The resulting AST tree</param>
        /// <returns>True if successful, otherwise false</returns>
        public bool ParseString(string source, string filename, out AstScriptureNode? rootNode)
        {
            LogText("Starting a 'String -> AST' operation...");
            CurrentJob.LastFile = filename;
            CurrentJob.RootFile = filename;

            // Reset stats, as we are starting a new operation
            if (_isUsed)
            {
                resetBase();
                resetStatistics();
            }
            bool result = false;

            // Pick an appropriate parse method, based on verbosity level
            if (Verbosity == LogVerbosity.Low)
            {
                result = ParseString_LowVerbosity(source, CurrentJob, out rootNode);
            }
            else if (Verbosity == LogVerbosity.Medium)
            {
                result = ParseString_MediumVerbosity(source, CurrentJob, out rootNode);
            }
            else if (Verbosity == LogVerbosity.High)
            {
                result = ParseString_HighVerbosity(source, CurrentJob, out rootNode);
            }
            else
            {
                result = false;
                rootNode = null;
            }

            // Set stats
            _isUsed = true;
            _fileCounter++;
            if (result == true) _parsedFileCounter++;
            else _failedFileCounter++;

            // log
            LogInfo("All Files: " + _fileCounter.ToString() +
                ", Succeeded: " + _parsedFileCounter.ToString() +
                ", Failed: " + _failedFileCounter.ToString() +
                ", Errors: " + _errorCounter.ToString());

            return result;
        }



        private string _createMD5(string input, int length)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                string hash = sb.ToString();

                if (length < 4 || length > 32) length = 16;
                string shortHash = hash.Substring(0, length);
                return shortHash;
            }
        }
    }
}
