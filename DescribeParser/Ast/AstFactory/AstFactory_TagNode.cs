using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public static partial class AstFactory
    {
        // AstTagNode
        /// <summary>
        /// Factory method to create instances of AstTagNode.
        /// </summary>
        /// <param name="open">The open bracket of the Tag object.</param>
        /// <param name="id">The id of the Tag object.</param>
        /// <param name="close">The closing bracket of the Tag object.</param>
        /// <param name="parent">The parent item.</param>
        /// <returns>New instance of AstTagNode.</returns>
        public static AstTagNode CreateTagNode(AstLeafNode open, AstLeafNode id, AstLeafNode close, 
            IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(id);
            ValidateAstChildNodeP(close);

            AstTagNode tag = new AstTagNode();

            tag.OpenBracket = open;
            tag.Id = id;
            tag.CloseBracket = close;

            tag.Parent = parent;
            tag.Position = CreateSourcePosition(open.Position!, close.Position!);

            return tag;
        }
    }
}
