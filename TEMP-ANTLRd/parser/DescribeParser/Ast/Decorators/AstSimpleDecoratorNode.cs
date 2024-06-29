using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstSimpleDecoratorNode : AstDecoratorNode
    {
        public AstTextNode OpenBracket 
        { 
            get
            {
                return Chunks[0];
            }
            set
            {
                Chunks[0] = value;
            }
        }
        public AstTextNode Name
        {
            get
            {
                return Chunks[1];
            }
            set
            {
                Chunks[1] = value;
            }
        }
        public AstTextNode CloseBracket
        {
            get
            {
                return Chunks[2];
            }
            set
            {
                Chunks[2] = value;
            }
        }


        public AstSimpleDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close) 
        {
            initialize(open, name, close);
        }
        public AstSimpleDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close, AstSourcePosition position)
            : base(position)
        {
            initialize(open, name, close);
        }
        public AstSimpleDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close, AstNode parent)
            : base(parent)
        {
            initialize(open, name, close);
        }
        public AstSimpleDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close, AstSourcePosition position, AstNode parent)
            : base(position, parent)
        {
            initialize(open, name, close);
        }
        public AstSimpleDecoratorNode(AstTextNode open, AstTextNode name, AstTextNode close, AstNode parent, AstSourcePosition position)
            : base(parent, position)
        {
            initialize(open, name, close);
        }
        void initialize(AstTextNode open, AstTextNode name, AstTextNode close)
        {
            OpenBracket = open;
            Name = name;
            CloseBracket = close;
        }



        public override string ToCode()
        {
            string s = string.Join("", Chunks);
            return s;
        }
    }
}
