using DescribeCompiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompilerCLI
{
    internal class Datnik
    {
        /// <summary>
        /// The input file or folder
        /// </summary>
        public static string input;

        /// <summary>
        /// Wether the input is a file or a folder
        /// </summary>
        public static bool isInputDir;

        /// <summary>
        /// The output file or folder
        /// </summary>
        public static string output;

        /// <summary>
        /// Wether the output is a file or a folder
        /// </summary>
        public static bool isOutputDir;

        /// <summary>
        /// The verbosity for the parser
        /// </summary>
        public static LogVerbosity verbosity;

        /// <summary>
        /// The template for the parser
        /// </summary>
        public static string templateName;



        static Datnik()
        {
            input = "";
            output = "";

            isInputDir = false;
            isOutputDir = false;

            verbosity = LogVerbosity.Low;
            templateName = null;
        }
    }
}
