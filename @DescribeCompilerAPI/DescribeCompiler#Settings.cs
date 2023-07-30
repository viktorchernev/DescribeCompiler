using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// Wether to parse only .ds files, or all the files in a directory.
        /// </summary>
        public const bool PARSE_DS_ONLY = true;

        /// <summary>
        /// Wether to parse files in all subdirectories or only in the top directory.
        /// </summary>
        public const bool PARSE_TOP_DIRECTORY_ONLY = false;

        /// <summary>
        /// A string representing the full name of the compiler (with the version)
        /// </summary>
        public const string COMPILER_NAME = "Describe Compiler v0.9.2";

        /// <summary>
        /// A string representing the compiler version
        /// </summary>
        public const string COMPILER_VER = "0.9.2";

        /// <summary>
        /// The default grammar file to be loaded with this version of the compiler.
        /// The grammar is usually left alone, unless there is a very good reason to be changed,
        /// which, on the other hand, makes this the de facto grammar that is used.
        /// </summary>
        public const GrammarName DEFAULT_GRAMMAR = GrammarName.Decorators;
    }
}