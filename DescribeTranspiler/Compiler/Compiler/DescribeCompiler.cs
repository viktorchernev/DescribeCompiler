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
        /// Translate a folder of Describe source files
        /// </summary>
        /// <param name="dirInfo">Represents the directory of files to be parsed</param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFolder(DirectoryInfo dirInfo, ref DescribeUnfold unfold)
        {
            _fileCounter = 0;
            _reductionCounter = 0;
            bool result = false;

            if (Verbosity == LogVerbosity.Low)
            {
                result = ParseFolder_LowVerbosity(dirInfo, unfold);
            }
            else if (Verbosity == LogVerbosity.Medium)
            {
                result = ParseFolder_MediumVerbosity(dirInfo, unfold);
            }
            else if (Verbosity == LogVerbosity.High)
            {
                _tokenCounter = 0;
                _reductionCounter = 0;
                result = ParseFolder_HighVerbosity(dirInfo, unfold);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirInfo"></param>
        /// <param name="unfolds"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ParseFolder(DirectoryInfo dirInfo, ref List<DescribeUnfold> unfolds)
        {
            throw new NotImplementedException("Not implemented yet");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirInfo"></param>
        /// <param name="roots"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ParseFolder(DirectoryInfo dirInfo, out List<AstScriptureNode> roots)
        {
            throw new NotImplementedException("Not implemented yet");
        }



        /// <summary>
        /// Parse multiple Describe source code string
        /// </summary>
        /// <param name="nameCodeList">
        /// The list of source code strings to be parsed.
        /// Keys are the filenames. Values are the sources.
        /// </param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseStrings(List<KeyValuePair<string, string>> nameCodeList, ref DescribeUnfold unfold)
        {
            _fileCounter = 0;
            _reductionCounter = 0;
            bool result = false;

            if (Verbosity == LogVerbosity.Low)
            {
                result = ParseMultiString_LowVerbosity(nameCodeList, unfold);
            }
            else if (Verbosity == LogVerbosity.Medium)
            {
                result = ParseMultiString_MediumVerbosity(nameCodeList, unfold);
            }
            else if (Verbosity == LogVerbosity.High)
            {
                _tokenCounter = 0;
                _reductionCounter = 0;
                result = ParseMultiString_HighVerbosity(nameCodeList, unfold);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameCodeList"></param>
        /// <param name="unfolds"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ParseStrings(List<KeyValuePair<string, string>> nameCodeList, ref List<DescribeUnfold> unfolds)
        {
            throw new NotImplementedException("Not implemented yet");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameCodeList"></param>
        /// <param name="roots"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ParseStrings(List<KeyValuePair<string, string>> nameCodeList, out List<AstScriptureNode> roots)
        {
            throw new NotImplementedException("Not implemented yet");
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
        public bool ParseFile(FileInfo fileInfo, out AstScriptureNode root)
        {
            throw new NotImplementedException("Not implemented yet");
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
    }
}
