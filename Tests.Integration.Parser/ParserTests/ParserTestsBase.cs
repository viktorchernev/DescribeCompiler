using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.IntegrationTests
{
    internal class ParserTestsBase
    {
        internal static string ReplaceWhitespaceE(string text)
        {
            return text.Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
        internal static string ReplaceWhitespaceS(string text)
        {
            return text.Replace(Environment.NewLine, "↓")
                .Replace("\r", "←")
                .Replace("\t", "→");
        }
        internal static string getEmbeddedResource(string resourceName)
        {
            string text = "";
            using (Stream stream = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException("Resource not found.");
                }
                using (StreamReader reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }
            }
            return text;
        }
        internal static string[] getEmbeddedResoucesNames()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resourceNames = assembly.GetManifestResourceNames();
            return resourceNames;
        }
    }
}
