using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// If Ctor went wrong, we should not be allowed to continue
        /// </summary>
        public bool isInitialized = false;

        /// <summary>
        /// The number of parsed files in the current operation
        /// </summary>
        public int FileCounter = 0;

        /// <summary>
        /// The number of produced tokens in the current operation
        /// </summary>
        public int TokenCounter = 0;

        /// <summary>
        /// The number of parsed reductions in the current operation
        /// </summary>
        public int ReductionCounter = 0;

        //int parsedFilesCounter; //todo: integrate
        //int failedFilesCounter; //todo: integrate
    }
}
