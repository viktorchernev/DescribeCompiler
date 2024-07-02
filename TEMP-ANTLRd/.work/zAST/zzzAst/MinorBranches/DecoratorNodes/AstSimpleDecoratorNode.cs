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
        public AstTokenNode Name
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
        public AstTokenNode CloseBracket
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


        public AstSimpleDecoratorNode(AstTokenNode open, AstTokenNode name, AstTokenNode close) 
            : base(new List<AstTokenNode>() { open, name, close}) { }
        public AstSimpleDecoratorNode(AstTokenNode open, AstTokenNode name, AstTokenNode close, AstMinorBranchNode parent)
            : base(new List<AstTokenNode>() { open, name, close }, parent) { }



        public override string ToString()
        {
            string s = "(SIMPLE_DECORATOR : ";
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
