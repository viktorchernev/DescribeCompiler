using DescribeTranspiler;


namespace DescribeTranspiler.AWS
{
    public class Datnik
    {
        /// <summary>
        /// Password to decrypt input files, if parseEncryptedFiles == true
        /// </summary>
        public static string? inputPassword;

        /// <summary>
        /// Pasword to encrypt output file(s), if encryptOutput == true
        /// </summary>
        public static string? outputPassword;

        /// <summary>
        /// Pasword to encrypt log file(s), if encryptLog == true
        /// </summary>
        public static string? logPassword;

        /// <summary>
        /// Wether to parse encrypted files
        /// </summary>
        public static bool parseEncryptedFiles;

        /// <summary>
        /// Wether to encrypt output. Output will be a blob file.
        /// </summary>
        public static bool encryptOutput;

        /// <summary>
        /// Wether to encrypt log. Log will be a blob file.
        /// </summary>
        public static bool encryptLog;



        /// <summary>
        /// The input file name
        /// </summary>
        public static string? fileName;



        /// <summary>
        /// Wether the output needs to be in a beautified format
        /// </summary>
        public static bool isBeautified;

        /// <summary>
        /// The Descrabe language version to be used.
        /// </summary>
        public static DescribeVersionNumber langVer;


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




        static Datnik()
        {
            inputPassword = null;
            outputPassword = null;
            encryptOutput = false;
            encryptLog = false;
            parseEncryptedFiles = false;

            fileName = null;
            isBeautified = false;

            translatorName = "HTML_PAGE";

            verbosity = LogVerbosity.Low;
            langVer = DescribeVersionNumber.Version10;
            requireSuccess = true;
        }
    }
}
