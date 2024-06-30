using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public abstract class AstNode
    {
        public SourcePosition? Position;
        public AstBranchNode? Parent;

        public AstNode()
        {
            Position = null;
            Parent = null;
        }
        public AstNode(SourcePosition position)
        {
            Position = position;
            Parent = null;
        }
        public AstNode(AstBranchNode parent)
        {
            Parent = parent;
            Position = null;
        }
        public AstNode(SourcePosition position, AstBranchNode parent)
        {
            Position = position;
            Parent = parent;
        }
        public AstNode(AstBranchNode parent, SourcePosition position)
        {
            Position = position;
            Parent = parent;
        }


        public abstract new string ToString();
        public abstract string ToJson();
        public abstract string ToCode();
    }
}
