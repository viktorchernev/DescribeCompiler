using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class DescribeSourcePosition
    {
        public int StartLine
        {
            get;
            internal set;
        }
        public int StartChar
        {
            get;
            internal set;
        }

        public int LastLine
        {
            get;
            internal set;
        }
        public int LastChar
        {
            get;
            internal set;
        }


        public DescribeSourcePosition(int startLine, int startChar, int lastLine, int lastChar)
        {
            StartLine = startLine;
            StartChar = startChar;
            LastLine = lastLine;
            LastChar = lastChar;
        }
    }
}
