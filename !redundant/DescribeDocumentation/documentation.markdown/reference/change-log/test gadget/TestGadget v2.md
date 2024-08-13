---
layout: page
title: TestGadget v2
permalink: /language/reference/versioning/test-gadget/test-gadget-v2/
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
    public static class TestGadget
    {
        public static Dictionary<string, List<string>> Productions;
        public static Dictionary<string, List<string>> Files;
        static TestGadget()
        {
            Productions = new Dictionary<string, List<string>>();
            Files = new Dictionary<string, List<string>>();
        }


        public static void TestParse(string path, bool waitUserInput = false)
        {
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                ParseTextFile(files[i]);
            }

            Console.WriteLine("\"" + path + "\" Done!");
            if (waitUserInput) Console.ReadLine();
        }
        public static void WriteProductions()
        {
            foreach (KeyValuePair<string, List<string>> kvp in TestGadget.Productions)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(kvp.Key + " -> ");
                Console.WriteLine("    " + String.Join(",\n    ", kvp.Value) + ";");
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


            foreach (KeyValuePair<string, List<string>> kvp in TestGadget.Productions)
            {
                treeIter = treeStore.AppendValues(kvp.Key);
                for(int j = 0; j < kvp.Value.Count; j++)
                {
                    treeStore.AppendValues(treeIter, kvp.Value[j]);
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
            TreeIter treeIter;


            foreach (string ptitle in Files["0_root"])
            {
                treeIter = treeStore.AppendValues(ptitle);
                for (int j = 0; j < Productions[ptitle].Count; j++)
                {
                    TreeIter newIter = treeStore.AppendValues(treeIter, Productions[ptitle][j]);
                    AddLayer(treeStore, newIter, Productions[ptitle][j]);
                }
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        static void AddLayer(TreeStore store, TreeIter iter, string itertext)
        {
            if (itertext.Contains('<') && itertext.Contains('>'))
            {
                itertext = itertext.Split('<')[0];
                itertext = itertext.Trim();
            }
            if (Productions.ContainsKey(itertext) == false) return;


            List<string> ps = Productions[itertext];
            Productions.Remove(itertext);


            for (int j = 0; j < ps.Count; j++)
            {
                TreeIter newIter = store.AppendValues(iter, ps[j]);
                AddLayer(store, newIter, ps[j]);
            }
        }



        static string ReadTextFile(string filename)
        {
            string text = File.ReadAllText(filename);
            return text;
        }
        static void ParseTextFile(string filename)
        {
            string fname = Path.GetFileNameWithoutExtension(filename);
            Files.Add(fname, new List<string>());

            string filetext = ReadTextFile(filename);
            string[] productions = filetext.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string prod in productions)
            {
                prod.Trim();
                string[] sides = prod.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < sides.Length; i++) sides[i] = sides[i].Trim();

                string title = sides[0];
                if (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title)) return;
                List<string> list = new List<string>();
                if (sides.Length > 1)
                {
                    list = sides[1]
                        .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    for (int i = 0; i < list.Count; i++) list[i] = list[i].Trim();
                }

                if (Productions.ContainsKey(title) == false)
                {
                    Productions.Add(title, list);
                    Files[fname].Add(title);
                }
                else
                {
                    int n = 0;
                    while (Productions.ContainsKey(title + " (" + n + ")"))
                    {
                        n++;
                    }
                    Productions.Add(title + " (" + n + ")", list);
                    Files[fname].Add(title + " (" + n + ")");
                }
            }
        }
    }
}

// TODO: Figure out what to do with multiple productions
// TODO: Figure out what to do with escaping charracters like commas
```

<br>
### Links
[Back](/language/reference/versioning/)