using System.IO;
using System.Linq;

namespace DescribeCompiler
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
		public static string ExtractResource_String(string filename)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();

			string[] resNames = a.GetManifestResourceNames();
			string resourceName = null; 
			foreach(string s in resNames)
			{
				if(s.EndsWith("." + filename))
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
        public static string ExtractResourceByName_String(string filename)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();

            string[] resNames = a.GetManifestResourceNames();
            string resourceName = null;
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
            if(resourceName == null)
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
    }
}
