using DescribeCompiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompilerCLI
{
    internal static class FunctionsMain
    {
        /// <summary>
        /// Externalize the inbuilt template files
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool ExtTemplates()
        {
            try
            {
                string dir = Assembly.GetExecutingAssembly().Location;
                dir = Path.GetDirectoryName(dir);
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
                FunctionsMessages.printExtTemplatesSuccess();
                return true;
            }
            catch (Exception ex)
            {
                FunctionsMessages.printFatalError(ex.Message);
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
                    Datnik.templateName,
                    FunctionsMessages.ConsoleLog,
                    FunctionsMessages.ConsoleLogError,
                    FunctionsMessages.ConsoleLogInfo,
                    FunctionsMessages.ConsoleLogParseInfo,
                    Datnik.verbosity);

                string html = "";
                if (Datnik.isInputDir == false) comp.ParseFile(new FileInfo(Datnik.input), out html);
                else comp.ParseFolder(new DirectoryInfo(Datnik.input), out html);

                if (html != null)
                {
                    File.WriteAllText(Datnik.output, html);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                FunctionsMessages.printFatalError(ex.Message);
                return false;
            }
        }
    }
}
