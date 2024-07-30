using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents a double decorator node - "{ Name | Value }", in the abstract syntax tree (AST).
    /// </summary>
    public class AstDoubleDecoratorNode : AstDecoratorNode
    {
        // Vars
        private AstLeafNode _open;
        private AstLeafNode _name;
        private AstLeafNode _value;
        private AstLeafNode _close;

        /// <summary>
        /// Gets the type of the Double Decorator node.
        /// </summary>
        public AstDoubleDecoratorType DecoratorType
        {
            get;
            internal set;
        }
        
        /// <summary>
        /// The Leaf Node representing the open bracket of the Double Decorator object - "{ Name | Value }"
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
        /// The Leaf Node representing the Name of the Double Decorator object - "{ Name | Value }"
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
        /// The Leaf Node representing the Value of the Double Decorator object - "{ Name | Value }"
        /// </summary>
        public AstLeafNode Value
        {
            get
            {
                return _value;
            }
            internal set
            {
                _value = value;
                if (_value != null) _value.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Double Decorator object - "{ Name | Value }"
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
                return new List<AstLeafNode>() { OpenBracket, Name, Value, CloseBracket };
            }
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Link object as objects
        /// </summary>
        public override List<object> Children
        {
            get
            {
                return new List<object>() { OpenBracket, Name, Value, CloseBracket };
            }
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstDoubleDecoratorNode"/>.
        /// </summary>
        internal AstDoubleDecoratorNode()
        {
            _open = null!;
            _name = null!;
            _value = null!;
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

            // Value
            string? jv = Value?.ToJson();
            object? v = null;
            if (jv != null) v = JsonConvert.DeserializeObject(jv);

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
                value = v,
                closeBracket = c
            };

            // Json string
            return JsonConvert.SerializeObject(jsonObject);
        }
    }
}
