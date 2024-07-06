using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstBoldDecoratorNode : AstSimpleDecoratorNode 
    {
        public AstBoldDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close)
            : base(open, name, close) { }

        public AstBoldDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close, IAstBranchNode parent)
            : base(open, name, close, parent) { }

        public override string ToString()
        {
            string s = "(BoldDecorator : ";
            for (int i = 0; i < Leafs.Count - 1; i++)
            {
                s += "\"" + Leafs[i].ToCode() + "\", ";
            }
            if (Leafs.Count > 0)
            {
                s += "\"" + Leafs[Leafs.Count - 1].ToCode() + "\"";
            }
            s += ")";

            return s;
        }
    }
}
