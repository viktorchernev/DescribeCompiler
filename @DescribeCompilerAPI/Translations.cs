using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler
{
    public interface IUnfoldTranslator
    {
        bool IsInitialized();
        string TranslateUnfold(DescribeUnfold u);

        
    }
    public class UnfoldTranslator : IUnfoldTranslator
    {
        static string defaultTemplate = "HTML_PARACORD";
        public string selectedTemplate;

        static string pageTemplate;
        static string rootTemplate;
        static string itemTemplate;
        static string emptyItemTemplate;
        static string commentItemTemplate;
        static string coloredItemTemplate;
        static string prodTemplate;
        static string linkTemplate;

        public UnfoldTranslator(string template = null)
        {
            LogText = log;
            LogInfo = log;
            LogError = log;

            try
            {
                if(template != null) selectedTemplate = template;
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
                        if (finfo.Name.StartsWith("Page"))
                            pageTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Root"))
                            rootTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Production"))
                            prodTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemEmpty"))
                            emptyItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemComment"))
                            commentItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemColored"))
                            coloredItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Item"))
                            itemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Link"))
                            linkTemplate = File.ReadAllText(finfo.FullName);
                    }


                    bool flag = false;
                    if (pageTemplate == null)
                    {
                        LogError("No \"Page\" Template found during translation.");
                        flag = true;
                    }
                    if (rootTemplate == null)
                    {
                        LogError("No \"Root\" Template found during translation.");
                        flag = true;
                    }
                    if (prodTemplate == null)
                    {
                        LogError("No \"Production\" Template found during translation.");
                        flag = true;
                    }
                    if (itemTemplate == null)
                    {
                        LogError("No \"Item\" Template found during translation.");
                        flag = true;
                    }
                    if (emptyItemTemplate == null)
                    {
                        LogError("No \"ItemEmpty\" Template found during translation.");
                        flag = true;
                    }
                    if (commentItemTemplate == null)
                    {
                        LogError("No \"ItemComment\" Template found during translation.");
                        flag = true;
                    }
                    if (coloredItemTemplate == null)
                    {
                        LogError("No \"ItemColored\" Template found during translation.");
                        flag = true;
                    }
                    if (linkTemplate == null)
                    {
                        LogError("No \"Link\" Template found during translation.");
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
                    pageTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Page");
                    rootTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Root");
                    prodTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Production");
                    itemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Item");
                    emptyItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemEmpty");
                    commentItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemComment");
                    coloredItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemColored");
                    linkTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Link");

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

        public UnfoldTranslator(
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
                        if (finfo.Name.StartsWith("Page"))
                            pageTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Root"))
                            rootTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Production"))
                            prodTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemEmpty"))
                            emptyItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemComment"))
                            commentItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemColored"))
                            coloredItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Item"))
                            itemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Link"))
                            linkTemplate = File.ReadAllText(finfo.FullName);
                    }


                    bool flag = false;
                    if (pageTemplate == null)
                    {
                        LogError("No \"Page\" Template found during translation.");
                        flag = true;
                    }
                    if (rootTemplate == null)
                    {
                        LogError("No \"Root\" Template found during translation.");
                        flag = true;
                    }
                    if (prodTemplate == null)
                    {
                        LogError("No \"Production\" Template found during translation.");
                        flag = true;
                    }
                    if (itemTemplate == null)
                    {
                        LogError("No \"Item\" Template found during translation.");
                        flag = true;
                    }
                    if (emptyItemTemplate == null)
                    {
                        LogError("No \"ItemEmpty\" Template found during translation.");
                        flag = true;
                    }
                    if (commentItemTemplate == null)
                    {
                        LogError("No \"ItemComment\" Template found during translation.");
                        flag = true;
                    }
                    if (coloredItemTemplate == null)
                    {
                        LogError("No \"ItemColored\" Template found during translation.");
                        flag = true;
                    }
                    if (linkTemplate == null)
                    {
                        LogError("No \"Link\" Template found during translation.");
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
                    pageTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Page");
                    rootTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Root");
                    prodTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Production");
                    itemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Item");
                    emptyItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemEmpty");
                    commentItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemComment");
                    coloredItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemColored");
                    linkTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Link");

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

        public UnfoldTranslator(
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
                        if (finfo.Name.StartsWith("Page"))
                            pageTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Root"))
                            rootTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Production"))
                            prodTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemEmpty"))
                            emptyItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemComment"))
                            commentItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemColored"))
                            coloredItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Item"))
                            itemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Link"))
                            linkTemplate = File.ReadAllText(finfo.FullName);
                    }


                    bool flag = false;
                    if (pageTemplate == null)
                    {
                        LogError("No \"Page\" Template found during translation.");
                        flag = true;
                    }
                    if (rootTemplate == null)
                    {
                        LogError("No \"Root\" Template found during translation.");
                        flag = true;
                    }
                    if (prodTemplate == null)
                    {
                        LogError("No \"Production\" Template found during translation.");
                        flag = true;
                    }
                    if (itemTemplate == null)
                    {
                        LogError("No \"Item\" Template found during translation.");
                        flag = true;
                    }
                    if (emptyItemTemplate == null)
                    {
                        LogError("No \"ItemEmpty\" Template found during translation.");
                        flag = true;
                    }
                    if (commentItemTemplate == null)
                    {
                        LogError("No \"ItemComment\" Template found during translation.");
                        flag = true;
                    }
                    if (coloredItemTemplate == null)
                    {
                        LogError("No \"ItemColored\" Template found during translation.");
                        flag = true;
                    }
                    if (linkTemplate == null)
                    {
                        LogError("No \"Link\" Template found during translation.");
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
                    pageTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Page");
                    rootTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Root");
                    prodTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Production");
                    itemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Item");
                    emptyItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemEmpty");
                    commentItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemComment");
                    coloredItemTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemColored");
                    linkTemplate =
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Link");

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

        public UnfoldTranslator(
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
                        if (finfo.Name.StartsWith("Page")) 
                            pageTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Root")) 
                            rootTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Production")) 
                            prodTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemEmpty"))
                            emptyItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemComment"))
                            commentItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("ItemColored"))
                            coloredItemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Item")) 
                            itemTemplate = File.ReadAllText(finfo.FullName);
                        else if (finfo.Name.StartsWith("Link")) 
                            linkTemplate = File.ReadAllText(finfo.FullName);
                    }
                    
                    
                    bool flag = false;
                    if (pageTemplate == null)
                    {
                        LogError("No \"Page\" Template found during translation.");
                        flag = true;
                    }
                    if (rootTemplate == null)
                    {
                        LogError("No \"Root\" Template found during translation.");
                        flag = true;
                    }
                    if (prodTemplate == null)
                    {
                        LogError("No \"Production\" Template found during translation.");
                        flag = true;
                    }
                    if (itemTemplate == null)
                    {
                        LogError("No \"Item\" Template found during translation.");
                        flag = true;
                    }
                    if (emptyItemTemplate == null)
                    {
                        LogError("No \"ItemEmpty\" Template found during translation.");
                        flag = true;
                    }
                    if (commentItemTemplate == null)
                    {
                        LogError("No \"ItemComment\" Template found during translation.");
                        flag = true;
                    }
                    if (coloredItemTemplate == null)
                    {
                        LogError("No \"ItemColored\" Template found during translation.");
                        flag = true;
                    }
                    if (linkTemplate == null)
                    {
                        LogError("No \"Link\" Template found during translation.");
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
                    pageTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate,  @"Page");
                    rootTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Root");
                    prodTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Production");
                    itemTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Item");
                    emptyItemTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemEmpty");
                    commentItemTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemComment");
                    coloredItemTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"ItemColored");
                    linkTemplate = 
                        ResourceUtil.ExtractResourceByFileName_String(selectedTemplate, @"Link");

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



        //http://xahlee.info/comp/unicode_circled_numbers.html
        static Dictionary<char, string> WhiteCircledLetters = new Dictionary<char, string>()
        {
            {'A', "&#x24B6"},
            {'B', "&#x24B7"},
            {'C', "&#x24B8"},
            {'D', "&#x24B9"},
            {'E', "&#x24BA"},
            {'F', "&#x24BB"},
            {'G', "&#x24BC"},
            {'H', "&#x24BD"},
            {'I', "&#x24BE"},
            {'J', "&#x24BF"},
            {'K', "&#x24C0"},
            {'L', "&#x24C1"},
            {'M', "&#x24C2"},
            {'N', "&#x24C3"},
            {'O', "&#x24C4"},
            {'P', "&#x24C5"},
            {'Q', "&#x24C6"},
            {'R', "&#x24C7"},
            {'S', "&#x24C8"},
            {'T', "&#x24C9"},
            {'U', "&#x24CA"},
            {'V', "&#x24CB"},
            {'W', "&#x24CC"},
            {'X', "&#x24CD"},
            {'Y', "&#x24CE"},
            {'Z', "&#x24CF"},
            {'a', "&#x24D0"},
            {'b', "&#x24D1"},
            {'c', "&#x24D2"},
            {'d', "&#x24D3"},
            {'e', "&#x24D4"},
            {'f', "&#x24D5"},
            {'g', "&#x24D6"},
            {'h', "&#x24D7"},
            {'i', "&#x24D8"},
            {'j', "&#x24D9"},
            {'k', "&#x24DA"},
            {'l', "&#x24DB"},
            {'m', "&#x24DC"},
            {'n', "&#x24DD"},
            {'o', "&#x24DE"},
            {'p', "&#x24DF"},
            {'q', "&#x24E0"},
            {'r', "&#x24E1"},
            {'s', "&#x24E2"},
            {'t', "&#x24E3"},
            {'u', "&#x24E4"},
            {'v', "&#x24E5"},
            {'w', "&#x24E6"},
            {'x', "&#x24E7"},
            {'y', "&#x24E8"},
            {'z', "&#x24E9"},
        };
        static Dictionary<int, string> intWhiteCircledLetters = new Dictionary<int, string>()
        {
            {0, "&#x24B6"},
            {1, "&#x24B7"},
            {2, "&#x24B8"},
            {3, "&#x24B9"},
            {4, "&#x24BA"},
            {5, "&#x24BB"},
            {6, "&#x24BC"},
            {7, "&#x24BD"},
            {8, "&#x24BE"},
            {9, "&#x24BF"},
            {10, "&#x24C0"},
            {11, "&#x24C1"},
            {12, "&#x24C2"},
            {13, "&#x24C3"},
            {14, "&#x24C4"},
            {15, "&#x24C5"},
            {16, "&#x24C6"},
            {17, "&#x24C7"},
            {18, "&#x24C8"},
            {19, "&#x24C9"},
            {20, "&#x24CA"},
            {21, "&#x24CB"},
            {22, "&#x24CC"},
            {23, "&#x24CD"},
            {24, "&#x24CE"},
            {25, "&#x24CF"},
            {26, "&#x24D0"},
            {27, "&#x24D1"},
            {28, "&#x24D2"},
            {29, "&#x24D3"},
            {30, "&#x24D4"},
            {31, "&#x24D5"},
            {32, "&#x24D6"},
            {33, "&#x24D7"},
            {34, "&#x24D8"},
            {35, "&#x24D9"},
            {36, "&#x24DA"},
            {37, "&#x24DB"},
            {38, "&#x24DC"},
            {39, "&#x24DD"},
            {40, "&#x24DE"},
            {41, "&#x24DF"},
            {42, "&#x24E0"},
            {43, "&#x24E1"},
            {44, "&#x24E2"},
            {45, "&#x24E3"},
            {46, "&#x24E4"},
            {47, "&#x24E5"},
            {48, "&#x24E6"},
            {49, "&#x24E7"},
            {50, "&#x24E8"},
            {51, "&#x24E9"},
        };
        static Dictionary<char, string> BlackCircledLetters = new Dictionary<char, string>()
        {
            {'A', "&#x1F150"},
            {'B', "&#x1F151"},
            {'C', "&#x1F152"},
            {'D', "&#x1F153"},
            {'E', "&#x1F154"},
            {'F', "&#x1F155"},
            {'G', "&#x1F156"},
            {'H', "&#x1F157"},
            {'I', "&#x1F158"},
            {'J', "&#x1F159"},
            {'K', "&#x1F15A"},
            {'L', "&#x1F15B"},
            {'M', "&#x1F15C"},
            {'N', "&#x1F15D"},
            {'O', "&#x1F15E"},
            {'P', "&#x1F15F"},
            {'Q', "&#x1F160"},
            {'R', "&#x1F161"},
            {'S', "&#x1F162"},
            {'T', "&#x1F163"},
            {'U', "&#x1F164"},
            {'V', "&#x1F165"},
            {'W', "&#x1F166"},
            {'X', "&#x1F167"},
            {'Y', "&#x1F168"},
            {'Z', "&#x1F169"},
        };
        static Dictionary<int, string> intBlackCircledLetters = new Dictionary<int, string>()
        {
            {0, "&#x1F150"},
            {1, "&#x1F151"},
            {2, "&#x1F152"},
            {3, "&#x1F153"},
            {4, "&#x1F154"},
            {5, "&#x1F155"},
            {6, "&#x1F156"},
            {7, "&#x1F157"},
            {8, "&#x1F158"},
            {9, "&#x1F159"},
            {10, "&#x1F15A"},
            {11, "&#x1F15B"},
            {12, "&#x1F15C"},
            {13, "&#x1F15D"},
            {14, "&#x1F15E"},
            {15, "&#x1F15F"},
            {16, "&#x1F160"},
            {17, "&#x1F161"},
            {18, "&#x1F162"},
            {19, "&#x1F163"},
            {20, "&#x1F164"},
            {21, "&#x1F165"},
            {22, "&#x1F166"},
            {23, "&#x1F167"},
            {24, "&#x1F168"},
            {25, "&#x1F169"},
        };
        static Dictionary<int, string> WhiteCircledNumbers = new Dictionary<int, string>()
        {
            {0, "&#x24EA"},
            {1, "&#x2460"},
            {2, "&#x2461"},
            {3, "&#x2462"},
            {4, "&#x2463"},
            {5, "&#x2464"},
            {6, "&#x2465"},
            {7, "&#x2466"},
            {8, "&#x2467"},
            {9, "&#x2468"},
            {10, "&#x2469"},
            {11, "&#x246A"},
            {12, "&#x246B"},
            {13, "&#x246C"},
            {14, "&#x246D"},
            {15, "&#x246E"},
            {16, "&#x246F"},
            {17, "&#x2470"},
            {18, "&#x2471"},
            {19, "&#x2472"},
            {20, "&#x2473"}
        };



        /// <summary>
        /// Get html code from unfold
        /// </summary>
        /// <param name="u">The unfold to be translated</param>
        /// <returns>The generated html code</returns>
        public string TranslateUnfold(DescribeUnfold u)
        {
            if (_initialized == false) return null;

            string data = "";
            foreach (string key in u.PrimaryProductions)
            {
                string s = TranslateProductionOrItem(u, key);
                data += s;
            }

            string rt = rootTemplate.Replace("{ITEMS}", data);
            string pt = pageTemplate.Replace("{DATA}", rt);
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
                    template = template.Replace("{TEXT}", intBlackCircledLetters[i]);
                    linkage += template;
                }
                linkage = " " + linkage;
            }

            //replace in template
            string pt = prodTemplate.Replace("{TITLE}", u.Translations[id] + linkage);
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
                    template = template.Replace("{TEXT}", intBlackCircledLetters[i]);
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
                        string res = commentItemTemplate.Replace("{ITEM}", u.Translations[id] + linkage);
                        return res;
                    }
                    else if (s.StartsWith("color|"))
                    {
                        string val = s.Substring(6);
                        string res = coloredItemTemplate.Replace("{ITEM}", u.Translations[id] + linkage);
                        res = res.Replace("{COLOR}", val);
                        return res;
                    }
                }
            }
            string it = itemTemplate.Replace("{ITEM}", u.Translations[id] + linkage);
            return it;
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