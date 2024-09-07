using DescribeTranspiler.Translators;
using DescribeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescribeParser.Unfold;
using DescribeTranspiler.Listiary.Translators;

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
                comp.PARSE_TOP_DIRECTORY_ONLY = Datnik.topOnly;
                comp.PARSE_DS_ONLY = Datnik.dsOnly;
                comp.STOP_ON_ERROR = Datnik.requireSuccess;

                //templates
                DescribeUnfoldTranslator translator;
                if (Datnik.translatorName.ToLower().StartsWith("json_listiary")
                    || Datnik.translatorName.ToLower() == "json_listiary")
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
                else if (Datnik.translatorName.ToLower().StartsWith("html_plain"))
                {
                    translator = new HtmlBasicTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("html_")
                    || Datnik.translatorName.ToLower() == "html")
                {
                    translator = new HtmlPageTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("xml_")
                    || Datnik.translatorName.ToLower() == "xml")
                {
                    translator = new XmlBasicTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("sql_")
                    || Datnik.translatorName.ToLower() == "sql")
                {
                    translator = new SqlFileFillTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
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
                if (Datnik.isInputDir == false) r = comp.ParseFile(new FileInfo(Datnik.input!), ref unfold);
                else r = comp.ParseFolder(new DirectoryInfo(Datnik.input!), ref unfold);

                string? result; 
                if(Datnik.isBeautified)
                {
                    if (translator is JsonBasicTranslator)
                        result = (translator as JsonBasicTranslator)!.TranslateUnfoldPretty(unfold);
                    else if (translator is JsonListiaryTranslator)
                        result = (translator as JsonListiaryTranslator)!.TranslateUnfoldPretty(unfold);
                    else result = translator.TranslateUnfold(unfold);
                }
                else
                {
                    result = translator.TranslateUnfold(unfold);
                }

                if (result != null)
                {
                    File.WriteAllText(Datnik.output!, result);
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
