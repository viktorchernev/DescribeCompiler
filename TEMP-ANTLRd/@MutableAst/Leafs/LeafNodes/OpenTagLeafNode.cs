using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class OpenTagLeafNode : AstLeafNode
    {
        public OpenTagLeafNode(string text)
            : base(AstLeafType.OpenTag, text) { }

        public OpenTagLeafNode(string text, SourcePosition position)
        : base(AstLeafType.OpenTag, text, position) { }
        
        public OpenTagLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.OpenTag, text, parent) { }

        public OpenTagLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.OpenTag, text, position, parent) { }

        public OpenTagLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.OpenTag, text, parent, position) { }


        public OpenTagLeafNode(string text, string trivia)
        : base(AstLeafType.OpenTag, text, trivia) { }

        public OpenTagLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.OpenTag, text, trivia, position) { }

        public OpenTagLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.OpenTag, text, trivia, parent) { }

        public OpenTagLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.OpenTag, text, trivia, position, parent) { }

        public OpenTagLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.OpenTag, text, trivia, parent, position) { }
    }
}
