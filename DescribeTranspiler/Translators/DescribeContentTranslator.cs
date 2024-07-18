using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler.Translators
{
    public abstract class DescribeContentTranslator : DescribeTranslator
    {
        public override bool IsInitialized
        {
            get;
            protected set;
        }


        public readonly string TemplatesFolderName;
        Dictionary<string, string> Templates;



        /// <summary>
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        public DescribeContentTranslator(string templatesFolderName, string[] templateNames)
        {
            //set default log handlers
            LogText = log;
            LogInfo = log;
            LogError = log;

            //try to initialize templates
            try
            {
                Templates = new Dictionary<string, string>();
                TemplatesFolderName = templatesFolderName;
                string n = templatesFolderName;
                foreach(string tname in templateNames)
                {
                    string template = ResourceUtil.ExtractResourceByFileName_String(n, tname);
                    Templates.Add(tname, template);
                }

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                LogError("Fatal error: " + ex.Message);
            }
        }

        /// <summary>
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        /// <param name="logText">method to log text</param>
        public DescribeContentTranslator(string templatesFolderName, string[] templateNames,
            Action<string> logText)
        {
            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogError = log;

            //try to initialize templates
            try
            {
                Templates = new Dictionary<string, string>();
                TemplatesFolderName = templatesFolderName;
                string n = templatesFolderName;
                foreach (string tname in templateNames)
                {
                    string template = ResourceUtil.ExtractResourceByFileName_String(n, tname);
                    Templates.Add(tname, template);
                }

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                LogError("Fatal error: " + ex.Message);
            }
        }

        /// <summary>
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        public DescribeContentTranslator(string templatesFolderName, string[] templateNames,
            Action<string> logText, Action<string> logError)
        {
            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;

            LogError = log;
            LogError += logError;

            //try to initialize templates
            try
            {
                Templates = new Dictionary<string, string>();
                TemplatesFolderName = templatesFolderName;
                string n = templatesFolderName;
                foreach (string tname in templateNames)
                {
                    string template = ResourceUtil.ExtractResourceByFileName_String(n, tname);
                    Templates.Add(tname, template);
                }

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                LogError("Fatal error: " + ex.Message);
            }
        }

        /// <summary>
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        public DescribeContentTranslator(string templatesFolderName, string[] templateNames,
            Action<string> logText, Action<string> logError, Action<string> logInfo)
        {
            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogInfo += logInfo;

            LogError = log;
            LogError += logError;

            //try to initialize templates
            try
            {
                Templates = new Dictionary<string, string>();
                TemplatesFolderName = templatesFolderName;
                string n = templatesFolderName;
                foreach (string tname in templateNames)
                {
                    string template = ResourceUtil.ExtractResourceByFileName_String(n, tname);
                    Templates.Add(tname, template);
                }

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                LogError("Fatal error: " + ex.Message);
            }
        }



        //log
        public string Log
        {
            get;
            private set;
        }
        public Action<string> LogInfo;
        public Action<string> LogError;
        public Action<string> LogText;
        private void log(string text)
        {
            if (!string.IsNullOrEmpty(Log)) Log += Environment.NewLine;
            Log += text;
        }
    }
}
