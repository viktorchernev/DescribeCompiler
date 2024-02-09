using DescribeCompiler.Compiler.Optimizers;
using DescribeCompiler.Compiler.Preprocessors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;


namespace DescribeCompiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// The GOLD parser
        /// </summary>
        private GoldParser.Parser.Parser _GoldParser;

        /// <summary>
        /// The optimizer class
        /// </summary>
        public IDescribeOptimizer _Optimizer
        {
            get;
            set;
        }

        /// <summary>
        /// The preprocessor class
        /// </summary>
        public IDescribePreprocessor _Preprocessor 
        { 
            get; 
            set; 
        }



        /// <summary>
        /// Set different grammar version.
        /// </summary>
        /// <param name="grammarName">The enumerated name of the grammar to be loaded</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ChangeGrammar(GrammarName grammarName)
        {
            try
            {
                string grammarname = GrammarNameToResourceName(grammarName);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(grammarName);
                if (LoadGrammar(grammar))
                {
                    switch (grammarName)
                    {
                        case GrammarName.Basic:
                            _Optimizer = new OptimizerForDescribe06();
                            _Preprocessor = new PreprocessorForDescribe06();
                            break;
                        case GrammarName.Tags:
                            _Optimizer = new OptimizerForDescribe07();
                            _Preprocessor = new PreprocessorForDescribe07();
                            break;
                        case GrammarName.Links:
                            _Optimizer = new OptimizerForDescribe08();
                            _Preprocessor = new PreprocessorForDescribe08();
                            break;
                        case GrammarName.Decorators:
                            _Optimizer = new OptimizerForDescribe09();
                            _Preprocessor = new PreprocessorForDescribe09();
                            break;
                        case GrammarName.Official:
                        default:
                            _Optimizer = new OptimizerForDescribe10();
                            _Preprocessor = new PreprocessorForDescribe10();
                            break;
                    }
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
        /// Translate a folder of Describe source files
        /// </summary>
        /// <param name="dirInfo">Represents the directory of files to be parsed</param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFolder(DirectoryInfo dirInfo, DescribeUnfold unfold)
        {
            FileCounter = 0;
            ReductionCounter = 0;
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
                TokenCounter = 0;
                ReductionCounter = 0;
                result = ParseFolder_HighVerbosity(dirInfo, unfold);
            }
            return result;
        }

        /// <summary>
        /// Parse a Describe source file
        /// </summary>
        /// <param name="fileInfo">Represents the file to be parsed</param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseFile(FileInfo fileInfo, DescribeUnfold unfold)
        {
            FileCounter = 0;
            ReductionCounter = 0;
            bool result = false;

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
                TokenCounter = 0;
                ReductionCounter = 0;
                result = ParseFile_HighVerbosity(fileInfo, unfold);
            }
            return result;
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
        public bool ParseMultiString(List<KeyValuePair<string, string>> nameCodeList, DescribeUnfold unfold)
        {
            FileCounter = 0;
            ReductionCounter = 0;
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
                TokenCounter = 0;
                ReductionCounter = 0;
                result = ParseMultiString_HighVerbosity(nameCodeList, unfold);
            }
            return result;
        }

        /// <summary>
        /// Parse a Describe source code string
        /// </summary>
        /// <param name="source">The describe source code to be parsed</param>
        /// <param name="unfold">The unfold that will receive the data</param>
        /// <returns>true if successful, otherwise false</returns>
        public bool ParseString(string source, string filename, DescribeUnfold unfold)
        {
            FileCounter = 0;
            ReductionCounter = 0;
            bool result = false;

            if (Verbosity == LogVerbosity.Low)
            {
                result = ParseString_LowVerbosity(source, filename, unfold);
            }
            else if (Verbosity == LogVerbosity.Medium)
            {
                result = ParseString_MediumVerbosity(source, filename, unfold);
            }
            else if (Verbosity == LogVerbosity.High)
            {
                TokenCounter = 0;
                ReductionCounter = 0;
                result = ParseString_HighVerbosity(source, filename, unfold);
            }
            return result;
        }
    }
}