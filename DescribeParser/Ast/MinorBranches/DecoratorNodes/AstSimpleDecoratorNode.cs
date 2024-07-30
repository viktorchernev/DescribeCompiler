using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a simple decorator node - "{ Name }", in the abstract syntax tree (AST).
    /// </summary>
    public class AstSimpleDecoratorNode : AstDecoratorNode
    {
        // Vars
        private AstLeafNode _open;
        private AstLeafNode _name;
        private AstLeafNode _close;

        /// <summary>
        /// Gets the type of the Simple Decorator node.
        /// </summary>
        public AstSimpleDecoratorType DecoratorType
        {
            get;
            internal set;
        }

        /// <summary>
        /// The Leaf Node representing the open bracket of the Simple Decorator object - "{ Name }"
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
        /// The Leaf Node representing the Name of the Simple Decorator object - "{ Name }"
        /// </summary>
        public AstLeafNode Name
        {
            get
            {
                return _name;
            }
            internal set
            {
                _name = value;
                if (_name != null) _name.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Simple Decorator object - "{ Name }"
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
        /// Get or Set the Leaf Nodes that make the Link object
        /// </summary>
        public override List<AstLeafNode> Leafs
        {
            get
            {
                return new List<AstLeafNode>() { OpenBracket, Name, CloseBracket };
            }
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Link object as objects
        /// </summary>
        public override List<object> Children
        {
            get
            {
                return new List<object>() { OpenBracket, Name, CloseBracket };
            }
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstSimpleDecoratorNode"/>.
        /// </summary>
        internal AstSimpleDecoratorNode()
        {
            _open = null!;
            _name = null!;
            _close = null!;
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
            // OpenBracket
            string? jo = OpenBracket?.ToJson();
            object? o = null;
            if (jo != null) o = JsonConvert.DeserializeObject(jo);

            // Name
            string? jn = Name?.ToJson();
            object? n = null;
            if (jn != null) n = JsonConvert.DeserializeObject(jn);

            // CloseBracket
            string? jc = CloseBracket?.ToJson();
            object? c = null;
            if (jc != null) c = JsonConvert.DeserializeObject(jc);

            // Json object
            var jsonObject = new
            {
                decoratorType = DecoratorType.ToString(),
                openBracket = o,
                name = n,
                closeBracket = c
            };

            // Json string
            return JsonConvert.SerializeObject(jsonObject);
        }
    }
}
