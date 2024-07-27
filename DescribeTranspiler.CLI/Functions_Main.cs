using DescribeTranspiler.Translators;
using DescribeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescribeParser.Unfold;

namespace DescribeTranspiler.Cli
{
    internal static class MainFunctions
    {
        /// <summary>
        /// Compile source file(s)
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool Compile()
        {
            try
            {
                DescribeTranspiler.DescribeCompiler comp =
                new DescribeTranspiler.DescribeCompiler(
                    Datnik.verbosity,
                    Messages.ConsoleLog,
                    Messages.ConsoleLogError,
                    Messages.ConsoleLogInfo,
                    Messages.ConsoleLogParseInfo);

                //settings
                DescribeTranspiler.DescribeCompiler.PARSE_TOP_DIRECTORY_ONLY = Datnik.topOnly;
                DescribeTranspiler.DescribeCompiler.PARSE_DS_ONLY = Datnik.dsOnly;
                DescribeTranspiler.DescribeCompiler.STOP_ON_ERROR = Datnik.requireSuccess;

                //options
                comp.ArtifactMode = Datnik.artifactMode;
                if (Datnik.artifactMode != DescribeTranspiler.Compiler.ArtifactMode.No
                    && Datnik.artifactsFolderPath != null)
                {
                    comp.ArtifactsPath = Datnik.artifactsFolderPath;
                }

                //templates
                DescribeTranslator translator = null;
                if (Datnik.translatorName.ToLower().StartsWith("json_world_of_lists")
                    || Datnik.translatorName.ToLower() == "json_world_of_lists")
                {
                    translator = new JsonListiaryTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("json_")
                    || Datnik.translatorName.ToLower() == "json")
                {
                    translator = new JsonBasicTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("html_")
                    || Datnik.translatorName.ToLower() == "html")
                {
                    translator = new HtmlPageTranslator();
                    (translator as HtmlPageTranslator).LogText = Messages.ConsoleLog;
                    (translator as HtmlPageTranslator).LogError = Messages.ConsoleLogError;
                    (translator as HtmlPageTranslator).LogInfo = Messages.ConsoleLogInfo;
                }
                else
                {
                    Messages.printFatalError(
                        "Template name does not start with \"HTML_\" or \"JSON_\"," +
                        " thus, it is not known which translator to use");
                    return false;
                }

                //compile
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
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }
    }

}
