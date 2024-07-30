using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Expression Line object 
    /// </summary>
    public class AstExpressionLineNode : AstNode, IAstBranchChildNode
    {
        // Vars
        private IAstBranchChildNode? _body;
        private AstLeafNode? _punctuation;

        /// <summary>
        /// The Item Node or Expression Node representing the Body symbol 
        /// of the Expression line object
        /// </summary>
        public IAstBranchChildNode? Body
        {
            get
            {
                return _body;
            }
            internal set
            {
                _body = value;
                if (_body != null) _body.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the punctuation symbol of the Expression line object
        /// </summary>
        public AstLeafNode? Punctuation
        {
            get
            {
                return _punctuation;
            }
            internal set
            {
                _punctuation = value;
                if (_punctuation != null) _punctuation.Parent = this;
            }
        }



        // Properties
        /// <summary>
        /// Wether this Expression line object has Body
        /// </summary>
        public bool HasBody
        {
            get 
            { 
                return Body != null; 
            }
        }

        /// <summary>
        /// Wether this Expression line object has Punctuation
        /// </summary>
        public bool HasPunctuation
        {
            get
            {
                return Punctuation != null;
            }
        }



        // IAstBranchNode
        /// <summary>
        /// Gets all the direct descendant nodes of this Expression Line object
        /// </summary>
        public List<object> Children
        {
            get
            {
                List<object> result = new List<object>();
                if (Body != null) result.Add(Body);
                if (Punctuation != null) result.Add(Punctuation);
                return result;
            }
        }

        /// <summary>
        /// Gets all the Leaf Nodes contained in this Expression Line object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get
            {
                List<AstLeafNode> li = new List<AstLeafNode>();
                if (Body != null) li.AddRange(Body.Leafs);
                if (Punctuation != null) li.Add(Punctuation);
                return li;
            }
        }



        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Expression Line object
        /// </summary>
        public SourcePosition Position
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Parent of this Expression Line object
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstExpressionLineNode"/>.
        /// </summary>
        internal AstExpressionLineNode()
        {
            Position = null!;
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Expression Line object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string indent = "    ";
            string s = "ExpressionLine : " + Environment.NewLine + Environment.NewLine;

            if (Body != null)
            {
                string body = Environment.NewLine + Body.ToString();
                body = body.Replace(Environment.NewLine, Environment.NewLine + indent + indent);
                s += indent + "body - " + body.TrimStart() + Environment.NewLine;
            }
            else s += indent + "body - NULL" + Environment.NewLine;

            if (Punctuation != null) s += indent + "punctuation - " + Punctuation.ToString() + Environment.NewLine;
            else s += indent + "punctuation - NULL" + Environment.NewLine;

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Expression Line object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            // Body
            string? jb = Body?.ToJson();
            object? b = null;
            if (jb != null) b = JsonConvert.DeserializeObject(jb);

            // Punctuation
            string? jp = Punctuation?.ToJson();
            object? p = null;
            if (jp != null) p = JsonConvert.DeserializeObject(jp);

            // Json object
            var jsonObject = new
            {
                body = b,
                punctuation = p
            };

            // Json string
            string s = JsonConvert.SerializeObject(jsonObject);
            return s;
        }

        /// <summary>
        /// Get a source code string representation of the Expression Line object
        /// </summary>
        public override string ToCode()
        {
            string s = "";
            if (Body != null)
            {
                s += Body?.ToCode();
            }
            s += Punctuation?.ToCode();
            return s;
        }
    }
}
