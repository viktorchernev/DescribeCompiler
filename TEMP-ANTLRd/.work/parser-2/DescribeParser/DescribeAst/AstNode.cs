using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.AST
{
    public abstract class AstNode
    {
        public string Text;
        public int Line;
        public int Start;
        public int End;
    }
}
