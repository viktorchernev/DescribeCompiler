using DescribeParser;
using DescribeParser.Ast;
using DescribeParser.Unfold;

namespace DescribeTranspiler.Translators
{
    public abstract class DescribeAstTranslator
    {
        /// <summary>
        /// This is meant as a failsafe - if false then the
        /// translation process should not be allowed to start.
        /// </summary>
        public abstract bool IsInitialized
        {
            get;
            protected set;
        }


        /// <summary>
        /// Translate an AstNode. This is the main method.
        /// </summary>
        /// <param name="u">The AstNode class to translate.</param>
        /// <returns>The resulting string in the target language.</returns>
        public abstract string? TranslateAstTree(AstNode root);
    }
}