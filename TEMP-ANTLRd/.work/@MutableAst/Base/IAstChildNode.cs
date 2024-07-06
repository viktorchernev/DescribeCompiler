using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public interface IAstChildNode
    {
        public SourcePosition? Position { get; set; }
        public IAstBranchNode? Parent { get; set; }
    }
}
