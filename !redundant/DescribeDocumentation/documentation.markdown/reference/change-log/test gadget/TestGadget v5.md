---
layout: page
title: TestGadget v5 (WinForms, Gold parser)
permalink: /language/reference/versioning/test-gadget/test-gadget-v5/
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
            MyParser = new MyParserClass();
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
        }



        public static void WriteTree(TreeView tree)
        {
            for (int j = 0; j < MyParser.Productions["rootnode"].Count; j++)
            {
                string code = MyParser.Productions["rootnode"][j];
                string text = "NULL";
                if (code != null)
                {
                    text = MyParser.Translations[code];
                    var node = tree.Nodes.Add(text);
                    AddLayer(node, code);
                }
            }
        }
        static void AddLayer(TreeNode node, string code)
        {
            if (MyParser.Productions.ContainsKey(code) == false) return;

            List<string> ps = MyParser.Productions[code];
            for (int j = 0; j < ps.Count; j++)
            {
                string text = "NULL";
                if (ps[j] != null)
                {
                    text = MyParser.Translations[ps[j]];
                    var n = node.Nodes.Add(text);
                    AddLayer(n, ps[j]);
                }
            }
        }



        public static void LoadGrammer(string path)
        {
            try
            {
                if (MyParser.Setup(path))
                {
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
            ParseSource(filename);
        }
        public static void ParseTextFiles(string path, string filename)
        {
            if (MyParser.Loaded == false) return;
            List<string> parsedFiles = new List<string>();

            string cur = path + filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if (filetext == null || string.IsNullOrWhiteSpace(filetext)) continue;
                ParseSource(cur);

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



        static MyParserClass MyParser;
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

    internal class MyParserClass
    {
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


        public Dictionary<string, List<string>> Productions = new Dictionary<string, List<string>>();
        public Dictionary<string, string> Translations = new Dictionary<string, string>();
        public Dictionary<string, string> Files = new Dictionary<string, string>();


        void Populate(object o)
        {
            Reduction r = (Reduction)o;
            string ruleName = GetRuleName(r);


            if (ruleName == "item")
            {
                Item? item = GetItem(r);
                if (item == null) return;

                if (item.Tag.FileId != null)
                {
                    if (Files.ContainsKey(item.Tag.Id) == false)
                    {
                        Files.Add(item.Tag.Id, item.Tag.FileId);
                    }
                }
                if (Translations.ContainsKey(item.Tag.Id) == false)
                {
                    Translations.Add(item.Tag.Id, item.Literal);
                }
            }
            else if (ruleName == "expression")
            {
                Reduction litem = (Reduction)r.get_Data(0);
                Item? lit = GetItem(litem);
                if (lit == null) return;


                var next = r.get_Data(2);
                if(next is Reduction == false) return;
                Reduction ritem = (Reduction)next;
                string rule = ritem.Parent.Head().Name();
                if (rule == "item")
                {
                    Item? rit = GetItem(ritem);
                    if (rit == null) return;
                    List<string> rcodes = new List<string>() { rit.Tag.Id };
                    Productions.Add(lit.Tag.Id, rcodes);
                }
                else if (rule == "itemlist")
                {
                    List<Reduction>? reductions = UnwindItemlist(ritem);
                    if (reductions == null) return;

                    List<Item> items = new List<Item>();
                    foreach (Reduction red in reductions)
                    {
                        if (red == null) continue;
                        Item? item = GetItem(red);
                        if (item == null) continue;
                        items.Add(item);
                    }
                    List<string> rcodes = new List<string>();
                    foreach (Item it in items)
                    {
                        rcodes.Add(it.Tag.Id);
                    }
                    Productions.Add(lit.Tag.Id, rcodes);
                }
            }
        }

        Item? GetItem(Reduction r)
        {
            string name = GetRuleName(r);
            if (name != "item") return null;

            Tag? t = getTag(r);
            string literal = (string)r.get_Data(0);

            return new Item(literal, t);
        }
        Tag? getTag(Reduction r)
        {
            string name = GetRuleName(r);
            if (name != "item") return null;

            Reduction rtag = (Reduction)r.get_Data(1);          //get tag from "item"

            if (rtag.Count() == 3)
            {
                string? tag = rtag.get_Data(1).ToString();
                return new Tag(tag);
            }
            else if (rtag.Count() == 5)
            {
                string? tag = rtag.get_Data(3).ToString();
                if (tag == null) return null;                    //log error

                string? fname = rtag.get_Data(1).ToString();
                if (fname == null) return null;                  //log error


                return new Tag(tag, fname);
            }
            else return null;                                    //log error
        }
        string GetRuleName(Reduction r)
        {
            string ruleName = r.Parent.Head().Name();
            return ruleName;
        }
        List<Reduction>? UnwindItemlist(Reduction r)
        {
            Reduction left = (Reduction)r.get_Data(0);
            Reduction right = (Reduction)r.get_Data(2);

            if (GetRuleName(right) == "item")
            {
                return new List<Reduction>() { left, right };
            }
            else if (GetRuleName(right) == "itemlist")
            {
                List<Reduction>? li = UnwindItemlist(right);
                if (li == null) return null;

                List<Reduction> output = new List<Reduction>() { left };
                foreach (Reduction e in li) output.Add(e);
                return output;
            }

            return null;
        }
    }
    public class Tag
    {
        string _id;
        string? _fileId;

        public string Id
        {
            get { return _id; }
        }
        public string? FileId
        {
            get { return _fileId; }
        }

        public Tag(string id)
        {
            _id = id;
        }
        public Tag(string id, string fileId)
        {
            _id = id;
            _fileId = fileId;
        }
    }
    public class Item
    {
        string _literal;
        Tag _tag;

        public string Literal
        {
            get { return _literal; }
        }
        public Tag Tag
        {
            get { return _tag; }
        }

        public Item(string literal, Tag tag)
        {
            _literal = literal;
            _tag = tag;
        }
    }
}

//https://www.meziantou.net/introduction-to-goldparser.htm
//TestGadget.LoadGrammer(@"C:\PATH HERE\#DESCRIBE.egt");
//TestGadget.ParseTextFiles(@"C:\PATH HERE\", "0_root");
//TestGadget.WriteTree(MainTreeView);


// When there is a literal that is 8 symbols long it is mistaken for an id, resulting in a syntax error
// Cyrilic symbols result in a lexical error
```

<br>
### Links
[Back](/language/reference/versioning/)