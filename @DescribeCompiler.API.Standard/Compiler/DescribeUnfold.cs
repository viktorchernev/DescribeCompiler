using System.Collections.Generic;

namespace DescribeCompiler
{
    public class DescribeUnfold
    {
        public List<string> PrimaryProductions;                         //ids of productions that are primary productions
        public Dictionary<string, List<string>> Productions;            //id of lhs item vs ids of rhs items
        public Dictionary<string, string> Translations;                 //id of item vs text of item
        public Dictionary<string, List<string>> Links;                  //id vs links texts
        public Dictionary<string, List<string>> Decorators;             //id vs decorators texts

        public string CurNamespace;                                     //current namespace we are in
        public string CurFile;                                          //current file we are in
        public List<string> Files;                                      //list of files

        public string InitialDir;
        public List<string> ParsedFiles;
        public List<string> FailedFiles;

        public Dictionary<string, List<string>> ItemIdFile;             //item id vs filepath that contains it
        public Dictionary<string, string> ProdIdFile;                   //production id vs filepath that contains it



        /// <summary>
        /// Ctor.
        /// </summary>
        public DescribeUnfold()
        {
            PrimaryProductions = new List<string>();
            Productions = new Dictionary<string, List<string>>();
            Translations = new Dictionary<string, string>();

            CurNamespace = "";
            CurFile = "";
            Files = new List<string>();

            InitialDir = "";
            ParsedFiles = new List<string>();
            FailedFiles = new List<string>();

            ItemIdFile = new Dictionary<string, List<string>>();
            ProdIdFile = new Dictionary<string, string>();

            Links = new Dictionary<string, List<string>>();
            Decorators = new Dictionary<string, List<string>>();
        }
    }
}
