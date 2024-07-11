using DescribeTranspiler;
using DescribeTranspiler.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler.Cli
{
    public class Datnik
    {
        /// <summary>
        /// Password to decrypt input files, if parseEncryptedFiles == true
        /// </summary>
        public static string inputPassword;

        /// <summary>
        /// Pasword to encrypt output file(s), if encryptOutput == true
        /// </summary>
        public static string outputPassword;

        /// <summary>
        /// Wether to try to decrypt encrypted files (.DENC)
        /// </summary>
        public static bool parseEncryptedFiles;

        /// <summary>
        /// 
        /// </summary>
        public static bool encryptOutput;



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
        /// When parsing a folder, weather to parse files in top directory only
        /// or parse files in child directories as well
        /// </summary>
        public static bool topOnly;

        /// <summary>
        /// Weather to omit files that are not Describe source files (".DS")
        /// </summary>
        public static bool dsOnly;



        /// <summary>
        /// The verbosity for the parser
        /// </summary>
        public static LogVerbosity verbosity;

        /// <summary>
        /// Weather the compiler should stop after encountering an error 
        /// or add the file to the list of failed files and continue with 
        /// the next one
        /// </summary>
        public static bool requireSuccess;



        /// <summary>
        /// The name of the translator for the parser
        /// </summary>
        public static string translatorName;



        /// <summary>
        /// Path to an external log file
        /// </summary>
        public static string logFilePath;

        /// <summary>
        /// Weather to output logs to an external file
        /// </summary>
        public static bool logToFile;



        /// <summary>
        /// Weather to and how to use artifacts
        /// </summary>
        public static ArtifactMode artifactMode;

        /// <summary>
        /// Path to artifacts folder
        /// </summary>
        public static string artifactsFolderPath;


        static Datnik()
        {
            inputPassword = null;
            outputPassword = null;
            parseEncryptedFiles = false;
            encryptOutput = false;

            input = null;
            output = null;
            isInputDir = false;
            isOutputDir = false;
            topOnly = false;

            translatorName = "HTML_PARACORD";

            logFilePath = null;
            logToFile = false;

            dsOnly = true;
            verbosity = LogVerbosity.Low;
            requireSuccess = true;

            artifactMode = ArtifactMode.No;
            artifactsFolderPath = null;
        }
    }
}
