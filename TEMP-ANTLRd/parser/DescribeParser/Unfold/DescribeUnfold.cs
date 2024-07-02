using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser
{
    public partial class DescribeUnfold
    {
        //file stats
        public List<string> AllFiles;                                   //list of files that have been parsed or failed
        public List<string> ParsedFiles;                                //list of files that have been parsed successfully
        public List<string> FailedFiles;                                //list of files that have been parsed unsuccessfully

        //main data
        public List<string> PrimaryProductions;                         //ids of productions that are primary productions
        public Dictionary<string, List<string>> Productions;            //id of left-hand side item, ids of right-hand side items
        public Dictionary<string, List<string>> Tildes;            	    //id of item, ids of tildes
        public Dictionary<string, string> Translations;                 //id of item, text of item
        public Dictionary<string, List<Tuple<string, string>>> Links;       //id of item, links texts
        public Dictionary<string, List<List<string>>> Decorators;           //id of item, decorators texts

        //main data place inside files
        public Dictionary<string, List<string>> ItemidFile;             //item id, filepath(s) that contains it
        public Dictionary<string, List<string>> ProdidFile;             //production id, filepath that contains it

        //Those are mostly used by the parser.
        //By naming them LastFile instead of CurFile
        //we made them part of the parsing metrics instead
        //of an ugly remnant and a place not to touch.
        public string LastNamespace;                                     //current namespace we are in
        public string LastFile;                                          //current file we are in
        //public string FirstNamespace;
        //public string FirstFile;


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
            Tildes = new Dictionary<string, List<string>>();
            Translations = new Dictionary<string, string>();
            Links = new Dictionary<string, List<Tuple<string, string>>>();
            Decorators = new Dictionary<string, List<List<string>>>();

            ItemidFile = new Dictionary<string, List<string>>();
            ProdidFile = new Dictionary<string, List<string>>();
        }
    }
}
