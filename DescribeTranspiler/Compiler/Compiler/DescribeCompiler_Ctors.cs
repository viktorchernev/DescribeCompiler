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

            //init
            try
            {
                resetBase();
                resetStatistics();
                Verbosity = verbosity;

                LogInfo("Verbosity set to: " + Verbosity.ToString());
                LogInfo("Describe Transpiler initialized.");
            }
            catch (Exception ex)
            {
                LogError("Failed to initialize Describe Transpiler: " + ex.Message);
                return;
            }

            _isInitialized = true;
        }
    }
}