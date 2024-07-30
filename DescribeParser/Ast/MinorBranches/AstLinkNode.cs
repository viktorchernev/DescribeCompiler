using Newtonsoft.Json;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Link object.
    /// </summary>
    public class AstLinkNode : AstNode, IAstBranchChildNode
    {
        // Values
        private AstLeafNode _open;
        private AstLeafNode _url;
        private AstLeafNode? _title;
        private AstLeafNode? _letter;
        private AstLeafNode _close;

        /// <summary>
        /// The Leaf Node representing the open bracket of the Link object
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
        /// The Leaf Node representing the URL of the Link object
        /// </summary>
        public AstLeafNode Url
        {
            get
            {
                return _url;
            }
            internal set
            {
                _url = value;
                if (_url != null) _url.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the Title of the Link object
        /// </summary>
        public AstLeafNode? Title
        {
            get
            {
                return _title;
            }
            internal set
            {
                _title = value;
                if (_title != null) _title.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the Letter of the Link object
        /// </summary>
        public AstLeafNode? Letter
        {
            get
            {
                return _letter;
            }
            internal set
            {
                _letter = value;
                if (_letter != null) _letter.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Link object
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



        // Properties
        /// <summary>
        /// Wether this Link object contains a Title
        /// </summary>
        public bool HasTitle
        {
            get
            {
                return Title != null;
            }
        }

        /// <summary>
        /// Wether this Link object contains a Letter
        /// </summary>
        public bool HasLetter
        {
            get
            {
                return Letter != null;
            }
        }


        // IAstBranchNode
        /// <summary>
        /// Get or Set the Leaf Nodes that make the Link object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get
            {
                return new List<AstLeafNode>() { OpenBracket, Url, Title!, Letter!, CloseBracket };
            }
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Link object as objects
        /// </summary>
        public List<object> Children
        {
            get
            {
                return new List<object>() { OpenBracket, Url, Title!, Letter!, CloseBracket };
            }
        }


        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Link object
        /// </summary>
        public SourcePosition Position
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
        /// Internal constructor to prevent external instantiation of <see cref="AstLinkNode"/>.
        /// </summary>
        internal AstLinkNode()
        {
            Position = null!;
            _open = null!;
            _url = null!;
            _close = null!;
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Link object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Leafs.Count - 1; i++)
            {
                if (Leafs[i] == null) s += "NULL";
                else s += "\"" + replaceWhitespaceE(Leafs[i].ToCode()) + "\" ";
            }
            if (Leafs.Count > 0)
            {
                if (Leafs[Leafs.Count - 1] == null) s += "NULL";
                else s += " \"" + replaceWhitespaceE(Leafs[Leafs.Count - 1].ToCode()) + "\"";
            }

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Link object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            // OpenBracket
            string? jo = OpenBracket?.ToJson();
            object? o = null;
            if (jo != null) o = JsonConvert.DeserializeObject(jo);

            // Url
            string? ju = Url?.ToJson();
            object? u = null;
            if (ju != null) u = JsonConvert.DeserializeObject(ju);

            // Title
            string? jt = Title?.ToJson();
            object? t = null;
            if (jt != null) t = JsonConvert.DeserializeObject(jt);

            // Letter
            string? jl = Letter?.ToJson();
            object? l = null;
            if (jl != null) l = JsonConvert.DeserializeObject(jl);

            // CloseBracket
            string? jc = CloseBracket?.ToJson();
            object? c = null;
            if (jc != null) c = JsonConvert.DeserializeObject(jc);

            // Json object
            var jsonObject = new
            {
                openBracket = o,
                url = u,
                title = t,
                letter = l,
                closeBracket = c
            };

            // Json string
            return JsonConvert.SerializeObject(jsonObject);
        }

        /// <summary>
        /// Get a source code string representation of the Link object
        /// </summary>
        public override string ToCode()
        {
            string s = OpenBracket.ToCode() + Url.ToCode();
            if (Title != null) s += "|" + Title.ToCode();
            if (Letter != null) s += "|" + Letter.ToCode();
            s += CloseBracket.ToCode();
            return s;
        }
    }
}
