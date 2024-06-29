using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast.Decorators
{
    public class AstBgColorDecoratorNode : AstDoubleDecoratorNode 
    {
        public AstBgColorDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode value, AstTextNode close)
            : base(open, name, value, close) { }
    }
}
