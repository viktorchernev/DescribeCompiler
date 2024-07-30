using Newtonsoft.Json;
using System.Linq.Expressions;
namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Expression object 
    /// </summary>
    public class AstExpressionNode : AstNode, IAstBranchChildNode
    {
        // Vars
        private AstItemNode _title;
        private AstLeafNode _prod;
        private List<AstExpressionLineNode> _linesList;

        /// <summary>
        /// The Leaf Node representing the title symbol of the Expression object
        /// </summary>
        public AstItemNode TitleItem
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
        /// The Leaf Node representing the production arrow symbol of the Expression object
        /// </summary>
        public AstLeafNode ProductionArrow
        {
            get
            {
                return _prod;
            }
            internal set
            {
                _prod = value;
                if (_prod != null) _prod.Parent = this;
            }
        }

        /// <summary>
        /// The List representing the Expression Line objects of this Scripture object
        /// </summary>
        public List<AstExpressionLineNode> Lines
        {
            get
            {
                return _linesList;
            }
            internal set
            {
                _linesList = value;
                if (_linesList == null) return;
                for (int i = 0; i < _linesList.Count; i++)
                {
                    if (_linesList[i] != null) _linesList[i].Parent = this;
                }
            }
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
        public SourcePosition Position
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Parent of this Expression object
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstExpressionNode"/>.
        /// </summary>
        internal AstExpressionNode()
        {
            Position = null!;
            _title = null!;
            _prod = null!;
            _linesList = null!;
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Expression object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string indent = "    ";
            string s = "Expression : " + Environment.NewLine + Environment.NewLine;

            string head = Environment.NewLine + TitleItem.ToString();
            head = head.Replace(Environment.NewLine, Environment.NewLine + indent + indent);
            s += indent + "titleItem - " + head.TrimStart() + Environment.NewLine;

            s += indent + "productionArrow - " + ProductionArrow.ToString() + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < Lines.Count; i++)
            {
                if(Lines[i] != null)
                {
                    string curl = Environment.NewLine + Lines[i].ToString();
                    curl = curl.Replace(Environment.NewLine, Environment.NewLine + indent + indent);
                    s += indent + "line - " + curl.TrimStart() + Environment.NewLine;
                }
                else s += indent + "line - NULL" + Environment.NewLine;
            }

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Expression object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            // TitleItem
            string? jt = TitleItem?.ToJson();
            object? t = null;
            if (jt != null) t = JsonConvert.DeserializeObject(jt);

            // ProductionArrow
            string? ja = ProductionArrow?.ToJson();
            object? a = null;
            if (ja != null) a = JsonConvert.DeserializeObject(ja);

            // Lines
            List<object?>? ls = null;
            if (Lines != null)
            {
                ls = new List<object?>();
                foreach (var line in Lines)
                {
                    string? jsonLine = line.ToJson();
                    if (jsonLine != null)
                    {
                        ls.Add(JsonConvert.DeserializeObject(jsonLine));
                    }
                    else ls.Add(null);
                }
            }

            // Json object
            var jsonObject = new
            {
                title = t,
                arrow = a,
                lines = ls
            };

            // Json string
            string s = JsonConvert.SerializeObject(jsonObject);
            return s;
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
