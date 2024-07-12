using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Unfold
{
    /// <summary>
    /// Represents a decorator structure containing name, value, and category information.
    /// </summary>
    public struct DescribeDecorator
    {
        /// <summary>
        /// Gets or sets the name of the decorator.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the optional value of the decorator.
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// Gets or sets the optional category of the decorator.
        /// </summary>
        public string? Category { get; set; }
    }
}

// Nullable strings are an overhead both 1 byte in terms of memory
// and in execution time, as a check needs to be performed.
// However, they add clarity to the code and will be used, unless bottleneck issues arise.