using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class SeparatorLeafNode : AstLeafNode
    {
        public SeparatorLeafNode(string text)
            : base(AstLeafType.Separator, text) { }

        public SeparatorLeafNode(string text, SourcePosition position)
        : base(AstLeafType.Separator, text, position) { }
        
        public SeparatorLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.Separator, text, parent) { }

        public SeparatorLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Separator, text, position, parent) { }

        public SeparatorLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Separator, text, parent, position) { }


        public SeparatorLeafNode(string text, string trivia)
        : base(AstLeafType.Separator, text, trivia) { }

        public SeparatorLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.Separator, text, trivia, position) { }

        public SeparatorLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.Separator, text, trivia, parent) { }

        public SeparatorLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Separator, text, trivia, position, parent) { }

        public SeparatorLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Separator, text, trivia, parent, position) { }
    }
}
