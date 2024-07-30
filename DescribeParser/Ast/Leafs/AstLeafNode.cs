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
        /// Gets the leading trivia associated with the leaf node.
        /// </summary>
        public string? LeadingTrivia
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the trailing trivia associated with the leaf node.
        /// </summary>
        public string? TrailingTrivia
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
                if (LeadingTrivia == null && TrailingTrivia == null) return false;
                return true;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="AstLeafNode"/> has leading trivia.
        /// </summary>
        public bool HasLeadingTrivia
        {
            get
            {
                return LeadingTrivia == null ;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="AstLeafNode"/> has trailing trivia.
        /// </summary>
        public bool HasTrailingTrivia
        {
            get
            {
                return TrailingTrivia == null;
            }
        }



        // IAstChildNode
        /// <summary>
        /// Gets the position of this leaf node within the source code.
        /// </summary>
        public SourcePosition Position 
        { 
            get; 
            set;
        }

        /// <summary>
        /// Gets the parent branch node of this leaf node.
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstLeafNode"/>.
        /// </summary>
        internal AstLeafNode()
        {
            Text = "";
            Position = null!;
        }



        // ToString()
        /// <summary>
        /// Returns a string representation of the <see cref="AstLeafNode"/>.
        /// </summary>
        /// <returns>A string representing the <see cref="AstLeafNode"/>.</returns>
        public override string ToString()
        {
            string s = "AstLeafNode/";
            s += LeafType.ToString() + " : ";
            if (!string.IsNullOrEmpty(LeadingTrivia))
                s += "\"" + replaceWhitespaceE(LeadingTrivia) + "\" ";

            s += " \"" + replaceWhitespaceE(Text) + "\" ";

            if (!string.IsNullOrEmpty(TrailingTrivia)) 
                s += " \"" + replaceWhitespaceE(TrailingTrivia) + "\"";

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
                leafType = LeafType.ToString(),
                text = Text,
                leadingTrivia = LeadingTrivia,
                trailingTrivia = TrailingTrivia,
            };

            string s = JsonConvert.SerializeObject(jsonObject);
            return s;
        }

        /// <summary>
        /// Converts the <see cref="AstLeafNode"/> back to source code.
        /// </summary>
        /// <returns>A string representing the code generated from the <see cref="AstLeafNode"/>.</returns>
        public override string ToCode()
        {
            string s = "";
            if (!string.IsNullOrEmpty(LeadingTrivia))
            {
                s += LeadingTrivia;
            }
            s += Text;
            if (!string.IsNullOrEmpty(TrailingTrivia))
            {
                s += TrailingTrivia;
            }
            return s;
        }
    }
}
