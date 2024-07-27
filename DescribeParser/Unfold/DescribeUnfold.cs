using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Unfold
{
    /// <summary>
    /// Represents the data structure for containing unfolded data, with links and decorators.
    /// </summary>
    public partial class DescribeUnfold
    {
        /// <summary>
        /// Gets or sets the parse job object for the Unfold.
        /// This class is used in the parsing process and does not need to be accessed directly.
        /// </summary>
        public IDescribeParseJob ParseJob { get; set; }


        //file stats
        /// <summary>
        /// Gets or sets the list of all files.
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
        public Dictionary<string, List<DescribeLink>> Links { get; set; }

        /// <summary>
        /// Gets or sets the dictionary of decorators (item ID - decorators for that item).
        /// </summary>
        public Dictionary<string, List<DescribeDecorator>> Decorators { get; set; }



        //main data place inside files
        /// <summary>
        /// Gets or sets the item/file dictionary (item ID - filenames for that item).
        /// </summary>
        public Dictionary<string, List<string>> ItemidFile { get; set; }

        /// <summary>
        /// Gets or sets the production/file dictionary (item ID - filenames for that production).
        /// </summary>
        public Dictionary<string, List<string>> ProdidFile { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeUnfold"/> class.
        /// </summary>
        public DescribeUnfold()
        {
            ParseJob = new SimpleParseJob();

            AllFiles = new List<string>();
            ParsedFiles = new List<string>();
            FailedFiles = new List<string>();

            PrimaryProductions = new List<string>();
            Productions = new Dictionary<string, List<string>>();
            Tildes = new Dictionary<string, List<string>>();
            Translations = new Dictionary<string, string>();
            Links = new Dictionary<string, List<DescribeLink>>();
            Decorators = new Dictionary<string, List<DescribeDecorator>>();

            ItemidFile = new Dictionary<string, List<string>>();
            ProdidFile = new Dictionary<string, List<string>>();
        }
    }
}

// We might implement a thread-safe version in the future, using thread-safe
// dictionaries and collections, such as ConcurrentDictionary<TKey, TValue> and ConcurrentBag<T>