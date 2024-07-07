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
        /// Creates an <see cref="AstExpressionLineNode"/> with the specified body.
        /// </summary>
        /// <param name="body">The body of the expression line node.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstExpressionLineNode"/> with the specified body.</returns>
        public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body,
            IAstBranchNode parent = null)
        {
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = body;
            line.Punctuation = null;
            line.Position = CreateSourcePosition((body as IAstChildNode).Position);

            return line;
        }

        /// <summary>
        /// Creates an <see cref="AstExpressionLineNode"/> with the specified punctuation.
        /// </summary>
        /// <param name="punctoation">The punctuation of the expression line node.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstExpressionLineNode"/> with the specified punctuation.</returns>
        public static AstExpressionLineNode CreateExpressionLineNode(AstLeafNode punctoation,
            IAstBranchNode parent = null)
        {
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = null;
            line.Punctuation = punctoation;
            line.Position = CreateSourcePosition(punctoation.Position);

            return line;
        }

        /// <summary>
        /// Creates an <see cref="AstExpressionLineNode"/> with the specified body and punctuation.
        /// </summary>
        /// <param name="body">The body of the expression line node.</param>
        /// <param name="punctoation">The punctuation of the expression line node.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstExpressionLineNode"/> with the specified body and punctuation.</returns>
        public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body, 
            AstLeafNode punctoation, IAstBranchNode parent = null)
        {
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = body;
            line.Punctuation = punctoation;
            line.Position = CreateSourcePosition((body as IAstChildNode).Position, punctoation.Position);

            return line;
        }
    }
}
