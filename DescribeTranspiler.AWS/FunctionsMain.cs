using DescribeTranspiler;
using DescribeTranspiler.Translators;
using DescribeParser;

using System;
using System.IO;
using DescribeParser.Unfold;
using DescribeTranspiler.Listiary.Translators;


namespace DescribeCompiler.AWS
{
    internal static class MainFunctions
    {
        /// <summary>
        /// Compile source file(s)
        /// </summary>
        /// <param name="code">The describe source code to be parsed</param>
        /// <param name="filename">The describe source code file name</param>
        /// <returns>True if successful, otherwise false</returns>
        internal static string? Compile(string code, string filename)
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
                if (comp.LanguageVersion != Datnik.langVer) comp.LanguageVersion = Datnik.langVer;

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
                        "Template name does not start with \"HTML_\", \"JSON_\", \"XML_\" or \"SQL_\"," +
                        " thus, it is not known which translator to use");
                    return null;
                }

                //compile
                DescribeUnfold unfold = new DescribeUnfold();
                bool r = false;
                if (Datnik.parseEncryptedFiles == false)
                {
                    if (Datnik.isInputDir == false) r = comp.ParseFile(new FileInfo(Datnik.input!), ref unfold);
                    else r = comp.ParseFolder(new DirectoryInfo(Datnik.input!), ref unfold);
                }
                else
                {
                    //encrypted file
                    return null;
                }

                //translate
                string? result;
                if (Datnik.isBeautified)
                {
                    if (translator is JsonBasicTranslator)
                        result = (translator as JsonBasicTranslator)!.TranslateUnfoldPretty(unfold);
                    else if (translator is JsonListiaryTranslator)
                        result = (translator as JsonListiaryTranslator)!.TranslateUnfoldPretty(unfold);
                    else if (translator is XmlBasicTranslator)
                        result = (translator as XmlBasicTranslator)!.TranslateUnfoldPretty(unfold);
                    else result = translator.TranslateUnfold(unfold);
                }
                else
                {
                    result = translator.TranslateUnfold(unfold);
                }
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Function.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return null;
            }
        }

        /// <summary>
        /// Compile source files
        /// </summary>
        /// <param name="codes">The describe source codes to be parsed</param>
        /// <returns>True if successful, otherwise false</returns>
        internal static string? CompileMulty(List<KeyValuePair<string, string>> codes)
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
                if (comp.LanguageVersion != Datnik.langVer) comp.LanguageVersion = Datnik.langVer;


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
                        "Template name does not start with \"HTML_\", \"JSON_\", \"XML_\" or \"SQL_\"," +
                        " thus, it is not known which translator to use");
                    return null;
                }

                //compile
                DescribeUnfold unfold = new DescribeUnfold();
                bool r = false;
                if (Datnik.parseEncryptedFiles == false)
                {
                    if (Datnik.isInputDir == false) r = comp.ParseFile(new FileInfo(Datnik.input!), ref unfold);
                    else r = comp.ParseFolder(new DirectoryInfo(Datnik.input!), ref unfold);
                }
                else
                {
                    //encrypted file
                    return null;
                }

                //translate
                string? result;
                if (Datnik.isBeautified)
                {
                    if (translator is JsonBasicTranslator)
                        result = (translator as JsonBasicTranslator)!.TranslateUnfoldPretty(unfold);
                    else if (translator is JsonListiaryTranslator)
                        result = (translator as JsonListiaryTranslator)!.TranslateUnfoldPretty(unfold);
                    else if (translator is XmlBasicTranslator)
                        result = (translator as XmlBasicTranslator)!.TranslateUnfoldPretty(unfold);
                    else result = translator.TranslateUnfold(unfold);
                }
                else
                {
                    result = translator.TranslateUnfold(unfold);
                }
                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Function.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return null;
            }
        }
    }
}