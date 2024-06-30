using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstNlCommentDecoratorNode : AstSimpleDecoratorNode
    {
        public AstNlCommentDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close)
            : base(open, name, close) { }
        public AstNlCommentDecoratorNode(AstLeafNode open, AstLeafNode name, AstLeafNode close, AstBranchNode parent)
            : base(open, name, close, parent) { }


        public override string ToString()
        {
            string s = "(NlCommentDecorator : ";
            for (int i = 0; i < Chunks.Count - 1; i++)
            {
                s += "\"" + Chunks[i].ToCode() + "\", ";
            }
            if (Chunks.Count > 0)
            {
                s += "\"" + Chunks[Chunks.Count - 1].ToCode() + "\"";
            }
            s += ")";

            return s;
        }
    }
}