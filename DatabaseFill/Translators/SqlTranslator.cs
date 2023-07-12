using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DescribeCompiler;

namespace DatabaseFill.Translators
{
    public class SqlTranslator : IUnfoldTranslator
    {
        static string defaultTemplate = "SQL_DATABASEFILL";
        public string selectedTemplate;

        static string failedFileQuery;
        static string passedFileQuery;

        public SqlTranslator(string template = null)
        {
            LogText = log;
            LogInfo = log;
            LogError = log;

            try
            {
                if (template != null) selectedTemplate = template;
                else selectedTemplate = defaultTemplate;

                string templatesDir = Assembly.GetExecutingAssembly().Location;
                templatesDir = Path.GetDirectoryName(templatesDir);
                templatesDir = templatesDir + "\\Templates";
                string tdir = templatesDir + "\\" + selectedTemplate;
                DirectoryInfo directoryInfo = new DirectoryInfo(tdir);

                if (directoryInfo.Exists)
                {
                    FileInfo[] fs = directoryInfo.GetFiles();
                    foreach (FileInfo finfo in fs)
                    {
                        // make sure that "ItemEmpty" or "ItemComment" and all other
                        // that start with Item are before "Item"
                        if (finfo.Name.StartsWith("PassedFileQuery"))
                            passedFileQuery = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("FailedFileQuery"))
                            failedFileQuery = File.ReadAllText(finfo.FullName);
                    }

                    bool flag = false;
                    if (passedFileQuery == null)
                    {
                        LogError("No \"PassedFileQuery\" Template found during translation.");
                        flag = true;
                    }
                    if (failedFileQuery == null)
                    {
                        LogError("No \"FailedFileQuery\" Template found during translation.");
                        flag = true;
                    }

                    if (!flag)
                    {
                        LogInfo("Describe translator initialized - using template \""
                            + selectedTemplate + "\"");
                        _initialized = true;
                    }
                }
                else
                {
                    passedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"PassedFileQuery");
                    failedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"FailedFileQuery");

