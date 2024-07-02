using Newtonsoft.Json;

namespace DescribeParser.Ast
{
    public class AstLinkNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Values
        /// <summary>
        /// The Leaf Node representing the open bracket of the Link object
        /// </summary>
        public AstLeafNode OpenBracket
        {
            get
            {
                return Leafs[0];
            }
            set
            {
                Leafs[0] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the URL of the Link object
        /// </summary>
        public AstLeafNode Url
        {
            get
            {
                return Leafs[1];
            }
            set
            {
                Leafs[1] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the Title of the Link object
        /// </summary>
        public AstLeafNode? Title
        {
            get
            {
                AstLeafNode n = Leafs[3];
                return n;
            }
            set
            {
                Leafs[3] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the Letter of the Link object
        /// </summary>
        public AstLeafNode? Letter
        {
            get
            {
                AstLeafNode n = Leafs[5];
                return n;
            }
            set
            {
                Leafs[5] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Link object
        /// </summary>
        public AstLeafNode CloseBracket
        {
            get
            {
                return Leafs[4];
            }
            set
            {
                Leafs[4] = value;
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
                var li = new List<AstLeafNode>() { OpenBracket, Url };
                if (Title != null) li.Add(Title);
                if (Letter != null) li.Add(Letter);
                return li;
            }
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Link object as objects
        /// </summary>
        public List<object> Children
        {
            get
            {
                var li = new List<object>() { OpenBracket, Url };
                if (Title != null) li.Add(Title);
                if (Letter != null) li.Add(Letter);
                return li;
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
        /// Internal constructor to prevent external instantiation of <see cref="AstLinkNode"/>.
        /// </summary>
        internal AstLinkNode()
        { }



        // ToString()
        /// <summary>
        /// Get a string representation of the Link object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "(Link : ";
            for (int i = 0; i < Leafs.Count - 1; i++)
            {
                if (Leafs[i] == null) s += "NULL";
                else s += "\"" + Leafs[i].ToCode() + "\", ";
            }
            if (Leafs.Count > 0)
            {
                if (Leafs[Leafs.Count - 1] == null) s += "NULL";
                else s += "\"" + Leafs[Leafs.Count - 1].ToCode() + "\"";
            }
            s += ")";

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Link object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            var jsonObject = new
            {
                openBracket = JsonConvert.DeserializeObject(OpenBracket.ToJson()),
                url = JsonConvert.DeserializeObject(Url.ToJson()),
                title = Title != null ? JsonConvert.DeserializeObject(Title.ToJson()) : null,
                letter = Letter != null ? JsonConvert.DeserializeObject(Letter.ToJson()) : null,
                closeBracket = JsonConvert.DeserializeObject(CloseBracket.ToJson())
            };

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
