using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstSourcePosition
    {
        public int FirstIndex
        {
            get;
            internal set;
        }
        public int FirstLine
        {
            get;
            internal set;
        }
        public int FirstColumn
        {
            get;
            internal set;
        }

        public int LastIndex
        {
            get;
            internal set;
        }
        public int LastLine
        {
            get;
            internal set;
        }
        public int LastColumn
        {
            get;
            internal set;
        }



        public AstSourcePosition(AstSourcePosition position)
        {
            FirstIndex = position.FirstIndex;
            FirstLine = position.FirstLine;
            FirstColumn = position.FirstColumn;

            LastIndex = position.LastIndex;
            LastLine = position.LastLine;
            LastColumn = position.LastColumn;
        }
        public AstSourcePosition(int firstIndex, int firstLine, int firstColumn, int lastIndex, int lastLine, int lastColumn)
        {
            FirstIndex = firstIndex;
            FirstLine = firstLine;
            FirstColumn = firstColumn;
            LastIndex = lastIndex;
            LastLine = lastLine;
            LastColumn = lastColumn;
        }
    }
}
