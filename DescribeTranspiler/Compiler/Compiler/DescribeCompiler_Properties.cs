using DescribeParser;
using DescribeParser.Visitors;
using DescribeTranspiler;
using DescribeTranspiler.Preprocessors;


namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        // Functional

        /// <summary>
        /// The current Preprocessor class for the current version of the language
        /// that will be used for parsing.
        /// </summary>
        public IDescribePreprocessor CurrentPreprocessor
        {
            get
            {
                return _preprocessors[GRAMMAR_VERSION];
            }
            set
            {
                _preprocessors[GRAMMAR_VERSION] = value;
            }
        }

        /// <summary>
        /// The universal Unfold visitor class - Used to optimise parse result (parse tree)
        /// to an Unfold structure.
        /// </summary>
        public UniversalUnfoldVisitor UnfoldVisitor
        {
            get
            {
                return _unfoldVisitor;
            }
            set
            {
                _unfoldVisitor = value;
            }
        }

        /// <summary>
        /// The universal Unfold visitor class - Used to optimise parse result (parse tree)
        /// to an Abstract Syntax Tree
        /// </summary>
        public UniversalAstVisitor AstVisitor
        {
            get
            {
                return _astVisitor;
            }
            set
            {
                _astVisitor = value;
            }
        }

        /// <summary>
        /// The universal Log visitor class - Used to optimise parse result (parse tree)
        /// to a log text.
        /// </summary>
        public UniversalLogVisitor LogVisitor
        {
            get
            {
                return _logVisitor;
            }
            set
            {
                _logVisitor = value;
            }
        }

        /// <summary>
        /// The universal Log visitor class - Used to optimise parse result (parse tree)
        /// to a log text.
        /// </summary>
        public SimpleParseJob CurrentJob
        {
            get
            {
                return _currentJob;
            }
            set
            {
                _currentJob = value;
            }
        }


        // Functional

        /// <summary>
        /// Get Compiler log
        /// </summary>
        public string Log
        {
            get
            {
                return _log;
            }
            private set
            {
                _log = value;
            }
        }

        /// <summary>
        /// The logging verbosity level
        /// </summary>
        public LogVerbosity Verbosity
        {
            get
            {
                return LOG_VERBOSITY;
            }
            set 
            {
                LOG_VERBOSITY = value; 
            }
        }

        /// <summary>
        /// Gets or sets current language to be used during parsing
        /// </summary>
        public DescribeVersionName LanguageName
        { 
            get
            {
                return GRAMMAR_NAME;
            }
            set
            {
                GRAMMAR_NAME = value;
                switch (value)
                {
                    case DescribeVersionName.Basics:
                        GRAMMAR_VERSION = DescribeVersionNumber.Version06;
                        break;
                    case DescribeVersionName.Tags:
                        GRAMMAR_VERSION = DescribeVersionNumber.Version07;
                        break;
                    case DescribeVersionName.Links:
                        GRAMMAR_VERSION = DescribeVersionNumber.Version08;
                        break;
                    case DescribeVersionName.Decorators:
                        GRAMMAR_VERSION = DescribeVersionNumber.Version09;
                        break;
                    case DescribeVersionName.Lines:
                        GRAMMAR_VERSION = DescribeVersionNumber.Version10;
                        break;
                    case DescribeVersionName.Doubles:
                        GRAMMAR_VERSION = DescribeVersionNumber.Version11;
                        break;
                    default:
                        throw new ArgumentException("LanguageName is unknown");
                }
            }
        }

        /// <summary>
        /// Gets or sets current language to be used during parsing
        /// </summary>
        public DescribeVersionNumber LanguageVersion
        {
            get
            {
                return GRAMMAR_VERSION;
            }
            set
            {
                GRAMMAR_VERSION = value;
                switch (value)
                {
                    case DescribeVersionNumber.Version06:
                        GRAMMAR_NAME = DescribeVersionName.Basics;
                        break;
                    case DescribeVersionNumber.Version07:
                        GRAMMAR_NAME = DescribeVersionName.Tags;
                        break;
                    case DescribeVersionNumber.Version08:
                        GRAMMAR_NAME = DescribeVersionName.Links;
                        break;
                    case DescribeVersionNumber.Version09:
                        GRAMMAR_NAME = DescribeVersionName.Decorators;
                        break;
                    case DescribeVersionNumber.Version10:
                        GRAMMAR_NAME = DescribeVersionName.Lines;
                        break;
                    case DescribeVersionNumber.Version11:
                        GRAMMAR_NAME = DescribeVersionName.Doubles;
                        break;
                    default:
                        throw new ArgumentException("LanguageVersion is unknown");
                }
            }
        }


        // Info

        /// <summary>
        /// Get the name of the Compiler that is currently being used
        /// </summary>
        public string CompilerName
        {
            get
            {
                return COMPILER_NAME;
            }
        }

        /// <summary>
        /// Get the version of the Compiler that is currently being used
        /// </summary>
        public string CompilerVersion
        {
            get
            {
                return COMPILER_VERSION;
            }
        }

        /// <summary>
        /// Get the name of the grammar that is currently loaded
        /// in the compiler and will be used for parsing
        /// </summary>
        public string GrammarName
        {
            get
            {
                switch(GRAMMAR_NAME)
                {
                    case DescribeVersionName.Basics:
                        return "Describe Basics";
                    case DescribeVersionName.Tags:
                        return "Describe Tags";
                    case DescribeVersionName.Links:
                        return "Describe Links";
                    case DescribeVersionName.Decorators:
                        return "Describe Decorators";
                    case DescribeVersionName.Lines:
                        return "Describe Lines";
                    case DescribeVersionName.Doubles:
                        return "Describe Doubles";
                    default:
                        return "unknown";
                }
            }
        }

        /// <summary>
        /// Get the version of the grammar that is currently loaded
        /// in the compiler and will be used for parsing
        /// </summary>
        public string GrammarVersion
        {
            get
            {
                switch (GRAMMAR_VERSION)
                {
                    case DescribeVersionNumber.Version06:
                        return "Describe v0.6";
                    case DescribeVersionNumber.Version07:
                        return "Describe v0.7";
                    case DescribeVersionNumber.Version08:
                        return "Describe v0.8";
                    case DescribeVersionNumber.Version09:
                        return "Describe v0.9";
                    case DescribeVersionNumber.Version10:
                        return "Describe v1.0";
                    case DescribeVersionNumber.Version11:
                        return "Describe v1.1";
                    default:
                        return "unknown";
                }
            }
        }

        /// <summary>
        /// Get the name with version of the grammar that is currently loaded
        /// in the compiler and will be used for parsing
        /// </summary>
        public string GrammarFullName
        {
            get
            {
                switch (GRAMMAR_NAME)
                {
                    case DescribeVersionName.Basics:
                        return "Describe Basics - v0.6";
                    case DescribeVersionName.Tags:
                        return "Describe Tags - v0.7";
                    case DescribeVersionName.Links:
                        return "Describe Links - v0.8";
                    case DescribeVersionName.Decorators:
                        return "Describe Decorators - v0.9";
                    case DescribeVersionName.Lines:
                        return "Describe Lines - v1.0";
                    case DescribeVersionName.Doubles:
                        return "Describe Doubles - v1.1";
                    default:
                        return "unknown";
                }
            }
        }


        // Statistics

        /// <summary>
        /// Get wether the current Transpiler is initialized.
        /// </summary>
        public bool IsInitialized
        {
            get
            {
                return _isInitialized;
            }
        }

        /// <summary>
        /// Get wether the current Transpiler has been used.
        /// </summary>
        public bool IsUsed
        {
            get
            {
                return _isUsed;
            }
        }

        /// <summary>
        /// Gets the number of parsed files in the current operation
        /// </summary>
        public int FileCount
        {
            get
            {
                return _fileCounter;
            }
        }

        /// <summary>
        /// Gets the number of folders parsed in the current operation
        /// </summary>
        public int FolderCount
        {
            get
            {
                return FolderCount;
            }
        }

        /// <summary>
        /// Gets the number of files successfully parsed in the current operation
        /// </summary>
        public int ParsedFileCount
        {
            get
            {
                return _parsedFileCounter;
            }
        }

        /// <summary>
        /// Gets the number of files failed to parse in the current operation
        /// </summary>
        public int FailedFileCount
        {
            get
            {
                return _failedFileCounter;
            }
        }

        /// <summary>
        /// Gets the number of characters red in the current operation
        /// </summary>
        public int CharacterCount
        {
            get
            {
                return _characterCounter;
            }
        }

        /// <summary>
        /// Gets the number of produced tokens in the current operation
        /// </summary>
        public int TokenCount
        {
            get
            {
                return _tokenCounter;
            }
        }

        /// <summary>
        /// Gets the number of parsed reductions in the current operation
        /// </summary>
        public int ReductionCount
        {
            get
            {
                return _reductionCounter;
            }
        }

        /// <summary>
        /// Gets the number of exceptions thrown in the current operation
        /// </summary>
        public int ErrorCount
        {
            get
            {
                return _errorCounter;
            }
        }
    }
}