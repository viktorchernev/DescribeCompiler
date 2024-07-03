using Newtonsoft.Json;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a decorator node in the abstract syntax tree (AST).
    /// </summary>
    public class AstDecoratorNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // IAstBranchNode
        /// <summary>
        /// Get or Set the Leaf Nodes that make the Link object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get;
            internal set;
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Link object as objects
        /// </summary>
        public List<object> Children
        {
            get
            {
                List<object> os = new List<object>();
                for (int i = 0; i < Leafs.Count; i++) os.Add(Leafs[i]);
                return os;
            }
        }


        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Link object
        /// </summary>
        public SourcePosition? Position
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Parent of this Link object
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstDecoratorNode"/>.
        /// </summary>
        internal AstDecoratorNode()
        {
            Leafs = new List<AstLeafNode>();
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Decorator object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "(Decorator : ";
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
        /// Get a JSON string representation of the Decorator object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            var jsonObject = new
            {
                Leafs = Leafs?.Select(leaf => leaf?.ToJson()).ToList()
            };

            return JsonConvert.SerializeObject(jsonObject);
        }

        /// <summary>
        /// Get a source code string representation of the Decorator object
        /// </summary>
        public override string ToCode()
        {
            string s = Leafs[0].ToCode();
            s += Leafs[1].ToCode();
            for (int i = 2; i < Leafs.Count - 1; i++)
            {
                s += "|" + Leafs[i].ToCode();
            }
            s += Leafs[Leafs.Count - 1].ToCode();
            return s;
        }
    }
}
