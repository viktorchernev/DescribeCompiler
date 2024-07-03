using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Expression object 
    /// </summary>
    public class AstExpressionNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Vars
        /// <summary>
        /// The Leaf Node representing the title symbol of the Expression object
        /// </summary>
        public AstItemNode TitleItem
        {
            get;
            internal set;
        }

        /// <summary>
        /// The Leaf Node representing the production arrow symbol of the Expression object
        /// </summary>
        public AstLeafNode ProductionArrow
        {
            get;
            internal set; 
        }

        /// <summary>
        /// The List representing the Expression Line objects of this Scripture object
        /// </summary>
        public List<AstExpressionLineNode> Lines
        { 
            get; 
            internal set; 
        }



        // Properties
        /// <summary>
        /// Gets the <see cref="AstExpressionLineNode"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the expression to get.</param>
        /// <returns>The <see cref="AstExpressionLineNode"/> at the specified index.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than or equal to the number of expressions.</exception>
        public AstExpressionLineNode this[int index]
        {
            get
            {
                // You can include additional bounds-checking logic here
                if (index < 0 || index >= Lines.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return Lines[index];
            }
        }

        /// <summary>
        /// Wether this Expression object has multiple Expression lines or not
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                if (Lines.Count != 1) return false;
                if (Lines[0].HasBody == false) return true;
                return false;
            }
        }

        /// <summary>
        /// Wether this Expression object has multiple Expression lines or not
        /// </summary>
        public bool IsMultyLined
        {
            get
            {
                return Lines.Count > 1;
            }
        }

        /// <summary>
        /// Gets the Number of Lines in this Expression object
        /// </summary>
        public int LinesCount
        {
            get
            {
                return Lines.Count;
            }
        }



        // IAstBranchNode
        /// <summary>
        /// Gets all the direct descendant nodes of this Expression object
        /// </summary>
        public List<object> Children
        {
            get
            {
                List<object> result = new List<object>();
                result.Add(TitleItem);
                result.Add(ProductionArrow);
                result.AddRange(Lines);
                return result;
            }
        }

        /// <summary>
        /// Gets all the Leaf Nodes contained in this Expression object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get
            {
                List<AstLeafNode> li = new List<AstLeafNode>();
                li.AddRange(TitleItem.Leafs);
                li.Add(ProductionArrow);
                for (int i = 0; i < Lines.Count; i++)
                {
                    li.AddRange(Lines[i].Leafs);
                }
                return li;
            }
        }



        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Expression object
        /// </summary>
        public SourcePosition? Position
        {
            get;
            internal set;
        }

        /// <summary>
        /// Get the Parent of this Expression object
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            internal set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstExpressionNode"/>.
        /// </summary>
        internal AstExpressionNode()
        { }



        // ToString()
        /// <summary>
        /// Get a string representation of the Expression object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "Expression : " + Environment.NewLine;
            s += TitleItem.ToString() + Environment.NewLine;
            s += ProductionArrow.ToString() + Environment.NewLine;
            for (int i = 0; i < Lines.Count; i++)
            {
                if (Lines[i] != null) s += Lines[i].ToString() + Environment.NewLine;
            }

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Expression object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            var jsonObject = new
            {
                title = TitleItem?.ToJson(),
                arrow = ProductionArrow?.ToJson(),
                lines = Lines?.Select(line => JsonConvert.DeserializeObject(line.ToJson())).ToList(),
            };

            return JsonConvert.SerializeObject(jsonObject);
        }

        /// <summary>
        /// Get a source code string representation of the Expression object
        /// </summary>
        public override string ToCode()
        {
            string s = "";

            s += TitleItem.ToCode();
            s += ProductionArrow.ToCode();
            for (int i = 0; i < Lines.Count; i++)
            {
                s += Lines[i].ToCode();
            }
            return s;
        }
    }
}
