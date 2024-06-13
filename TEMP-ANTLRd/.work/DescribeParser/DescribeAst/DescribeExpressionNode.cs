using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DescribeParser.AST
{
    public class DescribeExpressionNode : AstNode
    {
        private List<AstNode> _children;

        public RecognitionException Exception
        {
            get;
            set;
        }
        public new string Text
        {
            get
            {
                string text = "";
                for(int i = 0; i < _children.Count; i++)
                {
                    text += _children[i].Text;
                }
                return text;
            }
        }
        public new int Line
        {
            get
            {
                AstNode firstChild = _children[0];
                return firstChild.Line;
            }
        }
        public new int Start
        {
            get
            {
                AstNode firstChild = _children[0];
                return firstChild.Start;
            }
        }
        public new int End
        {
            get
            {
                AstNode lastChild = _children[_children.Count - 1];
                return lastChild.End;
            }
        }


        public DescribeExpressionNode(ParserRuleContext context)
        {
            Exception = context.exception;

            _children = new List<AstNode>();
            List<IParseTree> children = context.children.ToList();
            for (int i = 0; i < children.Count; i++)
            {
                if(children[i] is ITerminalNode)
                {
                    DescribeToken token = new DescribeToken((ITerminalNode)children[i]);
                    _children.Add(token);
                }
                else
                {
                    DescribeExpressionNode node = new DescribeExpressionNode((ParserRuleContext)children[i]);
                    _children.Add(node);
                }
            }
        }

        public List<AstNode> Children
        {
            get
            { 
                return _children; 
            }
        }
        public int Count
        {
            get 
            { 
                return _children.Count; 
            }
        }




        public override string ToString()
        {
            string msg = "Not implemented yet";
            return msg;
        }


        static string GetTokenType(int tokenType)
        {
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        static string ReplaceWhitespaceE(string text)
        {
            return text.Replace(Environment.NewLine, "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
    }
}
