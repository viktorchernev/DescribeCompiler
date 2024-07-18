using Antlr4.Runtime;
using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Visitors
{
    public interface IUnfoldVisitorV2
    {
        string Log
        {
            get;
        }

        bool DoScripture(DescribeUnfoldV2 u, ParserRuleContext context, string filename = "");
    }
}
