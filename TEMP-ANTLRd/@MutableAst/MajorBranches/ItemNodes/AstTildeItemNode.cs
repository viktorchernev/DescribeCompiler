using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstTildeItemNode : AstItemNode
    {
        // Ctors
        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text,
            IAstBranchNode parent = null)
                : base(tilde, text, parent){ }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag,
            IAstBranchNode parent = null)
                : base(tilde, text, tag, parent) { }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links,
            IAstBranchNode parent = null)
                : base(tilde, text, tag, links, parent) { }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, List<AstLinkNode> links, AstTagNode tag,
            IAstBranchNode parent = null)
                : base(tilde, text, links, tag, parent) { }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, List<AstDecoratorNode> decorators, List<AstLinkNode> links, AstTagNode tag,
            IAstBranchNode parent = null)
                : base(tilde, text, decorators, links, tag, parent) { }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, List<AstDecoratorNode> decorators, AstTagNode tag, List<AstLinkNode> links,
           IAstBranchNode parent = null)
                : base(tilde, text, decorators, tag, links, parent) { }


        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstDecoratorNode> decorators, List<AstLinkNode> links,
            IAstBranchNode parent = null)
                : base(tilde, text, tag, decorators, links, parent) { }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, List<AstLinkNode> links, List<AstDecoratorNode> decorators, AstTagNode tag,
            IAstBranchNode parent = null)
                : base(tilde, text, links, decorators, tag, parent) { }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
                : base(tilde, text, tag, links, decorators, parent) { }

        public AstTildeItemNode(AstLeafNode tilde, AstLeafNode text, List<AstLinkNode> links, AstTagNode tag, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
                : base(tilde, text, links, tag, decorators, parent) { }



        // ToString()
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
