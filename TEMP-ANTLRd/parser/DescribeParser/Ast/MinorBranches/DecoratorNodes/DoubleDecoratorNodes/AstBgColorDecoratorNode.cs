using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstBgColorDecoratorNode : AstDoubleDecoratorNode 
    {
        public AstBgColorDecoratorNode(AstTokenNode open, AstTokenNode name, AstTokenNode value, AstTokenNode close)
            : base(open, name, value, close) { }

        public AstBgColorDecoratorNode(AstTokenNode open, AstTokenNode name, AstTokenNode value, AstTokenNode close, AstMinorBranchNode parent)
            : base(open, name, value, close, parent) { }

        public override string ToString()
        {
            string s = "(BgColorDecorator : ";
            for (int i = 0; i < Chunks.Count - 1; i++)
            {
                s += "\"" + Chunks[i].ToCode() + "\", ";
            }
            if (Chunks.Count > 0)
            {
                s += "\"" + Chunks[Chunks.Count - 1].ToCode() + "\"";
            }
            s += ")";

            return s;
        }
    }
}
