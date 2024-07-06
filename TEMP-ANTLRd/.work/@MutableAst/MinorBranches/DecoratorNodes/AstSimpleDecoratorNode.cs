using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstSimpleDecoratorNode : AstDecoratorNode
    {
        public AstLeafNode OpenBracket 
        { 
            get
            {
                return Leafs[0];
            }
            set
            {
                Leafs[0] = value;
            }
        }
        public AstLeafNode Name
        {
            get
            {
                return Leafs[1];
            }
            set
            {
                Leafs[1] = value;
            }
        }
        public AstLeafNode CloseBracket
        {
            get
            {
                return Leafs[2];
            }
            set
            {
                Leafs[2] = value;
            }
        }


        public AstSimpleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close) 
            : base(new List<AstLeafNode>() { open, name, close}) { }
        public AstSimpleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close, IAstBranchNode parent)
            : base(new List<AstLeafNode>() { open, name, close }, parent) { }



        public override string ToString()
        {
            string s = "(SIMPLE_DECORATOR : ";
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
