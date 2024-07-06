using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DescribeParser.Ast
{
    public class AstTripleDecoratorNode : AstDecoratorNode
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
        public AstLeafNode Category
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
        public AstLeafNode Name
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
        public AstLeafNode Value
        {
            get
            {
                return Leafs[3];
            }
            set
            {
                Leafs[3] = value;
            }
        }
        public AstLeafNode CloseBracket
        {
            get
            {
                return Leafs[4];
            }
            set
            {
                Leafs[4] = value;
            }
        }


        public AstTripleDecoratorNode(AstLeafNode open, AstLeafNode category,
            AstLeafNode name, AstLeafNode value, AstLeafNode close)
                : base(new List<AstLeafNode>() { open, category, name, value, close }) { }

        public AstTripleDecoratorNode(AstLeafNode open, AstLeafNode category,
            AstLeafNode name, AstLeafNode value, AstLeafNode close, IAstBranchNode parent)
            : base(new List<AstLeafNode>() { open, category, name, value, close }, parent) { }


        public override string ToString()
        {
            string s = "(TRIPLE_DECORATOR : ";
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
