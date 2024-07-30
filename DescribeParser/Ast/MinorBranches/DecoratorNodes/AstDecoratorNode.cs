using Newtonsoft.Json;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a decorator node in the abstract syntax tree (AST).
    /// </summary>
    public abstract class AstDecoratorNode : AstNode, IAstBranchChildNode
    {
        // IAstBranchNode
        /// <summary>
        /// Get or Set the Leaf Nodes that make the Decorator object
        /// </summary>
        public abstract List<AstLeafNode> Leafs
        {
            get;
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Decorator object, as objects
        /// </summary>
        public abstract List<object> Children
        {
            get;
        }


        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Decorator object
        /// </summary>
        public SourcePosition Position
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Parent of this Decorator object
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
            Position = null!;
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Decorator object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Leafs.Count - 1; i++)
            {
                s += "\"" + replaceWhitespaceE(Leafs[i].ToCode()) + "\" ";
            }
            if (Leafs.Count > 0)
            {
                s += " \"" + replaceWhitespaceE(Leafs[Leafs.Count - 1].ToCode()) + "\"";
            }

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Decorator object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            // Leafs
            List<object?>? ls = null;
            if (Leafs != null)
            {
                ls = new List<object?>();
                foreach (var leaf in Leafs)
                {
                    string? jsonLeaf = leaf.ToJson();
                    if (jsonLeaf != null)
                    {
                        ls.Add(JsonConvert.DeserializeObject(jsonLeaf));
                    }
                    else ls.Add(null);
                }
            }

            // Json object
            var jsonObject = new
            {
                Leafs = ls
            };

            // Json string
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
