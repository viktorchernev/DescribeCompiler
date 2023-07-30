using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="templateName">The name of the templates set to use</param>
        public DescribeCompiler(string templateName)
        {
            LogText = log;
            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(templateName, LogVerbosity.High);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="templateName">The name of the templates set to use</param>
        public DescribeCompiler(string templateName, LogVerbosity verbosity)
        {
            LogText = log;
            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(templateName, verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="templateName">The name of the templates set to use</param>
        /// <param name="logText">method to log text</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            string templateName,
            LogVerbosity verbosity,
            Action<string> logText)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(templateName, verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="templateName">The name of the templates set to use</param>
        /// <param name="logText">method to log text<</param>
        /// <param name="logError">method to log errors<</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            string templateName,
            LogVerbosity verbosity,
            Action<string> logText,
            Action<string> logError)
        {
            Translator = new HtmlTranslator(logText, logError, templateName);

            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(templateName, verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="templateName">The name of the templates set to use</param>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            string templateName,
            LogVerbosity verbosity,
            Action<string> logText,
            Action<string> logError,
            Action<string> logInfo)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogInfo += logInfo;

            LogParserInfo = log;

            initializeCompiler(templateName, verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="templateName">The name of the templates set to use</param>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        /// <param name="logParserInfo">method to log parser output</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            string templateName,
            LogVerbosity verbosity,
            Action<string> logText,
            Action<string> logError,
            Action<string> logInfo,
            Action<string> logParserInfo)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogInfo += logInfo;

            LogParserInfo = log;
            LogParserInfo += logParserInfo;

            initializeCompiler(templateName, verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="templateName">The name of the templates set to use</param>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        /// <param name="logParserInfo">method to log parser output</param>
        /// <param name="translator">The translator to be used</param>
        public DescribeCompiler(
            string templateName,
            LogVerbosity verbosity,
            Action<string> logText,
            Action<string> logError,
            Action<string> logInfo,
            Action<string> logParserInfo,
            IUnfoldTranslator translator)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogInfo += logInfo;

            LogParserInfo = log;
            LogParserInfo += logParserInfo;

            Translator = translator;

            initializeCompiler(templateName, verbosity);
        }



        private void initializeCompiler(string templateName, LogVerbosity verbosity)
        {
            if (templateName.StartsWith("HTML_"))
                Translator = new HtmlTranslator(LogText, LogError, LogInfo, templateName);
            else if (templateName.StartsWith("JSON_"))
                Translator = new JsonTranslator(LogText, LogError, LogInfo, templateName);
            else
                Translator = new HtmlTranslator(LogText, LogError, LogInfo, templateName);
            if (Translator.IsInitialized() == false)
            {
                LogError("Failed to initialize the translator");
                return;
            }

            LogInfo("Initializing " + COMPILER_NAME);
            LoadedGrammarName = "";

            //init
            try
            {
                _GoldParser = new GoldParser.Parser.Parser();
                LogInfo("GOLD parser engine initialized");

                //set verbosity
                Verbosity = verbosity;
                LogInfo("Verbosity set to: " + Verbosity.ToString());
            }
            catch (Exception ex)
            {
                LogError("Failed to initialize GOLD parser: " + ex.Message);
                return;
            }

            //preload default grammar
            try
            {
                string grammarname = GrammarNameToResourceName(DEFAULT_GRAMMAR);
                byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
                string fullname = GrammarNameToFullGramarName(DEFAULT_GRAMMAR);
                if (LoadGrammar(grammar))
                {
                    LogInfo("Preloaded grammar: \"" + fullname + "\"");
                    if (Verbosity != LogVerbosity.High) LogText("------------------------");
                    LoadedGrammarName = fullname;
                }
                else
                {
                    LogInfo("Failed to preload grammar: \"" + fullname + "\"");
                    if (Verbosity != LogVerbosity.High) LogText("------------------------");
                    return;
                }
            }
            catch (Exception ex)
            {
                LogError("Failed to preload grammar: " + ex.Message);
                if (Verbosity != LogVerbosity.High) LogText("------------------------");
                return;
            }

            isInitialized = true;
        }
    }
}