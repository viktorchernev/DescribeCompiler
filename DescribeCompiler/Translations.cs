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
        public static string TranslateUnfold(DescribeUnfold u)
        {
            string pageTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedPage.html");
            string rootTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedRoot.html");

            string data = "";
            foreach (string key in u.PrimaryProductions)
            {
                string s = TranslateProductionOrItem(u, key);
                data += s;
            }

            rootTemplate = rootTemplate.Replace("{ITEMS}", data);
            pageTemplate = pageTemplate.Replace("{DATA}", rootTemplate);
            return pageTemplate;
        }

        static string TranslateProductionOrItem(DescribeUnfold u, string id)
        {
            if (u.Productions.ContainsKey(id)) return TranslateProduction(u, id);
            else return TranslateItem(u, id);
        }
        static string TranslateProduction(DescribeUnfold u, string id)
        {
            string prodTemplate = "";
            prodTemplate = ResourceUtil.ExtractResource_String(@"NotSpacedProduction.html");

            List<string> li = new List<string>();
            if (u.Productions.ContainsKey(id)) li = u.Productions[id];
            string items = "";
            foreach (string s in li)
            {
                string z = TranslateProductionOrItem(u, s);
                items += z;
            }
            prodTemplate = prodTemplate.Replace("{TITLE}", u.Translations[id]);
            prodTemplate = prodTemplate.Replace("{ITEMS}", items);
            return prodTemplate;
        }
        static string TranslateItem(DescribeUnfold u, string id)
        {
            string itemTemplate  = ResourceUtil.ExtractResource_String(@"NotSpacedItem.html");
            itemTemplate = itemTemplate.Replace("{ITEM}", u.Translations[id]);
            return itemTemplate;
        }
    }
}