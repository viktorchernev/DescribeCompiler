using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DescribeParser.Ast
{
    public class AstDoubleDecoratorNode : AstDecoratorNode
    {
        public AstLeafNode OpenBracket 
        { 
            get
            {
                return Chunks[0];
            }
            set
            {
                Chunks[0] = value;
            }
        }
        public AstLeafNode Name
        {
            get
            {
                return Chunks[1];
            }
            set
            {
                Chunks[1] = value;
            }
        }
        public AstLeafNode Value
        {
            get
            {
                return Chunks[2];
            }
            set
            {
                Chunks[2] = value;
            }
        }
        public AstLeafNode CloseBracket
        {
            get
            {
                return Chunks[3];
            }
            set
            {
                Chunks[3] = value;
            }
        }


        public AstDoubleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close)
            : base(new List<AstLeafNode>() { open, name, value, close }) { }
        public AstDoubleDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close, AstBranchNode parent)
            : base(new List<AstLeafNode>() { open, name, value, close }, parent) { }


        public override string ToString()
        {
            string s = "(DOUBLE_DECORATOR : ";
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
