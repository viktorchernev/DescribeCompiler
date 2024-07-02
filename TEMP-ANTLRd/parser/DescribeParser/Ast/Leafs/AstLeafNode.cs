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
        public AstLeafType LeafType
        {
            get;
            internal set;
        }
        public string Text
        {
            get;
            internal set;
        }
        public string? Trivia
        {
            get;
            internal set;
        }


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


        // Internal Ctor - to prevent external instantiation
        internal AstLeafNode()
        {
            Text = "";
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
