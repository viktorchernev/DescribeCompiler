using DescribeTranspiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler.Cli
{
    internal static class Arguments
    {

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
                    DirectoryInfo di = Directory.GetParent(arg);
                    if (di.Exists)
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

        /// <summary>
        /// Read artifacts argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readArtifactsArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "m" || val == "makeonly") Datnik.artifactMode = DescribeTranspiler.Compiler.ArtifactMode.MakeOnly;
                else if (val == "t" || val == "takeonly") Datnik.artifactMode = DescribeTranspiler.Compiler.ArtifactMode.TakeOnly;
                else if (val == "u" || val == "use") Datnik.artifactMode = DescribeTranspiler.Compiler.ArtifactMode.Use;
                else if (val == "n" || val == "no") Datnik.artifactMode = DescribeTranspiler.Compiler.ArtifactMode.No;
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
        /// Path to folder to use for storing and retrieving artifacts
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readArtifactsPathArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    Messages.printArgumentError(arg, argindex, "");
                    return false;
                }

                //existing dir - ok
                if (Directory.Exists(val))
                {
                    Datnik.artifactsFolderPath = val;
                    return true;
                }
                else
                {
                    Datnik.artifactsFolderPath = null;
                    Messages.printArgumentError(arg,
                            argindex, "is not a valid folder path");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Datnik.artifactsFolderPath = null;
                Messages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }
    }

}
