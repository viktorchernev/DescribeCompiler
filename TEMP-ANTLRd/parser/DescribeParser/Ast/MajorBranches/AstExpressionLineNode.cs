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
    public class AstExpressionLineNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Vars
        /// <summary>
        /// The Item Node or Expression Node representing the Body symbol 
        /// of the Expression line object
        /// </summary>
        public IAstBranchNode? Body
        {
            get;
            internal set;
        }

        /// <summary>
        /// The Leaf Node representing the punctuation symbol of the Expression line object
        /// </summary>
        public AstLeafNode? Punctuation
        {
            get; 
            internal set;
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
        public SourcePosition? Position
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
        { }



        // ToString()
        /// <summary>
        /// Get a string representation of the Expression Line object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "ExpressionLine : " + Environment.NewLine;
            s += Body?.ToString() + Environment.NewLine;
            s += Punctuation?.ToString() + Environment.NewLine;

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Expression Line object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            var jsonObject = new
            {
                body = Body?.ToJson(),
                punctuation = Punctuation?.ToJson(),
            };

            return JsonConvert.SerializeObject(jsonObject);
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
