﻿using DescribeParser.Unfold;
using DescribeTranspiler.Translators;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace DescribeTranspiler.Listiary.Translators
{
    /// <summary>
    /// Translates Describe Unfold to SQL queries intended at populating database with files.
    /// </summary>
    public class SqlFileFillTranslator : DescribeUnfoldTranslator
    {
        //templates
        static string? failedFileQueryTemplate;
        static string? passedFileQueryTemplate;

        public override bool IsInitialized
        {
            get;
            protected set;
        }



        public SqlFileFillTranslator()
        {
            Log = "";

            //set default log handlers
            LogText = log;
            LogInfo = log;
            LogError = log;

            try
            {
                string n = "SQL_FILEFILL";
                passedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"PassedFileQuery");
                failedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"FailedFileQuery");

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }

        public SqlFileFillTranslator(
            Action<string> logText)
        {
            Log = "";

            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogError = log;

            try
            {
                string n = "SQL_FILEFILL";
                passedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"PassedFileQuery");
                failedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"FailedFileQuery");

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }

        public SqlFileFillTranslator(
            Action<string> logText,
            Action<string> logError)
        {
            Log = "";

            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;

            LogError = log;
            LogError += logError;

            try
            {
                string n = "SQL_FILEFILL";
                passedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"PassedFileQuery");
                failedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"FailedFileQuery");

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }

        public SqlFileFillTranslator(
            Action<string> logText,
            Action<string> logError,
            Action<string> logInfo)
        {
            Log = "";

            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogInfo += logInfo;

            LogError = log;
            LogError += logError;

            try
            {
                string n = "SQL_FILEFILL";
                passedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"PassedFileQuery");
                failedFileQueryTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"FailedFileQuery");

                LogInfo("Translator initialized - using template \"" + n + "\"");
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                LogError("Fatal error: " + ex.Message);
            }
        }



        public override string TranslateUnfold(DescribeUnfold u)
        {
            string query = "";
            List<string> filenames = new List<string>();

            for (int i = 0; i < u.ParsedFiles.Count; i++)
            {
                string cur = u.ParsedFiles[i];
                cur = cur.Substring(u.ParseJob.InitialDir.Length);
                cur = JsonConvert.SerializeObject(cur); cur = cur.Substring(1, cur.Length - 2);
                //if (cur.EndsWith(".ds")) cur = cur.Substring(0, cur.Length - 3);
                if (filenames.Contains(cur)) return null;
                else filenames.Add(cur);

                string text = File.ReadAllText(u.ParsedFiles[i]);
                cur = MySqlHelper.EscapeString(cur);
                text = MySqlHelper.EscapeString(text);

                string pt = passedFileQueryTemplate.Replace("{FILE_NAME}", cur);
                pt = pt.Replace("{FILE_CONTENT}", text);
                query += pt;
            }
            for (int i = 0; i < u.FailedFiles.Count; i++)
            {
                string cur = u.FailedFiles[i];
                cur = cur.Substring(u.ParseJob.InitialDir.Length);
                cur = JsonConvert.SerializeObject(cur); cur = cur.Substring(1, cur.Length - 2);
                cur = cur.TrimStart('\\');
                //if (cur.EndsWith(".ds")) cur = cur.Substring(0, cur.Length - 3);
                if (filenames.Contains(cur)) return null;
                else filenames.Add(cur);

                string text = File.ReadAllText(u.ParsedFiles[i]);
                cur = MySqlHelper.EscapeString(cur);
                text = MySqlHelper.EscapeString(text);

                string ft = failedFileQueryTemplate.Replace("{FILE_NAME}", cur);
                ft = ft.Replace("{FILE_CONTENT}", text);
                query += ft;
            }

            return query;
        }



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
