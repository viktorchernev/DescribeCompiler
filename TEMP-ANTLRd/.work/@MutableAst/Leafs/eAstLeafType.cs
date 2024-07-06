using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public enum AstLeafType
    {
        Unknown,
        Text,

        ProductionArrow,
        Separator,
        Terminator,

        OpenTag,
        CloseTag,
        OpenLink,
        CloseLink,
        OpenDecorator,
        CloseDecorator,
    }
}
