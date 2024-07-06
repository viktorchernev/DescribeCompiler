using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstDecoratedItemNode : AstItemNode
    {
        public AstDecoratedItemNode(AstLeafNode text, List<AstDecoratorNode> decorators, IAstBranchNode parent = null)
            : base(text, decorators, parent) { }
    }
}
