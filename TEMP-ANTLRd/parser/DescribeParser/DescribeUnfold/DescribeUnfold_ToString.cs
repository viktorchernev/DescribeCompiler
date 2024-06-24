using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser
{
    public partial class DescribeUnfold
    {
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
                if (kvp.Value.Count > 10)
                {
                    text += Environment.NewLine + INDENT + INDENT + INDENT;
                    for (int i = 0; i < kvp.Value.Count - 1; i++)
                    {
                        text += "\"" + kvp.Value[i] + "\", ";
                        if ((i + 1) % 10 == 0) text += Environment.NewLine + INDENT + INDENT + INDENT;
                    }
                }
                else
                {
                    for (int i = 0; i < kvp.Value.Count - 1; i++)
                    {
                        text += "\"" + kvp.Value[i] + "\", ";
                    }
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
