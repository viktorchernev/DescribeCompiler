using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstLinkNode : AstMinorBranchNode
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
        public AstTokenNode Url
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
        public AstTokenNode Title
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
        public AstTokenNode Letter
        {
            get
            {
                return Chunks[3] as AstTokenNode;
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
                return Chunks[4] as AstTokenNode;
            }
            set
            {
                Chunks[4] = value;
            }
        }



        public AstLinkNode(AstTokenNode url)
            : base(url) { }
        public AstLinkNode(AstTokenNode url, AstMinorBranchNode parent)
            : base(url, parent) { }

        public AstLinkNode(AstTokenNode url, AstTokenNode title)
            : base(new List<AstTokenNode>() { url, title }) { }
        public AstLinkNode(AstTokenNode url, AstTokenNode title, AstMinorBranchNode parent)
            : base(new List<AstNode>() { url, title }, parent) { }

        public AstLinkNode(AstTokenNode url, AstTokenNode title, AstTokenNode letter)
            : base(new List<AstNode>() { url, title, letter }) { }
        public AstLinkNode(AstTokenNode url, AstTokenNode title, AstTokenNode letter, AstMinorBranchNode parent)
            : base(new List<AstNode>() { url, title, letter }, parent) { }



        public override string ToString()
        {
            string s = "(Link : ";
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
