using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstItemNode : AstMinorBranchNode
    {
        AstTokenNode Tilde
        {
            get
            {
                return Chunks[0];
            }
            set
            {
                Chunks[0] = value;
            }
        }
        AstTokenNode Text
        {
            get
            {
                return Chunks[1];
            }
            set
            {
                Chunks[1] = value;
            }
        }
        AstTagNode? Tag
        {
            get
            {
                for(int i = 1; i < Chunks.Count; i++)
                {
                    if (Chunks[i] is AstTokenNode)
                    {
                        AstLeafNode 
                    }
                    return null;
                }
            }
        }
        List<AstLinkNode> Links;
        List<AstDecoratorNode> Decorators;



        public AstItemNode(AstTokenNode tilde, AstTokenNode text)
            : base(new List<AstTokenNode>() { tilde, text }) { }


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
