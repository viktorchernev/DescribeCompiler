using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class CloseDecoratorLeafNode : AstLeafNode
    {
        public CloseDecoratorLeafNode(string text)
            : base(AstLeafType.CloseDecorator, text) { }

        public CloseDecoratorLeafNode(string text, SourcePosition position)
        : base(AstLeafType.CloseDecorator, text, position) { }
        
        public CloseDecoratorLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.CloseDecorator, text, parent) { }

        public CloseDecoratorLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.CloseDecorator, text, position, parent) { }

        public CloseDecoratorLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.CloseDecorator, text, parent, position) { }


        public CloseDecoratorLeafNode(string text, string trivia)
        : base(AstLeafType.CloseDecorator, text, trivia) { }

        public CloseDecoratorLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.CloseDecorator, text, trivia, position) { }

        public CloseDecoratorLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.CloseDecorator, text, trivia, parent) { }

        public CloseDecoratorLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.CloseDecorator, text, trivia, position, parent) { }

        public CloseDecoratorLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.CloseDecorator, text, trivia, parent, position) { }
    }
}
