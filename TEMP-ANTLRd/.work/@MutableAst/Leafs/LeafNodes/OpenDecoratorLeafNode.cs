using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class OpenDecoratorLeafNode : AstLeafNode
    {
        public OpenDecoratorLeafNode(string text)
            : base(AstLeafType.OpenDecorator, text) { }

        public OpenDecoratorLeafNode(string text, SourcePosition position)
        : base(AstLeafType.OpenDecorator, text, position) { }
        
        public OpenDecoratorLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.OpenDecorator, text, parent) { }

        public OpenDecoratorLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.OpenDecorator, text, position, parent) { }

        public OpenDecoratorLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.OpenDecorator, text, parent, position) { }


        public OpenDecoratorLeafNode(string text, string trivia)
        : base(AstLeafType.OpenDecorator, text, trivia) { }

        public OpenDecoratorLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.OpenDecorator, text, trivia, position) { }

        public OpenDecoratorLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.OpenDecorator, text, trivia, parent) { }

        public OpenDecoratorLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.OpenDecorator, text, trivia, position, parent) { }

        public OpenDecoratorLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.OpenDecorator, text, trivia, parent, position) { }
    }
}
