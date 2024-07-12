using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Unfold
{
    /// <summary>
    /// Represents a link structure containing URL, title, and letter information.
    /// </summary>
    public struct DescribeLink
    {
        /// <summary>
        /// Gets or sets the URL of the link.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the optional title of the link.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the optional letter associated with the link.
        /// </summary>
        public string? Letter { get; set; }
    }
}

// Nullable strings are an overhead both 1 byte in terms of memory
// and in execution time, as a check needs to be performed.
// However, they add clarity to the code and will be used, unless bottleneck issues arise.