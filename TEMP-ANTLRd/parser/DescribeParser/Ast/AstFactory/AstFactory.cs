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
            IAstBranchNode parent = null)
        {
            AstTagNode tag = new AstTagNode();

            tag.OpenBracket = open;
            tag.Id = id;
            tag.CloseBracket = close;

            tag.Parent = parent;
            //calculate Position

            return tag;
        }



        // AstLinkNode
        /// <summary>
        /// Factory method to create instances of AstLinkNode.
        /// </summary>
        /// <param name="open">The open bracket of the Link object</param>
        /// <param name="url">The url of the Link object</param>
        /// <param name="close">The closing bracket of the Link object</param>
        /// <param name="parent">The parent item</param>
        /// <returns>New instance of AstLinkNode.</returns>
        public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode close,
            IAstBranchNode parent = null)
        {
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
        public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode title, 
            AstLeafNode close, IAstBranchNode parent = null)
        {
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
        public static AstLinkNode CreateLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode title,
            AstLeafNode letter, AstLeafNode close, IAstBranchNode parent = null)
        {
            return _createLinkNode(open, url, title, letter, close, parent);
        }

        static AstLinkNode _createLinkNode(AstLeafNode open, AstLeafNode url, AstLeafNode title,
            AstLeafNode letter, AstLeafNode close, IAstBranchNode parent = null)
        {
            AstLinkNode link = new AstLinkNode();

            link.OpenBracket = open;
            link.Url = url;
            link.Title = title;
            link.Letter = letter;
            link.CloseBracket = close;

            link.Parent = parent;
            //calculate Position

            return link;
        }



        // AstDecoratorNode
        public static AstSimpleDecoratorNode CreateSimpleDecoratorNode(AstSimpleDecoratorType type, 
            AstLeafNode open, AstLeafNode name, AstLeafNode close, IAstBranchNode parent = null)
        {
            AstSimpleDecoratorNode decorator = new AstSimpleDecoratorNode();

            decorator.DecoratorType = type;
            decorator.OpenBracket = open;
            decorator.Name = name;
            decorator.CloseBracket = close;
            decorator.Parent = parent;

            //calculate position

            return decorator;
        }

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

            //calculate position

            return decorator;
        }

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

            //calculate position

            return decorator;
        }



        // AstItemNode
        public static AstItemNode CreateItemNode(AstLeafNode text,
            IAstBranchNode parent = null)
        {
            AstItemNode item = new AstItemNode();

            item.Tilde = null;
            item.Text = text; text.Parent = item;
            item.Tag = null;
            item.Links = null;
            item.Decorators = null;
            item.Parent = parent;

            item.Position = CreateSourcePosition(text.Position);

            return item;
        }

        public static AstItemNode CreateItemNode(AstLeafNode text, AstTagNode Tag,
            List<AstLinkNode> links, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
        {
            AstItemNode item = new AstItemNode();

            item.Tilde = null;
            item.Text = text;
            item.Tag = Tag;
            item.Links = links;
            item.Decorators = decorators;
            item.Parent = parent;
            //calculate position

            return item;
        }

        public static AstItemNode CreateItemNode(AstLeafNode tilde, AstLeafNode text, AstTagNode Tag,
            List<AstLinkNode> links, List<AstDecoratorNode> decorators,
            IAstBranchNode parent = null)
        {
            AstItemNode item = new AstItemNode();

            item.Tilde = tilde;
            item.Text = text;
            item.Tag = Tag;
            item.Links = links;
            item.Decorators = decorators;
            item.Parent = parent;
            //calculate position

            return item;
        }



        // AstExpressionNode
        public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow,
            AstExpressionLineNode line, IAstBranchNode parent = null)
        {
            AstExpressionNode expression = new AstExpressionNode();

            expression.TitleItem = titleItem;
            expression.ProductionArrow = arrow;
            expression.Lines = new List<AstExpressionLineNode>() { line };
            expression.Parent = parent;
            //calculate position

            return expression;
        }

        public static AstExpressionNode CreateExpressionNode(AstItemNode titleItem, AstLeafNode arrow,
            List<AstExpressionLineNode> lines, IAstBranchNode parent = null)
        {
            AstExpressionNode expression = new AstExpressionNode();

            expression.TitleItem = titleItem;
            expression.ProductionArrow = arrow;
            expression.Lines = lines;
            expression.Parent = parent;
            //calculate position

            return expression;
        }

        public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body,
            IAstBranchNode parent = null)
        {
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = body;
            line.Punctuation = null;

            return line;
        }

        public static AstExpressionLineNode CreateExpressionLineNode(AstLeafNode punctoation,
            IAstBranchNode parent = null)
        {
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = null;
            line.Punctuation = punctoation;

            return line;
        }

        public static AstExpressionLineNode CreateExpressionLineNode(IAstBranchNode body, 
            AstLeafNode punctoation, IAstBranchNode parent = null)
        {
            AstExpressionLineNode line = new AstExpressionLineNode();

            line.Body = body;
            line.Punctuation = punctoation;

            return line;
        }



        // AstScriptureNode
        public static AstScriptureNode CreateScriptureNode(List<AstExpressionNode> expressions,
            Exception exception = null)
        {
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = null;
            scripture.Namespace = null;
            scripture.Expressions = expressions;
            scripture.Exception = exception;

            return scripture;
        }

        public static AstScriptureNode CreateScriptureNode(AstExpressionNode expression,
            Exception exception = null)
        {
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = null;
            scripture.Namespace = null;
            scripture.Expressions = new List<AstExpressionNode>() { expression };
            scripture.Exception = exception;

            return scripture;
        }

        public static AstScriptureNode CreateScriptureNode(string filename, 
            List<AstExpressionNode> expressions, Exception exception = null)
        {
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = null;
            scripture.Expressions = expressions;
            scripture.Exception = exception;

            return scripture;
        }

        public static AstScriptureNode CreateScriptureNode(string filename, 
            AstExpressionNode expression, Exception exception = null)
        {
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = null;
            scripture.Expressions = new List<AstExpressionNode>() { expression };
            scripture.Exception = exception;

            return scripture;
        }

        public static AstScriptureNode CreateScriptureNode(string filename, string namespaceName,
            List<AstExpressionNode> expressions, Exception exception = null)
        {
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = namespaceName;
            scripture.Expressions = expressions;
            scripture.Exception = exception;

            return scripture;
        }

        public static AstScriptureNode CreateScriptureNode(string filename, string namespaceName,
            AstExpressionNode expression, Exception exception = null)
        {
            AstScriptureNode scripture = new AstScriptureNode();

            scripture.FileName = filename;
            scripture.Namespace = namespaceName;
            scripture.Expressions = new List<AstExpressionNode>() { expression };
            scripture.Exception = exception;

            return scripture;
        }
    }
}
