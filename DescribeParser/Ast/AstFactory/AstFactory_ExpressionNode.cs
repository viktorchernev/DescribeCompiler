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
        /// Creates an <see cref="AstExpressionNode"/> with the specified title item, production arrow, and a single line.
        /// </summary>
        /// <param name="titleItem">The title item of the expression node.</param>
        /// <param name="arrow">The production arrow of the expression node.</param>
        /// <param name="line">The single line of the expression node.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstExpressionNode"/> with the specified title item, production arrow, and a single line.</returns>
        public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow,
            AstExpressionLineNode line, IAstBranchNode? parent = null)
        {
            // null checks
            ValidateAstChildNodeP(titleItem);
            ValidateAstChildNodeP(arrow);
            ValidateAstChildNodeP(line);

            // code
            AstExpressionNode expression = new AstExpressionNode();

            expression.TitleItem = titleItem;
            expression.ProductionArrow = arrow;
            expression.Lines = new List<AstExpressionLineNode>() { line };
            expression.Parent = parent;
            expression.Position = CreateSourcePosition(titleItem.Position!, line.Position!);

            return expression;
        }

        /// <summary>
        /// Creates an <see cref="AstExpressionNode"/> with the specified title item, production arrow, and multiple lines.
        /// </summary>
        /// <param name="titleItem">The title item of the expression node.</param>
        /// <param name="arrow">The production arrow of the expression node.</param>
        /// <param name="lines">The list of lines for the expression node.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstExpressionNode"/> with the specified title item, production arrow, and multiple lines.</returns>
        public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow,
            List<AstExpressionLineNode> lines, IAstBranchNode? parent = null)
        {
            // null checks
            ValidateAstChildNodeP(titleItem);
            ValidateAstChildNodeP(arrow);
            ValidateAstNodeListP(lines);

            // code
            AstExpressionNode expression = new AstExpressionNode();

            expression.TitleItem = titleItem;
            expression.ProductionArrow = arrow;
            expression.Lines = lines;
            expression.Parent = parent;
            expression.Position = CreateSourcePosition(titleItem.Position!, lines[^1].Position!);

            return expression;
        }
    }
}
