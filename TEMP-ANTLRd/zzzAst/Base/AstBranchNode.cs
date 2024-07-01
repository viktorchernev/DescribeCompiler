using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public abstract class AstBranchNode<T> : AstNode
    {
        public abstract List<T> Chunks
        {
            get;
            set;
        }
    }
}
