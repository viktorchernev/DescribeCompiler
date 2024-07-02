using Newtonsoft.Json;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Tag object 
    /// </summary>
    public class AstTagNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Values
        /// <summary>
        /// The Leaf Node representing the open bracket of the Tag object
        /// </summary>
        public AstLeafNode OpenBracket
        {
            get
            {
                return Leafs[0];
            }
            internal set
            {
                Leafs[0] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the id of the Tag object
        /// </summary>
        public AstLeafNode Id
        {
            get
            {
                return Leafs[1];
            }
            internal set
            {
                Leafs[1] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Tag object
        /// </summary>
        public AstLeafNode CloseBracket
        {
            get
            {
                return Leafs[2];
            }
            internal set
            {
                Leafs[2] = value;
            }
        }



        // IAstBranchNode
        /// <summary>
        /// Get or Set the Leaf Nodes that make the Tag object
        /// </summary>
        public List<AstLeafNode> Leafs
        { 
            get
            {
                return new List<AstLeafNode>() { OpenBracket, Id, CloseBracket };
            }
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Tag object as objects
        /// </summary>
        public List<object> Children
        {
            get
            {
                return new List<object>() { OpenBracket, Id, CloseBracket };
            }
        }



        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Tag object
        /// </summary>
        public SourcePosition? Position
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Parent of this Tag object
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstTagNode"/>.
        /// </summary>
        internal AstTagNode()
        { }



        // ToString()
        /// <summary>
        /// Get a string representation of the Tag object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "(Tag : ";
            for (int i = 0; i < Leafs.Count - 1; i++)
            {
                s += "\"" + Leafs[i].ToCode() + "\", ";
            }
            if (Leafs.Count > 0)
            {
                s += "\"" + Leafs[Leafs.Count - 1].ToCode() + "\"";
            }
            s += ")";

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Tag object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            var jsonObject = new
            {
                openBracket = JsonConvert.DeserializeObject(OpenBracket.ToJson()),
                id = JsonConvert.DeserializeObject(Id.ToJson()),
                closeBracket = JsonConvert.DeserializeObject(CloseBracket.ToJson())
            };

            return JsonConvert.SerializeObject(jsonObject);
        }

        /// <summary>
        /// Get a source code string representation of the Tag object
        /// </summary>
        public override string ToCode()
        {
            string s = OpenBracket.ToCode() + Id.ToCode() + CloseBracket.ToCode();
            return s;
        }
    }
}
