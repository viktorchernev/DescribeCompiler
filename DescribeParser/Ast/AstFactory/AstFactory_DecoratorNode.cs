using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    /// <summary>
    /// This is the Factorcy class used to produce AST objects.
    /// </summary>
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
            AstLeafNode open, AstLeafNode name, AstLeafNode close, IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(name);
            ValidateAstChildNodeP(close);

            AstSimpleDecoratorNode decorator = new AstSimpleDecoratorNode();

            decorator.DecoratorType = type;
            decorator.OpenBracket = open;
            decorator.Name = name;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position!, close.Position!);

            return decorator;
        }

        /// <summary>
        /// Creates an <see cref="AstSimpleDecoratorNode"/> with the specified open bracket, name, and close bracket.
        /// </summary>
        /// <param name="open">The open bracket node of the decorator.</param>
        /// <param name="name">The name node of the decorator.</param>
        /// <param name="close">The close bracket node of the decorator.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstSimpleDecoratorNode"/> with the specified type, open bracket, name, and close bracket.</returns>
        public static AstSimpleDecoratorNode CreateSimpleDecoratorNode(AstLeafNode open, 
            AstLeafNode name, AstLeafNode close, IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(name);
            ValidateAstChildNodeP(close);

            AstSimpleDecoratorNode decorator = new AstSimpleDecoratorNode();

            decorator.DecoratorType = getSimpleDecoratorType(name.Text);
            decorator.OpenBracket = open;
            decorator.Name = name;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position!, close.Position!);

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
            IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(name);
            ValidateAstChildNodeP(value);
            ValidateAstChildNodeP(close);

            AstDoubleDecoratorNode decorator = new AstDoubleDecoratorNode();

            decorator.DecoratorType = type;
            decorator.OpenBracket = open;
            decorator.Name = name;
            decorator.Value = value;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position!, close.Position!);

            return decorator;
        }

        /// <summary>
        /// Creates an <see cref="AstDoubleDecoratorNode"/> with the specified open bracket, name, value, and close bracket.
        /// </summary>
        /// <param name="open">The open bracket node of the decorator.</param>
        /// <param name="name">The name node of the decorator.</param>
        /// <param name="value">The value node of the decorator.</param>
        /// <param name="close">The close bracket node of the decorator.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstDoubleDecoratorNode"/> with the specified open bracket, name, value, and close bracket.</returns>
        public static AstDoubleDecoratorNode CreateDoubleDecoratorNode(AstLeafNode open, 
            AstLeafNode name, AstLeafNode value, AstLeafNode close, IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(name);
            ValidateAstChildNodeP(value);
            ValidateAstChildNodeP(close);

            AstDoubleDecoratorNode decorator = new AstDoubleDecoratorNode();

            decorator.DecoratorType = getDoubleDecoratorType(name.Text);
            decorator.OpenBracket = open;
            decorator.Name = name;
            decorator.Value = value;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position!, close.Position!);

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
            IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(category);
            ValidateAstChildNodeP(name);
            ValidateAstChildNodeP(value);
            ValidateAstChildNodeP(close);

            AstTripleDecoratorNode decorator = new AstTripleDecoratorNode();

            decorator.DecoratorType = type;
            decorator.OpenBracket = open;
            decorator.Category = category;
            decorator.Name = name;
            decorator.Value = value;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position!, close.Position!);

            return decorator;
        }

        /// <summary>
        /// Creates an <see cref="AstTripleDecoratorNode"/> with the specified open bracket, category, name, value, and close bracket.
        /// </summary>
        /// <param name="open">The open bracket node of the decorator.</param>
        /// <param name="category">The category node of the decorator.</param>
        /// <param name="name">The name node of the decorator.</param>
        /// <param name="value">The value node of the decorator.</param>
        /// <param name="close">The close bracket node of the decorator.</param>
        /// <param name="parent">The parent node, if any. Default is null.</param>
        /// <returns>An <see cref="AstTripleDecoratorNode"/> with the specified open bracket, category, name, value, and close bracket.</returns>
        public static AstTripleDecoratorNode CreateTripleDecoratorNode(AstLeafNode open, 
            AstLeafNode category, AstLeafNode name, AstLeafNode value, AstLeafNode close,
            IAstBranchNode? parent = null)
        {
            ValidateAstChildNodeP(open);
            ValidateAstChildNodeP(category);
            ValidateAstChildNodeP(name);
            ValidateAstChildNodeP(value);
            ValidateAstChildNodeP(close);

            AstTripleDecoratorNode decorator = new AstTripleDecoratorNode();

            decorator.DecoratorType = getTripleDecoratorType(name.Text); ;
            decorator.OpenBracket = open;
            decorator.Category = category;
            decorator.Name = name;
            decorator.Value = value;
            decorator.CloseBracket = close;
            decorator.Parent = parent;
            decorator.Position = CreateSourcePosition(open.Position!, close.Position!);

            return decorator;
        }



        static AstSimpleDecoratorType getSimpleDecoratorType(string text)
        {
            text = text.Trim().ToLower();
            switch (text)
            {
                case "empty": return AstSimpleDecoratorType.EmptyDecorator;
                case "comment": return AstSimpleDecoratorType.CommentDecorator;
                case "nlcomment": return AstSimpleDecoratorType.NlCommentDecorator;
                case "bold": return AstSimpleDecoratorType.BoldDecorator;
                case "italic": return AstSimpleDecoratorType.ItalicDecorator;
                case "underline": return AstSimpleDecoratorType.UnderlineDecorator;
                case "striked": return AstSimpleDecoratorType.StrikedDecorator;
            }

            return AstSimpleDecoratorType.Unknown;
        }
        static AstDoubleDecoratorType getDoubleDecoratorType(string text)
        {
            text = text.Trim().ToLower();
            switch (text)
            {
                case "color": return AstDoubleDecoratorType.ColorDecorator;
                case "bgcolor": return AstDoubleDecoratorType.BgColorDecorator;
                case "enlist": return AstDoubleDecoratorType.EnlistDecorator;
                case "custom": return AstDoubleDecoratorType.CustomDecorator;
            }

            return AstDoubleDecoratorType.Unknown;
        }
        static AstTripleDecoratorType getTripleDecoratorType(string text)
        {
            text = text.Trim().ToLower();
            switch (text)
            {
                case "custom": return AstTripleDecoratorType.CustomDoubleDecorator;
            }

            return AstTripleDecoratorType.Unknown;
        }
    }
}
