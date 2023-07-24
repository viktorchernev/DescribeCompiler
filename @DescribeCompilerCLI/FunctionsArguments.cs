using DescribeCompiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompilerCLI
{
    internal static class FunctionsArguments
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
                FunctionsMessages.printArgumentError(arg, argindex, "is not a valid file or folder");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Read output file or folder
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readOutputArgument(string arg, int argindex)
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
                        if (Path.GetFileName(arg) == string.Empty) Datnik.isOutputDir = true;
                        else Datnik.isOutputDir = false;
                        Datnik.output = arg;
                        return true;
                    }
                    else
                    {
                        FunctionsMessages.printArgumentError(arg,
                            argindex, "is not a valid outpit file or folder path");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                FunctionsMessages.printArgumentError(arg, argindex, ex.Message);
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
                    FunctionsMessages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (val == "low" || val == "l") Datnik.verbosity = LogVerbosity.Low;
                else if (val == "medium" || val == "m") Datnik.verbosity = LogVerbosity.Medium;
                else if (val == "high" || val == "h") Datnik.verbosity = LogVerbosity.High;
                else
                {
                    FunctionsMessages.printArgumentError(arg,
                        argindex,
                        "invalid value \"" + val + "\"");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                FunctionsMessages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read template argument
        /// </summary>
        /// <param name="arg">The argument raw text</param>
        /// <param name="argindex">The index of the argument (for logging purposes)</param>
        /// <returns>True if successful</returns>
        internal static bool readTemplateArgument(string arg, int argindex)
        {
            try
            {
                string val = arg.Substring(arg.IndexOf("=") + 1);
                if (val == null)
                {
                    FunctionsMessages.printArgumentError(arg, argindex, "");
                    return false;
                }
                else if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                {
                    FunctionsMessages.printArgumentError(arg, argindex, "Empty value for template name");
                    return false;
                }
                else
                {
                    Datnik.templateName = val;
                    return true;
                }
            }
            catch (Exception ex)
            {
                FunctionsMessages.printArgumentError(arg, argindex, ex.Message);
                return false;
            }
        }
    }
}
