using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public interface IAstBranchNode
    {
        public List<AstLeafNode> Leafs { get; }
        public List<object> Children { get; }
    }
    public interface IAstBranchNode<T>
    {
        public List<AstLeafNode> Leafs { get; }
        public List<T> Children { get; }
    }
}
