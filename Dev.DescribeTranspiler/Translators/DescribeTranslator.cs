using DescribeParser;
using DescribeParser.Unfold;

namespace DescribeTranspiler.Translators
{
    public abstract class DescribeTranslator
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
        /// Translate an unfold structure. This is the main method.
        /// </summary>
        /// <param name="u">The unfold structure to translate.</param>
        /// <returns>The resulted string in the target language.</returns>
        public abstract string TranslateUnfold(DescribeUnfold u);
    }
}
// After we have parsed our files and optimized the resulting parse tree to content in an Unfold
// structure, we might want to translate this unfold structure to a desired language (like HTML,
// or JSON e.g.) This is where Translators come into play.
//
// Previously (before v0.9.2) translators were a part of the compilation process itself, which
// limited flexibility and made implementation of custom translators harder.