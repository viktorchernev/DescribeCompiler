using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;

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
        public IDescribeOptimizer Optimizer
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
    }
}