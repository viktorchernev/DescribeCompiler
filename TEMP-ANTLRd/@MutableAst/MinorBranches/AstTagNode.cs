using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Tag object 
    /// </summary>
    public class AstTagNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Values
        /// <summary>
        /// The Leaf Node representing the open bracket of the Tag object
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
        /// The Leaf Node representing the id of the Tag object
        /// </summary>
        public AstLeafNode Id
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
        /// The Leaf Node representing the closing bracket of the Tag object
        /// </summary>
        public AstLeafNode CloseBracket
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



        // IAstBranchNode
        /// <summary>
        /// Get or Set the Leaf Nodes that make the Tag object
        /// </summary>
        public List<AstLeafNode> Leafs
        { 
            get;
            set; 
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Tag object as objects
        /// </summary>
        public List<object> Children
        { 
            get;
        }



        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Tag object
        /// </summary>
        public SourcePosition? Position
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



        // Ctor
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="open">The open bracket of the Tag object</param>
        /// <param name="id">The id of the Tag object</param>
        /// <param name="close">The closing bracket of the Tag object</param>
        public AstTagNode(AstLeafNode open, AstLeafNode id, AstLeafNode close)
        {
            OpenBracket = open;
            Id = id;
            CloseBracket = close;
            Parent = null;
            //calculate Position
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="open">The open bracket of the Tag object</param>
        /// <param name="id">The id of the Tag object</param>
        /// <param name="close">The closing bracket of the Tag object</param>
        /// <param name="parent">The parent item</param>
        public AstTagNode(AstLeafNode open, AstLeafNode id, AstLeafNode close, IAstBranchNode parent)
        {
            OpenBracket = open;
            Id = id;
            CloseBracket = close;
            Parent = parent;
            //calculate Position
        }



        // ToString()
        /// <summary>
        /// Get a string representation of the Tag object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "(Tag : ";
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
        /// Get a JSON string representation of the Tag object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            var jsonObject = new
            {
                openBracket = JsonConvert.DeserializeObject(OpenBracket.ToJson()),
                id = JsonConvert.DeserializeObject(Id.ToJson()),
                closeBracket = JsonConvert.DeserializeObject(CloseBracket.ToJson())
            };

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
