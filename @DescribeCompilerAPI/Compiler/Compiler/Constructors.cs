using DescribeCompiler.Compiler.Optimizers;
using DescribeCompiler.Compiler.Preprocessors;
using System;

namespace DescribeCompiler
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

            switch (DEFAULT_GRAMMAR)
            {
                case GrammarName.Basic:
                    _Optimizer = new OptimizerForDescribe06();
                    _Preprocessor = new PreprocessorForDescribe06();
                    break;
                case GrammarName.Tags:
                    _Optimizer = new OptimizerForDescribe07();
                    _Preprocessor = new PreprocessorForDescribe07();
                    break;
                case GrammarName.Links:
                    _Optimizer = new OptimizerForDescribe08();
                    _Preprocessor = new PreprocessorForDescribe08();
                    break;
                case GrammarName.Decorators:
                    _Optimizer = new OptimizerForDescribe09();
                    _Preprocessor = new PreprocessorForDescribe09();
                    break;
                case GrammarName.Official:
                default:
                    _Optimizer = new OptimizerForDescribe10();
                    _Preprocessor = new PreprocessorForDescribe10();
                    break;
            }

            
            initializeCompiler(LogVerbosity.High);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        public DescribeCompiler(
            LogVerbosity verbosity)
        {
            LogText = log;
            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            switch (DEFAULT_GRAMMAR)
            {
                case GrammarName.Basic:
                    _Optimizer = new OptimizerForDescribe06();
                    _Preprocessor = new PreprocessorForDescribe06();
                    break;
                case GrammarName.Tags:
                    _Optimizer = new OptimizerForDescribe07();
                    _Preprocessor = new PreprocessorForDescribe07();
                    break;
                case GrammarName.Links:
                    _Optimizer = new OptimizerForDescribe08();
                    _Preprocessor = new PreprocessorForDescribe08();
                    break;
                case GrammarName.Decorators:
                    _Optimizer = new OptimizerForDescribe09();
                    _Preprocessor = new PreprocessorForDescribe09();
                    break;
                case GrammarName.Official:
                default:
                    _Optimizer = new OptimizerForDescribe10();
                    _Preprocessor = new PreprocessorForDescribe10();
                    break;
            }

            initializeCompiler(verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text</param>
        public DescribeCompiler(
            LogVerbosity verbosity,
            Action<string> logText)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogInfo = log;
            LogParserInfo = log;

            switch (DEFAULT_GRAMMAR)
            {
                case GrammarName.Basic:
                    _Optimizer = new OptimizerForDescribe06();
                    _Preprocessor = new PreprocessorForDescribe06();
                    break;
                case GrammarName.Tags:
                    _Optimizer = new OptimizerForDescribe07();
                    _Preprocessor = new PreprocessorForDescribe07();
                    break;
                case GrammarName.Links:
                    _Optimizer = new OptimizerForDescribe08();
                    _Preprocessor = new PreprocessorForDescribe08();
                    break;
                case GrammarName.Decorators:
                    _Optimizer = new OptimizerForDescribe09();
                    _Preprocessor = new PreprocessorForDescribe09();
                    break;
                case GrammarName.Official:
                default:
                    _Optimizer = new OptimizerForDescribe10();
                    _Preprocessor = new PreprocessorForDescribe10();
                    break;
            }

            initializeCompiler(verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text<</param>
        /// <param name="logError">method to log errors<</param>
        public DescribeCompiler(
            LogVerbosity verbosity,
            Action<string> logText,
            Action<string> logError)
        {
            LogText = log;
            LogText += logText;

            LogError = log;
            LogError += logError;

            LogInfo = log;
            LogParserInfo = log;

            switch (DEFAULT_GRAMMAR)
            {
                case GrammarName.Basic:
                    _Optimizer = new OptimizerForDescribe06();
                    _Preprocessor = new PreprocessorForDescribe06();
                    break;
                case GrammarName.Tags:
                    _Optimizer = new OptimizerForDescribe07();
                    _Preprocessor = new PreprocessorForDescribe07();
                    break;
                case GrammarName.Links:
                    _Optimizer = new OptimizerForDescribe08();
                    _Preprocessor = new PreprocessorForDescribe08();
                    break;
                case GrammarName.Decorators:
                    _Optimizer = new OptimizerForDescribe09();
                    _Preprocessor = new PreprocessorForDescribe09();
                    break;
                case GrammarName.Official:
                default:
                    _Optimizer = new OptimizerForDescribe10();
                    _Preprocessor = new PreprocessorForDescribe10();
                    break;
            }

            initializeCompiler(verbosity);
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="verbosity">The logging verbosity of the parser</param>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        public DescribeCompiler(
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

            switch (DEFAULT_GRAMMAR)
            {
                case GrammarName.Basic:
                    _Optimizer = new OptimizerForDescribe06();
                    _Preprocessor = new PreprocessorForDescribe06();
                    break;
                case GrammarName.Tags:
                    _Optimizer = new OptimizerForDescribe07();
                    _Preprocessor = new PreprocessorForDescribe07();
                    break;
                case GrammarName.Links:
                    _Optimizer = new OptimizerForDescribe08();
                    _Preprocessor = new PreprocessorForDescribe08();
                    break;
                case GrammarName.Decorators:
                    _Optimizer = new OptimizerForDescribe09();
                    _Preprocessor = new PreprocessorForDescribe09();
                    break;
                case GrammarName.Official:
                default:
                    _Optimizer = new OptimizerForDescribe10();
                    _Preprocessor = new PreprocessorForDescribe10();
                    break;
            }

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
        public DescribeCompiler(
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

            switch (DEFAULT_GRAMMAR)
            {
                case GrammarName.Basic:
                    _Optimizer = new OptimizerForDescribe06();
                    _Preprocessor = new PreprocessorForDescribe06();
                    break;
                case GrammarName.Tags:
                    _Optimizer = new OptimizerForDescribe07();
                    _Preprocessor = new PreprocessorForDescribe07();
                    break;
                case GrammarName.Links:
                    _Optimizer = new OptimizerForDescribe08();
                    _Preprocessor = new PreprocessorForDescribe08();
                    break;
                case GrammarName.Decorators:
                    _Optimizer = new OptimizerForDescribe09();
                    _Preprocessor = new PreprocessorForDescribe09();
                    break;
                case GrammarName.Official:
                default:
                    _Optimizer = new OptimizerForDescribe10();
                    _Preprocessor = new PreprocessorForDescribe10();
                    break;
            }

            initializeCompiler(verbosity);
        }



        private void initializeCompiler(LogVerbosity verbosity)
        {
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