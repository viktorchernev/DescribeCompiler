using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstLinkNode : AstBranchNode
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
        public AstLeafNode Url
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
        public AstLeafNode Title
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
        public AstLeafNode Letter
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
        public AstLeafNode CloseBracket
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



        public AstLinkNode(AstLeafNode url)
            : base(url) { }
        public AstLinkNode(AstLeafNode url, AstBranchNode parent)
            : base(url, parent) { }

        public AstLinkNode(AstLeafNode url, AstLeafNode title)
            : base(new List<AstLeafNode>() { url, title }) { }
        public AstLinkNode(AstLeafNode url, AstLeafNode title, AstBranchNode parent)
            : base(new List<AstLeafNode>() { url, title }, parent) { }

        public AstLinkNode(AstLeafNode url, AstLeafNode title, AstLeafNode letter)
            : base(new List<AstLeafNode>() { url, title, letter }) { }
        public AstLinkNode(AstLeafNode url, AstLeafNode title, AstLeafNode letter, AstBranchNode parent)
            : base(new List<AstLeafNode>() { url, title, letter }, parent) { }



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
