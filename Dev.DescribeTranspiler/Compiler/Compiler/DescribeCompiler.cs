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


namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        // need all these so that they can be swapped by user derived class
        // don't need to figure out a way to do this for the lexer and the parser?
        private Dictionary<DescribeVersion, IDescribePreprocessor> _preprocessors;



        /// <summary>
        /// The current version of the language the Compiler is parsing
        /// </summary>
        public DescribeVersion LanguageVersion
        {
            get;
            set;
        }

        /// <summary>
        /// The visitor class - Used to optimise parse result (parse tree)
        /// to an Unfold structure or an Abstract Syntax Tree
        /// </summary>
        public UniversalUnfoldVisitor _Visitor
        {
            get;
            set;
        }
        
        /// <summary>
        /// The preprocessor class
        /// </summary>
        public IDescribePreprocessor _Preprocessor
        {
            get
            {
                return _preprocessors[LanguageVersion];
            }
            set
            {
                _preprocessors[LanguageVersion] = value;
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
