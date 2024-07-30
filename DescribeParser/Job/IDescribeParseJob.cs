using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser
{
    /// <summary>
    /// Contains the intermediate data, used during a parse operation.
    /// </summary>
    public interface IDescribeParseJob
    {
        /// <summary>
        /// Gets or sets the starting directory.
        /// </summary>
        public string? InitialDir { get; set; }

        /// <summary>
        /// Gets or sets the current namespace we are in.
        /// </summary>
        public string? LastNamespace { get; set; }

        /// <summary>
        /// Gets or sets the current file we are in.
        /// </summary>
        public string? LastFile { get; set; }
    }
}
