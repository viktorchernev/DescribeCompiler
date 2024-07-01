using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstExpressionNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Vars
        public AstItemNode TitleItem
        {
            get;
            set;
        }
        public AstLeafNode ProductionArrow
        {
            get; 
            set; 
        }
        public List<AstExpressionLine> Lines
        { 
            get; 
            set; 
        }

        // Properties

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


        // Ctors


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
