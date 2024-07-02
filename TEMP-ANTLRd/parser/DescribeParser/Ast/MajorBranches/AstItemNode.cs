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
        public AstLeafNode Tilde
        {
            get;
            internal set;
        }
        public AstLeafNode Text
        {
            get;
            internal set;
        }
        public AstTagNode? Tag
        {
            get;
            internal set;
        }
        public List<AstLinkNode>? Links
        {
            get;
            internal set;
        }
        public List<AstDecoratorNode>? Decorators
        {
            get;
            internal set;
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



        // Internal Ctor - to prevent external instantiation
        internal AstItemNode()
        { }
 


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