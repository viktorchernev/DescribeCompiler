using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstLeafNode : AstNode
    {
        public string Text;
        public string? Trivia;

        public AstLeafNode(string text)
        {
            Text = text;
        }
        public AstLeafNode(string text, SourcePosition position) 
            : base(position)
        {
            Text = text;
        }
        public AstLeafNode(string text, AstBranchNode parent)
            : base(parent)
        {
            Text = text;
        }
        public AstLeafNode(string text, SourcePosition position, AstBranchNode parent)
            : base(position, parent)
        {
            Text = text;
        }
        public AstLeafNode(string text, AstBranchNode parent, SourcePosition position)
            : base(parent, position)
        {
            Text = text;
        }
        public AstLeafNode(string text, string trivia)
        {
            Text = text;
            Trivia = trivia;
        }
        public AstLeafNode(string text, string trivia, SourcePosition position)
            : base(position)
        {
            Text = text;
            Trivia = trivia;
        }
        public AstLeafNode(string text, string trivia, AstBranchNode parent)
            : base(parent)
        {
            Text = text;
            Trivia = trivia;
        }
        public AstLeafNode(string text, string trivia, SourcePosition position, AstBranchNode parent)
            : base(position, parent)
        {
            Text = text;
            Trivia = trivia;
        }
        public AstLeafNode(string text, string trivia, AstBranchNode parent, SourcePosition position)
            : base(parent, position)
        {
            Text = text;
            Trivia = trivia;
        }



        public override string ToString()
        {
            string s = "(TEXT : \"" + Text + "\"";
            if (!string.IsNullOrEmpty(Trivia))
            {
                s += ", \"" + Trivia + "\"";
            }
            s += ")";

            return s;
        }
        public override string ToJson()
        {
            var jsonObject = new
            {
                text = this.Text,
                trivia = this.Trivia
            };

            return JsonConvert.SerializeObject(jsonObject);
        }
        public override string ToCode()
        {
            string s = Text;
            if (!string.IsNullOrEmpty(Trivia))
            {
                s += Trivia;
            }
            return s;
        }
    }
}
