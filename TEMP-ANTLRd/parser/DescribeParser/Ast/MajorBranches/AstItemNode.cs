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
        AstLeafNode Tilde
        {
            get;
            set;
        }
        AstLeafNode Text
        {
            get;
            set;
        }
        AstTagNode? Tag
        {
            get;
            set;
        }
        List<AstLinkNode>? Links
        {
            get;
            set;
        }
        List<AstDecoratorNode>? Decorators
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
            set
            {
                throw new NotImplementedException();
            }
        }
        public List<AstLeafNode> Leafs
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
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
