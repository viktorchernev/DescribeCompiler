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
    /// Represents a triple decorator node - "{ Category | Name | Value }", in the abstract syntax tree (AST).
    /// </summary>
    public class AstTripleDecoratorNode : AstDecoratorNode
    {
        /// <summary>
        /// Gets the type of the Triple Decorator node.
        /// </summary>
        public AstTripleDecoratorType DecoratorType
        {
            get;
            internal set;
        }

        /// <summary>
        /// The Leaf Node representing the open bracket of the Triple Decorator object - "{ Category | Name | Value }"
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
        /// The Leaf Node representing the Category of the Triple Decorator object - "{ Category | Name | Value }"
        /// </summary>
        public AstLeafNode Category
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
        /// The Leaf Node representing the Name of the Triple Decorator object - "{ Category | Name | Value }"
        /// </summary>
        public AstLeafNode Name
        {
            get
            {
                return Leafs[2];
            }
            set
            {
                Leafs[2] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the Value of the Triple Decorator object - "{ Category | Name | Value }"
        /// </summary>
        public AstLeafNode Value
        {
            get
            {
                return Leafs[3];
            }
            set
            {
                Leafs[3] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Triple Decorator object - "{ Category | Name | Value }"
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



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstTripleDecoratorNode"/>.
        /// </summary>
        internal AstTripleDecoratorNode()
        { }



        // ToString()
        /// <summary>
        /// Get a string representation of the Decorator object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "(TRIPLE_DECORATOR : ";
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
                decoratorType = DecoratorType.ToString(),
                openBracket = JsonConvert.DeserializeObject(OpenBracket.ToJson()),
                category = JsonConvert.DeserializeObject(Category.ToJson()),
                name = JsonConvert.DeserializeObject(Name.ToJson()),
                value = JsonConvert.DeserializeObject(Value.ToJson()),
                closeBracket = JsonConvert.DeserializeObject(CloseBracket.ToJson())
            };

            return JsonConvert.SerializeObject(jsonObject);
        }
    }
}
