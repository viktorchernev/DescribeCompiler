using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast.Decorators
{
    public class AstUnderlineDecoratorNode : AstSimpleDecoratorNode 
    {
        public AstUnderlineDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close)
            : base(open, name, close) { }
    }
}
