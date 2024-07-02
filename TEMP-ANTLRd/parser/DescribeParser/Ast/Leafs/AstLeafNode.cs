using Newtonsoft.Json;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a leaf node in an abstract syntax tree (AST).
    /// </summary>
    public class AstLeafNode : AstNode, IAstChildNode
    {
        // Vars
        /// <summary>
        /// Gets the type of the leaf node.
        /// </summary>
        public AstLeafType LeafType
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the text associated with the leaf node.
        /// </summary>
        public string Text
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the additional trivia associated with the leaf node.
        /// </summary>
        public string? Trivia
        {
            get;
            internal set;
        }



        // Properties
        /// <summary>
        /// Gets a value indicating whether the <see cref="AstLeafNode"/> has additional trivia.
        /// </summary>
        public bool HasTrivia
        {
            get
            {
                return Trivia != null;
            }
        }



        // IAstChildNode
        /// <summary>
        /// Gets the position of this leaf node within the source code.
        /// </summary>
        public SourcePosition? Position 
        { 
            get; 
            internal set;
        }

        /// <summary>
        /// Gets the parent branch node of this leaf node.
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            internal set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstLeafNode"/>.
        /// </summary>
        internal AstLeafNode()
        {
            Text = "";
        }



        // ToString()
        /// <summary>
        /// Returns a string representation of the <see cref="AstLeafNode"/>.
        /// </summary>
        /// <returns>A string representing the <see cref="AstLeafNode"/>.</returns>
        public override string ToString()
        {
            string s = "(AstLeafNode / ";
            s += LeafType.ToString() + " : ";
            s += "\"" + Text + "\"";
            if (!string.IsNullOrEmpty(Trivia))
            {
                s += ", \"" + Trivia + "\"";
            }
            s += ")";

            return s;
        }

        /// <summary>
        /// Converts the <see cref="AstLeafNode"/> to a JSON string.
        /// </summary>
        /// <returns>A JSON string representing the <see cref="AstLeafNode"/>.</returns>
        public override string ToJson()
        {
            var jsonObject = new
            {
                leafType = LeafType,
                text = Text,
                trivia = Trivia
            };

            return JsonConvert.SerializeObject(jsonObject);
        }

        /// <summary>
        /// Converts the <see cref="AstLeafNode"/> back to source code.
        /// </summary>
        /// <returns>A string representing the code generated from the <see cref="AstLeafNode"/>.</returns>
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
