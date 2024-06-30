using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstTagNode : AstBranchNode
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
        public AstLeafNode Id
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
        public AstLeafNode CloseBracket
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



        public AstTagNode(AstLeafNode id)
            : base(id) { }
        public AstTagNode(AstLeafNode id, AstBranchNode parent)
            : base(id, parent) { }



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
