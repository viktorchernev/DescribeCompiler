using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoldParser.Egt
{
    /// <summary>
    /// This extension to the binary reader supports direct reading of
    /// a unicode (utf-16) string.
    /// </summary>
    internal class Utf16Reader : System.IO.BinaryReader
    {
        internal Utf16Reader(Stream input) : base(input)
        {
        }
        internal Utf16Reader(Stream input, Encoding encoding) : base(input, encoding)
        {
        }


        /// <summary>
        /// Reads a unicode (utf-16) string.
        /// </summary>
        /// <returns>Unicode string</returns>
        internal string ReadUnicodeString()
        {
            StringBuilder builder = new StringBuilder();
            ushort ch = ReadUInt16();
            while (ch != 0)
            {
                builder.Append((char)ch);
                ch = ReadUInt16();
            }
            return builder.ToString();
        }

        /// <summary>
        /// Reads a unicode (utf-16) string.
        /// This version of ReadUnicodeString() is supposed to be 
        /// safe for other platforms according to that source I
        /// am reading
        /// </summary>
        /// <returns>Unicode string</returns>
        internal string RawReadUnicodeString()
        {
            StringBuilder builder = new StringBuilder();
            ushort ch = RawReadUInt16();
            while (ch != 0)
            {
                builder.Append((char)ch);
                ch = RawReadUInt16();
            }
            return builder.ToString();
        }

        /// <summary>
        /// Read a uint in little endian. This is the format already used
        /// by the .NET BinaryReader. However, it is good to specificially
        /// define this given byte order can change depending on platform.
        /// </summary>
        /// <returns>ushort</returns>
        public ushort RawReadUInt16()
        {
            int b0 = ReadByte();
            int b1 = ReadByte();

            return (ushort)((b1 << 8) + b0);
        }
    }
}
