using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler.Compiler.Preprocessors
{
    public interface IDescribePreprocessor
    {
        /// <summary>
        /// Preprocess Describe source code
        /// </summary>
        /// <param name="value">The source code string to be preprocessed</param>
        /// <returns>The preprocessed source code string</returns>
        string ProcessSource(string value);
    }
}
