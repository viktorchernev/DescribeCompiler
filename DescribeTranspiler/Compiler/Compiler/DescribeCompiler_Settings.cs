using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// Weather to parse only .ds files, or all the files in a directory.
        /// </summary>
        public bool PARSE_DS_ONLY = true;

        /// <summary>
        /// Weather to parse files in all subdirectories or only in the top directory.
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
        public LogVerbosity LOG_VERBOSITY = LogVerbosity.Low;

        /// <summary>
        /// The default parser to be loaded with this version of the compiler.
        /// The grammar is usually left alone, unless there is a very good reason to be changed,
        /// which, on the other hand, makes this the de facto grammar that is used.
        /// </summary>
        public DescribeVersionName GRAMMAR_NAME = DescribeVersionName.Lines;

        /// <summary>
        /// The default parser to be loaded with this version of the compiler.
        /// The grammar is usually left alone, unless there is a very good reason to be changed,
        /// which, on the other hand, makes this the de facto grammar that is used.
        /// </summary>
        public DescribeVersionNumber GRAMMAR_VERSION = DescribeVersionNumber.Version10;



        /// <summary>
        /// A string representing the full name of the compiler (with the version)
        /// </summary>
        public static string COMPILER_NAME = "Describe Transpiler v1.0";

        /// <summary>
        /// A string representing the compiler version
        /// </summary>
        public static string COMPILER_VERSION = "1.0";
    }
}
