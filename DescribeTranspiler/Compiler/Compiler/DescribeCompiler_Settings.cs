using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        // TODO: Add properties for those first 3 settings,
        // so that there can be a log method evoked to log the changing of the property

        /// <summary>
        /// Weather to parse only .ds files, or all the files in a directory.
        /// </summary>
        public bool PARSE_DS_ONLY = true;

        /// <summary>
        /// Weather to parse files in all sub-directories or only in the top directory.
        /// </summary>
        public bool PARSE_TOP_DIRECTORY_ONLY = false;

        /// <summary>
        /// Weather to stop if there is an error in source code, or skip the file
        /// and continue parsing.
        /// </summary>
        public bool STOP_ON_ERROR = false;



        /// <summary>
        /// The log verbosity that is to be used.
        /// </summary>
        private LogVerbosity LOG_VERBOSITY = LogVerbosity.Low;

        /// <summary>
        /// The default parser to be loaded with this version of the compiler.
        /// The grammar is usually left alone, unless there is a very good reason to be changed,
        /// which, on the other hand, makes this the de facto grammar that is used.
        /// </summary>
        private DescribeVersionName GRAMMAR_NAME = DescribeVersionName.Lines;

        /// <summary>
        /// The default parser to be loaded with this version of the compiler.
        /// The grammar is usually left alone, unless there is a very good reason to be changed,
        /// which, on the other hand, makes this the de facto grammar that is used.
        /// </summary>
        private DescribeVersionNumber GRAMMAR_VERSION = DescribeVersionNumber.Version10;



        /// <summary>
        /// A string representing the full name of the compiler (with the version)
        /// </summary>
        private static string COMPILER_NAME = "Describe Transpiler v1.0";

        /// <summary>
        /// A string representing the compiler version
        /// </summary>
        private static string COMPILER_VERSION = "1.0";
    }
}
