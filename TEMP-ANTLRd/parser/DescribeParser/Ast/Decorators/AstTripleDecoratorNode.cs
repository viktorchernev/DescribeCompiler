using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DescribeParser.Ast
{
    public class AstTripleDecoratorNode : AstDecoratorNode
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
        public AstTextNode Category
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
        public AstTextNode Name
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
        public AstTextNode Value
        {
            get
            {
                return Chunks[3];
            }
            set
            {
                Chunks[3] = value;
            }
        }
        public AstTextNode CloseBracket
        {
            get
            {
                return Chunks[4];
            }
            set
            {
                Chunks[4] = value;
            }
        }


        public AstTripleDecoratorNode(AstTextNode open, AstTextNode category, 
            AstTextNode name, AstTextNode value, AstTextNode close) 
        {
            initialize(open, category, name, value, close);
        }

        public AstTripleDecoratorNode(AstTextNode open, AstTextNode category, 
            AstTextNode name, AstTextNode value, AstTextNode close, 
            AstSourcePosition position)
            : base(position)
        {
            initialize(open, category, name, value, close);
        }

        public AstTripleDecoratorNode(AstTextNode open, AstTextNode category, 
            AstTextNode name, AstTextNode value, AstTextNode close, 
            AstNode parent)
            : base(parent)
        {
            initialize(open, category, name, value, close);
        }

        public AstTripleDecoratorNode(AstTextNode open, AstTextNode category, 
            AstTextNode name, AstTextNode value, AstTextNode close, 
            AstSourcePosition position, AstNode parent)
            : base(position, parent)
        {
            initialize(open, category, name, value, close);
        }

        public AstTripleDecoratorNode(AstTextNode open, AstTextNode category, 
            AstTextNode name, AstTextNode value, AstTextNode close, 
            AstNode parent, AstSourcePosition position)
            : base(parent, position)
        {
            initialize(open, category, name, value, close);
        }

        void initialize(AstTextNode open, AstTextNode category, AstTextNode name, 
            AstTextNode value, AstTextNode close)
        {
            OpenBracket = open;
            Category = category;
            Name = name;
            Value = value;
            CloseBracket = close;
        }



        public override string ToCode()
        {
            string s = string.Join("", Chunks);
            return s;
        }
    }
}
