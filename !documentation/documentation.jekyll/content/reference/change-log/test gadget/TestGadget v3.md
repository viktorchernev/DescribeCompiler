---
layout: page
title: TestGadget v3
permalink: /test-gadget/test-gadget-v3
exclude: true
---
```
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gtk;

namespace TOATg
{
    public static class TestGadget3
    {
        public static Dictionary<string, List<string>> Productions;
        public static Dictionary<string, string> Translations;
        public static Dictionary<string, string> Files;


        static TestGadget3()
        {
            Translations = new Dictionary<string, string>();
            Files = new Dictionary<string, string>();
            Productions = new Dictionary<string, List<string>>();
        }


        public static void ParseTextFile(string filename)
        {
            string filetext = ReadTextFile(filename);
            List<string> productions = GetProductions(filetext);
            foreach (string prod in productions)
            {
                ParseProduction(prod);
            }
        }
        public static void ParseTextFiles(string filename)
        {
            List<string> parsedFiles = new List<string>();

            string cur = filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if(filetext != null)
                {
                    List<string> productions = GetProductions(filetext);
                    foreach (string prod in productions)
                    {
                        ParseProduction(prod);
                    }
                }

                cur = "";
                foreach (string s in Files.Values)
                {
                    if (parsedFiles.Contains(@"/home/viktor/Desktop/tree2/" + s) == false)
                    {
                        cur = @"/home/viktor/Desktop/tree2/" + s;
                        break;
                    }
                }
            }
        }

        public static void WriteTree()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter;


            foreach (KeyValuePair<string, List<string>> kvp in Productions)
            {
                treeIter = treeStore.AppendValues(Translations[kvp.Key]);
                for (int j = 0; j < Productions[kvp.Key].Count; j++)
                {
                    string code = Productions[kvp.Key][j];
                    TreeIter newIter = treeStore.AppendValues(treeIter, Translations[code]);
                }
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteList()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter;


            //Productions["rootnode"]

            foreach (KeyValuePair<string, List<string>> kvp in Productions)
            {
                treeIter = treeStore.AppendValues(Translations[kvp.Key]);
                for (int j = 0; j < Productions[kvp.Key].Count; j++)
                {
                    string code = Productions[kvp.Key][j];
                    string text = "NULL";
                    if (code != null) text = Translations[code];
                    treeStore.AppendValues(treeIter, text);
                }
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteTree2()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter = treeStore.AppendValues(Translations["rootnode"]);
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null) text = Translations[code];
                TreeIter newIter = treeStore.AppendValues(treeIter, text);
                AddLayer(treeStore, newIter, code);
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteTree2(Window window)
        {
            // Make new window
            //Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter = treeStore.AppendValues(Translations["rootnode"]);
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null) text = Translations[code];
                TreeIter newIter = treeStore.AppendValues(treeIter, text);
                AddLayer(treeStore, newIter, code);
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        static void AddLayer(TreeStore store, TreeIter iter, string code)
        {
            if (Productions.ContainsKey(code) == false) return;


            List<string> ps = Productions[code];
            for (int j = 0; j < ps.Count; j++)
            {
                string text = "NULL";
                if (ps[j] != null) text = Translations[ps[j]];
                TreeIter newIter = store.AppendValues(iter, text);
                AddLayer(store, newIter, ps[j]);
            }
        }

        static void ParseProduction(string production)
        {
            string[] sides = production.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sides.Length; i++) sides[i] = sides[i].Trim();

            string lhs = sides[0];
            if (string.IsNullOrEmpty(lhs) || string.IsNullOrWhiteSpace(lhs)) return;

            List<string> rhs = new List<string>();
            if (sides.Length > 1)
            {
                rhs = sides[1]
                    .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                for (int i = 0; i < rhs.Count; i++) rhs[i] = rhs[i].Trim();
            }

            string lcode = ParseTranslation(lhs);
            List<string> rcodes = new List<string>();
            foreach (string stat in rhs)
            {
                string rcode = ParseTranslation(stat);
                rcodes.Add(rcode);
            }
            Productions.Add(lcode, rcodes);
        }
        static string ParseTranslation(string statement)
        {
            if (!statement.Contains('<')) return null;
            if (!statement.Contains('<')) return null;

            string[] sides = statement.Split('<');
            string text = sides[0].Trim();

            string code = sides[1].Split('>')[0];
            if(code.Contains('/') && code.Length == 17)
            {
                string[] sep = code.Split('/');
                code = sep[1];
                string file = sep[0];
                if(!Files.ContainsKey(code)) Files.Add(code, file);
            }
            if (!Translations.ContainsKey(code)) Translations.Add(code, text);
            return code;
        }

        static List<string> GetProductions(string filetext)
        {
            string[] productions = filetext.Split(
                new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> li = new List<string>();
            foreach (string p in productions)
            {
                if(!string.IsNullOrEmpty(p) && !string.IsNullOrWhiteSpace(p))
                {
                    li.Add(p.Trim());
                }
            }

            return li;
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
    }
}

// TODO: Take into account escape sequences - \; \, \< \>
// TODO: Fix reworded "," with "and" and "or"

```


### Links
[Back](/versioning/)