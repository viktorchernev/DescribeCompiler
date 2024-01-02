using DescribeCompiler;
using DescribeCompiler.Compiler;
using DescribeCompiler.Translators;

using System;
using System.IO;


namespace DescribeCompiler.AWS
{
    internal static class MainFunctions
    {
        /// <summary>
        /// Compile source file(s)
        /// </summary>
        /// <param name="code">The describe source code to be parsed</param>
        /// <returns>True if successful, otherwise false</returns>
        internal static string Compile(string code, string filename)
        {
            try
            {
                DescribeCompiler comp =
                new DescribeCompiler(
                    Datnik.verbosity,
                    Messages.ConsoleLog,
                    Messages.ConsoleLogError,
                    Messages.ConsoleLogInfo,
                    Messages.ConsoleLogParseInfo);


                //templates
                JsonTranslator translator;
                if(Datnik.translatorName.ToLower().StartsWith("json_") 
                    || Datnik.translatorName.ToLower() == "json")
                {
                    translator = new JsonTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else
                {
                    Messages.printFatalError(
                        "Template name does not start with \"HTML_\" or \"JSON_\"," + 
                        " thus, it is not known which translator to use");
                    return null;
                }

                //compile
                DescribeUnfold unfold = new DescribeUnfold();
                bool r = comp.ParseString(code, filename, unfold);
                string result = translator.TranslateUnfold(unfold);
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