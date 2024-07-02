using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstDecoratorNode : AstMinorBranchNode
    {
        public AstDecoratorNode()
        { }
        public AstDecoratorNode(SourcePosition position)
            : base(position) { }
        public AstDecoratorNode(AstMinorBranchNode parent)
            : base(parent) { }
        public AstDecoratorNode(SourcePosition position, AstMinorBranchNode parent)
            : base(position, parent) { }
        public AstDecoratorNode(AstMinorBranchNode parent, SourcePosition position)
            : base(parent, position) { }

        public AstDecoratorNode(AstTokenNode chunk)
            : base(chunk) { }
        public AstDecoratorNode(AstTokenNode chunk, AstMinorBranchNode parent)
            : base(chunk, parent) { }

        public AstDecoratorNode(List<AstTokenNode> chunks)
            :base(chunks){ }
        public AstDecoratorNode(List<AstTokenNode> chunks, AstMinorBranchNode parent)
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
