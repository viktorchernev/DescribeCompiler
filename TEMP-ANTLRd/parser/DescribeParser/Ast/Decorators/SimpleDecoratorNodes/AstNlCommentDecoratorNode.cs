using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstNlCommentDecoratorNode : AstSimpleDecoratorNode
    {
        public AstNlCommentDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close)
            : base(open, name, close) { }
    }
}