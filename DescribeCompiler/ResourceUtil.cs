using System.IO;
using System.Linq;

namespace DescribeCompiler
{
    public class ResourceUtil
	{   
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
    }
}
