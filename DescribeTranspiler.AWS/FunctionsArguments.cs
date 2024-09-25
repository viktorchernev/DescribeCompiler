using DescribeTranspiler;
using System;
using System.IO;


namespace DescribeCompiler.AWS
{
    internal static class Arguments
    {
        /// <summary>
        /// Read color theme
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readThemeArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "DBLUE") Messages.SetDarkBlueTheme();
                else if (val == "LBLUE") Messages.SetLightBlueTheme();
                else if (val == "GREEN") Messages.SetGreenTheme();
                else if (val == "PASTEL") Messages.SetPastelTheme();
                else if (val == "EARTH") Messages.SetEarthTheme();
                else if (val == "CONTRAST") Messages.SetHighContrastTheme();
                else if (val == "DEFAULT") Messages.SetDefaultTheme();
                else if (val == "VIOLET") Messages.SetVioletTheme();
                else if (val == "CYAN") Messages.SetCyanTheme();
                else
                {
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Read the password for encrypting the input file(s) with .denc extention.
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readInputPasswordArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                if (val.Length > 6)
                {
                    Datnik.inputPassword = val;
                    Datnik.parseEncryptedFiles = true;
                }
                else
                {
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value length - \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read the password for output file(s).
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readOutputPasswordArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                if (val.Length > 6)
                {
                    Datnik.outputPassword = val;
                    Datnik.encryptOutput = true;
                }
                else
                {
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value length - \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read the password for encrypting the log file.
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readLogPasswordArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                if (val.Length > 6)
                {
                    Datnik.logPassword = val;
                    Datnik.encryptLog = true;
                }
                else
                {
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value length - \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Read input file or folder
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readInputArgument(string arg, int argindex)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(arg);
                Datnik.input = arg;
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory) Datnik.isInputDir = true;
                else Datnik.isInputDir = false;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, "is not a valid file or folder");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Read input file
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readInputFileArgument(string arg, int argindex)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(arg);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    Messages.printArgumentError(arg, argindex, "is a folder. File is required");
                    return false;
                }
                else
                {
                    Datnik.input = arg;
                    Datnik.isInputDir = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, "is not a valid file");
                return false;
            }
        }

        /// <summary>
        /// Read input folder
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readInputFolderArgument(string arg, int argindex)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(arg);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    Datnik.input = arg;
                    Datnik.isInputDir = true;
                    return true;
                }
                else
                {
                    Messages.printArgumentError(arg, argindex, "is a file. Folder is required");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, "is not a valid folder");
                return false;
            }
        }

        /// <summary>
        /// Read output file or folder
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readOutputArgument(string arg, int argindex, bool isDir)
        {
            try
            {
                //existing file - ok
                if (File.Exists(arg))
                {
                    Datnik.output = arg;
                    Datnik.isOutputDir = false;
                    return true;
                }
                //existing dir - ok
                else if (Directory.Exists(arg))
                {
                    Datnik.output = arg;
                    Datnik.isOutputDir = true;
                    return true;
                }
                else
                {
                    // notexisting file or dir - we want parent dir to exist
                    DirectoryInfo di = Directory.GetParent(arg);
                    if (di.Exists)
                    {
                        Datnik.isOutputDir = isDir;
                        Datnik.output = arg;
                        return true;
                    }
                    else
                    {
                        Messages.printArgumentError(arg,
                            argindex, "is not a valid outpit file or folder path");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read output file
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readOutputFileArgument(string arg, int argindex)
        {
            try
            {
                //existing file - ok
                if (File.Exists(arg))
                {
                    Datnik.output = arg;
                    Datnik.isOutputDir = false;
                    return true;
                }
                //existing dir - not ok
                else if (Directory.Exists(arg))
                {
                    Messages.printArgumentError(arg, argindex, "is a folder. File is required");
                    return false;
                }
                else
                {
                    // notexisting file or dir - we want parent dir to exist
                    DirectoryInfo? di = Directory.GetParent(arg);
                    if (di != null && di.Exists)
                    {
                        Datnik.output = arg;
                        Datnik.isOutputDir = false;
                        return true;
                    }
                    else
                    {
                        Messages.printArgumentError(arg,
                            argindex, "is not a valid outpit file path");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read output folder
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readOutputFolderArgument(string arg, int argindex)
        {
            try
            {
                //existing file - not ok
                if (File.Exists(arg))
                {
                    Messages.printArgumentError(arg, argindex, "is a file. Folder is required");
                    return false;
                }
                //existing dir - ok
                else if (Directory.Exists(arg))
                {
                    Datnik.output = arg;
                    Datnik.isOutputDir = true;
                    return true;
                }
                else
                {
                    // notexisting file or dir - we want parent dir to exist
                    DirectoryInfo di = Directory.GetParent(arg);
                    if (di.Exists)
                    {
                        Datnik.output = arg;
                        Datnik.isOutputDir = true;
                        return true;
                    }
                    else
                    {
                        Messages.printArgumentError(arg,
                            argindex, "is not a valid outpit folder path");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Read dsonly argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readDsonlyArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "true") Datnik.dsOnly = true;
                else if (val == "false") Datnik.dsOnly = false;
                else
                {
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read verbosity argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readVerbosityArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "low" || val == "l") Datnik.verbosity = LogVerbosity.Low;
                else if (val == "medium" || val == "m") Datnik.verbosity = LogVerbosity.Medium;
                else if (val == "high" || val == "h") Datnik.verbosity = LogVerbosity.High;
                else
                {
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read onerror argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readOnerrorArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "stop") Datnik.requireSuccess = true;
                else if (val == "ignore") Datnik.requireSuccess = false;
                else
                {
                    Messages.printArgumentError(arg,
                        argindex, "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read toponly argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readToponlyArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "true") Datnik.topOnly = true;
                else if (val == "false") Datnik.topOnly = false;
                else
                {
                    Messages.printArgumentError(arg,
                        argindex, "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read translator argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readTranslatorArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (val == null)
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "Empty value for template name");
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
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read beautify argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readBeautifyArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "true") Datnik.isBeautified = true;
                else if (val == "false") Datnik.isBeautified = false;
                else
                {
                    Messages.printArgumentError(arg,
                        argindex, "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read language-version aka lang-ver argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readLanguageVersion(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
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
                    Messages.printArgumentError(arg,
                        argindex,
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Path to a log file to output logs to
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readLogfileArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                //there is a bug in visual studio I think where if your path
                //in the command line parameter is in parentheses and ends with
                //a backslash, it is treated as an escaped backslash

                //existing file - ok
                if (File.Exists(val))
                {
                    Datnik.logFilePath = val;
                    Datnik.logToFile = true;
                    return true;
                }
                //existing dir - ok
                else if (Directory.Exists(val))
                {
                    Datnik.logFilePath = Path.Combine(val, "lastlog.txt");
                    Datnik.logToFile = true;
                    return true;
                }
                else
                {
                    // notexisting file or dir - we want parent dir to exist
                    DirectoryInfo di = Directory.GetParent(val);
                    if (di.Exists)
                    {
                        Datnik.logFilePath = val;
                        Datnik.logToFile = true;
                        return true;
                    }
                    else
                    {
                        Datnik.logFilePath = null;
                        Datnik.logToFile = false;
                        Messages.printArgumentError(arg,
                            argindex, "is not a valid outpit file path");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Datnik.logFilePath = null;
                Datnik.logToFile = false;
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }
    }
}