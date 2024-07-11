using DescribeTranspiler.Compiler;


namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// Get Compiler log
        /// </summary>
        public string Log
        {
            get;
            private set;
        }

        /// <summary>
        /// The logging verbosity level
        /// </summary>
        public LogVerbosity Verbosity
        {
            get;
            private set;
        }

        /// <summary>
        /// Get the name of the grammar that is currently loaded
        /// in the compiler and will be used for parsing
        /// </summary>
        public string LoadedGrammarName
        {
            get;
            private set;
        }

        /// <summary>
        /// The artifact mode of the parser:
        /// Weather to Make, Take, Both or ignore artifacts all-together
        /// </summary>
        public ArtifactMode ArtifactMode
        {
            get;
            set;
        }

        /// <summary>
        /// The path to the artifact folder to be used
        /// </summary>
        public string ArtifactsPath
        {
            get;
            set;
        }
    }
}