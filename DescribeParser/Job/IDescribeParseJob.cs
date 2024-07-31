using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser
{
    /// <summary>
    /// This interface represents a class, used to contain intermediate data, 
    /// used during a parse operation.
    /// </summary>
    public interface IDescribeParseJob
    {
        /// <summary>
        /// Gets or sets the starting directory of the parse operation.
        /// </summary>
        public string? InitialDir { get; set; }

        /// <summary>
        /// Gets or sets the current namespace in a parse operation.
        /// </summary>
        public string? LastNamespace { get; set; }

        /// <summary>
        /// Gets or sets the current file in a parse operation.
        /// </summary>
        public string? LastFile { get; set; }
    }
}
