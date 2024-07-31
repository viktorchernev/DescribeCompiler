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
        /// Creates an AstItemNode with the specified text and optional parent.
        /// </summary>
        /// <param name="text">The text node of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode text,
            IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = null;
            item.Text = text;
            item.Tag = null;
            item.Links = null;
            item.Decorators = null;
            item.Parent = parent;

            item.Position = CreateSourcePosition(text.Position!);

            return item;
        }

        /// <summary>
        /// Creates an AstItemNode with the specified text, tag, and optional parent.
        /// </summary>
        /// <param name="text">The text node of the item.</param>
        /// <param name="tag">The tag node of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode? tag,
            IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = null;
            item.Text = text;
            item.Tag = tag;
            item.Links = null;
            item.Decorators = null;
            item.Parent = parent;

            item.Position = CreateSourcePosition(text.Position!, tag?.Position!);

            return item;
        }

        /// <summary>
        /// Creates an AstItemNode with the specified text, tag, links, and optional parent.
        /// </summary>
        /// <param name="text">The text node of the item.</param>
        /// <param name="tag">The tag node of the item.</param>
        /// <param name="links">The list of link nodes of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode? tag,
            List<AstLinkNode>? links, IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = null;
            item.Text = text;
            item.Tag = tag;
            item.Links = links;
            item.Decorators = null;
            item.Parent = parent;

            SourcePosition? linkPos = null;
            if(links != null)
            {
                for(int i = links.Count - 1; i > -1; i--)
                {
                    if (links[i] != null)
                    {
                        ValidateSourcePositionP(links[i].Position);
                        linkPos = links[i].Position;
                        break;
                    }
                }
            }
            item.Position = CreateSourcePosition(text.Position!, tag?.Position!, linkPos!);

            return item;
        }

        /// <summary>
        /// Creates an AstItemNode with the specified text, tag, links, decorators, and optional parent.
        /// </summary>
        /// <param name="text">The text node of the item.</param>
        /// <param name="tag">The tag node of the item.</param>
        /// <param name="links">The list of link nodes of the item.</param>
        /// <param name="decorators">The list of decorator nodes of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode? tag,
            List<AstLinkNode>? links, List<AstDecoratorNode>? decorators,
            IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = null;
            item.Text = text;
            item.Tag = tag;
            item.Links = links;
            item.Decorators = decorators;
            item.Parent = parent;

            SourcePosition? linkPos = null;
            if (links != null)
            {
                for (int i = links.Count - 1; i > -1; i--)
                {
                    if (links[i] != null)
                    {
                        ValidateSourcePositionP(links[i].Position);
                        linkPos = links[i].Position;
                        break;
                    }
                }
            }

            SourcePosition? decoratorsPos = null;
            if (decorators != null)
            {
                for (int i = decorators.Count - 1; i > -1; i--)
                {
                    if (decorators[i] != null)
                    {
                        ValidateSourcePositionP(decorators[i].Position);
                        decoratorsPos = decorators[i].Position;
                        break;
                    }
                }
            }

            item.Position = CreateSourcePosition(text.Position!, tag?.Position!, linkPos!, decoratorsPos!);

            return item;
        }



        /// <summary>
        /// Creates an AstItemNode with the specified text, tilde, and optional parent.
        /// </summary>
        /// <param name="text">The text node of the item.</param>
        /// <param name="tilde">The tilde node of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode? tilde, AstLeafNode text,
            IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = tilde;
            item.Text = text;
            item.Tag = null;
            item.Links = null;
            item.Decorators = null;
            item.Parent = parent;

            item.Position = CreateSourcePosition(tilde?.Position, text.Position!);

            return item;
        }

        /// <summary>
        /// Creates an AstItemNode with the specified tilde, text, tag, and optional parent.
        /// </summary>
        /// <param name="tilde">The tilde node of the item.</param>
        /// <param name="text">The text node of the item.</param>
        /// <param name="tag">The tag node of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode? tilde, AstLeafNode text, 
            AstTagNode? tag, IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = tilde;
            item.Text = text;
            item.Tag = tag;
            item.Links = null;
            item.Decorators = null;
            item.Parent = parent;

            item.Position = CreateSourcePosition(tilde?.Position, text.Position!, tag?.Position);

            return item;
        }

        /// <summary>
        /// Creates an AstItemNode with the specified tilde, text, tag, links, and optional parent.
        /// </summary>
        /// <param name="tilde">The tilde node of the item.</param>
        /// <param name="text">The text node of the item.</param>
        /// <param name="tag">The tag node of the item.</param>
        /// <param name="links">The list of link nodes of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode? tilde, AstLeafNode text, 
            AstTagNode? tag, List<AstLinkNode>? links, IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = tilde;
            item.Text = text;
            item.Tag = tag;
            item.Links = links;
            item.Decorators = null;
            item.Parent = parent;

            SourcePosition? linkPos = null;
            if (links != null)
            {
                for (int i = links.Count - 1; i > -1; i--)
                {
                    if (links[i] != null)
                    {
                        ValidateSourcePositionP(links[i].Position);
                        linkPos = links[i].Position;
                        break;
                    }
                }
            }

            item.Position = CreateSourcePosition(tilde?.Position, text.Position!, tag?.Position, linkPos!);

            return item;
        }

        /// <summary>
        /// Creates an AstItemNode with the specified tilde, text, tag, links, decorators, and optional parent.
        /// </summary>
        /// <param name="tilde">The tilde node of the item.</param>
        /// <param name="text">The text node of the item.</param>
        /// <param name="tag">The tag node of the item.</param>
        /// <param name="links">The list of link nodes of the item.</param>
        /// <param name="decorators">The list of decorator nodes of the item.</param>
        /// <param name="parent">The optional parent node of the item.</param>
        /// <returns>The created AstItemNode.</returns>
        public static AstItemNode CreateItemNode(AstLeafNode? tilde, AstLeafNode text, 
            AstTagNode? tag, List<AstLinkNode>? links, List<AstDecoratorNode>? decorators,
            IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(text);

            // code
            AstItemNode item = new AstItemNode();

            item.Tilde = tilde;
            item.Text = text;
            item.Tag = tag;
            item.Links = links;
            item.Decorators = decorators;
            item.Parent = parent;

            SourcePosition? linkPos = null;
            if (links != null)
            {
                for (int i = links.Count - 1; i > -1; i--)
                {
                    if (links[i] != null)
                    {
                        ValidateSourcePositionP(links[i].Position);
                        linkPos = links[i].Position;
                        break;
                    }
                }
            }

            SourcePosition? decoratorsPos = null;
            if (decorators != null)
            {
                for (int i = decorators.Count - 1; i > -1; i--)
                {
                    if (decorators[i] != null)
                    {
                        ValidateSourcePositionP(decorators[i].Position);
                        decoratorsPos = decorators[i].Position;
                        break;
                    }
                }
            }

            item.Position = CreateSourcePosition(tilde?.Position, text.Position!, tag?.Position, linkPos!, decoratorsPos!);

            return item;
        }
    }
}
