using DescribeTranspiler.Preprocessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescribeParser.Visitors;
using Antlr4.Runtime;
using DescribeParser;
using DescribeParser.Unfold;
using DescribeParser.Ast;


namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        // need all these so that they can be swapped by user derived class
        // don't need to figure out a way to do this for the lexer and the parser?
        private Dictionary<DescribeVersionNumber, IDescribePreprocessor> _preprocessors;

        /// <summary>
        /// The Universal visitor for working with Unfolds.
        /// </summary>
        private UniversalUnfoldVisitor _unfoldVisitor;

        /// <summary>
        /// The Universal visitor for working with Abstract Syntax Trees.
        /// </summary>
        private UniversalAstVisitor _astVisitor;

        /// <summary>
        /// The Universal visitor for working with Logs (logging only).
        /// </summary>
        private UniversalLogVisitor _logVisitor;

        /// <summary>
        /// The logs for the current parse operation
        /// </summary>
        private string _log;


        private void resetBase()
        {
            _preprocessors = new Dictionary<DescribeVersionNumber, IDescribePreprocessor>();
            _preprocessors.Add(DescribeVersionNumber.Version06, new PreprocessorFor06(this));
            _preprocessors.Add(DescribeVersionNumber.Version07, new PreprocessorFor07(this));
            _preprocessors.Add(DescribeVersionNumber.Version08, new PreprocessorFor08(this));
            _preprocessors.Add(DescribeVersionNumber.Version09, new PreprocessorFor09(this));
            _preprocessors.Add(DescribeVersionNumber.Version10, new PreprocessorFor10(this));
            _preprocessors.Add(DescribeVersionNumber.Version11, new PreprocessorFor11(this));

            _unfoldVisitor = new UniversalUnfoldVisitor();
            _astVisitor = new UniversalAstVisitor();
            _logVisitor = new UniversalLogVisitor();

            _log = "";
        }
    }
}
