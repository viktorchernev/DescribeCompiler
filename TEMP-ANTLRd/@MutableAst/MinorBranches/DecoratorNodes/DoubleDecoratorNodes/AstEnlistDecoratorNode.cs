using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstEnlistDecoratorNode : AstDoubleDecoratorNode 
    {
        public AstEnlistDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close)
            : base(open, name, value, close) { }

        public AstEnlistDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close, IAstBranchNode parent)
            : base(open, name, value, close, parent) { }

        public override string ToString()
        {
            string s = "(EnlistDecorator : ";
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