                    LogInfo("Translator initialized - using template \""
                            + selectedTemplate + "\"");
                    _initialized = true;
                }
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }

        public SqlTranslator(
            Action<string> logText,
            string template = null)
        {
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogError = log;

            try
            {
                if (template != null) selectedTemplate = template;
                else selectedTemplate = defaultTemplate;

                string templatesDir = Assembly.GetExecutingAssembly().Location;
                templatesDir = Path.GetDirectoryName(templatesDir);
                templatesDir = templatesDir + "\\Templates";
                string tdir = templatesDir + "\\" + selectedTemplate;
                DirectoryInfo directoryInfo = new DirectoryInfo(tdir);

                if (directoryInfo.Exists)
                {
                    FileInfo[] fs = directoryInfo.GetFiles();
                    foreach (FileInfo finfo in fs)
                    {
                        // make sure that "ItemEmpty" or "ItemComment" and all other
                        // that start with Item are before "Item"
                        if (finfo.Name.StartsWith("PassedFileQuery"))
                            passedFileQuery = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("FailedFileQuery"))
                            failedFileQuery = File.ReadAllText(finfo.FullName);
                    }

                    bool flag = false;
                    if (passedFileQuery == null)
                    {
                        LogError("No \"PassedFileQuery\" Template found during translation.");
                        flag = true;
                    }
                    if (failedFileQuery == null)
                    {
                        LogError("No \"FailedFileQuery\" Template found during translation.");
                        flag = true;
                    }

                    if (!flag)
                    {
                        LogInfo("Describe translator initialized - using template \""
                            + selectedTemplate + "\"");
                        _initialized = true;
                    }
                }
                else
                {
                    passedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"PassedFileQuery");
                    failedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"FailedFileQuery");

                    LogInfo("Translator initialized - using template \""
                            + selectedTemplate + "\"");
                    _initialized = true;
                }
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }

        public SqlTranslator(
            Action<string> logText,
            Action<string> logError,
            string template = null)
        {
            LogText = log;
            LogText += logText;

            LogInfo = log;

            LogError = log;
            LogError += logError;

            try
            {
                if (template != null) selectedTemplate = template;
                else selectedTemplate = defaultTemplate;

                string templatesDir = Assembly.GetExecutingAssembly().Location;
                templatesDir = Path.GetDirectoryName(templatesDir);
                templatesDir = templatesDir + "\\Templates";
                string tdir = templatesDir + "\\" + selectedTemplate;
                DirectoryInfo directoryInfo = new DirectoryInfo(tdir);

                if (directoryInfo.Exists)
                {
                    FileInfo[] fs = directoryInfo.GetFiles();
                    foreach (FileInfo finfo in fs)
                    {
                        // make sure that "ItemEmpty" or "ItemComment" and all other
                        // that start with Item are before "Item"
                        if (finfo.Name.StartsWith("PassedFileQuery"))
                            passedFileQuery = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("FailedFileQuery"))
                            failedFileQuery = File.ReadAllText(finfo.FullName);
                    }

                    bool flag = false;
                    if (passedFileQuery == null)
                    {
                        LogError("No \"PassedFileQuery\" Template found during translation.");
                        flag = true;
                    }
                    if (failedFileQuery == null)
                    {
                        LogError("No \"FailedFileQuery\" Template found during translation.");
                        flag = true;
                    }

                    if (!flag)
                    {
                        LogInfo("Describe translator initialized - using template \""
                            + selectedTemplate + "\"");
                        _initialized = true;
                    }
                }
                else
                {
                    passedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"PassedFileQuery");
                    failedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"FailedFileQuery");

                    LogInfo("Translator initialized - using template \""
                            + selectedTemplate + "\"");
                    _initialized = true;
                }
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }

        public SqlTranslator(
            Action<string> logText,
            Action<string> logError,
            Action<string> logInfo,
            string template = null)
        {
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogInfo += logInfo;

            LogError = log;
            LogError += logError;

            try
            {
                if (template != null) selectedTemplate = template;
                else selectedTemplate = defaultTemplate;

                string templatesDir = Assembly.GetExecutingAssembly().Location;
                templatesDir = Path.GetDirectoryName(templatesDir);
                templatesDir = templatesDir + "\\Templates";
                string tdir = templatesDir + "\\" + selectedTemplate;
                DirectoryInfo directoryInfo = new DirectoryInfo(tdir);

                if (directoryInfo.Exists)
                {
                    FileInfo[] fs = directoryInfo.GetFiles();
                    foreach (FileInfo finfo in fs)
                    {
                        // make sure that "ItemEmpty" or "ItemComment" and all other
                        // that start with Item are before "Item"
                        if (finfo.Name.StartsWith("PassedFileQuery"))
                            passedFileQuery = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("FailedFileQuery"))
                            failedFileQuery = File.ReadAllText(finfo.FullName);
                    }

                    bool flag = false;
                    if (passedFileQuery == null)
                    {
                        LogError("No \"PassedFileQuery\" Template found during translation.");
                        flag = true;
                    }
                    if (failedFileQuery == null)
                    {
                        LogError("No \"FailedFileQuery\" Template found during translation.");
                        flag = true;
                    }

                    if (!flag)
                    {
                        LogInfo("Describe translator initialized - using template \""
                            + selectedTemplate + "\"");
                        _initialized = true;
                    }
                }
                else
                {
                    passedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"PassedFileQuery");
                    failedFileQuery =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"FailedFileQuery");

                    LogInfo("Translator initialized - using template \""
                            + selectedTemplate + "\"");
                    _initialized = true;
                }
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }






        public string TranslateUnfold(DescribeCompiler.DescribeUnfold u)
        {
            for (int i = 0; i < u.ParsedFiles.Count; i++)
            {
                string cur = u.ParsedFiles[i]; 
                cur = cur.Substring(u.InitialDir.Length);
                cur = cur.Trim('\\', '/').Replace('\\', '-').Replace('/', '-').Replace('.', '-');

                string text = File.ReadAllText(u.ParsedFiles[i]);
                cur = MySqlHelper.EscapeString(cur);
                text = MySqlHelper.EscapeString(text);
            }
            for (int i = 0; i < u.FailedFiles.Count; i++)
            {
                string cur = u.FailedFiles[i];
                cur = cur.Substring(u.InitialDir.Length);
            }

            return null;
        }




        public string Log
        {
            get;
            private set;
        }
        private void log(string text)
        {
            if (!string.IsNullOrEmpty(Log)) Log += Environment.NewLine;
            Log += text;
        }
        bool _initialized = false;
        public bool IsInitialized()
        {
            return _initialized;
        }

        //log handlers
        public Action<string> LogInfo;
        public Action<string> LogError;
        public Action<string> LogText;
    }
}
