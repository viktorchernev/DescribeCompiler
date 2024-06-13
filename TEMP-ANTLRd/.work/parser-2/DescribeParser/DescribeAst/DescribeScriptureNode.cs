using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.AST
{
    public class DescribeScriptureNode : AstNode
    {
        public DescribeVersion LanguageVersion
        {
            get;
            private set;
        }
        public List<AstNode> Expressions
        {
            get;
            set;
        }
        public List<DescribeToken> Tail
        {
            get;
            set;
        }
        public DescribeToken EOF
        { 
            get; 
            private set; 
        }
        public Exception Exception
        { 
            get; 
            private set; 
        }


        public int ExpressionCount
        {
            get
            {
                return Expressions.Count;
            }
        }
        public bool HasMultipleExpressions
        {
            get
            {
                return Expressions.Count > 1;
            }
        }
        public bool HasException
        {
            get
            {
                return Exception != null;
            }
        }
        public bool HasTail
        {
            get
            {
                return Tail != null;
            }
        }


        //.Ctor(ParserRuleContext)
		//.ToString()                 ->string
		//.ToCode()                   ->string
		//.ToTokenList()              ->List<DescribeToken>
    }
}
