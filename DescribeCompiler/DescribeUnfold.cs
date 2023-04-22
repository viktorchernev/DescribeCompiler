using System.Collections.Generic;

namespace DescribeCompiler
{
    public class DescribeUnfold
    {
        public List<string> PrimaryProductions;
        public Dictionary<string, List<string>> Productions;
        public Dictionary<string, string> Translations;

        public string CurrentFolder;
        public List<string> Files;
        public Dictionary<string, string> IdFile;

        public Dictionary<string, List<string>> Links;
        public Dictionary<string, List<string>> Decorators;

        public DescribeUnfold()
        {
            PrimaryProductions = new List<string>();
            Productions = new Dictionary<string, List<string>>();
            Translations = new Dictionary<string, string>();

            CurrentFolder = "";
            Files = new List<string>();
            IdFile = new Dictionary<string, string>();

            Links = new Dictionary<string, List<string>>();
            Decorators = new Dictionary<string, List<string>>();
        }
    }
}
