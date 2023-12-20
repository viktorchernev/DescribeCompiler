using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler
{
    //http://www.goldparser.org/doc/grammars/predefined-sets.htm
    public interface IDescribeOptimizer
    {
        /// <summary>
        /// Translate Gold engine parse tree (root Reduction r) to Unfold structure.
        /// </summary>
        /// <param name="u">Unfold to be populated</param>
        /// <param name="r">Root reduction aka the parse tree</param>
        /// <returns>True if successful</returns>
        bool DoScripture(DescribeUnfold u, Reduction r);
    }
}
