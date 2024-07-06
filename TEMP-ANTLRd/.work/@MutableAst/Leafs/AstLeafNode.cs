using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstLeafNode : AstNode, IAstChildNode
    {
        // Vars
        public AstLeafType LeafType;
        public string Text;
        public string? Trivia;

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
        public AstLeafNode(AstLeafType leaftype, string text)
        {
            LeafType = leaftype;
            Text = text;
            Position = null;
            Parent = null;
        }
        public AstLeafNode(AstLeafType leaftype, string text, SourcePosition position) 
        {
            LeafType = leaftype;
            Text = text;
            Position = position;
            Parent = null;
        }
        public AstLeafNode(AstLeafType leaftype, string text, IAstBranchNode parent)
        {
            LeafType = leaftype;
            Text = text;
            Position = null;
            Parent = parent;
        }
        public AstLeafNode(AstLeafType leaftype, string text, SourcePosition position, IAstBranchNode parent)
        {
            LeafType = leaftype;
            Text = text;
            Position = position;
            Parent = parent;
        }
        public AstLeafNode(AstLeafType leaftype, string text, IAstBranchNode parent, SourcePosition position)
        {
            LeafType = leaftype;
            Text = text;
            Position = position;
            Parent = parent;
        }
        public AstLeafNode(AstLeafType leaftype, string text, string trivia)
        {
            LeafType = leaftype;
            Text = text;
            Trivia = trivia;
            Position = null;
            Parent = null;
        }
        public AstLeafNode(AstLeafType leaftype, string text, string trivia, SourcePosition position)
        {
            LeafType = leaftype;
            Text = text;
            Trivia = trivia;
            Position = position;
            Parent = null;
        }
        public AstLeafNode(AstLeafType leaftype, string text, string trivia, IAstBranchNode parent)
        {
            LeafType = leaftype;
            Text = text;
            Trivia = trivia;
            Position = null;
            Parent = parent;
        }
        public AstLeafNode(AstLeafType leaftype, string text, string trivia, SourcePosition position, IAstBranchNode parent)
        {
            LeafType = leaftype;
            Text = text;
            Trivia = trivia;
            Position = position;
            Parent = parent;
        }
        public AstLeafNode(AstLeafType leaftype, string text, string trivia, IAstBranchNode parent, SourcePosition position)
        {
            LeafType = leaftype;
            Text = text;
            Trivia = trivia;
            Position = position;
            Parent = parent;
        }


        // ToString()
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
