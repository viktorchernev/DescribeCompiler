using DescribeCompiler;
using DescribeCompiler.Translators;

using System;
using System.IO;


namespace DescribeCompilerCLI
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
                DescribeCompiler.DescribeCompiler comp =
                new DescribeCompiler.DescribeCompiler(
                    Datnik.verbosity,
                    Messages.ConsoleLog,
                    Messages.ConsoleLogError,
                    Messages.ConsoleLogInfo,
                    Messages.ConsoleLogParseInfo);

                //settings
                DescribeCompiler.DescribeCompiler.PARSE_TOP_DIRECTORY_ONLY = Datnik.topOnly;
                DescribeCompiler.DescribeCompiler.PARSE_DS_ONLY = Datnik.dsOnly;
                DescribeCompiler.DescribeCompiler.STOP_ON_ERROR = Datnik.requireSuccess;

                //options
                comp.ArtifactMode = Datnik.artifactMode;
                if(Datnik.artifactMode != DescribeCompiler.Compiler.ArtifactMode.No 
                    && Datnik.artifactsFolderPath != null)
                {
                    comp.ArtifactsPath = Datnik.artifactsFolderPath;
                }

                //templates
                DescribeTranslator translator = null;
                if(Datnik.translatorName.ToLower().StartsWith("json_world_of_lists")
                    || Datnik.translatorName.ToLower() == "json_world_of_lists")
                {
                    translator = new JsonTranslatorWOL(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if(Datnik.translatorName.ToLower().StartsWith("json_") 
                    || Datnik.translatorName.ToLower() == "json")
                {
                    translator = new JsonTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if(Datnik.translatorName.ToLower().StartsWith("html_")
                    || Datnik.translatorName.ToLower() == "html")
                {
                    translator = new HtmlTranslator();
                    (translator as HtmlTranslator).LogText = Messages.ConsoleLog;
                    (translator as HtmlTranslator).LogError = Messages.ConsoleLogError;
                    (translator as HtmlTranslator).LogInfo = Messages.ConsoleLogInfo;
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