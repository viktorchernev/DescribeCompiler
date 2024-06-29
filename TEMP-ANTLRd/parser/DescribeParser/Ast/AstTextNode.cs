using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstTextNode : AstNode
    {
        public string Text;

        public AstTextNode(string text)
        {
            Text = text;
        }
        public AstTextNode(string text, AstSourcePosition position) 
            : base(position)
        {
            Text = text;
        }
        public AstTextNode(string text, AstNode parent)
            : base(parent)
        {
            Text = text;
        }
        public AstTextNode(string text, AstSourcePosition position, AstNode parent)
            : base(position, parent)
        {
            Text = text;
        }
        public AstTextNode(string text, AstNode parent, AstSourcePosition position)
            : base(parent, position)
        {
            Text = text;
        }


        public override string ToString()
        {
            return "Not implemented yet";
        }
        public override string ToJson()
        {
            return "Not implemented yet";
        }
        public override string ToCode()
        {
            return "Not implemented yet";
        }
    }
}
