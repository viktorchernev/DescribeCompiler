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
        private bool _isInitialized = false;

        /// <summary>
        /// When we use the transpiler, this becomes true, indicating that
        /// it will need to be reset before we should use it again, so that
        /// logs and statistics don't accumulate.
        /// </summary>
        private bool _isUsed = false;



        /// <summary>
        /// The number of parsed files in the current operation
        /// </summary>
        private int _fileCounter = 0;

        /// <summary>
        /// The number of folders parsed in the current operation
        /// </summary>
        private int _folderCounter = 0;

        /// <summary>
        /// The number of files successfully parsed in the current operation
        /// </summary>
        private int _parsedFileCounter = 0;

        /// <summary>
        /// The number of files failed to parse in the current operation
        /// </summary>
        private int _failedFileCounter = 0;

        /// <summary>
        /// The number of characters red in the current operation
        /// </summary>
        private int _characterCounter = 0;

        /// <summary>
        /// The number of produced tokens in the current operation
        /// </summary>
        private int _tokenCounter = 0;

        /// <summary>
        /// The number of parsed reductions in the current operation
        /// </summary>
        private int _reductionCounter = 0;

        /// <summary>
        /// The number of exceptions thrown in the current operation
        /// </summary>
        private int _errorCounter = 0;


        private void resetStatistics()
        {
            _fileCounter = 0;
            _folderCounter = 0;
            _parsedFileCounter = 0;
            _failedFileCounter = 0;
            _characterCounter = 0;
            _tokenCounter = 0;
            _reductionCounter = 0;
            _errorCounter = 0;
        }
        private void softResetStatistics()
        {
            _characterCounter = 0;
            _tokenCounter = 0;
            _reductionCounter = 0;
            _errorCounter = 0;
        }
    }
}
