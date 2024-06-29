using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast.Decorators
{
    public class AstItalicDecoratorNode : AstSimpleDecoratorNode 
    {
        public AstItalicDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close)
            : base(open, name, close) { }
    }
}
