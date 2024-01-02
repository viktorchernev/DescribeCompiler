using GoldParser.Grammar;
using GoldParser.ParseTree;

using System;
using System.Collections.Generic;
using System.Linq;


namespace DescribeCompiler.Compiler.Optimizers
{
    //http://www.goldparser.org/doc/grammars/predefined-sets.htm
    public class OptimizerForDescribe06 : IDescribeOptimizer
    {
        //Misc
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



        // Text
        // <text-chunk>
        // ::= Text | EscapeHyphen | EscapeLeftArrow | EscapeRightArrow | EscapeSeparator
        // | EscapeTerminator | EscapeStar | EscapeFSlash | EscapeBSlash
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
                case "EscapeFSlash":
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
            for (int i = 0; i < r.Count(); i++)
            {
                string ruleName = r[i].Symbol.Name;
                switch (ruleName)
                {
                    case "text":
                        text = DoText(r[i].Data as Reduction);
                        text = text.Trim();
                        break;
                }
            }

            //text can't be null
            if (text == null) return null;

            //tag
            string tag = getRandomString();
            if (!u.Translations.Keys.Contains(tag))
            {
                u.Translations.Add(tag, text);
            }
            else
            {
                //redefinition
                u.Translations[tag] = text;
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
        // ::= <item> Separator <item>
        // | <item> Separator <expression>
        // | <item> Separator <item-or-expression-list>
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
        // ::= <item> <producer> Terminator    
        // | <item> <producer> <item-or-expression> Terminator   
        // | <item> <producer> <item-or-expression-list> Terminator
        // | <item> <producer> <item-or-expression>
        // | <item> <producer> <item-or-expression-list>
        private string DoExpression(DescribeUnfold u, Reduction r)
        {
            string head = DoItem(u, r[0].Data as Reduction);

            //empty production treated as item
            if (r[2] is Token && r[2].Data.ToString() == ";")
            {
                return head;
            }

            //otherwise continue as normal production
            string ruleName = GetRuleName(r[2].Data as Reduction);
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
        /// <summary>
        /// Translate Gold engine parse tree (root Reduction r) to Unfold structure.
        /// </summary>
        /// <param name="u">Unfold to be populated</param>
        /// <param name="r">Root reduction aka the parse tree</param>
        /// <returns>True if successful</returns>
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
