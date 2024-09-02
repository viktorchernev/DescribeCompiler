using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler
{
    /// <summary>
    /// Represents a Describe source code string to be parsed.
    /// </summary>
    public struct SourceCode
    {
        /// <summary>
        /// The name associated with this string.
        /// </summary>
        public string FileName;

        /// <summary>
        /// The source code to be parsed.
        /// </summary>
        public string SourceText;
    }
}
