using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class CloseLinkLeafNode : AstLeafNode
    {
        public CloseLinkLeafNode(string text)
            : base(AstLeafType.CloseLink, text) { }

        public CloseLinkLeafNode(string text, SourcePosition position)
        : base(AstLeafType.CloseLink, text, position) { }
        
        public CloseLinkLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.CloseLink, text, parent) { }

        public CloseLinkLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.CloseLink, text, position, parent) { }

        public CloseLinkLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.CloseLink, text, parent, position) { }


        public CloseLinkLeafNode(string text, string trivia)
        : base(AstLeafType.CloseLink, text, trivia) { }

        public CloseLinkLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.CloseLink, text, trivia, position) { }

        public CloseLinkLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.CloseLink, text, trivia, parent) { }

        public CloseLinkLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.CloseLink, text, trivia, position, parent) { }

        public CloseLinkLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.CloseLink, text, trivia, parent, position) { }
    }
}
