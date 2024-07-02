using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public enum AstSimpleDecoratorType
    {
        BoldDecorator,
        ItalicDecorator,
        StrikedDecorator,
        UnderlineDecorator,

        CommentDecorator,
        NlCommentDecorator,
    }
}
