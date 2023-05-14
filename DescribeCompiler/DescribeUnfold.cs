using System.Collections.Generic;

namespace DescribeCompiler
{
    public class DescribeUnfold
    {
        public List<string> PrimaryProductions;                         //ids of productions that are primary productions
        public Dictionary<string, List<string>> Productions;            //id of lhs item vs ids of rhs items
        public Dictionary<string, string> Translations;                 //id of item vs text of item

        public string CurFileNamespace;                                 //current namespace we are in
        public List<string> Files;                                      //list of files
        public Dictionary<string, string> IdFile;                       //id vs filepath that contains it

        public Dictionary<string, List<string>> Links;                  //id vs links texts
        public Dictionary<string, List<string>> Decorators;             //id vs decorators texts

        /// <summary>
        /// Ctor.
        /// </summary>
        public DescribeUnfold()
        {
            PrimaryProductions = new List<string>();
            Productions = new Dictionary<string, List<string>>();
            Translations = new Dictionary<string, string>();

            CurFileNamespace = "";
            Files = new List<string>();
            IdFile = new Dictionary<string, string>();

            Links = new Dictionary<string, List<string>>();
            Decorators = new Dictionary<string, List<string>>();
        }
    }
}
