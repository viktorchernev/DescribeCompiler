using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler.Translators
{
    public class JsonTranslator : DescribeTranslator
    {
        public override bool USES_TEMPLATES
        {
            get { return true; }
        }
        public override bool HAS_INBUILT_TEMPLATES
        {
            get { return true; }
        }
        public override string DEFAULT_TEMPLATES_NAME
        {
            get { return "JSON_COMMONER"; }
        }
        public override bool IsInitialized
        {
            get;
            protected set;
        }


        //templates
        public bool selectInbuiltTemplate = true;
        public string selectedTemplate = null;

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
        public JsonTranslator()
        {
            //set default log handlers
            LogText = log;
            LogInfo = log;
            LogError = log;

            //try to initialize templates
            try
            {
                if (!USES_TEMPLATES)
                {
                    IsInitialized = true;
                    LogInfo("Translator initialized - not using templates");
                }
                else if (HAS_INBUILT_TEMPLATES)
                {
                    string n = DEFAULT_TEMPLATES_NAME;
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

                    LogInfo("Translator initialized - using template \"" + n + "\"");
                    selectInbuiltTemplate = true;
                    selectedTemplate = n;
                    IsInitialized = true;
                }
                else
                {
                    LogInfo("Translator NOT initialized - Must further load templates from folder before using.");
                    selectInbuiltTemplate = false;
                    IsInitialized = false;
                }
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
        public JsonTranslator(Action<string> logText)
        {
            //set default log handlers
            LogText = log;
            LogText += logText;

            LogInfo = log;
            LogError = log;

            //try to initialize templates
            try
            {
                if (!USES_TEMPLATES)
                {
                    IsInitialized = true;
                    LogInfo("Translator initialized - not using templates");
                }
                else if (HAS_INBUILT_TEMPLATES)
                {
                    string n = DEFAULT_TEMPLATES_NAME;
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

                    LogInfo("Translator initialized - using template \"" + n + "\"");
                    selectInbuiltTemplate = true;
                    selectedTemplate = n;
                    IsInitialized = true;
                }
                else
                {
                    LogInfo("Translator NOT initialized - Must further load templates from folder before using.");
                    selectInbuiltTemplate = false;
                    IsInitialized = false;
                }
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
        public JsonTranslator(Action<string> logText, Action<string> logError)
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
                if (!USES_TEMPLATES)
                {
                    IsInitialized = true;
                    LogInfo("Translator initialized - not using templates");
                }
                else if (HAS_INBUILT_TEMPLATES)
                {
                    string n = DEFAULT_TEMPLATES_NAME;
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

                    LogInfo("Translator initialized - using template \"" + n + "\"");
                    selectInbuiltTemplate = true;
                    selectedTemplate = n;
                    IsInitialized = true;
                }
                else
                {
                    LogInfo("Translator NOT initialized - Must further load templates from folder before using.");
                    selectInbuiltTemplate = false;
                    IsInitialized = false;
                }
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
        public JsonTranslator(Action<string> logText, Action<string> logError, Action<string> logInfo)
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
                if (!USES_TEMPLATES)
                {
                    IsInitialized = true;
                    LogInfo("Translator initialized - not using templates");
                }
                else if (HAS_INBUILT_TEMPLATES)
                {
                    string n = DEFAULT_TEMPLATES_NAME;
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

                    LogInfo("Translator initialized - using template \"" + n + "\"");
                    selectInbuiltTemplate = true;
                    selectedTemplate = n;
                    IsInitialized = true;
                }
                else
                {
                    LogInfo("Translator NOT initialized - Must further load templates from folder before using.");
                    selectInbuiltTemplate = false;
                    IsInitialized = false;
                }
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                LogError("Fatal error: " + ex.Message);
            }
        }




        /// <summary>
        /// Load templates from an external folder.
        /// </summary>
        /// <param name="path">The path to the desired templates folder</param>
        /// <returns>True if successful</returns>
        public bool LoadExternalTemplates(string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                if (directoryInfo.Exists)
                {
                    FileInfo[] fs = directoryInfo.GetFiles();
                    foreach (FileInfo finfo in fs)
                    {
                        // make sure that "ItemEmpty" or "ItemComment" and all other
                        // that start with Item are before "Item"
                        if (finfo.Name.StartsWith("Page")) pageTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Root")) rootTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ProductionColored")) coloredProductionTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Production")) productionTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemEmpty")) emptyItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemCommentNl")) nlcommentItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemComment")) commentItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemColored")) coloredItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Item")) itemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Link")) linkTemplate = File.ReadAllText(finfo.FullName);
                    }

                    LogInfo("Translator initialized - using external template \"" + path + "\"");
                    selectInbuiltTemplate = false;
                    selectedTemplate = path;
                    IsInitialized = true;
                    return true;
                }
                else
                {
                    LogInfo("Translator Not initialized - external template path does not exist \"" + path + "\"");
                    selectInbuiltTemplate = false;
                    selectedTemplate = path;
                    IsInitialized = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                LogError("Fatal error: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Load templates from an internal folder of embedded resources.
        /// </summary>
        /// <param name="name">The name of the internal folder</param>
        /// <returns>True if successful</returns>
        public bool LoadInternalTemplates(string name)
        {
            try
            {
                pageTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"Page");
                rootTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"Root");
                coloredProductionTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"ProductionColored");
                productionTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"Production");
                itemTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"Item");
                emptyItemTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"ItemEmpty");
                commentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"ItemComment");
                nlcommentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"ItemCommentNl");
                coloredItemTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"ItemColored");
                linkTemplate = ResourceUtil.ExtractResourceByFileName_String(name, @"Link");

                LogInfo("Translator initialized - using template \"" + name + "\"");
                selectInbuiltTemplate = true;
                selectedTemplate = name;
                IsInitialized = true;
                return true;
            }
            catch (Exception ex)
            {
                IsInitialized = false;
                LogError("Fatal error: " + ex.Message);
                return false;
            }
        }



        /// <summary>
        /// Get JSON code from unfold
        /// </summary>
        /// <param name="u">The unfold to be translated</param>
        /// <returns>The generated JSON code</returns>
        public string TranslateUnfold(DescribeUnfold u)
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
                    if (linkage.Length > 0) linkage += ",";
                    linkage += template;
                }
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
                        string res = coloredProductionTemplate.Replace("{TITLE}", 
                            u.Translations[id].Replace("\\", "\\\\").Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{COLOR}", val);
                        res = res.Replace("{ITEMS}", items);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                }
            }
            string pt = productionTemplate.Replace("{TITLE}", 
                u.Translations[id].Replace("\\", "\\\\").Replace("\"", "\\\""));

            //HAcKeD IN PLACE REMOVE
            string cur = u.ProdIdFile[id];
            cur = cur.Substring(u.InitialDir.Length);
            cur = cur.Trim('\\', '/').Replace('\\', '.').Replace('/', '.');
            if (cur.EndsWith(".ds")) cur = cur.Substring(0, cur.Length - 3);
            pt = pt.Replace(",\"text\":", ",\"filename\":\"" + cur + "\",\"text\":");

            pt = pt.Replace("{LINKS}", linkage);
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
                    if (linkage.Length > 0) linkage += ",";
                    linkage += template;
                }
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
                        string res = commentItemTemplate.Replace("{ITEM}", 
                                u.Translations[id].Replace("\\", "\\\\")
                                .Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                    else if (s == "nlcomment")
                    {
                        string res = nlcommentItemTemplate.Replace("{ITEM}",
                                u.Translations[id].Replace("\\", "\\\\")
                                .Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                    else if (s.StartsWith("color|"))
                    {
                        string val = s.Substring(6);
                        string res = coloredItemTemplate.Replace("{ITEM}", 
                            u.Translations[id].Replace("\\", "\\\\")
                            .Replace("\"", "\\\""));
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{COLOR}", val);
                        if (res.Contains("{ID}")) res = res.Replace("{ID}", id);
                        return res;
                    }
                }
            }
            string it = itemTemplate.Replace("{ITEM}", 
                u.Translations[id].Replace("\\", "\\\\")
                .Replace("\"", "\\\""));
            it = it.Replace("{LINKS}", linkage);
            if(it.Contains("{ID}")) it = it.Replace("{ID}", id);
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
