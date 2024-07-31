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
        /// <summary>
        /// Factory method to create instances of AstLinkNode.
        /// </summary>
        /// <param name="open">The open bracket of the Link object</param>
        /// <param name="url">The url of the Link object</param>
        /// <param name="close">The closing bracket of the Link object</param>
        /// <param name="parent">The parent item</param>
        /// <returns>New instance of AstLinkNode.</returns>
        public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode close,
            IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(url);
            ValidateAstChildNodeP(close);
            return _createLinkNode(open, url, null, null, close, parent);
        }

        /// <summary>
        /// Factory method to create instances of AstLinkNode.
        /// </summary>
        /// <param name="open">The open bracket of the Link object</param>
        /// <param name="url">The url of the Link object</param>
        /// <param name="title">The Title of the Link object</param>
        /// <param name="close">The closing bracket of the Link object</param>
        /// <param name="parent">The parent item</param>
        /// <returns>New instance of AstLinkNode.</returns>
        public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode? title, 
            AstLeafNode close, IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(url);
            ValidateAstChildNodeP(close);
            return _createLinkNode(open, url, title, null, close, parent);
        }

        /// <summary>
        /// Factory method to create instances of AstLinkNode.
        /// </summary>
        /// <param name="open">The open bracket of the Link object</param>
        /// <param name="url">The url of the Link object</param>
        /// <param name="title">The Title of the Link object</param>
        /// <param name="letter">The Letter of the Link object</param>
        /// <param name="close">The closing bracket of the Link object</param>
        /// <param name="parent">The parent item</param>
        /// <returns>New instance of AstLinkNode.</returns>
        public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode? title,
            AstLeafNode? letter, AstLeafNode close, IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(url);
            ValidateAstChildNodeP(close);
            return _createLinkNode(open, url, title, letter, close, parent);
        }



        static AstLinkNode _createLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode? title,
            AstLeafNode? letter, AstLeafNode close, IAstBranchNode? parent = null)
        {
            AstLinkNode link = new AstLinkNode();

            link.OpenBracket = open;
            link.Url = url;
            link.Title = title;
            link.Letter = letter;
            link.CloseBracket = close;

            link.Parent = parent;
            link.Position = CreateSourcePosition(open.Position, close.Position);

            return link;
        }
    }
}
