using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class ProductionArrowLeafNode : AstLeafNode
    {
        public ProductionArrowLeafNode(string text)
            : base(AstLeafType.ProductionArrow, text) { }

        public ProductionArrowLeafNode(string text, SourcePosition position)
        : base(AstLeafType.ProductionArrow, text, position) { }
        
        public ProductionArrowLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.ProductionArrow, text, parent) { }

        public ProductionArrowLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.ProductionArrow, text, position, parent) { }

        public ProductionArrowLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.ProductionArrow, text, parent, position) { }


        public ProductionArrowLeafNode(string text, string trivia)
        : base(AstLeafType.ProductionArrow, text, trivia) { }

        public ProductionArrowLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.ProductionArrow, text, trivia, position) { }

        public ProductionArrowLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.ProductionArrow, text, trivia, parent) { }

        public ProductionArrowLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.ProductionArrow, text, trivia, position, parent) { }

        public ProductionArrowLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.ProductionArrow, text, trivia, parent, position) { }
    }
}
