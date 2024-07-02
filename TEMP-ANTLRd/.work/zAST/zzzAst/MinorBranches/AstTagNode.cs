using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstTagNode : AstMinorBranchNode
    {
        public AstTokenNode OpenBracket
        {
            get
            {
                return Chunks[0] as AstTokenNode;
            }
            set
            {
                Chunks[0] = value;
            }
        }
        public AstTokenNode Id
        {
            get
            {
                return Chunks[1] as AstTokenNode;
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
                return Chunks[2] as AstTokenNode;
            }
            set
            {
                Chunks[2] = value;
            }
        }



        public AstTagNode(AstTokenNode open, AstTokenNode id, AstTokenNode close)
            : base(new List<AstNode>() { open, id, close }) { }
        public AstTagNode(AstTokenNode open, AstTokenNode id, AstTokenNode close, AstMinorBranchNode parent)
            : base(new List<AstNode>() { open, id, close }, parent) { }



        public override string ToString()
        {
            string s = "(Tag : ";
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
