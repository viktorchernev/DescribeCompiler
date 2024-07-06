using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstTextLeafNode : AstLeafNode
    {
        public AstTextLeafNode(string text)
            : base(AstLeafType.Text, text) { }

        public AstTextLeafNode(string text, SourcePosition position)
        : base(AstLeafType.Text, text, position) { }
        
        public AstTextLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.Text, text, parent) { }

        public AstTextLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Text, text, position, parent) { }

        public AstTextLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Text, text, parent, position) { }


        public AstTextLeafNode(string text, string trivia)
        : base(AstLeafType.Text, text, trivia) { }

        public AstTextLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.Text, text, trivia, position) { }

        public AstTextLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.Text, text, trivia, parent) { }

        public AstTextLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Text, text, trivia, position, parent) { }

        public AstTextLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Text, text, trivia, parent, position) { }
    }
}
