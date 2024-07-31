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
        /// Creates a leaf node with the specified type, text, position, and optional parent node.
        /// </summary>
        /// <param name="leaftype">The type of the leaf node.</param>
        /// <param name="text">The text content of the leaf node.</param>
        /// <param name="position">The source position of the leaf node.</param>
        /// <param name="parent">The parent node of the leaf node, if any. Default is null.</param>
        /// <returns>A new instance of <see cref="AstLeafNode"/>.</returns>
        public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, 
            SourcePosition position, IAstBranchNode? parent = null)
        {
            ValidateString(text);
            ValidateSourcePosition(position);
            return _createLeafNode(leaftype, text, null, null, position, parent);
        }

        /// <summary>
        /// Creates a leaf node with the specified type, text, trailing trivia, position, and optional parent node.
        /// </summary>
        /// <param name="leaftype">The type of the leaf node.</param>
        /// <param name="text">The text content of the leaf node.</param>
        /// <param name="trailingTrivia">The trailing trivia of the leaf node.</param>
        /// <param name="position">The source position of the leaf node.</param>
        /// <param name="parent">The parent node of the leaf node, if any. Default is null.</param>
        /// <returns>A new instance of <see cref="AstLeafNode"/>.</returns>
        public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text, 
            string? trailingTrivia, SourcePosition position, IAstBranchNode? parent = null)
        {
            ValidateString(text);
            ValidateSourcePosition(position);
            return _createLeafNode(leaftype, text, null, trailingTrivia, position, parent);
        }

        /// <summary>
        /// Creates a leaf node with the specified type, text, leading and trailing trivia, position, and optional parent node.
        /// </summary>
        /// <param name="leaftype">The type of the leaf node.</param>
        /// <param name="text">The text content of the leaf node.</param>
        /// <param name="leadingTrivia">The leading trivia of the leaf node.</param>
        /// <param name="trailingTrivia">The trailing trivia of the leaf node.</param>
        /// <param name="position">The source position of the leaf node.</param>
        /// <param name="parent">The parent node of the leaf node, if any. Default is null.</param>
        /// <returns>A new instance of <see cref="AstLeafNode"/>.</returns>
        public static AstLeafNode CreateLeafNode(AstLeafType leaftype, string text,
            string? leadingTrivia, string? trailingTrivia,
            SourcePosition position, IAstBranchNode? parent = null)
        {
            if (trailingTrivia == null && leadingTrivia == null)
            {
                return CreateLeafNode(leaftype, text, position, parent);
            }
            else if (leadingTrivia == null)
            {
                return CreateLeafNode(leaftype, text, trailingTrivia!, position, parent);
            }

            ValidateString(text);
            ValidateSourcePosition(position);
            return _createLeafNode(leaftype, text, leadingTrivia, trailingTrivia, position, parent);
        }



        /// <summary>
        /// Helper method to create a leaf node with the specified properties.
        /// </summary>
        /// <param name="leaftype">The type of the leaf node.</param>
        /// <param name="text">The text content of the leaf node.</param>
        /// <param name="leadTrivia">The leading trivia of the leaf node.</param>
        /// <param name="trailTrivia">The trailing trivia of the leaf node.</param>
        /// <param name="position">The source position of the leaf node.</param>
        /// <param name="parent">The parent node of the leaf node.</param>
        /// <returns>A new instance of <see cref="AstLeafNode"/>.</returns>
        static AstLeafNode _createLeafNode(AstLeafType leaftype, 
            string text, string? leadTrivia, string? trailTrivia, SourcePosition position, IAstBranchNode? parent)
        {
            AstLeafNode leaf = new AstLeafNode();

            leaf.LeafType = leaftype;
            leaf.Text = text;
            leaf.LeadingTrivia = leadTrivia;
            leaf.TrailingTrivia = trailTrivia;

            leaf.Position = position;
            leaf.Parent = parent;

            return leaf;
        }
    }
}
