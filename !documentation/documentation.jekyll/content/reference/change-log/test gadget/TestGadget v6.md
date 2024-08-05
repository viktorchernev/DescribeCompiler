---
layout: page
title: TestGadget v6 (WinForms, Gold parser)
permalink: /test-gadget/test-gadget-v6
exclude: true
---
```
using GOLD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGadget
{
    public static class TestGadget
    {
        static TestGadget()
        {
            MyParser = new DescribeParser();
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
        }
        public static void Reset()
        {
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
            MyParser.PrimaryProductions = new Dictionary<string, List<string>>();
            MyParser.IsFirstScripture = true;
        }


        public static void WriteTree(TreeView tree)
        {
            tree.Nodes.Clear();

            foreach (string pkey in MyParser.PrimaryProductions.Keys)
            {
                string text = MyParser.Translations[pkey];
                var node = tree.Nodes.Add(text);
                foreach(string lkey in MyParser.PrimaryProductions[pkey])
                {
                    AddLayer(node, lkey);
                }
            }
        }
        static void AddLayer(TreeNode node, string key)
        {
            if (MyParser.Translations.ContainsKey(key) == false) return;

            string text = MyParser.Translations[key];
            var n = node.Nodes.Add(text);

            if(MyParser.Productions.ContainsKey(key))
            {
                foreach (string rkey in MyParser.Productions[key])
                {
                    AddLayer(n, rkey);
                }
            }
            else if (MyParser.PrimaryProductions.ContainsKey(key))
            {
                foreach (string rkey in MyParser.PrimaryProductions[key])
                {
                    AddLayer(n, rkey);
                }
            }
        }


        public static string? SourcePath;
        public static string? GrammarPath;
        public static void LoadGrammer(string path)
        {
            try
            {
                if (MyParser.Setup(path))
                {
                    GrammarPath = path;
                    //MessageBox.Show("CGT loaded");
                }
                else
                {
                    MessageBox.Show("CGT failed to load");
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ParseTextFile(string filename)
        {
            if (MyParser.Loaded == false) return;
            string filetext = ReadTextFile(filename);
            if (filetext == null || string.IsNullOrWhiteSpace(filetext)) return;

            SourcePath = filename;
            ParseSource(filename);
        }
        public static void ParseTextFiles(string path)
        {
            if (MyParser.Loaded == false) return;
            string fname = Path.GetFileName(path);
            string? folder = Path.GetDirectoryName(path);
            if(folder == null) return;
            folder += "\\";

            ParseTextFiles(folder, fname);
        }
        public static void ParseTextFiles(string path, string filename)
        {
            if (MyParser.Loaded == false) return;
            SourcePath = path + filename;

            List<string> parsedFiles = new List<string>();

            string cur = path + filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if (filetext != null 
                    && string.IsNullOrWhiteSpace(filetext) == false)
                {
                    ParseSource(cur);
                }

                cur = "";
                foreach (string s in MyParser.Files.Values)
                {
                    if (parsedFiles.Contains(path + s) == false)
                    {
                        cur = path + s;
                        break;
                    }
                }
            }
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }



        static DescribeParser MyParser;
        static void ParseSource(string path)
        {
            try
            {
                string text = File.ReadAllText(path);
                StringReader reader = new StringReader(text);
                bool result = MyParser.Parse(reader);
                if (result)
                {
                    //MessageBox.Show(path + " parsed successfully!");
                }
                else
                {
                    MessageBox.Show(path + Environment.NewLine + MyParser.FailMessage);
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    internal class DescribeParser
    {
        // The final translations are stored here
        //public List<Production> All = new List<Production>();
        public Dictionary<string, List<string>> PrimaryProductions = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> Productions = new Dictionary<string, List<string>>();
        public Dictionary<string, string> Translations = new Dictionary<string, string>();
        public Dictionary<string, string> Files = new Dictionary<string, string>();

        // Other variables
        public bool Loaded = false;
        private GOLD.Parser parser = new GOLD.Parser();
        public GOLD.Reduction? Root = null;//hacked to be nullable, it wasn't
        public string FailMessage = "";

        public bool Setup(string FilePath)
        {
            Loaded = parser.LoadTables(FilePath);
            return Loaded;
        }
        public bool Parse(TextReader reader)
        {
            GOLD.ParseMessage response;
            bool done = false;
            bool accepted = false;

            parser.Open(reader);
            parser.TrimReductions = false;

            while (!done)
            {
                response = parser.Parse();
                switch (response)
                {
                    case GOLD.ParseMessage.LexicalError:
                        //Cannot recognize token
                        FailMessage = "Lexical Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data;
                        done = true;
                        break;

                    case GOLD.ParseMessage.SyntaxError:
                        //Expecting a different token
                        FailMessage = "Syntax Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data + "\n" +
                                      "Expecting: " + parser.ExpectedSymbols().Text();
                        done = true;
                        break;

                    case GOLD.ParseMessage.Reduction:
                        //Populate dictionaries
                        Populate(parser.CurrentReduction);
                        break;

                    case GOLD.ParseMessage.Accept:
                        //Accepted!
                        Root = (GOLD.Reduction)parser.CurrentReduction;    //The root node!                                  
                        done = true;
                        accepted = true;
                        break;

                    case GOLD.ParseMessage.TokenRead:
                        //You don't have to do anything here.
                        break;

                    case GOLD.ParseMessage.InternalError:
                        //INTERNAL ERROR! Something is horribly wrong.
                        FailMessage = "INTERNAL ERROR! Something is horribly wrong";
                        done = true;
                        break;

                    case GOLD.ParseMessage.NotLoadedError:
                        //This error occurs if the CGT was not loaded.                   
                        FailMessage = "Tables not loaded";
                        done = true;
                        break;

                    case GOLD.ParseMessage.GroupError:
                        //GROUP ERROR! Unexpected end of file
                        FailMessage = "Runaway group";
                        done = true;
                        break;
                }
            }
            return accepted;
        }

        private void Populate(object o)
        {
            Reduction r = (Reduction)o;
            string ruleName = GetRuleName(r);
            if (ruleName != "scripture") return;

            //All = DoScripture(r);
            List<Production> ps = DoScripture(r);
            Translate(ps);
        }
        private void Translate(List<Production> productions)
        {
            foreach (Production p in productions)
            {
                string a = p.Left.Tag.Id;
                if (p.Left.Tag.Type == TagType.File)
                {
                    FileTag ftag = (FileTag)p.Left.Tag;
                    Files.Add(ftag.Id, ftag.FileName);
                }

                List<string> bs = new List<string>();
                foreach (Termin t in p.Rights)
                {
                    bs.Add(t.Tag.Id);
                    if (t.Tag.Type == TagType.File)
                    {
                        FileTag ftag = (FileTag)t.Tag;
                        Files.Add(ftag.Id, ftag.FileName);
                    }
                }

                if(p.IsPrimery) PrimaryProductions.Add(a, bs);
                else Productions.Add(a, bs);


                if (Translations.ContainsKey(p.Left.Tag.Id) == false)
                {
                    Translations.Add(p.Left.Tag.Id, p.Left.Literal);
                }
                foreach (Termin t in p.Rights)
                {
                    if (Translations.ContainsKey(t.Tag.Id) == false)
                    {
                        Translations.Add(t.Tag.Id, t.Literal);
                    }
                }
            }
        }



        //Misc
        string GetRuleName(Reduction r)
        {
            string ruleName = r.Parent.Head().Name();
            return ruleName;
        }

        //Text
        string DoText(Reduction r)
        {
            if(r.Count() == 1)
            {
                string? s = r[0].Data.ToString();
                if (string.IsNullOrEmpty(s))
                {
                    throw new Exception("Inproper TEXT - text[0] is null or empty");
                }
                return s;
            }
            else if (r.Count() == 2)
            {
                string s = DoText((Reduction)r[0].Data) + " " + DoText((Reduction)r[1].Data);
                return s;
            }
            else
            {
                throw new Exception("Inproper TEXT - text is of inproper lenght");
            }
        }

        //Tags
        Tag DoTag(Reduction r)
        {
            if (r.Count() == 3)
            {
                return DoSimpleTag(r);
            }
            else if (r.Count() == 5)
            {
                return DoFileTag(r);
            }
            else
            {
                throw new Exception("Inproper TAG - tag is not 3 or 5 items long");
            }
        }
        SimpleTag DoSimpleTag(Reduction r)
        {
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[1] is not a reduction");
            }
            Reduction rtext = (Reduction)r[1].Data;
            string? rn = GetRuleName(rtext);
            if (rn != "text")
            {
                throw new Exception("Inproper TAG - tag[1] is not \"text\"");
            }
            string tag = DoText(rtext);
            return new SimpleTag(tag);
        }
        FileTag DoFileTag(Reduction r)
        {
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[1] is not a reduction");
            }
            Reduction rtext = (Reduction)r[1].Data;
            string? rn = GetRuleName(rtext);
            if (rn != "text")
            {
                throw new Exception("Inproper TAG - tag[1] is not \"text\"");
            }
            string file = DoText(rtext);

            if (r[3].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[3] is not a reduction");
            }
            Reduction rftext = (Reduction)r[3].Data;
            string? rfn = GetRuleName(rftext);
            if (rfn != "text")
            {
                throw new Exception("Inproper TAG - tag[3] is not \"text\"");
            }
            string tag = DoText(rftext);
            return new FileTag(tag, file);
        }

        //Items
        Termin DoTermin(Reduction r)
        {
            var count = r.Count();

            var data = r[0].Data;
            var data2 = r[1].Data;

            if (count < 1 || count > 3)
            {
                throw new Exception("Inproper ITEM - item must have 1, 2 or 3 items");
            }
            else if (count == 1)
            {
                return DoTermin1(r);
            }
            else if (count == 2)
            {
                return DoTermin2(r);
            }
            else //count == 3
            {
                return DoTermin3(r);
            }
        }
        Termin DoTermin1(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[0] must be a reduction");
            }
            string n = GetRuleName((Reduction)r[0].Data);
            if (n != "tag")
            {
                throw new Exception("Inproper ITEM - item[0] must be a tag");
            }
            //Tag tag = DoTag((Reduction)r[1].Data);
            throw new Exception("Inproper ITEM - item must have 2 items");
        }
        Termin DoTermin2(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[0] must be a reduction");
            }
            string n0 = GetRuleName((Reduction)r[0].Data);
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[1] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[1].Data);

            if (n0 != "text")
            {
                throw new Exception("Inproper ITEM - item[0] must be a text");
            }
            if (n1 != "tag")
            {
                throw new Exception("Inproper ITEM - item[1] must be a tag");
            }

            string text = DoText((Reduction)r[0].Data);
            Tag tag = DoTag((Reduction)r[1].Data);
            return new Termin(text, tag);
        }
        Termin DoTermin3(Reduction r)
        {
            throw new Exception("Inproper ITEM - item must have 1, 2 items");
        }

        //Itemlists
        List<Termin> DoItemlist(Reduction r)
        {
            var count = r.Count();
            if (count != 3)
            {
                throw new Exception("Inproper ITEMLIST - itemlist must have 3 items");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEMLIST - itemlist[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "item")
            {
                throw new Exception("Inproper ITEMLIST - itemlist[0] must be an item");
            }

            if (r[2].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEMLIST - itemlist[2] must be a reduction");
            }
            string n2 = GetRuleName((Reduction)r[2].Data);
            if (n2 != "item" && n2 != "itemlist")
            {
                throw new Exception("Inproper ITEMLIST - itemlist[2] must be an item or an itemlist");
            }

            Termin a = DoTermin((Reduction)r[0].Data);
            List<Termin> list = new List<Termin>() { a };

            if(n2 == "item")
            {
                Termin b = DoTermin((Reduction)r[2].Data);
                list.Add(b);
            }
            else
            {
                List<Termin> bs = DoItemlist((Reduction)r[2].Data);
                foreach (Termin t in bs) list.Add(t);
            }

            return list;
        }

        //Expressions
        Production DoExpression(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSION - expression[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "item")
            {
                throw new Exception("Inproper EXPRESSION - expression[0] must be an item");
            }
            Termin leftHandSide = DoTermin((Reduction)r[0].Data);

            if (r[1].Data.ToString() != "->")
            {
                throw new Exception("Inproper EXPRESSION - expression[1] must be '->'");
            }

            List<Termin> ts = new List<Termin>();
            for (int i = 2; i < r.Count(); i++)
            {
                if (r[i].Data is Reduction)
                {
                    string ruleName = GetRuleName((Reduction)r[i].Data);

                    switch (ruleName)
                    {
                        case "item":
                            Termin x = DoTermin((Reduction)r[i].Data);
                            ts.Add(x);
                            break;
                        case "itemlist":
                            List<Termin> ys = DoItemlist((Reduction)r[i].Data);
                            foreach (Termin y in ys) ts.Add(y);
                            break;
                        case "expression":
                            Termin z = DoExpression((Reduction)r[i].Data).Left;
                            ts.Add(z);
                            break;
                        case "expressionlist":
                            List<Production> ms = DoExpressionlist((Reduction)r[i].Data);
                            foreach (Production m in ms) ts.Add(m.Left);
                            break;
                        default:
                            continue;
                    }
                }
            }

            return new Production(leftHandSide, ts);
        }
        List<Production> DoExpressionlist(Reduction r)
        {
            var count = r.Count();
            if (count != 2)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist must have 2 items");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "expression")
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[0] must be an expression");
            }

            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[1] must be a reduction");
            }
            string n2 = GetRuleName((Reduction)r[1].Data);
            if (n2 != "expression" && n2 != "expressionlist")
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[1] must be an expression or an expressionlist");
            }

            Production a = DoExpression((Reduction)r[0].Data);
            List<Production> list = new List<Production>() { a };

            if (n2 == "expression")
            {
                Production b = DoExpression((Reduction)r[1].Data);
                list.Add(b);
            }
            else
            {
                List<Production> bs = DoExpressionlist((Reduction)r[1].Data);
                foreach (Production t in bs) list.Add(t);
            }

            return list;
        }

        //Scripture
        public bool IsFirstScripture = true;
        List<Production> DoScripture(Reduction r)
        {
            var count = r.Count();
            if (count != 1)
            {
                throw new Exception("Inproper SCRIPTURE - scripture must have 1 item");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper SCRIPTURE - scripture[0] must be a reduction");
            }
            string n = GetRuleName((Reduction)r[0].Data);
            if (n != "expression" && n != "expressionlist")
            {
                throw new Exception("Inproper SCRIPTURE - scripture[0] must be an expression or an expressionlist");
            }

            if(n == "expression")
            {
                Production p = DoExpression((Reduction)r[0].Data);
                if (IsFirstScripture)
                {
                    p.IsPrimery = true;
                    IsFirstScripture = false;
                }
                return new List<Production>() { p };
            }
            else
            {
                List<Production> ps = DoExpressionlist((Reduction)r[0].Data);
                if (IsFirstScripture)
                {
                    foreach (Production p in ps) p.IsPrimery = true;
                    IsFirstScripture = false;
                }
                return ps;
            }
        }
    }




}

//https://www.meziantou.net/introduction-to-goldparser.htm
//TestGadget.LoadGrammer(@"C:\PATH HERE\#DESCRIBE.egt");
//TestGadget.ParseTextFiles(@"C:\PATH HERE\", "0_root");
//TestGadget.WriteTree(MainTreeView);
```

### Links
[Back](/versioning/)