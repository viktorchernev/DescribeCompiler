using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstItemNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Vars
        protected string _order = "";
        public AstLeafNode Tilde
        {
            get;
            set;
        }
        public AstLeafNode Text
        {
            get;
            set;
        }
        public AstTagNode? Tag
        {
            get;
            set;
        }
        public List<AstLinkNode>? Links
        {
            get;
            set;
        }
        public List<AstDecoratorNode>? Decorators
        {
            get;
            set;
        }

        // Properties
        public bool HasTag
        {
            get
            {
                return Tag == null;
            }
        }
        public bool HasLinks
        {
            get
            {
                return Links == null;
            }
        }
        public bool HasDecorators
        {
            get
            {
                return Decorators == null;
            }
        }

        // IAstBranchNode
        public List<object> Children
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public List<AstLeafNode> Leafs
        {
            get
            {
                List<AstLeafNode> li = new List<AstLeafNode>();
                li.Add(Text);
                if (Tag != null) 
                { 
                    li.AddRange(Tag.Leafs); 
                }
                if (Links != null) 
                { 
                    for(int i = 0; i < Links.Count; i++)
                    {
                        if (Links[i] != null) li.AddRange(Links[i].Leafs);
                    }
                }
                if (Decorators != null)
                {
                    for (int i = 0; i < Decorators.Count; i++)
                    {
                        if (Decorators[i] != null) li.AddRange(Decorators[i].Leafs);
                    }
                }

                return li;
            }
        }

        // IAstChildNode
        public SourcePosition? Position
        {
            get;
            set;
        }
        public IAstBranchNode? Parent
        {
            get;
            set;
        }


        // Ctors
        public AstItemNode(AstLeafNode text, 
            IAstBranchNode parent = null)
        {
            _order = "";

            Tilde = null;
            Text = text;
            Tag = null;
            Links = null;
            Decorators = null;
            Parent = parent;

            if(text.Position == null) Position = null;
            else Position = new SourcePosition(text.Position);
        }

        public AstItemNode(AstLeafNode text, AstTagNode tag, 
            IAstBranchNode parent = null)
        {
            _order = "t";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = null;
            Decorators = null;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, List<AstLinkNode> links,
            IAstBranchNode parent = null)
        {
            _order = "t";

            Tilde = null;
            Text = text;
            Tag = null;
            Links = links;
            Decorators = null;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
        {
            _order = "t";

            Tilde = null;
            Text = text;
            Tag = null;
            Links = null;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, AstTagNode tag, List<AstLinkNode> links,
            IAstBranchNode parent = null)
        {
            _order = "tl";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = null;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, List<AstLinkNode> links, AstTagNode tag,
            IAstBranchNode parent = null)
        {
            _order = "lt";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = null;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, List<AstDecoratorNode> decorators, List<AstLinkNode> links, AstTagNode tag,
            IAstBranchNode parent = null)
        {
            _order = "dlt";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, List<AstDecoratorNode> decorators, AstTagNode tag, List<AstLinkNode> links,
           IAstBranchNode parent = null)
        {
            _order = "dtl";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, AstTagNode tag, List<AstDecoratorNode> decorators, List<AstLinkNode> links,
            IAstBranchNode parent = null)
        {
            _order = "tdl";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, List<AstLinkNode> links, List<AstDecoratorNode> decorators, AstTagNode tag,
            IAstBranchNode parent = null)
        {
            _order = "ldt";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
        {
            _order = "tld";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode text, List<AstLinkNode> links, AstTagNode tag, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
        {
            _order = "ltd";

            Tilde = null;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }


        public AstItemNode(AstLeafNode tilde, AstLeafNode text,
            IAstBranchNode parent = null)
        {
            _order = "";

            Tilde = tilde;
            Text = text;
            Tag = null;
            Links = null;
            Decorators = null;
            Parent = parent;

            if (text.Position == null) Position = null;
            else Position = new SourcePosition(text.Position);
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag,
            IAstBranchNode parent = null)
        {
            _order = "t";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = null;
            Decorators = null;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links,
            IAstBranchNode parent = null)
        {
            _order = "tl";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = null;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, List<AstLinkNode> links, AstTagNode tag,
            IAstBranchNode parent = null)
        {
            _order = "lt";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = null;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, List<AstDecoratorNode> decorators, List<AstLinkNode> links, AstTagNode tag,
            IAstBranchNode parent = null)
        {
            _order = "dlt";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, List<AstDecoratorNode> decorators, AstTagNode tag, List<AstLinkNode> links,
           IAstBranchNode parent = null)
        {
            _order = "dtl";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstDecoratorNode> decorators, List<AstLinkNode> links,
            IAstBranchNode parent = null)
        {
            _order = "tdl";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, List<AstLinkNode> links, List<AstDecoratorNode> decorators, AstTagNode tag,
            IAstBranchNode parent = null)
        {
            _order = "ldt";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode tag, List<AstLinkNode> links, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
        {
            _order = "tld";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }

        public AstItemNode(AstLeafNode tilde, AstLeafNode text, List<AstLinkNode> links, AstTagNode tag, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
        {
            _order = "ltd";

            Tilde = tilde;
            Text = text;
            Tag = tag;
            Links = links;
            Decorators = decorators;

            Parent = parent;
            if (text.Position == null) Position = null;
            else Position = text.Position;
        }



        // ToString()
        public override string ToCode()
        {
            throw new NotImplementedException();
        }
        public override string ToJson()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}