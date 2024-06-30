using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstDecoratorNode : AstBranchNode
    {
        public AstDecoratorNode()
        { }
        public AstDecoratorNode(SourcePosition position)
            : base(position) { }
        public AstDecoratorNode(AstBranchNode parent)
            : base(parent) { }
        public AstDecoratorNode(SourcePosition position, AstBranchNode parent)
            : base(position, parent) { }
        public AstDecoratorNode(AstBranchNode parent, SourcePosition position)
            : base(parent, position) { }

        public AstDecoratorNode(AstLeafNode chunk)
            : base(chunk) { }
        public AstDecoratorNode(AstLeafNode chunk, AstBranchNode parent)
            : base(chunk, parent) { }

        public AstDecoratorNode(List<AstLeafNode> chunks)
            :base(chunks){ }
        public AstDecoratorNode(List<AstLeafNode> chunks, AstBranchNode parent)
            : base(chunks, parent) { }


        public override string ToString()
        {
            string s = "(DECORATOR : ";
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
