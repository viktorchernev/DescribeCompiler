using GoldParser.Grammar;
using GoldParser.ParseTree;

using System;
using System.Collections.Generic;
using System.Linq;


namespace DescribeCompiler.Compiler.Optimizers
{
    public class OptimizerForDescribe10 : IDescribeOptimizer
    {
        private static Random random = new Random();
        private static string getRandomString(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        //Name
        private string GetRuleName(Reduction r)
        {
            string ruleName = r.Production.Head.Name;
            return ruleName;
        }



        // Tags
        // <tag> ::= <tagstart> <text> <tagend>
        private string DoTag(Reduction r)
        {
            string id = DoText(r[1].Data as Reduction);
            return id;
        }



        // Links
        // <links>
        // ::= Link Link
        // | Link <links>
        private string DoLink(string text)
        {
            if (text[1] != '[')
            {
                string s = text.Substring(1, text.Length - 2);
                return s;
            }
            else
            {
                string s = text.Substring(2, text.Length - 4);
                return s;
            }

        }
        private string[] DoLinks(Reduction r)
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



        // Decorators
        // <decorators>
        // ::= Decorator Decorator
        // | Decorator <decorators>
        private string DoDecorator(string text)
        {
            //we undo possible escape from preprocessor.
            //Hacked in place. Needs to be worked around.
            if (text.Contains("\\-")) text = text.Replace("\\-", "-");
            if (text.Contains("\\*")) text = text.Replace("\\*", "*");
            if (text.Contains("\\/")) text = text.Replace("\\/", "/");
            if (text.Contains("\\\\")) text = text.Replace("\\\\", "\\");
            if (text.Contains("\\[")) text = text.Replace("\\[", "[");
            if (text.Contains("\\]")) text = text.Replace("\\]", "]");
            if (text.Contains("\\{")) text = text.Replace("\\{", "{");
            if (text.Contains("\\}")) text = text.Replace("\\}", "}");
            if (text.Contains("\\<")) text = text.Replace("\\<", "<");
            if (text.Contains("\\>")) text = text.Replace("\\>", ">");
            if (text.Contains("\\,")) text = text.Replace("\\,", ",");
            if (text.Contains("\\;")) text = text.Replace("\\;", ";");

            text = text.Trim(' ');
            text = text.TrimStart('{');
            text = text.TrimStart('{');
            text = text.TrimEnd('}');
            text = text.TrimEnd('}');
            text = text.Trim(' ');
            return text;

            //if (text[1] != '{')
            //{
            //    string s = text.Substring(1, text.Length - 2);
            //    //we need to remove spaces here for the translations later on
            //    return s.Replace(" ", "");
            //}
            //else
            //{
            //    string s = text.Substring(2, text.Length - 4);
            //    //we need to remove spaces here for the translations later on
            //    return s.Replace(" ", "");
            //}
        }
        private string[] DoDecorators(Reduction r)
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



        // Text
        // <text-chunk>
        // ::= Text | EscapeHyphen | EscapeLeftArrow | EscapeRightArrow | EscapeSeparator
        // | EscapeTerminator | EscapeStar | EscapeEscape | EscapeFSlash | EscapeBSlash
        // | EscapeLeftSquare | EscapeRightSquare | EscapeLeftCurl | EscapeRightCurl
        private string DoTextChunk(Reduction r)
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
                case "EscapeLeftSquare":
                case "EscapeRightSquare":
                case "EscapeLeftCurl":
                case "EscapeRightCurl":
                    text = r[0].Data.ToString().Replace("\\", "");
                    break;
                case "EscapeBSlash":
                    text = r[0].Data.ToString().Replace("\\\\", "\\");
                    break;
            }
            string s = r[0].Data.ToString();
            return text;
        }

        // <text-chunk-list>    
        // ::= <text-chunk> <text-chunk>    
        // | <text-chunk> <text-chunk-list>
        private string DoTextChunkList(Reduction r)
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

        // <text>     
        // ::= <text-chunk>    
        // | <text-chunk-list>
        private string DoText(Reduction r)
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



        // ITEMS
        // <item>       
        // := <text> <tag> Link Decorator
        // | <text> <tag> <links> <decorators>
        // not in that order though
        private string DoItem(DescribeUnfold u, Reduction r)
        {
            string text = null;
            string tag = null;
            string[] links = null;
            string[] decorators = null;

            for (int i = 0; i < r.Count(); i++)
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
            if (u.CurNamespace != "")
            {
                if (tag.StartsWith("."))
                {
                    tag = u.CurNamespace + tag;
                }
                else if (tag.Contains(".") == false)
                {
                    tag = u.CurNamespace + "." + tag;
                }
            }

            //filename addressing
            //namespace addressing
            //(tag.StartsWith("#")) //encrypted


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
            if (links != null && links.Count() > 0)
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

            //idFile
            if (u.ItemIdFile.ContainsKey(tag) == false)
            {
                u.ItemIdFile.Add(tag, new List<string>() { u.CurFile });
            }
            else
            {
                u.ItemIdFile[tag].Add(u.CurFile);
            }


            return tag;
        }

        // <item-or-expression>    
        // ::= <item>    
        // | <expression>
        private string DoItemOrExpression(DescribeUnfold u, Reduction r)
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

