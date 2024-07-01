using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstExpressionLine
    {
        public AstNode Body
        {
            get;
            private set;
        }
        public AstLeafNode Punctuation
        {
            get; 
            set;
        }

        public AstExpressionLine(AstItemNode item, AstLeafNode punctuation)
        {
            Body = item;
            Punctuation = punctuation;
        }
        public AstExpressionLine(AstExpressionNode expression, AstLeafNode punctuation = null)
        {
            Body = expression;
            Punctuation = punctuation;
        }
    }
}
