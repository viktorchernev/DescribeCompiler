using Antlr4.Runtime;
using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Visitors
{
    public interface IUnfoldVisitor
    {
        string Log
        {
            get;
        }

        bool DoScripture(DescribeUnfold u, ParserRuleContext context, string filename = "");
    }
}
