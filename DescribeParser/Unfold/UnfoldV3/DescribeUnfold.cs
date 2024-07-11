using DescribeParser.Unfold.Oddball;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Unfold.UnfoldV3
{
    /// <summary>
    /// Represents the data structure for describing unfolded data with int indexes for IDs and files.
    /// Basically, DescribeUnfoldV3 is DescribeUnfoldV2 with int indexes for files and ids
    /// </summary>
    public partial class DescribeUnfoldV3
    {
        //file stats
        /// <summary>
        /// Gets or sets the dictionary of all files (file ID - file name or path)
        /// </summary>
        public Dictionary<int, string> AllFiles;
        
        /// <summary>
        /// Gets or sets the list of files that have been parsed successfully.
        /// </summary>
        public List<int> ParsedFiles { get; set; }

        /// <summary>
        /// Gets or sets the list of files that have been parsed unsuccessfully.
        /// </summary>
        public List<int> FailedFiles { get; set; }



        //main data
        /// <summary>
        /// Gets or sets the dictionary of (int ID of string ID, string ID)
        /// </summary>
        public Dictionary<int, string> Ids;

        /// <summary>
        /// Gets or sets the list of primary production IDs.
        /// </summary>
        public List<int> PrimaryProductions;

        /// <summary>
        /// Gets or sets the dictionary of productions (head item ID - body items ID's).
        /// </summary>
        public Dictionary<int, List<int>> Productions;

        /// <summary>
        /// Gets or sets the dictionary of tildes (head item ID - body items ID's).
        /// </summary>
        public Dictionary<int, List<int>> Tildes;

        /// <summary>
        /// Gets or sets the dictionary of translations (item ID - item Text).
        /// </summary>
        public Dictionary<int, string> Translations;

        /// <summary>
        /// Gets or sets the dictionary of links (item ID - links for that item).
        /// </summary>
        public Dictionary<int, List<Link>> Links;

        /// <summary>
        /// Gets or sets the dictionary of decorators (item ID - decorators for that item).
        /// </summary>
        public Dictionary<int, List<Decorator>> Decorators;



        //main data place inside files
        /// <summary>
        /// Files that contain items (item ID - filename IDs for that item).
        /// </summary>
        public Dictionary<int, List<int>> ItemidFile {  get; set; }
        
        /// <summary>
        /// Files that contain productions (item ID - filename IDs for that production).
        /// </summary>
        public Dictionary<int, List<int>> ProdidFile {  get; set; }



        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeUnfoldV3"/> class.
        /// </summary>
        public DescribeUnfoldV3()
        {
            AllFiles = new Dictionary<int, string>();
            ParsedFiles = new List<int>();
            FailedFiles = new List<int>();

            Ids = new Dictionary<int, string>();
            PrimaryProductions = new List<int>();
            Productions = new Dictionary<int, List<int>>();
            Tildes = new Dictionary<int, List<int>>();
            Translations = new Dictionary<int, string>();
            Links = new Dictionary<int, List<Link>>();
            Decorators = new Dictionary<int, List<Decorator>>();

            ItemidFile = new Dictionary<int, List<int>>();
            ProdidFile = new Dictionary<int, List<int>>();
        }
    }
}

// We might implement a thread-safe version in the future, using thread-safe
// dictionaries and collections, such as ConcurrentDictionary<TKey, TValue> and ConcurrentBag<T>