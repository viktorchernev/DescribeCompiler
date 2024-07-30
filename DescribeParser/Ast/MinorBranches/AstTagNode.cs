using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Tag object 
    /// </summary>
    public class AstTagNode : AstNode, IAstBranchChildNode
    {
        // Values
        private AstLeafNode _open;
        private AstLeafNode _id;
        private AstLeafNode _close;

        /// <summary>
        /// The Leaf Node representing the open bracket of the Tag object.
        /// </summary>
        public AstLeafNode OpenBracket
        {
            get
            {
                return _open;
            }
            internal set
            {
                _open = value;
                if (_open != null) _open.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the id of the Tag object
        /// </summary>
        public AstLeafNode Id
        {
            get
            {
                return _id;
            }
            internal set
            {
                _id = value;
                if (_id != null) _id.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Tag object
        /// </summary>
        public AstLeafNode CloseBracket
        {
            get
            {
                return _close;
            }
            internal set
            {
                _close = value;
                if (_close != null) _close.Parent = this;
            }
        }



        // IAstBranchNode
        /// <summary>
        /// Get the Leaf Nodes that make the Tag object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get
            {
                return new List<AstLeafNode>() { OpenBracket, Id, CloseBracket };
            }
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Tag object, as objects
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
        public SourcePosition Position
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
        {
            Position = null!;
            _open = null!;
            _id = null!;
            _close = null!;
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Tag object for logging purposes
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
        /// Get a JSON string representation of the Tag object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            // OpenBracket
            string? jo = OpenBracket?.ToJson();
            object? o = null;
            if (jo != null) o = JsonConvert.DeserializeObject(jo);

            // Id
            string? jd = Id?.ToJson();
            object? d = null;
            if (jd != null) d = JsonConvert.DeserializeObject(jd);

            // CloseBracket
            string? jc = CloseBracket?.ToJson();
            object? c = null;
            if (jc != null) c = JsonConvert.DeserializeObject(jc);

            // Json object
            var jsonObject = new
            {
                openBracket = o,
                id = d,
                closeBracket = c
            };

            // Json string
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
