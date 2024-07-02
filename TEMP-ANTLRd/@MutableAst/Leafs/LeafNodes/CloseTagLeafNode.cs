using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class CloseTagLeafNode : AstLeafNode
    {
        public CloseTagLeafNode(string text)
            : base(AstLeafType.CloseTag, text) { }

        public CloseTagLeafNode(string text, SourcePosition position)
        : base(AstLeafType.CloseTag, text, position) { }
        
        public CloseTagLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.CloseTag, text, parent) { }

        public CloseTagLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.CloseTag, text, position, parent) { }

        public CloseTagLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.CloseTag, text, parent, position) { }


        public CloseTagLeafNode(string text, string trivia)
        : base(AstLeafType.CloseTag, text, trivia) { }

        public CloseTagLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.CloseTag, text, trivia, position) { }

        public CloseTagLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.CloseTag, text, trivia, parent) { }

        public CloseTagLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.CloseTag, text, trivia, position, parent) { }

        public CloseTagLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.CloseTag, text, trivia, parent, position) { }
    }
}
