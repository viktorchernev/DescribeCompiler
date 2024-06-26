using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.AST
{
    public class DescribeItemNode
    {
        public List<DescribeToken> DataTokens
        {
            get;
            private set;
        }

        public Exception Exception
        {
            get;
            private set;
        }
    }
}
