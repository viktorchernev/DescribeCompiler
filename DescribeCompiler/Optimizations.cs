using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DescribeCompiler
{
    public static class Optimizations
    {
        //Misc
        private static Random random = new Random();
        private static string getRandomString(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static string GetRuleName(Reduction r)
        {
            string ruleName = r.Production.Head.Name;
            return ruleName;
        }


        //Tagging

        //Tags
        private static string DoTag(Reduction r)
        {
            string id = DoText(r[1].Data as Reduction);
            return id;
        }

        //<links>
        //::= Link Link
        //| Link <links>
        private static string DoLink(string text)
        {
            string s = text.Substring(1, text.Length - 2);
            return s;
        }
        private static string[] DoLinks(Reduction r)
        {
            string s1 = DoLink(r[0].Data.ToString());

            string ruleName = r[1].Symbol.Name;
            if (ruleName == "Link")
            {
                string s2 = DoLink(r[1].Data.ToString());
                return new string[] { s1, s2 };
            }
            else
            {
                string[] links = DoLinks(r[1].Data as Reduction);
                List<string> li = new List<string>() { s1 };
                li.AddRange(links);
                return li.ToArray();
            }
        }

        //<decorators>
        //::= Decorator Decorator
        //| Decorator <decorators>
        private static string DoDecorator(string text)
        {
            string s = text.Substring(1, text.Length - 2);
            return s;
        }
        private static string[] DoDecorators(Reduction r)
        {
            string s1 = DoDecorator(r[0].Data.ToString());

            string ruleName = r[1].Symbol.Name;
            if (ruleName == "Decorator")
            {
                string s2 = DoDecorator(r[1].Data.ToString());
                return new string[] { s1, s2 };
            }
            else
            {
                string[] decorators = DoDecorators(r[1].Data as Reduction);
                List<string> li = new List<string>() { s1 };
                li.AddRange(decorators);
                return li.ToArray();
            }
        }



        //Text

        //<text-chunk>
        //::= Text | EscapeHyphen | EscapeLeftArrow | EscapeRightArrow | EscapeSeparator
        //| EscapeTerminator | EscapeStar | EscapeEscape | EscapeFSlash | EscapeBSlash
        //| EscapeLeftSquare | EscapeRightSquare | EscapeLeftCurl | EscapeRightCurl
        private static string DoTextChunk(Reduction r)
        {
            GrammarSymbol sym = r.Production.Handle[0];
            string text = "";
            switch (sym.Name)
            {
                case "Text":
                default:
                    text = r[0].Data.ToString();
                    break;
                case "EscapeHyphen":
                case "EscapeLeftArrow":
                case "EscapeRightArrow":
                case "EscapeSeparator":
                case "EscapeTerminator":
                case "EscapeStar":
                case "EscapeEscape":
                case "EscapeFSlash":
                case "EscapeBSlash":
                case "EscapeLeftSquare":
                case "EscapeRightSquare":
                case "EscapeLeftCurl":
                case "EscapeRightCurl":
                    text = r[0].Data.ToString().Replace("\\", "");
                    break;
            }
            string s = r[0].Data.ToString();
            return text;
        }

        //<text-chunk-list>    
        //::= <text-chunk> <text-chunk>    
        //| <text-chunk> <text-chunk-list>
        private static string DoTextChunkList(Reduction r)
        {
            string s1 = DoTextChunk(r[0].Data as Reduction);

            string ruleName = GetRuleName(r[1].Data as Reduction);
            if (ruleName == "text-chunk")
            {
                string s2 = DoTextChunk(r[1].Data as Reduction);
                string s = s1 + s2;
                return s;
            }
            else
            {
                string s2 = DoTextChunkList(r[1].Data as Reduction);
                string s = s1 + s2;
                return s;
            }
        }

        //<text>     
        //::= <text-chunk>    
        //| <text-chunk-list>
        private static string DoText(Reduction r)
        {
            string ruleName = GetRuleName(r[0].Data as Reduction);
            if (ruleName == "text-chunk")
            {
                string s = DoTextChunk(r[0].Data as Reduction);
                return s;
            }
            else if (ruleName == "text-chunk-list")
            {
                string s = DoTextChunkList(r[0].Data as Reduction);
                return s;
            }
            else return null;
        }


        //ITEMS

        //<item>       
        //:= <text> <tag> Link Decorator
        //| <text> <tag> <links> <decorators>
        //not in that order though
        private static string DoItem(DescribeUnfold u, Reduction r)
        {
            string text = null;
            string tag = null;
            string[] links = null;
            string[] decorators = null;

            for(int i = 0; i < r.Count(); i++)
            {
                string ruleName = r[i].Symbol.Name;
                switch (ruleName)
                {
                    case "text":
                        text = DoText(r[i].Data as Reduction);
                        text = text.Trim();
                        break;
                    case "tag":
                        string t = DoTag(r[i].Data as Reduction);
                        tag = t;
                        break;
                    case "Link":
                        string l = DoLink(r[i].Data.ToString());
                        links = new string[] { l };
                        break;
                    case "links":
                        links = DoLinks(r[i].Data as Reduction);
                        break;
                    case "Decorator":
                        string d = DoDecorator(r[i].Data.ToString());
                        decorators = new string[] { d };
                        break;
                    case "decorators":
                        decorators = DoDecorators(r[i].Data as Reduction);
                        break;
                }
            }

            //text can't be null
            if (text == null) return null;

            //tag
            if (tag == null) //no tag
            {
                tag = getRandomString();
            }
            else if (tag.Contains("/")) //filename addressing
            {
                string[] sep = tag.Split('/');
                tag = sep[sep.Length - 1];

                List<string> arrl = sep.ToList();
                arrl.RemoveAt(arrl.Count() - 1);
                string filename = String.Join("\\", arrl);
                string path = Path.Combine(u.CurrentFolder, filename);

                if (!u.IdFile.Keys.Contains(tag)) u.IdFile.Add(tag, path);
                if (!u.Files.Contains(path)) u.Files.Add(path);

                //Path.Combine(unfold.CurrentFolder, unfold.Files[0]);
            }
            //else if (tag.Contains(".")) //namespace addressing (but does not contain '/', because filenames will contain a dot)
            //{

            //}
            //else if (tag.StartsWith("#")) //encrypted
            //{

            //}
            if (!u.Translations.Keys.Contains(tag))
            {
                u.Translations.Add(tag, text);
            }
            else
            {
                //redefinition
                u.Translations[tag] = text;
            }

            //links
            if(links != null && links.Count() > 0)
            {
                if (!u.Links.Keys.Contains(tag)) u.Links.Add(tag, new List<string>());
                foreach (string s in links)
                {
                    u.Links[tag].Add(s);
                }
            }

            //decorators
            if (decorators != null && decorators.Count() > 0)
            {
                if (!u.Decorators.Keys.Contains(tag)) u.Decorators.Add(tag, new List<string>());
                foreach (string s in decorators)
                {
                    u.Decorators[tag].Add(s);
                }
            }


            return tag;
        }

        //<item-or-expression>    
        //::= <item>    
        //| <expression>
        private static string DoItemOrExpression(DescribeUnfold u, Reduction r)
        {
            string ruleName = GetRuleName(r[0].Data as Reduction);
            if (ruleName == "item")
            {
                string key = DoItem(u, r[0].Data as Reduction);
                return key;
            }
            else if (ruleName == "expression")
            {
                string key = DoExpression(u, r[0].Data as Reduction);
                return key;
            }
            else return null;
        }

        //<item-or-expression-list>
        //::= <item> Separator <item>
        //| <item> Separator <expression>
        //| <item> Separator <item-or-expression-list>
        //| <expression> <item>
        //| <expression> <expression>
        //| <expression> <item-or-expression-list>
        private static string[] DoItemOrExpressionList(DescribeUnfold u, Reduction r)
        {
            //this method is about a list of "ItemOrExpression"
            string ruleName1 = GetRuleName(r[0].Data as Reduction);

            string key1 = "";
            if (ruleName1 == "item") key1 = DoItem(u, r[0].Data as Reduction);
            else if (ruleName1 == "expression") key1 = DoExpression(u, r[0].Data as Reduction);
            else return null;

            Reduction reduction = null;
            if (ruleName1 == "item") reduction = r[2].Data as Reduction;
            else if (ruleName1 == "expression") reduction = r[1].Data as Reduction;
            List<string> list = new List<string>() { key1 };

            string ruleName2 = GetRuleName(reduction);
            if (ruleName2 == "item")
            {
                string key = DoItem(u, reduction);
                list.Add(key);
            }
            else if (ruleName2 == "expression")
            {
                string key = DoExpression(u, reduction);
                list.Add(key);
            }
            else if (ruleName2 == "item-or-expression-list")
            {
                string[] keys = DoItemOrExpressionList(u, reduction);
                for (int i = 0; i < keys.Length; i++) list.Add(keys[i]);
            }

            return list.ToArray();
        }





        // EXPRESSIONS

        //<expression>     
        //::= <item> <producer> Terminator    
        //| <item> <producer> <item-or-expression> Terminator   
        //| <item> <producer> <item-or-expression-list> Terminator
        //| <item> <producer> <item-or-expression>
        //| <item> <producer> <item-or-expression-list>
        private static string DoExpression(DescribeUnfold u, Reduction r)
        {
            string head = DoItem(u, r[0].Data as Reduction);
            string ruleName = GetRuleName(r[2].Data as Reduction);
            if (ruleName == "Terminator")
            {
                u.Productions.Add(head, new List<string>());
            }
            else if (ruleName == "item-or-expression")
            {
                string right = DoItemOrExpression(u, r[2].Data as Reduction);
                u.Productions.Add(head, new List<string>() { right });
            }
            else if (ruleName == "item-or-expression-list")
            {
                string[] rights = DoItemOrExpressionList(u, r[2].Data as Reduction);
                u.Productions.Add(head, rights.ToList());
            }
            return head;
        }

        //<expression-list>
        //::= <expression> <expression>
        //| <expression> <expression-list>
        private static string[] DoExpressionList(DescribeUnfold u, Reduction r)
        {
            //this method is about a list of "Expression"
            string key1 = DoExpression(u, r[0].Data as Reduction);
            string ruleName2 = GetRuleName(r[1].Data as Reduction);
            if (ruleName2 == "expression")
            {
                string key2 = DoExpression(u, r[1].Data as Reduction);
                return new string[] { key1, key2 };
            }
            else if (ruleName2 == "expression-list")
            {
                string[] keys = DoExpressionList(u, r[1].Data as Reduction);
                List<string> li = new List<string>() { key1 };
                for (int i = 0; i < keys.Length; i++) li.Add(keys[i]);
                return li.ToArray();
            }

            return null;
        }
        
        //<scripture>
        //::= <expression>
        //| <expression-list>
        /// <summary>
        /// Translate Gold engine parse tree (root Reduction r) to Unfold structure.
        /// </summary>
        /// <param name="u">Unfold to be populated</param>
        /// <param name="r">Root reduction aka the parse tree</param>
        /// <param name="isPrimary">Wether this is the first file</param>
        /// <returns>True if successful</returns>
        public static bool DoScripture(DescribeUnfold u, Reduction r, bool isPrimary = true)
        {
            string ruleName = GetRuleName(r[0].Data as Reduction);
            if (ruleName == "expression")
            {
                string key2 = DoExpression(u, r[0].Data as Reduction);
                if (isPrimary) u.PrimaryProductions.Add(key2);
                return true;
            }
            else if (ruleName == "expression-list")
            {
                string[] keys = DoExpressionList(u, r[0].Data as Reduction);
                if (isPrimary)
                {
                    for (int i = 0; i < keys.Length; i++)
                    {
                        u.PrimaryProductions.Add(keys[i]);
                    }
                }
                return true;
            }

            return false;
        }
    }
}