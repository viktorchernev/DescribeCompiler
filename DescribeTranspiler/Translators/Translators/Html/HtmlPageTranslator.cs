using DescribeParser;
using DescribeParser.Unfold;
using Mysqlx.Session;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;


namespace DescribeTranspiler.Translators
{
    /// <summary>
    /// Translate Unfold to a simple HTML page with some CSS styling
    /// </summary>
    public class HtmlPageTranslator : DescribeUnfoldTranslator
    {
        public bool IsCensored = false;

        public override bool IsInitialized
        {
            get;
            protected set;
        }


        //templates
        const string templatesFolderName = "HTML_PAGE";
        static string? pageTemplate;
        static string? rootTemplate;
        static string? itemTemplate;
        static string? emptyItemTemplate;
        static string? commentItemTemplate;
        static string? nlcommentItemTemplate;
        static string? coloredItemTemplate;
        static string? productionTemplate;
        static string? coloredProductionTemplate;
        static string? linkTemplate;



        /// <summary>
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        public HtmlPageTranslator()
        {
            Log = "";

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
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        /// <param name="logText">method to log text</param>
        public HtmlPageTranslator(Action<string> logText)
        {
            Log = "";

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
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        public HtmlPageTranslator(Action<string> logText, Action<string> logError)
        {
            Log = "";

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
        /// Ctor.
        /// The Translator is loaded with the default templates.
        /// </summary>
        /// <param name="logText">method to log text</param>
        /// <param name="logError">method to log errors</param>
        /// <param name="logInfo">method to log less important info</param>
        public HtmlPageTranslator(Action<string> logText, Action<string> logError, Action<string> logInfo)
        {
            Log = "";

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
                nlcommentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemCommentNl");
                commentItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemComment");
                coloredItemTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"ItemColored");
                linkTemplate = ResourceUtil.ExtractResourceByFileName_String(n, @"Link");

                LogInfo("Translator initialized - \"" + n + "\"");
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
        public override string? TranslateUnfold(DescribeUnfold u)
        {
            if (IsInitialized == false) return null;

            string data = "";
            foreach (string key in u.PrimaryProductions)
            {
                string s = TranslateProductionOrItem(u, key);
                data += s;
            }

            string rt = rootTemplate!.Replace("{ITEMS}", data);
            string pt = pageTemplate!.Replace("{DATA}", rt);

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
                string ver = "Built with Describe Compiler version " + DescribeCompiler.CompilerVersion;
                pt = pt.Replace("{VERSION}", ver);
            }
            if (pageTemplate.Contains("{SHORT_VERSION}"))
            {
                string ver = "Describe Compiler v " + DescribeCompiler.CompilerVersion;
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
                List<DescribeLink> links = u.Links[id];
                for (int i = 0; i < links.Count; i++)
                {
                    string url = links[i].Url;
                    url = url.Replace("\\", "");
                    if (url.StartsWith("http") == false)
                    {
                        url  = "https://" + url;
                    }
                    string template = linkTemplate!.Replace("{HTTPS}", url);
                    string linkLetter = TranslateLink(url, i);
                    template = template.Replace("{TEXT}", linkLetter);
                    linkage += template;
                }
                linkage = " " + linkage;
            }

            //replace in template
            string? colval = null;
            if (u.Decorators.ContainsKey(id))
            {
                List<DescribeDecorator> decorators = u.Decorators[id];
                foreach (DescribeDecorator decorator in decorators)
                {
                    if (decorator.Name == "color")
                    {
                        colval = decorator.Value;
                    }
                    else if (decorator.Name == "sensitive" && IsCensored)
                    {
                        string text = u.Translations[id];
                        string censored = Regex.Replace(text, @"\S", "?");
                        u.Translations[id] = censored;
                    }
                    else if (decorator.Name == "secret" && IsCensored)
                    {
                        string mask = GenerateRandomDarkSquares(random.Next(10, 30));
                        u.Translations[id] = mask;
                    }
                    else if (decorator.Name == "hidden" && IsCensored)
                    {
                        string mask = GenerateRandomGreekText(random.Next(40, 100));
                        u.Translations[id] = mask;
                    }
                }
            }

            if(colval == null)
            {
                string pt = productionTemplate!.Replace("{TITLE}", HttpUtility.HtmlEncode(u.Translations[id]));
                pt = pt.Replace("{LINKS}", linkage);
                pt = pt.Replace("{ITEMS}", items);
                return pt;
            }
            else
            {
                string res = coloredProductionTemplate!.Replace("{TITLE}", HttpUtility.HtmlEncode(u.Translations[id]));
                res = res.Replace("{LINKS}", linkage);
                res = res.Replace("{COLOR}", colval);
                res = res.Replace("{ITEMS}", items);
                return res;
            }
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
                    string url = links[i].Url;
                    url = url.Replace("\\", "");
                    if (url.StartsWith("http") == false)
                    {
                        url = "https://" + url;
                    }
                    string template = linkTemplate!.Replace("{HTTPS}", url);
                    string linkLetter = TranslateLink(url, i);
                    template = template.Replace("{TEXT}", linkLetter);
                    linkage += template;
                }
                linkage = " " + linkage;
            }

            //replace in template
            string before = "";
            string after = "";
            string res = itemTemplate!.Replace("{ITEM}", HttpUtility.HtmlEncode(u.Translations[id]));
            res = res.Replace("{LINKS}", linkage);
            if (u.Decorators.ContainsKey(id))
            {
                List<DescribeDecorator> decorators = u.Decorators[id];
                foreach (DescribeDecorator decorator in decorators)
                {
                    if (decorator.Name == "empty")
                    {
                        res = emptyItemTemplate!;
                    }
                    else if (decorator.Name == "comment")
                    {
                        res = commentItemTemplate!.Replace("{ITEM}", HttpUtility.HtmlEncode(u.Translations[id]));
                        res = res.Replace("{LINKS}", linkage);
                    }
                    else if (decorator.Name == "nlcomment")
                    {
                        res = nlcommentItemTemplate!.Replace("{ITEM}", HttpUtility.HtmlEncode(u.Translations[id]));
                        res = res.Replace("{LINKS}", linkage);
                    }
                    else if (decorator.Name == "color")
                    {
                        res = coloredItemTemplate!.Replace("{ITEM}", HttpUtility.HtmlEncode(u.Translations[id]));
                        res = res.Replace("{LINKS}", linkage);
                        res = res.Replace("{COLOR}", decorator.Value);
                    }
                    else if (decorator.Name == "bold")
                    {
                        before += "<span style='font-weight:bold;'>";
                        res += "</span>";
                    }
                    else if (decorator.Name == "italic")
                    {
                        res = "<span style='font-style:italic;'>" + res + "</span>";
                    }
                    else if (decorator.Name == "underlined")
                    {
                        res = "<span style='text-decoration-line:underline;'>" + res + "</span>";
                    }
                    else if (decorator.Name == "striked")
                    {
                        res = "<span style='text-decoration-line:line-through;'>" + res + "</span>";
                    }
                    else if (decorator.Name == "sensitive" && IsCensored)
                    {
                        string text = u.Translations[id];
                        string censored = Regex.Replace(text, @"\S", "?");

                        // possible bug here - this is bad way of doing things
                        // that is hacked into place. Should be refactored
                        res = res.Replace(u.Translations[id], censored);
                        u.Translations[id] = censored;
                    }
                    else if (decorator.Name == "secret" && IsCensored)
                    {
                        // possible bug here - this is bad way of doing things
                        // that is hacked into place. Should be refactored
                        string mask = GenerateRandomDarkSquares(random.Next(10, 30));
                        res = res.Replace(u.Translations[id], mask);
                        u.Translations[id] = mask;
                    }
                    else if (decorator.Name == "hidden" && IsCensored)
                    {
                        // possible bug here - this is bad way of doing things
                        // that is hacked into place. Should be refactored
                        string mask = GenerateRandomGreekText(random.Next(40, 100));
                        res = res.Replace(u.Translations[id], mask);
                        u.Translations[id] = mask;
                    }
                }
            }
            return before + res + after;
        }
        string TranslateLink(string url, int index)
        {
            if (isWikipediaUrl(url)) return makeWikipediaLink(url, index);
            else if (isYoutubeUrl(url)) return makeYoutubeLink(url, index);
            else return makeGenericLink(url, index);
        }


