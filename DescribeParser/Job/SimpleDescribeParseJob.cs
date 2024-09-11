namespace DescribeParser
{
    /// <summary>
    /// This class contains intermediate data, used during a parse operation.
    /// </summary>
    public class SimpleParseJob : IDescribeParseJob
    {
        /// <summary>
        /// Gets or sets the starting directory of the parse operation.
        /// </summary>
        public string? InitialDir { get; set; }

        /// <summary>
        /// Gets or sets the current namespace in a parse operation.
        /// </summary>
        public string? LastNamespace { get; set; }

        /// <summary>
        /// Gets or sets the current local namespace in a parse operation.
        /// </summary>
        public string? LocalNamespace { get; set; }

        /// <summary>
        /// Gets or sets the current file in a parse operation.
        /// </summary>
        public string? LastFile { get; set; }

        /// <summary>
        /// Gets or sets the root file in a parse operation.
        /// </summary>
        public string? RootFile { get; set; }
    }
}
