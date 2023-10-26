using DescribeCompiler;
using DescribeCompiler.Translators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompilerCLI
{
    internal static class MainFunctions
    {
        /// <summary>
        /// Externalize a particular inbuilt template file set
        /// </summary>
        /// <param name="templateName">The name of the template set</param>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool ExtTemplate(string templateName)
        {
            string dir = Assembly.GetExecutingAssembly().Location;
            dir = Path.GetDirectoryName(dir);
            return ExtTemplate(dir, templateName);
        }

        /// <summary>
        /// Externalize a particular inbuilt template file set
        /// </summary>
        /// <param name="dir">The directory to externalize to</param>
        /// <param name="templateName">The name of the template set</param>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool ExtTemplate(string dir, string templateName)
        {
            try
            {
                string[] names = ResourceUtil.extractResourceNames();
                bool flag = false;
                foreach (string s in names)
                {
                    if (s.StartsWith("DescribeCompiler.Templates." + templateName + "."))
                    {
                        flag = true;
                        string[] sep = s.Split('.');
                        string folder = dir + "\\Templates\\" + sep[2];
                        string filename = sep[3];
                        for (int i = 4; i < sep.Length; i++)
                        {
                            filename += "." + sep[i];
                        }
                        if (Directory.Exists(folder) == false)
                        {
                            Directory.CreateDirectory(folder);
                        }
                        string template =
                            ResourceUtil.ExtractResourceByFileName_String(sep[sep.Length - 3], sep[sep.Length - 2]);
                        File.WriteAllText(folder + "\\" + filename, template);
                    }
                }
                if (flag)
                {
                    Messages.printExtTemplatesSuccess(dir);
                    return true;
                }
                else
                {
                    Messages.printFatalError("There is no template named \"" + templateName + "\"");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Messages.printFatalError(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Externalize the inbuilt template files
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool ExtTemplates()
        {
            string dir = Assembly.GetExecutingAssembly().Location;
            dir = Path.GetDirectoryName(dir);
            return ExtTemplates(dir);
        }

        /// <summary>
        /// Externalize the inbuilt template files
        /// </summary>
        /// <param name="dir">The directory to externalize to</param>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool ExtTemplates(string dir)
        {
            try
            {
                string[] names = ResourceUtil.extractResourceNames();
                foreach (string s in names)
                {
                    if (s.StartsWith("DescribeCompiler.Templates."))
                    {
                        string[] sep = s.Split('.');
                        string folder = dir + "\\Templates\\" + sep[2];
                        string filename = sep[3];
                        for (int i = 4; i < sep.Length; i++)
                        {
                            filename += "." + sep[i];
                        }
                        if (Directory.Exists(folder) == false)
                        {
                            Directory.CreateDirectory(folder);
                        }
                        string template =
                            ResourceUtil.ExtractResourceByFileName_String(sep[sep.Length - 3], sep[sep.Length - 2]);
                        File.WriteAllText(folder + "\\" + filename, template);
                    }
                }
                Messages.printExtTemplatesSuccess(dir);
                return true;
            }
            catch (Exception ex)
            {
                Messages.printFatalError(ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Compile source file(s)
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool Compile()
        {
            try
            {
                DescribeCompiler.DescribeCompiler comp =
                new DescribeCompiler.DescribeCompiler(
                    Datnik.verbosity,
                    Messages.ConsoleLog,
                    Messages.ConsoleLogError,
                    Messages.ConsoleLogInfo,
                    Messages.ConsoleLogParseInfo);

                DescribeCompiler.DescribeCompiler.PARSE_TOP_DIRECTORY_ONLY = Datnik.topOnly;
                DescribeCompiler.DescribeCompiler.PARSE_DS_ONLY = Datnik.dsOnly;
                DescribeCompiler.DescribeCompiler.STOP_ON_ERROR = Datnik.requireSuccess;
                //template
                //artifacts
                //ARTIFACTS_PATH

                //find out which translator to use
                JsonTranslator translator = new JsonTranslator(
                    Messages.ConsoleLog,
                    Messages.ConsoleLogError,
                    Messages.ConsoleLogInfo);

                DescribeUnfold unfold = new DescribeUnfold();
                bool r = false;
                if (Datnik.isInputDir == false) r = comp.ParseFile(new FileInfo(Datnik.input), unfold);
                else r = comp.ParseFolder(new DirectoryInfo(Datnik.input), unfold);
                string result = translator.TranslateUnfold(unfold);

                if (result != null)
                {
                    File.WriteAllText(Datnik.output, result);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Messages.printFatalError(ex.Message);
                return false;
            }
        }
    }
}