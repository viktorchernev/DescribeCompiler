using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstScriptureNode : AstMinorBranchNode
    {
        public bool IsMultyExpression
        {
            get
            {
                return Chunks.Count > 1;
            }
        }
        public int ExpressionCount
        {
            get
            {
                return Chunks.Count;
            }
        }


        public Exception Exception
        {
            get;
            private set;
        }
        public bool HasException
        {
            get
            {
                return Exception != null;
            }
        }


        public string FileName
        {
            get;
            private set;
        }
        public string Namespace
        {
            get;
            private set;
        }


        public AstExpressionNode this[int index]
        {
            get
            {
                // You can include additional bounds-checking logic here
                if (index < 0 || index >= Chunks.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return Chunks[index] as AstExpressionNode;
            }
        }
    }
}
