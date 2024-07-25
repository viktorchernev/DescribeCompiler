using DescribeParser;
using DescribeParser.Unfold;
using System;
using System.Collections.Generic;


namespace DescribeTranspiler.Translators
{
    public class JsonBasicTranslator : DescribeTranslator
    {
        public override bool IsInitialized
        {
            get;
            protected set;
        }


        //templates
        const string templatesFolderName = "JSON_COMMONER";
        static string pageTemplate;
        static string rootTemplate;
        static string itemTemplate;
        static string emptyItemTemplate;
        static string commentItemTemplate;
        static string nlcommentItemTemplate;
        static string coloredItemTemplate;
        static string productionTemplate;
        static string coloredProductionTemplate;
        static string linkTemplate;
        static string decoratorTemplate;


        /// <summary>
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        public JsonBasicTranslator()
        {
            //set default log handlers
            LogText = log;
            LogInfo = log;
            LogError = log;

            //try to initialize templates
            try
            {
                string n = templatesFolderName;
                pageTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Page");
                rootTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Root");
                coloredProductionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ProductionColored");
                productionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Production");
                itemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Item");
                emptyItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemEmpty");
                commentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemComment");
                nlcommentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemCommentNl");
                coloredItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemColored");
                linkTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Link");
                decoratorTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Decorator");

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
        public JsonBasicTranslator(Action<string> logText)
        {
            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogError = log;

            //try to initialize templates
            try
            {
                string n = templatesFolderName;
                pageTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Page");
                rootTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Root");
                coloredProductionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ProductionColored");
                productionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Production");
                itemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Item");
                emptyItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemEmpty");
                commentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemComment");
                nlcommentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemCommentNl");
                coloredItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemColored");
                linkTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Link");
                decoratorTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Decorator");

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
        public JsonBasicTranslator(Action<string> logText, Action<string> logError)
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
                string n = templatesFolderName;
                pageTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Page");
                rootTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Root");
                coloredProductionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ProductionColored");
                productionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Production");
                itemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Item");
                emptyItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemEmpty");
                commentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemComment");
                nlcommentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemCommentNl");
                coloredItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemColored");
                linkTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Link");
                decoratorTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Decorator");

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
        public JsonBasicTranslator(Action<string> logText, Action<string> logError, Action<string> logInfo)
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
                string n = templatesFolderName;
                pageTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Page");
                rootTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Root");
                coloredProductionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ProductionColored");
                productionTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Production");
                itemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Item");
                emptyItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemEmpty");
                commentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemComment");
                nlcommentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemCommentNl");
                coloredItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemColored");
                linkTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Link");
                decoratorTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Decorator");

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
        /// Get JSON code from unfold
        /// </summary>
        /// <param name="u">The unfold to be translated</param>
        /// <returns>The generated JSON code</returns>
        public override string TranslateUnfold(DescribeUnfold u)
        {
            if (IsInitialized == false) return null;

            string data = "";
            foreach (string key in u.PrimaryProductions)
            {
                string s = TranslateProductionOrItem(u, key);
                data += s;
            }

            string rt = rootTemplate.Replace("{ITEMS}", data);
            string pt = pageTemplate.Replace("{DATA}", rt);

            if (pageTemplate.Contains("{TIME_STAMP}"))
            {
                DateTime dt = DateTime.UtcNow;
                string time = "Built on " + dt.Day.ToString().PadLeft(2, '0')
                    + " " + dt.ToString("MMMM")
                    + " " + dt.Year.ToString() + ", "
                    + dt.Hour.ToString().PadLeft(2, '0') + ":"
                    + dt.Minute.ToString().PadLeft(2, '0') + ":"
                    + dt.Second.ToString().PadLeft(2, '0') + "."
                    + dt.Millisecond.ToString().PadLeft(3, '0') + " (UTC)";
                pt = pt.Replace("{TIME_STAMP}", time);
            }
            if (pageTemplate.Contains("{SHORT_TIME_STAMP}"))
            {
                DateTime dt = DateTime.UtcNow;
                string time = dt.Day.ToString().PadLeft(2, '0')
                    + " " + dt.ToString("MMM")
                    + " " + dt.Year.ToString() + ", "
                    + dt.Hour.ToString().PadLeft(2, '0') + ":"
                    + dt.Minute.ToString().PadLeft(2, '0') + ":"
                    + dt.Second.ToString().PadLeft(2, '0');
                pt = pt.Replace("{SHORT_TIME_STAMP}", time);
            }
            if (pageTemplate.Contains("{VERSION}"))
            {
                string ver = "Built with Describe Compiler version " + DescribeCompiler.COMPILER_VER;
                pt = pt.Replace("{VERSION}", ver);
            }
            if (pageTemplate.Contains("{SHORT_VERSION}"))
            {
                string ver = "Describe Compiler v " + DescribeCompiler.COMPILER_VER;
                pt = pt.Replace("{SHORT_VERSION}", ver);
            }

            return pt;
        }
        string TranslateProductionOrItem(DescribeUnfold u, string id)
        {
            if (u.Productions.ContainsKey(id)) return TranslateProduction(u, id);
            else return TranslateItem(u, id);
        }
        string TranslateProduction(DescribeUnfold u, string id)
        {
            List<string> li = new List<string>();
            if (u.Productions.ContainsKey(id)) li = u.Productions[id];
            string items = "";
            foreach (string s in li)
            {
                string z = TranslateProductionOrItem(u, s);
                if (items != "") items += ",";
                items += z;
            }

            //do links
            //we are assuming there would be no backslashes in links
            //because we are unescaping our links. Also, we are
            //assuming there is no item with mode then 26 links
            //or we will run out or dictionary symbols
            string linkage = "";
            if (u.Links.ContainsKey(id))
            {
                List<DescribeLink> links = u.Links[id];
                for (int i = 0; i < links.Count; i++)
                {
                    string url = links[i].Url;
                    url = url.Replace("\\", "");
                    if (url.StartsWith("http") == false)
                    {
                        url = "https://" + url;
                    }
                    string template = linkTemplate.Replace("{HTTPS}", url);
                    template = template.Replace("{TEXT}", CharacterDictionariesHtml.BlackCircledLettersI[i]);
                    if (linkage.Length > 0) linkage += ",";
                    linkage += template;
                }
            }

            string customDecorators = "";
            //replace in template
            if (u.Decorators.ContainsKey(id))
            {
                List<DescribeDecorator> decorators = u.Decorators[id];

                //Get custom decorators first
                foreach (DescribeDecorator d in decorators)
                {
                    if (d.Name != "custom") continue;
                    if (d.Category == null) continue;

                    string decorator = decoratorTemplate.Replace("{NAME}", d.Name);
                    decorator = decorator.Replace("{VALUE}", d.Value);
                    //decorator = decorator.Replace("{VALUE}", "");
                    if (!string.IsNullOrEmpty(customDecorators)) customDecorators += ",";
                    customDecorators += decorator;
                }

                foreach (DescribeDecorator d in decorators)
                {
                    if (d.Name == "color")
                    {
                        string res = coloredProductionTemplate.Replace("{TITLE}",
                            u.Translations[id].Replace("\\", "\\\\").Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{DECORATORS}", customDecorators);
                        res = res.Replace("{COLOR}", d.Value);
                        res = res.Replace("{ITEMS}", items);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                }
            }
            string pt = productionTemplate.Replace("{TITLE}",
                u.Translations[id].Replace("\\", "\\\\").Replace("\"", "\\\""));

            //HAcKeD IN PLACE REMOVE
            string cur = u.ProdidFile[id][0];
            if(u.ParseJob.InitialDir != null) cur = cur.Substring(u.ParseJob.InitialDir.Length);
            cur = cur.Trim('\\', '/').Replace('\\', '.').Replace('/', '.');
            if (cur.EndsWith(".ds")) cur = cur.Substring(0, cur.Length - 3);
            pt = pt.Replace(",\"text\":", ",\"filename\":\"" + cur + "\",\"text\":");

            pt = pt.Replace("{LINKS}", linkage);
            pt = pt.Replace("{DECORATORS}", customDecorators);
            pt = pt.Replace("{ITEMS}", items);
            if (pt.Contains("{ID}")) pt = pt.Replace("{ID}", id);

            return pt;
        }
        string TranslateItem(DescribeUnfold u, string id)
        {
            //do links
            //we are assuming there would be no backslashes in links
            //because we are unescaping our links. Also, we are
            //assuming there is no item with mode then 26 links
            //or we will run out or dictionary symbols
            string linkage = "";
            if (u.Links.ContainsKey(id))
            {
                List<DescribeLink> links = u.Links[id];
                for (int i = 0; i < links.Count; i++)
                {
                    string url = links[i].Url.Replace("\\", "");
                    if (url.StartsWith("http") == false)
                    {
                        url = "https://" + url;
                    }
                    string template = linkTemplate.Replace("{HTTPS}", url);
                    template = template.Replace("{TEXT}", CharacterDictionariesHtml.BlackCircledLettersI[i]);
                    if (linkage.Length > 0) linkage += ",";
                    linkage += template;
                }
            }

            string customDecorators = "";
            //replace in template
            if (u.Decorators.ContainsKey(id))
            {
                List<DescribeDecorator> decorators = u.Decorators[id];

                //Get custom decorators first
                foreach (DescribeDecorator d in decorators)
                {
                    if (d.Name != "custom") continue;
                    if (d.Category == null) continue;

                    string decorator = decoratorTemplate.Replace("{NAME}", d.Name);
                    decorator = decorator.Replace("{VALUE}", d.Value);
                    //decorator = decorator.Replace("{VALUE}", "");
                    if (!string.IsNullOrEmpty(customDecorators)) customDecorators += ",";
                    customDecorators += decorator;
                }

                foreach (DescribeDecorator d in decorators)
                {
                    if (d.Name == "empty")
                    {
                        return emptyItemTemplate;
                    }
                    else if (d.Name == "comment")
                    {
                        string res = commentItemTemplate.Replace("{ITEM}",
                                u.Translations[id].Replace("\\", "\\\\")
                                .Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{DECORATORS}", customDecorators);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                    else if (d.Name == "nlcomment")
                    {
                        string res = nlcommentItemTemplate.Replace("{ITEM}",
                                u.Translations[id].Replace("\\", "\\\\")
                                .Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{DECORATORS}", customDecorators);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                    else if (d.Name == "color")
                    {
                        string res = coloredItemTemplate.Replace("{ITEM}",
                            u.Translations[id].Replace("\\", "\\\\")
                            .Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{DECORATORS}", customDecorators);
                        res = res.Replace("{COLOR}", d.Value);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                }
            }
            string it = itemTemplate.Replace("{ITEM}",
                u.Translations[id].Replace("\\", "\\\\")
                .Replace("\"", "\\\""));
            it = it.Replace("{LINKS}", linkage);
            it = it.Replace("{DECORATORS}", customDecorators);
            if (it.Contains("{ID}")) it = it.Replace("{ID}", id);
            return it;
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
