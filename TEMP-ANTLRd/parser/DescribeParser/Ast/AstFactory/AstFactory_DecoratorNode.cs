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
        /// Creates an <see cref="AstSimpleDecoratorNode"/> with the specified type, open bracket, name, and close bracket.
        /// </summary>
        /// <param name="type">The type of the simple decorator.</param>
        /// <param name="open">The open bracket node of the decorator.</param>
        /// <param name="name">The name node of the decorator.</param>
        /// <param name="close">The close bracket node of the decorator.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstSimpleDecoratorNode"/> with the specified type, open bracket, name, and close bracket.</returns>
        public static AstSimpleDecoratorNode CreateSimpleDecoratorNode(AstSimpleDecoratorType type, 
            AstLeafNode open, AstLeafNode name, AstLeafNode close, IAstBranchNode parent = null)
        {
            AstSimpleDecoratorNode decorator = new AstSimpleDecoratorNode();

            decorator.DecoratorType = type;
            decorator.OpenBracket = open;
            decorator.Name = name;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position, close.Position);

            return decorator;
        }

        /// <summary>
        /// Creates an <see cref="AstDoubleDecoratorNode"/> with the specified type, open bracket, name, value, and close bracket.
        /// </summary>
        /// <param name="type">The type of the double decorator.</param>
        /// <param name="open">The open bracket node of the decorator.</param>
        /// <param name="name">The name node of the decorator.</param>
        /// <param name="value">The value node of the decorator.</param>
        /// <param name="close">The close bracket node of the decorator.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstDoubleDecoratorNode"/> with the specified type, open bracket, name, value, and close bracket.</returns>
        public static AstDoubleDecoratorNode CreateDoubleDecoratorNode(AstDoubleDecoratorType type,
            AstLeafNode open, AstLeafNode name, AstLeafNode value, AstLeafNode close, 
            IAstBranchNode parent = null)
        {
            AstDoubleDecoratorNode decorator = new AstDoubleDecoratorNode();

            decorator.DecoratorType = type;
            decorator.OpenBracket = open;
            decorator.Name = name;
            decorator.Value = value;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position, close.Position);

            return decorator;
        }

        /// <summary>
        /// Creates an <see cref="AstTripleDecoratorNode"/> with the specified type, open bracket, category, name, value, and close bracket.
        /// </summary>
        /// <param name="type">The type of the triple decorator.</param>
        /// <param name="open">The open bracket node of the decorator.</param>
        /// <param name="category">The category node of the decorator.</param>
        /// <param name="name">The name node of the decorator.</param>
        /// <param name="value">The value node of the decorator.</param>
        /// <param name="close">The close bracket node of the decorator.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstTripleDecoratorNode"/> with the specified type, open bracket, category, name, value, and close bracket.</returns>
        public static AstTripleDecoratorNode CreateTripleDecoratorNode(AstTripleDecoratorType type,
            AstLeafNode open, AstLeafNode category, AstLeafNode name, AstLeafNode value, AstLeafNode close,
            IAstBranchNode parent = null)
        {
            AstTripleDecoratorNode decorator = new AstTripleDecoratorNode();

            decorator.DecoratorType = type;
            decorator.OpenBracket = open;
            decorator.Category = category;
            decorator.Name = name;
            decorator.Value = value;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position, close.Position);

            return decorator;
        }
    }
}
