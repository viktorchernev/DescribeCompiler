using DescribeTranspiler;
using System;
using System.IO;


namespace DescribeTranspiler.AWS
{
    internal static class Arguments
    {
        /// <summary>
        /// Read the password for encrypting the input file(s) with .denc extention.
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readInputPasswordArgument(string? val)
        {
            try
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Datnik.parseEncryptedFiles = false;
                }
                else if (val.Length > 6)
                {
                    Datnik.inputPassword = val;
                    Datnik.parseEncryptedFiles = true;
                }
                else
                {
                    Messages.printArgumentError(val, 
                        "input_password",
                        "invalid value length - \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(val, "input_password", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read the password for output file(s).
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readOutputPasswordArgument(string? val)
        {
            try
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Datnik.encryptOutput = false;
                }
                else if (val.Length > 6)
                {
                    Datnik.outputPassword = val;
                    Datnik.encryptOutput = true;
                }
                else
                {
                    Messages.printArgumentError(val,
                        "output_password",
                        "invalid value length - \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(val, "output_password", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read the password for encrypting the log file.
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readLogPasswordArgument(string? val)
        {
            try
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Datnik.encryptLog = false;
                }
                else if (val.Length > 6)
                {
                    Datnik.logPassword = val;
                    Datnik.encryptLog = true;
                }
                else
                {
                    Messages.printArgumentError(val,
                        "log_password",
                        "invalid value length - \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(val, "log_password", ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Read input file or folder
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readFilenameArgument(string? val)
        {
            try
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(val, "filename");
                    return false;
                }
                Datnik.fileName = val;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(val, "filename");
                return false;
            }
            return true;
        }



        /// <summary>
        /// Read verbosity argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readVerbosityArgument(string? val)
        {
            try
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(val, "verbosity");
                    return false;
                }
                else if (val == "low" || val == "l") Datnik.verbosity = LogVerbosity.Low;
                else if (val == "medium" || val == "m") Datnik.verbosity = LogVerbosity.Medium;
                else if (val == "high" || val == "h") Datnik.verbosity = LogVerbosity.High;
                else
                {
                    Messages.printArgumentError(val,
                        "verbosity",
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(val, "verbosity", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read translator argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readTranslatorArgument(string? val)
        {
            try
            {
                if (val == null)
                {
                    Messages.printArgumentError(val, "translator");
                    return false;
                }
                else if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(val, "translator", "Empty value for translator name");
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
                Messages.printArgumentError(val, "translator", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read beautify argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readBeautifyArgument(string? val)
        {
            try
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(val, "beautify");
                    return false;
                }
                else if (val == "true") Datnik.isBeautified = true;
                else if (val == "false") Datnik.isBeautified = false;
                else
                {
                    Messages.printArgumentError(val,
                        "beautify", "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(val, "beautify", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read language-version aka lang-ver argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readLanguageVersion(string? val)
        {
            try
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(val, "language_version");
                    return false;
                }
                else if (val == "0.6" || val == "06") Datnik.langVer = DescribeVersionNumber.Version06;
                else if (val == "0.7" || val == "07") Datnik.langVer = DescribeVersionNumber.Version07;
                else if (val == "0.8" || val == "08") Datnik.langVer = DescribeVersionNumber.Version08;
                else if (val == "0.9" || val == "09") Datnik.langVer = DescribeVersionNumber.Version09;
                else if (val == "1.0" || val == "10") Datnik.langVer = DescribeVersionNumber.Version10;
                else if (val == "1.1" || val == "11") Datnik.langVer = DescribeVersionNumber.Version11;
                else
                {
                    Messages.printArgumentError(val,
                        "language_version",
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(val, "language_version", ex.Message);
                return false;
            }
        }
    }
}