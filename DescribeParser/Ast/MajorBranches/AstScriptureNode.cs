using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Scripture object 
    /// </summary>
    public class AstScriptureNode : AstNode, IAstBranchNode
    {
        // Vars
        List<AstExpressionNode> _expressions;

        /// <summary>
        /// The string representing the filename of the Scripture object
        /// </summary>
        public string? FileName
        {
            get;
            internal set;
        }

        /// <summary>
        /// The string representing the base namespace of the Scripture object
        /// </summary>
        public string? Namespace
        {
            get;
            internal set;
        }

        /// <summary>
        /// The List representing the Expression objects of this Scripture object
        /// </summary>
        public List<AstExpressionNode> Expressions
        {
            get
            {
                return _expressions;
            }
            internal set
            {
                _expressions = value;
                if (_expressions == null) return;
                for (int i = 0; i < _expressions.Count; i++)
                {
                    if (_expressions[i] != null) _expressions[i].Parent = this;
                }
            }
        }

        /// <summary>
        /// The Exception of this Scripture object - null if parsing was successful
        /// </summary>
        public Exception? Exception
        {
            get;
            internal set;
        }



        // Properties
        /// <summary>
        /// Gets the <see cref="AstExpressionNode"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the expression to get.</param>
        /// <returns>The <see cref="AstExpressionNode"/> at the specified index.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than or equal to the number of expressions.</exception>
        public AstExpressionNode this[int index]
        {
            get
            {
                // You can include additional bounds-checking logic here
                if (index < 0 || index >= Expressions.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return Expressions[index];
            }
        }

        /// <summary>
        /// Wether this Scripture object has an multiple Expressions or a single one
        /// </summary>
        public bool IsMultyExpression
        {
            get
            {
                return Expressions.Count > 1;
            }
        }

        /// <summary>
        /// Gets the Number of Expressions in this Scripture object
        /// </summary>
        public int ExpressionCount
        {
            get
            {
                return Expressions.Count;
            }
        }

        /// <summary>
        /// Wether this Scripture object has an Exception
        /// </summary>
        public bool HasException
        {
            get
            {
                return Exception != null;
            }
        }



        // IAstBranchNode
        /// <summary>
        /// Gets all the direct descendant nodes of this Scripture object
        /// </summary>
        public List<object> Children
        {
            get
            {
                List<object> result = new List<object>();
                for(int i = 0; i < Expressions.Count; i++)
                {
                    result.Add(Expressions[i]);
                }
                return result;
            }
        }

        /// <summary>
        /// Gets all the Leaf Nodes contained in this Scripture object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get
            {
                List<AstLeafNode> li = new List<AstLeafNode>();
                for (int i = 0; i < Expressions.Count; i++)
                {
                    li.AddRange(Expressions[i].Leafs);
                }
                return li;
            }
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstScriptureNode"/>.
        /// </summary>
        internal AstScriptureNode()
        {
            _expressions = new List<AstExpressionNode>();
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Scripture object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string indent = "    ";
            string s = "Scripture : " + Environment.NewLine + Environment.NewLine;

            if (FileName != null)
                s += indent + "filename - \"" + FileName.ToString() + "\"" + Environment.NewLine;
            else s += indent + "filename - NULL" + Environment.NewLine;

            if (Namespace != null)
                s += indent + "namespace - \"" + Namespace.ToString() + "\"" + Environment.NewLine;
            else s += indent + "namespace - NULL" + Environment.NewLine;

            if (Exception != null)
                s += indent + "Exception - \"" + Exception.Message + "\", \"" + Exception.StackTrace + "\"";
            else s += indent + "Exception - NULL" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < Expressions.Count; i++)
            {
                if (Expressions[i] != null)
                {
                    string txt = Expressions[i].ToString();
                    txt = txt.Replace(Environment.NewLine, Environment.NewLine + indent);
                    s += indent + txt + Environment.NewLine;
                }
            }

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Scripture object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            // Lines
            List<object?>? es = null;
            if (Expressions != null)
            {
                es = new List<object?>();
                foreach (var expression in Expressions)
                {
                    string? jsonExpr = expression.ToJson();
                    if (jsonExpr != null)
                    {
                        es.Add(JsonConvert.DeserializeObject(jsonExpr));
                    }
                    else es.Add(null);
                }
            }

            // Exception
            object? exceptionJsonObject = null;
            if(Exception != null) 
            {
                exceptionJsonObject = new { message = Exception.Message, type = Exception.GetType().FullName };
            }

            // Json object
            var jsonObject = new
            {
                filename = FileName,
                nspace = Namespace,
                expressions = Expressions?.Select(expression => JsonConvert.DeserializeObject(expression.ToJson())).ToList(),
                exception = exceptionJsonObject
            };

            // Json string
            string s = JsonConvert.SerializeObject(jsonObject);
            return s;
        }

        /// <summary>
        /// Get a source code string representation of the Scripture object
        /// </summary>
        public override string ToCode()
        {
            string s = "";
            for(int i = 0; i < Expressions.Count; i++)
            {
                s += Expressions[i].ToCode();
            }
            return s;
        }
    }
}
