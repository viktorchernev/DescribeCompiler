using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        /// The Leaf Node representing the Pipe before Title of the Link object
        /// </summary>
        public AstLeafNode? TitlePipe
        {
            get
            {
                AstLeafNode n = Leafs[2];
                return n;
            }
            set
            {
                Leafs[2] = value;
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
        /// The Leaf Node representing the Pipe before Letter of the Link object
        /// </summary>
        public AstLeafNode? LetterPipe
        {
            get
            {
                AstLeafNode n = Leafs[4];
                return n;
            }
            set
            {
                Leafs[4] = value;
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



        // Ctors
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="open">The open bracket of the Link object</param>
        /// <param name="url">The url of the Link object</param>
        /// <param name="close">The closing bracket of the Link object</param>
        /// <param name="parent">The parent item</param>
        public AstLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode close, 
            IAstBranchNode parent = null)
        {
            OpenBracket = open;
            Url = url;
            TitlePipe = null;
            Title = null;
            LetterPipe = null;
            Letter = null;
            CloseBracket = close;

            Parent = parent;
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="open">The open bracket of the Link object</param>
        /// <param name="url">The url of the Link object</param>
        /// <param name="titlePipe">The pipe before the Title of the Link object</param>
        /// <param name="title">The Title of the Link object</param>
        /// <param name="close">The closing bracket of the Link object</param>
        /// <param name="parent">The parent item</param>
        public AstLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode titlePipe, 
            AstLeafNode title, AstLeafNode close, IAstBranchNode parent = null)
        {
            OpenBracket = open;
            Url = url;
            TitlePipe = titlePipe;
            Title = title;
            LetterPipe = null;
            Letter = null;
            CloseBracket = close;

            Parent = parent;
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="open">The open bracket of the Link object</param>
        /// <param name="url">The url of the Link object</param>
        /// <param name="titlePipe">The pipe before the Title of the Link object</param>
        /// <param name="title">The Title of the Link object</param>
        /// <param name="letterPipe">The pipe before the Letter of the Link object</param>
        /// <param name="letter">The Letter of the Link object</param>
        /// <param name="close">The closing bracket of the Link object</param>
        /// <param name="parent">The parent item</param>
        public AstLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode titlePipe,
            AstLeafNode title, AstLeafNode letterPipe, AstLeafNode letter, 
            AstLeafNode close, IAstBranchNode parent = null)
        {
            OpenBracket = open;
            Url = url;
            TitlePipe = titlePipe;
            Title = title;
            LetterPipe = letterPipe;
            Letter = letter;
            CloseBracket = close;

            Parent = parent;
        }



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
            if (Title != null) s += Title.ToCode();
            if (Letter != null) s += Letter.ToCode();
            s += CloseBracket.ToCode();
            return s;
        }
    }
}
