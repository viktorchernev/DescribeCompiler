---
layout: page
title: TestGadget v1
permalink: /language/reference/versioning/test-gadget/test-gadget-v1/
exclude: true
---
```
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TOATe
{
    public static class TestGadget
    {
        public static Dictionary<string, List<string>> Productions;


        static TestGadget()
        {
            Productions = new Dictionary<string, List<string>>();
        }


        public static void TestParse(string path, bool waitUserInput = false)
        {
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                ParseTextFile(ReadTextFile(files[i]));
            }

            Console.WriteLine("\"" + path + "\" Done!");
            if(waitUserInput) Console.ReadLine();
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


        static string ReadTextFile(string filename)
        {
            string text = File.ReadAllText(filename);
            return text;
        }
        static void ParseTextFile(string filetext)
        {
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
                }
                else
                {
                    int n = 0;
                    while (Productions.ContainsKey(title + " (" + n + ")"))
                    {
                        n++;
                    }
                    Productions.Add(title + " (" + n + ")", list);
                }
            }
        }
    }
}

```

<br>
### Links
[Back](/language/reference/versioning/)