using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstNode
    {
        public AstSourcePosition? Position;
        public AstNode? Parent;

        public AstNode()
        {
            Position = null;
            Parent = null;
        }
        public AstNode(AstSourcePosition position)
        {
            Position = position;
            Parent = null;
        }
        public AstNode(AstNode parent)
        {
            Parent = parent;
        }
        public AstNode(AstSourcePosition position, AstNode parent)
        {
            Position = position;
            Parent = parent;
        }
        public AstNode(AstNode parent, AstSourcePosition position)
        {
            Position = position;
            Parent = parent;
        }


        public virtual new string ToString()
        {
            return "Not implemented yet";
        }
        public virtual string ToJson()
        {
            return "Not implemented yet";
        }
        public virtual string ToCode()
        {
            return "Not implemented yet";
        }
    }
}
