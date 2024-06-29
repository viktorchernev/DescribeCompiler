using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast.Decorators
{
    public class AstCustomDoubleDecoratorNode : AstTripleDecoratorNode 
    {
        public AstCustomDoubleDecoratorNode(AstTextNode open, AstTextNode category, 
            AstTextNode name, AstTextNode value, AstTextNode close)
            : base(open, category, name, value, close) { }
    }
}