        // <item-or-expression-list>
        // ::= <item> <separator> <item>
        // | <item> <separator> <expression>
        // | <item> <separator> <item-or-expression-list>
        // | <expression> <item>
        // | <expression> <expression>
        // | <expression> <item-or-expression-list>
        private string[] DoItemOrExpressionList(DescribeUnfold u, Reduction r)
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
        // <expression>     
        // ::= <item> <producer> <terminator>    
        // | <item> <producer> <item-or-expression> <terminator>   
        // | <item> <producer> <item-or-expression-list> <terminator>
        // | <item> <producer> <item-or-expression>
        // | <item> <producer> <item-or-expression-list>
        private string DoExpression(DescribeUnfold u, Reduction r)
        {
            string head = DoItem(u, r[0].Data as Reduction);

            //empty production treated as item
            string ruleName = GetRuleName(r[2].Data as Reduction);
            if (ruleName == "terminator")
            {
                return head;
            }

            //otherwise continue as normal production
            if (ruleName == "Terminator")
            {
                u.Productions.Add(head, new List<string>());
            }
            else if (ruleName == "item-or-expression")
            {
                string right = DoItemOrExpression(u, r[2].Data as Reduction);
                //check for id collision
                //item with same id is redefinition,
                //but 2 productions heads with same id is collision
                if (u.Productions.ContainsKey(head))
                {
                    string item = u.Translations[head] + " <" + head + ">";
                    string prodfile = u.ProdIdFile[head];
                    string message = "Collision! Item \"" + item +
                        "\" - there is production head with the same id in file: \"" +
                        prodfile + "\"";
                    throw new Exception(message);
                }
                u.Productions.Add(head, new List<string>() { right });
            }
            else if (ruleName == "item-or-expression-list")
            {
                string[] rights = DoItemOrExpressionList(u, r[2].Data as Reduction);
                //check for id collision
                //item with same id is redefinition,
                //but 2 productions heads with same id is collision
                if (u.Productions.ContainsKey(head))
                {
                    string item = u.Translations[head] + " <" + head + ">";
                    string prodfile = u.ProdIdFile[head];
                    string message = "Collision! Item \"" + item +
                        "\" - there is production head with the same id in file: \"" +
                        prodfile + "\"";
                    throw new Exception(message);
                }
                u.Productions.Add(head, rights.ToList());
            }

            //idFile
            u.ProdIdFile.Add(head, u.CurFile);

            //return
            return head;
        }

        // <expression-list>
        // ::= <expression> <expression>
        // | <expression> <expression-list>
        private string[] DoExpressionList(DescribeUnfold u, Reduction r, bool isPrimery = false)
        {
            //this method is about a list of "Expression"
            string key1 = DoExpression(u, r[0].Data as Reduction);

            //isPrimery meant that it is expressionList directly in the scripture
            //element - where we might find valid nammespace directive
            bool removeKey = false;
            if (isPrimery)
            {
                //setup the Namespace field in the unfold
                //production literal is "directives" or "DIRECTIVES".
                //if we have only one production then we won't be doing this check
                //for now and just parse it, be it a directive
                string literal = u.Translations[key1];
                if (literal == "directives" || literal == "DIRECTIVES")
                {
                    List<string> directives = u.Productions[key1];
                    foreach (string directive in directives)
                    {
                        string keyword = u.Translations[directive];
                        if (keyword == "namespace") u.CurNamespace = directive;
                        u.Translations.Remove(directive);
                    }

                    u.Translations.Remove(key1);
                    u.Productions.Remove(key1);
                    u.PrimaryProductions.Remove(key1);
                    removeKey = true;
                }
            }


            string ruleName2 = GetRuleName(r[1].Data as Reduction);
            if (ruleName2 == "expression")
            {
                string key2 = DoExpression(u, r[1].Data as Reduction);
                if (removeKey) return new string[] { key2 };
                else return new string[] { key1, key2 };
            }
            else if (ruleName2 == "expression-list")
            {
                string[] keys = DoExpressionList(u, r[1].Data as Reduction);
                List<string> li = new List<string>();
                if (removeKey == false) li.Add(key1);
                for (int i = 0; i < keys.Length; i++) li.Add(keys[i]);
                return li.ToArray();
            }

            return null;
        }

        // <scripture>
        // ::= <expression>
        // | <expression-list>
        ///<summary>
        ///Translate Gold engine parse tree (root Reduction r) to Unfold structure.
        ///</summary>
        ///<param name="u">Unfold to be populated</param>
        ///<param name="r">Root reduction aka the parse tree</param>
        ///<returns>True if successful</returns>
        public bool DoScripture(DescribeUnfold u, Reduction r)
        {
            //reset namespace for the file
            u.CurNamespace = "";

            //if we have no productions whatsoever
            //then this must be the primary file
            bool isPrimary = u.Productions.Count == 0;

            //Unfold the scripture
            string ruleName = GetRuleName(r[0].Data as Reduction);
            if (ruleName == "expression")
            {
                string key2 = DoExpression(u, r[0].Data as Reduction);
                if (isPrimary) u.PrimaryProductions.Add(key2);
                return true;
            }
            else if (ruleName == "expression-list")
            {
                string[] keys = DoExpressionList(u, r[0].Data as Reduction, true);
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
