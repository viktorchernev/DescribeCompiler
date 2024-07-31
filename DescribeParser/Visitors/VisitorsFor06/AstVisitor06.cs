using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Visitors
{
    /// <summary>
    /// An Ast visitor for Describe Language version 0.6
    /// Used to build Abstract Syntax Trees.
    /// </summary>
    public class AstVisitor06
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public AstVisitor06()
        {
            _log = "";
            _lerror = null;
        }

        string _log;
        string? _lerror;

        /// <summary>
        /// Gets or sets all the logs for this instance.
        /// </summary>
        public string Log
        {
            get
            {
                return _log;
            }
            set
            {
                Validators.ValidateString(value);
                _log = value;
            }
        }

        /// <summary>
        /// Gets the last error for this instance. 
        /// If there was an error, this string contains the message, 
        /// and if there weren't any errors, this will be `null`.
        /// </summary>
        public string? LastError
        {
            get
            {
                return _lerror;
            }
            set
            {
                _lerror = value;
            }
        }



        /// <summary>
        /// Translate ANTLR4 parser parse tree (root ScriptureContext context) to an Abstract Syntax Tree.
        /// "scripture : expression_list EOF | expression EOF;"
        /// </summary>
        /// <param name="context">Root context produced by the parser aka the parse tree</param>
        /// <param name="filename">The file name of the file that was parsed</param>
        /// <returns>The AstScriptureNode representing the syntax tree</returns>
        public AstScriptureNode TranslateScripture(Describe06Parser.ScriptureContext context, string filename = "")
        {
            List<AstExpressionNode> expressions = new List<AstExpressionNode>();
            IParseTree child = context.GetChild(0);
            if (child is Describe06Parser.ExpressionContext)
            {
                AstExpressionNode expr = DoExpression((child as Describe06Parser.ExpressionContext)!);
                expressions.Add(expr);
            }
            else if (child is Describe06Parser.Expression_listContext)
            {
                expressions = DoExpressionList((child as Describe06Parser.Expression_listContext)!);
            }
            else
            {
                throw new ArgumentException(
                    $"The first child of the provided ScriptureContext is not valid.",
                    nameof(child));
            }

            var scripture = AstFactory.CreateScriptureNode(filename, expressions, context.exception);
            return scripture;
        }



        /// <summary>
        /// Translate ANTLR4 parser expression_list to an Abstract Syntax Tree.
        /// "expression_list : expression+ expression;"
        /// </summary>
        private List<AstExpressionNode> DoExpressionList(Describe06Parser.Expression_listContext context)
        {
            int childCount = context.ChildCount;

            List<AstExpressionNode> list = new List<AstExpressionNode>();
            for (int i = 0; i < childCount; i++)
            {
                var child = context.GetChild(i) as Describe06Parser.ExpressionContext;
                if(child == null)
                {
                    throw new ArgumentException(
                    $"The child at index {i} of the provided Expression_listContext is not valid.",
                    nameof(child));
                }
                AstExpressionNode expression = DoExpression(child);
                list.Add(expression);
            }

            return list;
        }

        /// <summary>
        /// Translate ANTLR4 parser expression to Unfold structure.
        /// "expression : item producer item_or_expression_list TERMINATOR"
        /// "expression : item producer item TERMINATOR"
        /// "expression : item producer expression TERMINATOR"
        /// "expression : item producer TERMINATOR ;"
        /// </summary>
        private AstExpressionNode DoExpression(Describe06Parser.ExpressionContext context)
        {
            // sanity check
            int childCount = context.ChildCount;
            if (childCount < 3) throw new Exception("Expression is invalid");

            // get title item
            var firstChild = context.GetChild(0) as Describe06Parser.ItemContext;
            if (firstChild == null)
            {
                throw new ArgumentException(
                $"The first child of the provided ExpressionContext is not valid.",
                nameof(firstChild));
            }
            AstItemNode head = DoItem(firstChild);

            // get arrow leaf
            var secondChild = context.GetChild(1) as Describe06Parser.ProducerContext;
            if (secondChild == null)
            {
                throw new ArgumentException(
                    $"The second child of the provided ExpressionContext is not valid.",
                    nameof(secondChild));
            }
            AstLeafNode arrow = doProductionArrow(secondChild);

            // get lines
            List<AstExpressionLineNode> lines = new List<AstExpressionLineNode>();
            var nextChild = context.GetChild(2);
            if (nextChild is ITerminalNode)
            {
                var token = nextChild as ITerminalNode;
                AstLeafNode terminatorLeaf = doLeaf(token!);
                AstExpressionLineNode line = AstFactory.CreateExpressionLineNode(null, terminatorLeaf);
                lines.Add(line);
            }
            else if (nextChild is Describe06Parser.ItemContext)
            {
                var ctxt = nextChild as Describe06Parser.ItemContext;
                AstItemNode item = DoItem(ctxt!);

                var token = context.GetChild(3) as ITerminalNode;
                if(token == null)
                {
                    throw new ArgumentException(
                        $"The third child of the provided ExpressionContext is not valid.",
                        nameof(secondChild));
                }
                AstLeafNode terminatorLeaf = doLeaf(token);

                AstExpressionLineNode line = AstFactory.CreateExpressionLineNode(item, terminatorLeaf);
                lines.Add(line);
            }
            else if (nextChild is Describe06Parser.ExpressionContext)
            {
                var ctxt = nextChild as Describe06Parser.ExpressionContext;
                AstExpressionNode expression = DoExpression(ctxt!);

                var token = context.GetChild(3) as ITerminalNode;
                if (token == null)
                {
                    throw new ArgumentException(
                        $"The third child of the provided ExpressionContext is not valid.",
                        nameof(secondChild));
                }
                AstLeafNode terminatorLeaf = doLeaf(token);

                AstExpressionLineNode line = AstFactory.CreateExpressionLineNode(expression, terminatorLeaf);
                lines.Add(line);
            }
            else if (nextChild is Describe06Parser.Item_or_expression_listContext)
            {
                var ctxt = nextChild as Describe06Parser.Item_or_expression_listContext;
                List<AstExpressionLineNode> expressionLines = DoItemOrExpressionList(ctxt!);

                var token = context.GetChild(3) as ITerminalNode;
                if (token == null)
                {
                    throw new ArgumentException(
                        $"The third child of the provided ExpressionContext is not valid.",
                        nameof(secondChild));
                }
                AstLeafNode terminatorLeaf = doLeaf(token);

                expressionLines[expressionLines.Count - 1].Punctuation = terminatorLeaf;
                lines = expressionLines;
            }

            AstExpressionNode result = AstFactory.CreateExpressionNode(head, arrow, lines);
            return result;
        }

        /// <summary>
        /// "item_or_expression_list : (item_or_expression_part)+ item"
        ///	"item_or_expression_list : (item_or_expression_part)+ expression ;"
        ///	"item_or_expression_part : item SEPARATOR"
        /// "item_or_expression_part : expression (SEPARATOR)? ;"
        /// </summary>
        private List<AstExpressionLineNode> DoItemOrExpressionList(Describe06Parser.Item_or_expression_listContext context)
        {
            int childCount = context.ChildCount;
            List<AstExpressionLineNode> lines = new List<AstExpressionLineNode>();
            for (int i = 0; i < childCount - 1; i++)
            {
                var ch = context.GetChild(i) as Describe06Parser.Item_or_expression_partContext;
                if (ch == null)
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided Item_or_expression_listContext is not valid.",
                        nameof(ch));
                }
                AstExpressionLineNode line = DoItemOrExpressionPart(ch);
                lines.Add(line);
            }

            //deal with last child
            var lastChild = context.GetChild(childCount - 1);
            if (lastChild is Describe06Parser.ItemContext)
            {
                var item = DoItem((lastChild as Describe06Parser.ItemContext)!);
                var line = AstFactory.CreateExpressionLineNode(item, null);
                lines.Add(line);
            }
            else if (lastChild is Describe06Parser.ExpressionContext)
            {
                var expression = DoExpression((lastChild as Describe06Parser.ExpressionContext)!);
                var line = AstFactory.CreateExpressionLineNode(expression, null);
                lines.Add(line);
            }

            //return
            return lines;
        }

        /// <summary>
        /// "item_or_expression_part : item SEPARATOR"
        /// "item_or_expression_part : expression (SEPARATOR)? ;"
        /// </summary>
        private AstExpressionLineNode DoItemOrExpressionPart(Describe06Parser.Item_or_expression_partContext context)
        {
            int childCount = context.ChildCount;
            var firstChild = context.GetChild(0);

            if(firstChild is Describe06Parser.ItemContext)
            {
                var item = DoItem((firstChild as Describe06Parser.ItemContext)!);

                var secondChild = context.GetChild(1);
                if (secondChild == null || secondChild is not ITerminalNode)
                {
                    throw new ArgumentException(
                        $"The second child of the provided Item_or_expression_partContext is not valid.",
                        nameof(firstChild));
                }
                var puncruation = doLeaf((secondChild as ITerminalNode)!);
                var line = AstFactory.CreateExpressionLineNode(item, puncruation);
                return line;
            }
            else if(firstChild is Describe06Parser.ExpressionContext)
            {
                var expression = DoExpression((firstChild as Describe06Parser.ExpressionContext)!);

                AstLeafNode? punctuation = null;
                if(childCount > 1)
                {
                    var secondChild = context.GetChild(1);
                    if (secondChild == null || secondChild is not ITerminalNode)
                    {
                        throw new ArgumentException(
                            $"The second child of the provided Item_or_expression_partContext is not valid.",
                            nameof(firstChild));
                    }
                    var puncruation = doLeaf((secondChild as ITerminalNode)!);
                }
                
                var line = AstFactory.CreateExpressionLineNode(expression, punctuation);
                return line;
            }
            else
            {
                throw new ArgumentException(
                    $"The first child of the provided Item_or_expression_partContext is not valid.",
                    nameof(firstChild));
            }
        }

        /// <summary>
        /// "item : (text_chunk)+ ;"
        /// </summary>
        private AstItemNode DoItem(Describe06Parser.ItemContext context)
        {
            int childCount = context.ChildCount;
            if (childCount < 1) throw new Exception("Item is empty");

            // get text
            string text = "";
            for (int i = 0; i < childCount; i++)
            {
                var child = context.GetChild(i) as Describe06Parser.Text_chunkContext;
                if(child == null)
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided ItemContext is not valid.",
                        nameof(context));
                }
                ITerminalNode? token = child.GetChild(0) as ITerminalNode;
                string? s = token?.GetText();
                text += s;
            }

            // get position
            var firstChild = context.GetChild(0) as Describe06Parser.Text_chunkContext;
            ITerminalNode? firstToken = firstChild?.GetChild(0) as ITerminalNode;
            var lastChild = context.GetChild(childCount - 1) as Describe06Parser.Text_chunkContext;
            ITerminalNode? lastToken = lastChild?.GetChild(0) as ITerminalNode;
            if(firstToken == null || lastToken == null)
            {
                throw new ArgumentException(
                    $"The provided ItemContext is not valid.",
                    nameof(context));
            }
            SourcePosition pos = doPosition(firstToken, lastToken);

            // get trivia
            string? ltrivia = doLeadingTrivia(text);
            string? rtrivia = doTrailingTrivia(text);
            text = text.Trim();

            // get the item
            AstLeafNode infochunk = AstFactory.CreateLeafNode(AstLeafType.Text, text, ltrivia, rtrivia, pos);
            AstItemNode item = AstFactory.CreateItemNode(infochunk);
            return item;
        }


        // do ProductionArrow Leaf
        private AstLeafNode doProductionArrow(Describe06Parser.ProducerContext context)
        {
            int childCount = context.ChildCount;
            if (childCount != 2) throw new Exception("Production arrow is invalid");

            // get tokens
            var hyphen = context.GetChild(0) as ITerminalNode;
            if (hyphen == null)
            {
                throw new ArgumentException(
                    $"The first child of provided ProducerContext is not valid.",
                    nameof(context));
            }
            var rarr = context.GetChild(1) as ITerminalNode;
            if (rarr == null)
            {
                throw new ArgumentException(
                    $"The second child of provided ProducerContext is not valid.",
                    nameof(context));
            }

            // get text
            string text_hyphen = hyphen.GetText();
            string text_rarr = rarr.GetText();
            string text = text_hyphen.TrimStart();
            text += text_rarr.TrimEnd();

            // get trivia
            string? ltrivia = doLeadingTrivia(text_hyphen);
            string? rtrivia = doTrailingTrivia(text_rarr);

            // get position
            SourcePosition pos = doPosition(hyphen, rarr);

            // get leaf
            AstLeafNode leaf = AstFactory.CreateLeafNode(AstLeafType.ProductionArrow, text, ltrivia, rtrivia, pos);
            return leaf;
        }


        // do Leaf
        private AstLeafNode doLeaf(ITerminalNode token)
        {
            // get leaf type
            string type = GetTokenType(token.Symbol.Type);
            AstLeafType leafType = AstLeafType.Unknown;

            // Try to predict the AstLeafType
            // However, in many cases this will not be correct, as we
            // do not translate a single token to a single leaf, and
            // we have no way of knowing the leaf node here, unless 
            // it is Terminator or Separator
            switch (type)
            {
                case "TERMINATOR":
                    leafType = AstLeafType.Terminator;
                    break;
                case "SEPARATOR":
                    leafType = AstLeafType.Separator;
                    break;
                default:
                    leafType = AstLeafType.Text;
                    break;
            }

            // get the rest
            string text = token.GetText();
            SourcePosition pos = doPosition(token);
            string? ltrivia = doLeadingTrivia(text);
            string? rtrivia = doTrailingTrivia(text);
            text = text.Trim();

            // get leaf
            AstLeafNode leaf = AstFactory.CreateLeafNode(leafType, text, ltrivia, rtrivia, pos);
            return leaf;
        }


        // do Position
        private SourcePosition doPosition(ITerminalNode firstToken, ITerminalNode lastToken)
        {
            int startIndex, startLine, startCol, endIndex, endLine, endCol;
            startIndex = startLine = startCol = -1;
            endIndex = endLine = endCol = -1;

            // first
            startIndex = firstToken.Symbol.StartIndex;
            startLine = firstToken.Symbol.Line;
            startCol = firstToken.Symbol.Column;

            // last
            string lastText = lastToken.GetText();
            endIndex = lastToken.Symbol.StopIndex;

            var newLines = lastText.Split('\n');
            var newLinesCount = newLines.Length - 1;
            endLine = lastToken.Symbol.Line + newLinesCount;

            if (newLinesCount == 0) endCol = lastToken.Symbol.Column + lastText.Length;
            else endCol = newLines[newLines.Length - 1].Length;

            return AstFactory.CreateSourcePosition(startIndex, startLine, startCol, endIndex, endLine, endCol);
        }
        private SourcePosition doPosition(ITerminalNode token)
        {
            int startIndex, startLine, startCol, endIndex, endLine, endCol;
            startIndex = startLine = startCol = -1;
            endIndex = endLine = endCol = -1;

            // first
            startIndex = token.Symbol.StartIndex;
            startLine = token.Symbol.Line;
            startCol = token.Symbol.Column;

            // last
            string lastText = token.GetText();
            endIndex = token.Symbol.StopIndex;

            var newLines = lastText.Split('\n');
            var newLinesCount = newLines.Length - 1;
            endLine = token.Symbol.Line + newLinesCount;

            if (newLinesCount == 0) endCol = token.Symbol.Column + lastText.Length;
            else endCol = newLines[newLines.Length - 1].Length;

            return AstFactory.CreateSourcePosition(startIndex, startLine, startCol, endIndex, endLine, endCol);
        }


        // do Trivia
        private string? doLeadingTrivia(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;

            int i = 0;
            while (i < text.Length && char.IsWhiteSpace(text[i])) i++;
            return text.Substring(0, i);
        }
        private string? doTrailingTrivia(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;

            int i = text.Length - 1;
            while (i >= 0 && char.IsWhiteSpace(text[i])) i--;
            return text.Substring(i + 1);
        }


        // static helpers
        static string GetTokenType(int tokenType)
        {
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
    }
}
