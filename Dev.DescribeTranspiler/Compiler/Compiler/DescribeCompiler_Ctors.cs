using DescribeParser.Visitors;
using DescribeTranspiler.Preprocessors;
using System;
using Antlr4.Runtime;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public DescribeCompiler()
        {
            LogText = log;
            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(LogVerbosity.High);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(LogVerbosity verbosity)
        {
            LogText = log;
            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text</param>
        public DescribeCompiler(LogVerbosity verbosity,
            Action<string> logText)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text<</param>
        /// <param name="logError">method to log errors<</param>
        public DescribeCompiler(LogVerbosity verbosity,
            Action<string> logText, Action<string> logError)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogParserInfo = log;

            initializeCompiler(verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        public DescribeCompiler(LogVerbosity verbosity,
            Action<string> logText, Action<string> logError, Action<string> logInfo)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogInfo += logInfo;

            LogParserInfo = log;

            initializeCompiler(verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        /// <param name="logParserInfo">method to log parser output</param>
        public DescribeCompiler(LogVerbosity verbosity,
            Action<string> logText, Action<string> logError,
            Action<string> logInfo, Action<string> logParserInfo)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogInfo += logInfo;

            LogParserInfo = log;
            LogParserInfo += logParserInfo;

            initializeCompiler(verbosity);
        }



        private void initializeCompiler(LogVerbosity verbosity)
        {
            LogInfo("Initializing " + COMPILER_NAME);
            LoadedGrammarName = "";
            LanguageVersion = DescribeVersion.Version10;

            //init
            try
            {
                _preprocessors = new Dictionary<DescribeVersion, IDescribePreprocessor>();
                _preprocessors.Add(DescribeVersion.Version06, new PreprocessorFor06(this));
                _preprocessors.Add(DescribeVersion.Version07, new PreprocessorFor07(this));
                _preprocessors.Add(DescribeVersion.Version08, new PreprocessorFor08(this));
                _preprocessors.Add(DescribeVersion.Version09, new PreprocessorFor09(this));
                _preprocessors.Add(DescribeVersion.Version10, new PreprocessorFor10(this));
                _preprocessors.Add(DescribeVersion.Version11, new PreprocessorFor11(this));

                //_GoldParser = new GoldParser.Parser.Parser();
                //LogInfo("GOLD parser engine initialized");

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
            //try
            //{
            //    string grammarname = GrammarNameToResourceName(DEFAULT_GRAMMAR);
            //    byte[] grammar = ResourceUtil.ExtractResource_ByteArray(grammarname);
            //    string fullname = GrammarNameToFullGramarName(DEFAULT_GRAMMAR);
            //    if (LoadGrammar(grammar))
            //    {
            //        LogInfo("Preloaded grammar: \"" + fullname + "\"");
            //        if (Verbosity != LogVerbosity.High) LogText("------------------------");
            //        LoadedGrammarName = fullname;
            //    }
            //    else
            //    {
            //        LogInfo("Failed to preload grammar: \"" + fullname + "\"");
            //        if (Verbosity != LogVerbosity.High) LogText("------------------------");
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    LogError("Failed to preload grammar: " + ex.Message);
            //    if (Verbosity != LogVerbosity.High) LogText("------------------------");
            //    return;
            //}

            isInitialized = true;
        }
    }
}