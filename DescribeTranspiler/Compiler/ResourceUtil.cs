using System.IO;
using System.Linq;

namespace DescribeTranspiler
{
    public static class ResourceUtil
    {
        /// <summary>
        /// Retrieve a byte array that is an embedded resource
        /// </summary>
        /// <param name="filename">The name of the byte array resource</param>
        /// <returns>The retrieved byte array</returns>
        public static byte[] ExtractResource_ByteArray(string filename)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();

            string resourceName = a.GetManifestResourceNames()
                .Single(str => str.EndsWith(filename));

            using (Stream resFilestream = a.GetManifestResourceStream(resourceName))
            {
                if (resFilestream == null) return null;
                byte[] ba = new byte[resFilestream.Length];
                resFilestream.Read(ba, 0, ba.Length);
                return ba;
            }
        }

        /// <summary>
        /// Retrieve a string that is an embedded resource
        /// </summary>
        /// <param name="filename">The name of the string resource</param>
        /// <returns>The retrieved string</returns>
		public static string ExtractResourceByFileExtention_String(string filename)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();

            string[] resNames = a.GetManifestResourceNames();
            string resourceName = null;
            foreach (string s in resNames)
            {
                if (s.EndsWith("." + filename))
                {
                    resourceName = s;
                    break;
                }
            }
            using (Stream resFilestream = a.GetManifestResourceStream(resourceName))
            {
                if (resFilestream == null) return null;
                using (StreamReader reader = new StreamReader(resFilestream))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }



        /// <summary>
        /// Retrieve a string that is an embedded resource
        /// </summary>
        /// <param name="filename">The name of the string resource, without extention</param>
        /// <returns>The retrieved string</returns>
        public static string ExtractResourceByFileName_String(string folder, string filename)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();

            string[] resNames = a.GetManifestResourceNames();
            string resourceName = null;
            foreach (string s in resNames)
            {
                string[] sep = s.Split('.');
                if (sep.Length < 1) continue;
                if (sep.Length >= 3)
                {
                    //file extention
                    if (sep[sep.Length - 2] == filename && sep[sep.Length - 3] == folder)
                    {
                        resourceName = s;
                        break;
                    }
                    //no file extention
                    else if (sep[sep.Length - 1] == filename && sep[sep.Length - 2] == folder)
                    {
                        resourceName = s;
                        break;
                    }
                }
            }
            if (resourceName == null)
            {
                foreach (string s in resNames)
                {
                    string[] sep = s.Split('.');
                    if (sep.Length < 1) continue;
                    if (sep.Length >= 2 && sep[sep.Length - 2] == filename)
                    {
                        resourceName = s;
                        break;
                    }
                }
            }

            using (Stream resFilestream = a.GetManifestResourceStream(resourceName))
            {
                if (resFilestream == null) return null;
                using (StreamReader reader = new StreamReader(resFilestream))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }

        /// <summary>
        /// Retrieve the names of all embedded resources
        /// </summary>
        /// <returns>An array of strings containing the names</returns>
        public static string[] extractResourceNames()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();

            string[] resNames = a.GetManifestResourceNames();
            return resNames;
        }
    }
}
