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
        public AstTokenNode OpenBracket
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
        public AstTokenNode Category
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
        public AstTokenNode Name
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
        public AstTokenNode Value
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
        public AstTokenNode CloseBracket
        {
            get
            {
                return Chunks[4];
            }
            set
            {
                Chunks[4] = value;
            }
        }


        public AstTripleDecoratorNode(AstTokenNode open, AstTokenNode category, 
            AstTokenNode name, AstTokenNode value, AstTokenNode close)
                : base(new List<AstTokenNode>() { open, category, name, value, close }) { }

        public AstTripleDecoratorNode(AstTokenNode open, AstTokenNode category, 
            AstTokenNode name, AstTokenNode value, AstTokenNode close, AstMinorBranchNode parent)
            : base(new List<AstTokenNode>() { open, category, name, value, close }, parent) { }


        public override string ToString()
        {
            string s = "(TRIPLE_DECORATOR : ";
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
