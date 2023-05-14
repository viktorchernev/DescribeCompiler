using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler
{
    public static class Translations
    {
        static string pageTemplate;
        static string rootTemplate;
        static string itemTemplate;
        static string emptyItemTemplate;
        static string commentItemTemplate;
        static string prodTemplate;

        static Translations()
        {
            pageTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedPage.html");
            rootTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedRoot.html");
            prodTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedProduction.html");
            itemTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedItem.html");

            emptyItemTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedItemEmpty.html");
            commentItemTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedItemComment.html");
        }



        /// <summary>
        /// Get html code from unfold
        /// </summary>
        /// <param name="u">The unfold to be translated</param>
        /// <returns>The generated html code</returns>
        public static string TranslateUnfold(DescribeUnfold u)
        {
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

        static string TranslateProductionOrItem(DescribeUnfold u, string id)
        {
            if (u.Productions.ContainsKey(id)) return TranslateProduction(u, id);
            else return TranslateItem(u, id);
        }
        static string TranslateProduction(DescribeUnfold u, string id)
        {
            List<string> li = new List<string>();
            if (u.Productions.ContainsKey(id)) li = u.Productions[id];
            string items = "";
            foreach (string s in li)
            {
                string z = TranslateProductionOrItem(u, s);
                items += z;
            }
            string pt = prodTemplate.Replace("{TITLE}", u.Translations[id]);
            pt = pt.Replace("{ITEMS}", items);
            return pt;
        }
        static string TranslateItem(DescribeUnfold u, string id)
        {
            if (u.Decorators.ContainsKey(id))
            {
                List<string> decorators = u.Decorators[id];
                foreach (string s in decorators)
                {
                    if (s.Replace(" ", "") == "empty")
                    {
                        return emptyItemTemplate;
                    }
                    else if (s.Replace(" ", "") == "comment")
                    {
                        string res = commentItemTemplate.Replace("{ITEM}", u.Translations[id]);
                        return res;
                    }
                }
            }
            string it = itemTemplate.Replace("{ITEM}", u.Translations[id]);
            return it;
        }
    }
}