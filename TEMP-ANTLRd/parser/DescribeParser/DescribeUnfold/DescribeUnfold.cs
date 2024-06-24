using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser
{
    public class DescribeUnfold
    {
        //TEMP to be removed
            internal string CurNamespace;                                     //current namespace we are in
            internal string CurFile;                                          //current file we are in


        //file stats
        public List<string> AllFiles;                                   //list of files that have been parsed or failed
        public List<string> ParsedFiles;                                //list of files that have been parsed successfully
        public List<string> FailedFiles;                                //list of files that have been parsed unsuccessfully

        //main data
        public List<string> PrimaryProductions;                         //ids of productions that are primary productions
        public Dictionary<string, List<string>> Productions;            //id of left-hand side item, ids of right-hand side items
        //public Dictionary<string, List<string>> Tildes;            	//id of item, ids of tildes
        public Dictionary<string, string> Translations;                 //id of item, text of item
        //public Dictionary<string, List<string>> Links;                //id of item, links texts
        //public Dictionary<string, List<string>> Decorators;           //id of item, decorators texts

        //main data place inside files
        public Dictionary<string, List<string>> ItemidFile;             //item id, filepath(s) that contains it
        public Dictionary<string, List<string>> ProdidFile;             //production id, filepath that contains it


        /// <summary>
        /// Ctor.
        /// </summary>
        public DescribeUnfold()
        {
            AllFiles = new List<string>();
            ParsedFiles = new List<string>();
            FailedFiles = new List<string>();

            PrimaryProductions = new List<string>();
            Productions = new Dictionary<string, List<string>>();
            //Tildes = new Dictionary<string, List<string>>();
            Translations = new Dictionary<string, string>();
            //Links = new Dictionary<string, List<string>>();
            //Decorators = new Dictionary<string, List<string>>();

            ItemidFile = new Dictionary<string, List<string>>();
            ProdidFile = new Dictionary<string, List<string>>();
        }


        private readonly string INDENT = "    ";
        public override string ToString()
        {
            string text = "DescribeUnfold";
            text += Environment.NewLine + Environment.NewLine;

            // Files
            text += AllFiles_ToString();
            text += ParsedFiles_ToString();
            text += FailedFiles_ToString();
            text += Environment.NewLine;

            // Main Data
            text += PrimaryProductions_ToString();
            text += Productions_ToString();
            text += Translations_ToString();
            text += Environment.NewLine;

            //File Placement
            text += ProdidFile_ToString();
            text += ItemidFile_ToString();

            //return
            return text;
        }

        //ToString() - Files
        private string AllFiles_ToString()
        {
            string text = INDENT + ".AllFiles" + Environment.NewLine;
            if (FailedFiles.Count == 0) return text;

            for (int i = 0; i < AllFiles.Count; i++)
            {
                text += INDENT + INDENT + '"' + AllFiles[i] + '"' + Environment.NewLine;
            }

            text += Environment.NewLine;
            return text;
        }
        private string ParsedFiles_ToString()
        {
            string text = INDENT + ".ParsedFiles" + Environment.NewLine;
            if (FailedFiles.Count == 0) return text;

            for (int i = 0; i < ParsedFiles.Count; i++)
            {
                text += INDENT + INDENT + '"' + AllFiles[i] + '"' + Environment.NewLine;
            }

            text += Environment.NewLine;
            return text;
        }
        private string FailedFiles_ToString()
        {
            string text = INDENT + ".FailedFiles" + Environment.NewLine;
            if (FailedFiles.Count == 0) return text;

            for (int i = 0; i < FailedFiles.Count; i++)
            {
                text += INDENT + INDENT + '"' + AllFiles[i] + '"' + Environment.NewLine;
            }

            text += Environment.NewLine;
            return text;
        }

        //ToString() - Main Data
        private string PrimaryProductions_ToString()
        {
            string text = INDENT + ".PrimaryProductions" + Environment.NewLine;
            if (PrimaryProductions.Count == 0) return text;

            text += INDENT + INDENT;
            for (int i = 0; i < PrimaryProductions.Count; i++)
            {
                text += '"' + PrimaryProductions[i] + "\" ";
                if (i > 0 && i % 6 == 0) text += Environment.NewLine + INDENT + INDENT;
            }
            text += Environment.NewLine + Environment.NewLine;
            return text;
        }
        private string Productions_ToString()
        {
            string text = INDENT + ".Productions" + Environment.NewLine;
            if (Productions.Count == 0) return text;

            foreach (KeyValuePair<string, List<string>> kvp in Productions)
            {
                text += INDENT + INDENT + '"' + kvp.Key + "\" -> ";
                for (int i = 0; i < kvp.Value.Count - 1; i++)
                {
                    text += "\"" + kvp.Value[i] + "\", ";
                }
                text += "\"" + kvp.Value[kvp.Value.Count - 1] + "\";";
                text += Environment.NewLine;
            }
            text += Environment.NewLine;
            return text;
        }
        private string Translations_ToString()
        {
            string text = INDENT + ".Translations" + Environment.NewLine;
            if (Translations.Count == 0) return text;

            foreach (KeyValuePair<string, string> kvp in Translations)
            {
                text += INDENT + INDENT + '"' + kvp.Key + "\" - \"" + kvp.Value + '"';
                text += Environment.NewLine;
            }
            text += Environment.NewLine;
            return text;
        }

        //ToString() - File Placement
        private string ProdidFile_ToString()
        {
            string text = INDENT + ".ProdidFile (Not Implemented)" + Environment.NewLine;
            if (ProdidFile.Count == 0) return text;

            return text;
        }
        private string ItemidFile_ToString()
        {
            string text = INDENT + ".ItemidFile (Not Implemented)" + Environment.NewLine;
            if (ItemidFile.Count == 0) return text;

            return text;
        }
    }
}
