using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class TerminatorLeafNode : AstLeafNode
    {
        public TerminatorLeafNode(string text)
            : base(AstLeafType.Terminator, text) { }

        public TerminatorLeafNode(string text, SourcePosition position)
        : base(AstLeafType.Terminator, text, position) { }
        
        public TerminatorLeafNode(string text, IAstBranchNode parent)
        : base(AstLeafType.Terminator, text, parent) { }

        public TerminatorLeafNode(string text, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Terminator, text, position, parent) { }

        public TerminatorLeafNode(string text, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Terminator, text, parent, position) { }


        public TerminatorLeafNode(string text, string trivia)
        : base(AstLeafType.Terminator, text, trivia) { }

        public TerminatorLeafNode(string text, string trivia, SourcePosition position)
        : base(AstLeafType.Terminator, text, trivia, position) { }

        public TerminatorLeafNode(string text, string trivia, IAstBranchNode parent)
        : base(AstLeafType.Terminator, text, trivia, parent) { }

        public TerminatorLeafNode(string text, string trivia, SourcePosition position, IAstBranchNode parent)
        : base(AstLeafType.Terminator, text, trivia, position, parent) { }

        public TerminatorLeafNode(string text, string trivia, IAstBranchNode parent, SourcePosition position)
        : base(AstLeafType.Terminator, text, trivia, parent, position) { }
    }
}
