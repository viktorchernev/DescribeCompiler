using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler.Translators
{
    public abstract class DescribeTranslator
    {
        /// <summary>
        /// Wether the Translator makes use of template files.
        /// </summary>
        public abstract bool USES_TEMPLATES
        {
            get;
        }

        /// <summary>
        /// Wether there are inbuilt templates for the translator.
        /// </summary>
        public abstract bool HAS_INBUILT_TEMPLATES
        {
            get;
        }

        /// <summary>
        /// The default name of the templates for the translator.
        /// If HAS_INBUILT_TEMPLATES then this should be the name of some
        /// of the inbuilt templates in folder "Templates"
        /// </summary>
        public abstract string DEFAULT_TEMPLATES_NAME
        {
            get;
        }

        /// <summary>
        /// This is meant as a failsafe - if false then the
        /// translation process should not be allowed to start.
        /// </summary>
        public abstract bool IsInitialized
        {
            get;
            protected set;
        }
    }
}
// After we have parsed our files and optimized the resulting parse tree to content in an Unfold
// structure, we might want to translate this unfold structure to a desired language (like HTML,
// or JSON e.g.) This is where Translators come into play.
//
// Previously (before v0.9.2) translators were a part of the compilation process itself, which
// limited flexibility and made implementation of custom translators harder.
//
// Translators might (and will in many cases) make use of "translation templates". Those are
// collections of source code files containing placeholder text where information will be inserted.
// There are inbuilt templates it this project (as embedded resources - folder "Templates"), and
// there are inbuilt translators that will use those. You can use those templates in building
// your own translators, and you can provide an inbuilt translator with external templates.