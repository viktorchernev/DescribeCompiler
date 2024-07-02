using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstExpressionLineNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Vars
        public IAstBranchNode? Body
        {
            get;
            internal set;
        }
        public AstLeafNode Punctuation
        {
            get; 
            internal set;
        }

        // Properties
        public bool HasBody
        {
            get 
            { 
                return Body != null; 
            }
        }
        public bool HasPunctuation
        {
            get
            {
                return Punctuation != null;
            }
        }

        // IAstBranchNode
        public List<AstLeafNode> Leafs
        {
            get;
            set;
        }
        public List<object> Children
        {
            get;
            set;
        }

        // IAstChildNode
        public SourcePosition? Position
        {
            get;
            set;
        }
        public IAstBranchNode? Parent
        {
            get;
            set;
        }



        // Internal Ctor - to prevent external instantiation
        internal AstExpressionLineNode()
        { }



        // ToString()
        public override string ToCode()
        {
            throw new NotImplementedException();
        }
        public override string ToJson()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
