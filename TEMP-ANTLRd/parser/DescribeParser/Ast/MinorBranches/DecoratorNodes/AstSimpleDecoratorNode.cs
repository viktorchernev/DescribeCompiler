using Newtonsoft.Json;
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
                return Leafs[0];
            }
            internal set
            {
                Leafs[0] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the Name of the Simple Decorator object - "{ Name }"
        /// </summary>
        public AstLeafNode Name
        {
            get
            {
                return Leafs[1];
            }
            internal set
            {
                Leafs[1] = value;
            }
        }

        /// <summary>
        /// The Leaf Node representing the closing bracket of the Simple Decorator object - "{ Name }"
        /// </summary>
        public AstLeafNode CloseBracket
        {
            get
            {
                return Leafs[2];
            }
            internal set
            {
                Leafs[2] = value;
            }
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstSimpleDecoratorNode"/>.
        /// </summary>
        internal AstSimpleDecoratorNode()
        { }



        // ToString()
        /// <summary>
        /// Get a string representation of the Decorator object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "(SIMPLE_DECORATOR : ";
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
                name = JsonConvert.DeserializeObject(Name.ToJson()),
                closeBracket = JsonConvert.DeserializeObject(CloseBracket.ToJson())
            };

            return JsonConvert.SerializeObject(jsonObject);
        }
    }
}
