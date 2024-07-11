using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Unfold.Oddball
{
    /// <summary>
    /// Represents the data structure for describing unfolded data with links and decorators.
    /// Basically, DescribeUnfoldV2 is DescribeUnfold with Link and Decorator structures.
    /// </summary>
    public partial class DescribeUnfoldV2
    {
        //file stats
        /// <summary>
        /// Gets or sets the list of all files that have been parsed or failed.
        /// </summary>
        public List<string> AllFiles { get; set; }

        /// <summary>
        /// Gets or sets the list of files that have been parsed successfully.
        /// </summary>
        public List<string> ParsedFiles { get; set; }

        /// <summary>
        /// Gets or sets the list of files that have been parsed unsuccessfully.
        /// </summary>
        public List<string> FailedFiles { get; set; }



        //main data
        /// <summary>
        /// Gets or sets the list of primary production IDs.
        /// </summary>
        public List<string> PrimaryProductions { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of productions (head item ID - body items ID's).
        /// </summary>
        public Dictionary<string, List<string>> Productions { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of tildes (head item ID - body items ID's).
        /// </summary>
        public Dictionary<string, List<string>> Tildes { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of translations (item ID - item Text).
        /// </summary>
        public Dictionary<string, string> Translations { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of links (item ID - links for that item).
        /// </summary>
        public Dictionary<string, List<Link>> Links { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of decorators (item ID - decorators for that item).
        /// </summary>
        public Dictionary<string, List<Decorator>> Decorators { get; set; }



        //main data place inside files
        /// <summary>
        /// Files that contain items (item ID - filenames for that item).
        /// </summary>
        public Dictionary<string, List<string>> ItemidFile { get; set; }

        /// <summary>
        /// Files that contain productions (item ID - filenames for that production).
        /// </summary>
        public Dictionary<string, List<string>> ProdidFile { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeUnfoldV2"/> class.
        /// </summary>
        public DescribeUnfoldV2()
        {
            AllFiles = new List<string>();
            ParsedFiles = new List<string>();
            FailedFiles = new List<string>();

            PrimaryProductions = new List<string>();
            Productions = new Dictionary<string, List<string>>();
            Tildes = new Dictionary<string, List<string>>();
            Translations = new Dictionary<string, string>();
            Links = new Dictionary<string, List<Link>>();
            Decorators = new Dictionary<string, List<Decorator>>();

            ItemidFile = new Dictionary<string, List<string>>();
            ProdidFile = new Dictionary<string, List<string>>();
        }
    }
}

// We might implement a thread-safe version in the future, using thread-safe
// dictionaries and collections, such as ConcurrentDictionary<TKey, TValue> and ConcurrentBag<T>