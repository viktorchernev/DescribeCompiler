using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class OpenLinkLeafNode : AstLeafNode
    {
        public OpenLinkLeafNode(string text)
            : base(AstLeafType.OpenLink, text) { }

        public OpenLinkLeafNode(string text, SourcePosition position)
        : base(AstLeafType.OpenLink, text, position) { }
        
        public OpenLinkLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.OpenLink, text, parent) { }

        public OpenLinkLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.OpenLink, text, position, parent) { }

        public OpenLinkLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.OpenLink, text, parent, position) { }


        public OpenLinkLeafNode(string text, string trivia)
        : base(AstLeafType.OpenLink, text, trivia) { }

        public OpenLinkLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.OpenLink, text, trivia, position) { }

        public OpenLinkLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.OpenLink, text, trivia, parent) { }

        public OpenLinkLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.OpenLink, text, trivia, position, parent) { }

        public OpenLinkLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.OpenLink, text, trivia, parent, position) { }
    }
}
