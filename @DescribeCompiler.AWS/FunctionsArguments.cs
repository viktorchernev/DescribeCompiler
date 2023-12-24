using DescribeCompiler;
using System;
using System.IO;


namespace DescribeCompiler.AWS
{
    internal static class Arguments
    {
        /// <summary>
        /// Read verbosity argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readVerbosityArgument(InputJson inputJson)
        {
            try
            {
                string val = inputJson.Verbosity.ToLower();
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(inputJson.Verbosity, "Verbosity");
                    return false;
                }
                else if (val == "low" || val == "l") Datnik.verbosity = LogVerbosity.Low;
                else if (val == "medium" || val == "m") Datnik.verbosity = LogVerbosity.Medium;
                else if (val == "high" || val == "h") Datnik.verbosity = LogVerbosity.High;
                else
                {
                    Messages.printArgumentError(inputJson.Verbosity,
                        "Verbosity",
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(inputJson.Verbosity, "Verbosity", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read translator argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readTranslatorArgument(InputJson inputJson)
        {
            try
            {
                string val = inputJson.Translator.ToLower();
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(inputJson.Translator, "Translator");
                    return false;
                }
                else
                {
                    Datnik.translatorName = val;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(inputJson.Translator, "Translator", ex.Message);
                return false;
            }
        }
    }
}