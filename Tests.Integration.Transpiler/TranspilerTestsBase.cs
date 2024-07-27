using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Integration.Transpiler
{
    internal class TranspilerTestsBase
    {
        static string GetElapsedTime(Stopwatch watch)
        {
            // Old - millisecond range
            //string formattedElapsedTime = string.Format("{0:0}.{1:000} seconds", elapsed.TotalSeconds, elapsed.Milliseconds);
            //return formattedElapsedTime

            // New - 100 Nanosecond range
            TimeSpan elapsed = watch.Elapsed;

            // Convert ticks to nanoseconds
            double totalNanoseconds = elapsed.Ticks * 100.0;

            // Calculate milliseconds, microseconds, and nanoseconds
            int milliseconds = (int)(totalNanoseconds / 1_000_000);
            int microseconds = (int)((totalNanoseconds % 1_000_000) / 1_000);
            int nanoseconds = (int)(totalNanoseconds % 1_000);

            // Format the elapsed time to include milliseconds, microseconds, and nanoseconds
            string formattedElapsedTime = string.Format("{0:0}.{1:000}.{2:000}.{3:0} seconds",
                Math.Floor(elapsed.TotalSeconds), milliseconds, microseconds, nanoseconds / 100);

            //return
            return formattedElapsedTime;
        }
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
