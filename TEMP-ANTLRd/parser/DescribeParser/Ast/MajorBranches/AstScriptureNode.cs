using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstScriptureNode : AstNode, IAstBranchNode
    {
        // Vars
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
        public List<AstExpressionNode> Expressions
        {
            get;
            set;
        }
        public Exception Exception
        {
            get;
            private set;
        }

        // Properties
        public AstExpressionNode this[int index]
        {
            get
            {
                // You can include additional bounds-checking logic here
                if (index < 0 || index >= Expressions.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return Expressions[index] as AstExpressionNode;
            }
        }
        public bool IsMultyExpression
        {
            get
            {
                return Expressions.Count > 1;
            }
        }
        public int ExpressionCount
        {
            get
            {
                return Expressions.Count;
            }
        }
        public bool HasException
        {
            get
            {
                return Exception != null;
            }
        }

        // IAstBranchNode
        public List<object> Children
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public List<AstLeafNode> Leafs
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        // Ctors



        // ToString()
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        public override string ToJson()
        {
            throw new NotImplementedException();
        }
        public override string ToCode()
        {
            throw new NotImplementedException();
        }
    }
}
