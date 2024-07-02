using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class SourcePosition
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
    }
}
