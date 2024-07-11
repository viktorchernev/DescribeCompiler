using DescribeTranspiler;
using DescribeTranspiler.Compiler;


namespace DescribeCompiler.AWS
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
        /// 
        /// </summary>
        public static bool decryptInput;

        /// <summary>
        /// 
        /// </summary>
        public static bool encryptOutput;




        /// <summary>
        /// The input code
        /// </summary>
        public static string inputCode;

        /// <summary>
        /// The verbosity for the parser
        /// </summary>
        public static LogVerbosity verbosity;

        /// <summary>
        /// The name of the translator for the parser
        /// </summary>
        public static string translatorName;



        static Datnik()
        {
            inputPassword = null;
            outputPassword = null;
            decryptInput = false;
            encryptOutput = false;

            translatorName = "JSON";
            verbosity = LogVerbosity.Low;
        }
    }
}
