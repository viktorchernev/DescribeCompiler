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
        public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchChildNode body,
            IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(body);

            // code
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = body;
            line.Punctuation = null;
            line.Position = CreateSourcePosition(body.Position!);
            line.Parent = parent;

            return line;
        }

        /// <summary>
        /// Creates an <see cref="AstExpressionLineNode"/> with the specified punctuation.
        /// </summary>
        /// <param name="punctuation">The punctuation of the expression line node.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstExpressionLineNode"/> with the specified punctuation.</returns>
        public static AstExpressionLineNode CreateExpressionLineNode(AstLeafNode punctuation,
            IAstBranchNode? parent = null)
        {
            // Null checks
            ValidateAstChildNodeP(punctuation);

            // code
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = null;
            line.Punctuation = punctuation;
            line.Position = CreateSourcePosition(punctuation.Position!);
            line.Parent = parent;

            return line;
        }

        /// <summary>
        /// Creates an <see cref="AstExpressionLineNode"/> with the specified body and punctuation.
        /// </summary>
        /// <param name="body">The body of the expression line node.</param>
        /// <param name="punctuation">The punctuation of the expression line node.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstExpressionLineNode"/> with the specified body and punctuation.</returns>
        public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchChildNode? body, 
            AstLeafNode? punctuation, IAstBranchNode? parent = null)
        {
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = body;
            line.Punctuation = punctuation;
            line.Parent = parent;

            if(body != null && punctuation != null)
            {
                ValidateSourcePosition(punctuation.Position!);
                ValidateSourcePosition(body.Position!);
                line.Position = CreateSourcePosition(body.Position!, punctuation.Position!);
            }
            else if(body != null)
            {
                ValidateSourcePosition(body.Position!);
                line.Position = CreateSourcePosition(body.Position!);
            }
            else if (punctuation != null)
            {
                ValidateSourcePosition(punctuation.Position!);
                line.Position = CreateSourcePosition(punctuation.Position!);
            }
            else
            {
                throw new ArgumentException("Both 'body' and 'punctuation' cannot be null.");
            }

            return line;
        }
    }
}
