namespace DescribeTranspiler
{
    public partial class DescribeCompiler
    {
        /// <summary>
        /// Add your method for logging info here
        /// </summary>
        public Action<string> LogInfo;

        /// <summary>
        /// Add your method for logging error here
        /// </summary>
        public Action<string> LogError;

        /// <summary>
        /// Add your method for logging text here
        /// </summary>
        public Action<string> LogText;

        /// <summary>
        /// Add your method for logging parser data here
        /// </summary>
        public Action<string> LogParserInfo;

        /// <summary>
        /// This private method is assigned to all of the event handlers above.
	    /// It simply appends data to the Log property.
        /// </summary>
        /// <param name="text">The text to log</param>
        private void log(string text)
        {
            if (!string.IsNullOrEmpty(Log)) Log += Environment.NewLine;
            Log += text;
        }
    }
}