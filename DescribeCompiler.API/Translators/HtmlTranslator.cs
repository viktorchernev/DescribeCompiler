using System;
using System.Collections.Generic;


namespace DescribeCompiler.Translators
{
    public class HtmlTranslator : DescribeTranslator
    {
        public override bool IsInitialized
        {
            get;
            protected set;
        }


        //templates
        const string templatesFolderName = "HTML_PARACORD";
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



        /// <summary>
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        public HtmlTranslator()
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
                nlcommentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemCommentNl");
                commentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemComment");
                coloredItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemColored");
                linkTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Link");

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
        /// Get html code from unfold
        /// </summary>
        /// <param name="u">The unfold to be translated</param>
        /// <returns>The generated html code</returns>
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
                List<string> links = u.Links[id];
                for (int i = 0; i < links.Count; i++)
                {
                    links[i] = links[i].Replace("\\", "");
                    if (links[i].StartsWith("http") == false)
                    {
                        links[i] = "https://" + links[i];
                    }
                    string template = linkTemplate.Replace("{HTTPS}", links[i]);
                    template = template.Replace("{TEXT}", CharacterDictionariesHtml.BlackCircledLettersI[i]);
                    linkage += template;
                }
                linkage = " " + linkage;
            }

            //replace in template
            if (u.Decorators.ContainsKey(id))
            {
                List<string> decorators = u.Decorators[id];
                foreach (string s in decorators)
                {
                    if (s.StartsWith("color|"))
                    {
                        string val = s.Substring(6);
                        string res = coloredProductionTemplate.Replace("{TITLE}", u.Translations[id]);
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{COLOR}", val);
                        res = res.Replace("{ITEMS}", items);
                        return res;
                    }
                }
            }
            string pt = productionTemplate.Replace("{TITLE}", u.Translations[id]);
            pt = pt.Replace("{LINKS}", linkage);
            pt = pt.Replace("{ITEMS}", items);
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
                List<string> links = u.Links[id];
                for (int i = 0; i < links.Count; i++)
                {
                    links[i] = links[i].Replace("\\", "");
                    if (links[i].StartsWith("http") == false)
                    {
                        links[i] = "https://" + links[i];
                    }
                    string template = linkTemplate.Replace("{HTTPS}", links[i]);
                    template = template.Replace("{TEXT}", CharacterDictionariesHtml.BlackCircledLettersI[i]);
                    linkage += template;
                }
                linkage = " " + linkage;
            }

            //replace in template
            if (u.Decorators.ContainsKey(id))
            {
                List<string> decorators = u.Decorators[id];
                foreach (string s in decorators)
                {
                    if (s == "empty")
                    {
                        return emptyItemTemplate;
                    }
                    else if (s == "comment")
                    {
                        string res = commentItemTemplate.Replace("{ITEM}", u.Translations[id]);
                        res = res.Replace("{LINKS}", linkage);
                        return res;
                    }
                    else if (s == "nlcomment")
                    {
                        string res = nlcommentItemTemplate.Replace("{ITEM}", u.Translations[id]);
                        res = res.Replace("{LINKS}", linkage);
                        return res;
                    }
                    else if (s.StartsWith("color|"))
                    {
                        string val = s.Substring(6);
                        string res = coloredItemTemplate.Replace("{ITEM}", u.Translations[id]);
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{COLOR}", val);
                        return res;
                    }
                }
            }
            string it = itemTemplate.Replace("{ITEM}", u.Translations[id]);
            it = it.Replace("{LINKS}", linkage);
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