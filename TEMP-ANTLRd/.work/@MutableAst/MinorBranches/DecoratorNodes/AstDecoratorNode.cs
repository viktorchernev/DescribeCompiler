using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstDecoratorNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // IAstBranchNode
        /// <summary>
        /// Get or Set the Leaf Nodes that make the Link object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get;
            set;
        }

        /// <summary>
        /// Get the Leaf Nodes that make the Link object as objects
        /// </summary>
        public List<object> Children
        {
            get
            {
                List<object> os = new List<object>();
                for (int i = 0; i < Leafs.Count; i++) os.Add(Leafs[i]);
                return os;
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


        public AstDecoratorNode()
        {
            Leafs = new List<AstLeafNode>();
            Position = null;
            Parent = null;
        }
        public AstDecoratorNode(SourcePosition position)
        {
            Leafs = new List<AstLeafNode>();
            Position = position;
            Parent = null;
        }
        public AstDecoratorNode(IAstBranchNode parent)
        {
            Leafs = new List<AstLeafNode>();
            Position = null;
            Parent = parent;
        }
        public AstDecoratorNode(SourcePosition position, IAstBranchNode parent)
        {
            Leafs = new List<AstLeafNode>();
            Position = position;
            Parent = parent;
        }
        public AstDecoratorNode(IAstBranchNode parent, SourcePosition position)
        {
            Leafs = new List<AstLeafNode>();
            Position = position;
            Parent = parent;
        }

        public AstDecoratorNode(AstLeafNode chunk)
        {
            Leafs = new List<AstLeafNode>() { chunk };
            if (chunk.Position == null) Position = null;
            else Position = new SourcePosition(chunk.Position);
            Parent = null;
        }
        public AstDecoratorNode(AstLeafNode chunk, IAstBranchNode parent)
        {
            Leafs = new List<AstLeafNode>() { chunk };
            if (chunk.Position == null) Position = null;
            else Position = new SourcePosition(chunk.Position);
            Parent = parent;
        }

        public AstDecoratorNode(List<AstLeafNode> chunks)
        {
            Leafs = chunks;
            Parent = null;
            Position = null;
            
            //calculate Position
        }
        public AstDecoratorNode(List<AstLeafNode> chunks, IAstBranchNode parent)
        {
            Leafs = chunks;
            Parent = parent;
            Position = null;

            //calculate Position
        }


        // ToString()
        /// <summary>
        /// Get a string representation of the Decorator object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "(Decorator : ";
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
            //var jsonObject = new
            //{
            //    openBracket = JsonConvert.DeserializeObject(OpenBracket.ToJson()),
            //    url = JsonConvert.DeserializeObject(Url.ToJson()),
            //    title = Title != null ? JsonConvert.DeserializeObject(Title.ToJson()) : null,
            //    letter = Letter != null ? JsonConvert.DeserializeObject(Letter.ToJson()) : null,
            //    closeBracket = JsonConvert.DeserializeObject(CloseBracket.ToJson())
            //};

            //return JsonConvert.SerializeObject(jsonObject);
            return null;
        }

        /// <summary>
        /// Get a source code string representation of the Decorator object
        /// </summary>
        public override string ToCode()
        {
            string s = "";
            for(int i = 0; i < Leafs.Count; i++)
            {
                s += Leafs[i].ToCode();
            }
            return s;
        }
    }
}
