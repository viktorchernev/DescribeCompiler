﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstBoldDecoratorNode : AstSimpleDecoratorNode 
    {
        public AstBoldDecoratorNode(AstTokenNode open, AstTokenNode name, AstTokenNode close)
            : base(open, name, close) { }

        public AstBoldDecoratorNode(AstTokenNode open, AstTokenNode name, AstTokenNode close, AstMinorBranchNode parent)
            : base(open, name, close, parent) { }

        public override string ToString()
        {
            string s = "(BoldDecorator : ";
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