        //site recognizers
        bool isWikipediaUrl(string url)
        {
            if (url.StartsWith("https://www.wikipedia.org/")) return true;
            if (url.StartsWith("http://www.wikipedia.org/")) return true;
            if (url.StartsWith("https://en.wikipedia.org/")) return true;
            if (url.StartsWith("http://en.wikipedia.org/")) return true;
            return false;
        }
        bool isYoutubeUrl(string url)
        {
            if (url.StartsWith("https://www.youtube.com/")) return true;
            if (url.StartsWith("http://www.youtube.com/")) return true;
            return false;
        }

        //link generators
        string makeGenericLink(string url, int index)
        {
            string linkLetter = "";
            linkLetter = CharacterDictionariesHtml.BlackCircledLettersI[index];
            return linkLetter;
        }
        string makeWikipediaLink(string url, int index)
        {
            string linkLetter = "";
            linkLetter = CharacterDictionariesHtml.BlackCircledLettersI[22];
            linkLetter = "<span style='color:green;' >" + linkLetter + "</span>";
            return linkLetter;
        }
        string makeYoutubeLink(string url, int index)
        {
            string linkLetter = "";
            linkLetter = CharacterDictionariesHtml.BlackCircledLetters['Y'];
            linkLetter = "<span style='color:red;' >" + linkLetter + "</span>";
            return linkLetter;
        }

        //more
        Random random = new Random();
        string GenerateRandomGreekText(int length)
        {
            // Define a pool of Greek characters and spaces
            string pool = "α βγδ εζη θικ λμν ξοπ ρστ υφχ ψω άέή ίόύ ώ ";

            StringBuilder sb = new StringBuilder();

            // Generate random characters from the pool
            for (int i = 0; i < length; i++)
            {
                char randomChar = pool[random.Next(pool.Length)];
                sb.Append(randomChar);
            }

            return sb.ToString();
        }
        string GenerateRandomMathText(int length)
        {
            // Define a pool of Greek characters and spaces
            string pool = "+ - × ÷ = ≠ < > ≤ ≥ ∞ π ∑ ∫ √ ∆ ∇ ∝ ⊕ ⊗ ⊥ ⎰";

            StringBuilder sb = new StringBuilder();

            // Generate random characters from the pool
            for (int i = 0; i < length; i++)
            {
                char randomChar = pool[random.Next(pool.Length)];
                sb.Append(randomChar);
            }

            return sb.ToString();
        }
        string GenerateRandomDarkSquares(int length)
        {
            // Define a pool of Greek characters and spaces
            string pool = "▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇▇";

            StringBuilder sb = new StringBuilder();

            // Generate random characters from the pool
            for (int i = 0; i < length; i++)
            {
                char randomChar = pool[random.Next(pool.Length)];
                sb.Append(randomChar);
            }

            return sb.ToString();
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