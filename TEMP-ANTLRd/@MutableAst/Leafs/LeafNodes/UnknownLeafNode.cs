using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstUnknownLeafNode : AstLeafNode
    {
        public AstUnknownLeafNode(string text)
            : base(AstLeafType.Unknown, text) { }

        public AstUnknownLeafNode(string text, SourcePosition position)
        : base(AstLeafType.Unknown, text, position) { }
        
        public AstUnknownLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.Unknown, text, parent) { }

        public AstUnknownLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Unknown, text, position, parent) { }

        public AstUnknownLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Unknown, text, parent, position) { }


        public AstUnknownLeafNode(string text, string trivia)
        : base(AstLeafType.Unknown, text, trivia) { }

        public AstUnknownLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.Unknown, text, trivia, position) { }

        public AstUnknownLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.Unknown, text, trivia, parent) { }

        public AstUnknownLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Unknown, text, trivia, position, parent) { }

        public AstUnknownLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Unknown, text, trivia, parent, position) { }
    }
}
