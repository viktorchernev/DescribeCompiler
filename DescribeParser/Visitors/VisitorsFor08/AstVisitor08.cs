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
    /// An Ast visitor for Describe Language version 0.8
    /// Used to build Abstract Syntax Trees.
    /// </summary>
    public class AstVisitor08
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public AstVisitor08()
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
        public AstScriptureNode TranslateScripture(Describe08Parser.ScriptureContext context, string filename = "")
        {
            List<AstExpressionNode> expressions = new List<AstExpressionNode>();
            IParseTree child = context.GetChild(0);
            if (child is Describe08Parser.ExpressionContext)
            {
                AstExpressionNode expr = DoExpression((child as Describe08Parser.ExpressionContext)!);
                expressions.Add(expr);
            }
            else if (child is Describe08Parser.Expression_listContext)
            {
                expressions = DoExpressionList((child as Describe08Parser.Expression_listContext)!);
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
        private List<AstExpressionNode> DoExpressionList(Describe08Parser.Expression_listContext context)
        {
            int childCount = context.ChildCount;

            List<AstExpressionNode> list = new List<AstExpressionNode>();
            for (int i = 0; i < childCount; i++)
            {
                var child = context.GetChild(i) as Describe08Parser.ExpressionContext;
                if (child == null)
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
        private AstExpressionNode DoExpression(Describe08Parser.ExpressionContext context)
        {
            // sanity check
            int childCount = context.ChildCount;
            if (childCount < 3) throw new Exception("Expression is invalid");

            // get title item
            var firstChild = context.GetChild(0) as Describe08Parser.ItemContext;
            if (firstChild == null)
            {
                throw new ArgumentException(
                $"The first child of the provided ExpressionContext is not valid.",
                nameof(firstChild));
            }
            AstItemNode head = DoItem(firstChild);

            // get arrow leaf
            var secondChild = context.GetChild(1) as Describe08Parser.ProducerContext;
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
            else if (nextChild is Describe08Parser.ItemContext)
            {
                var ctxt = nextChild as Describe08Parser.ItemContext;
                AstItemNode item = DoItem(ctxt!);

                var token = context.GetChild(3) as ITerminalNode;
                if (token == null)
                {
                    throw new ArgumentException(
                        $"The third child of the provided ExpressionContext is not valid.",
                        nameof(secondChild));
                }
                AstLeafNode terminatorLeaf = doLeaf(token);

                AstExpressionLineNode line = AstFactory.CreateExpressionLineNode(item, terminatorLeaf);
                lines.Add(line);
            }
            else if (nextChild is Describe08Parser.ExpressionContext)
            {
                var ctxt = nextChild as Describe08Parser.ExpressionContext;
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
            else if (nextChild is Describe08Parser.Item_or_expression_listContext)
            {
                var ctxt = nextChild as Describe08Parser.Item_or_expression_listContext;
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
        private List<AstExpressionLineNode> DoItemOrExpressionList(Describe08Parser.Item_or_expression_listContext context)
        {
            int childCount = context.ChildCount;
            List<AstExpressionLineNode> lines = new List<AstExpressionLineNode>();
            for (int i = 0; i < childCount - 1; i++)
            {
                var ch = context.GetChild(i) as Describe08Parser.Item_or_expression_partContext;
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
            if (lastChild is Describe08Parser.ItemContext)
            {
                var item = DoItem((lastChild as Describe08Parser.ItemContext)!);
                var line = AstFactory.CreateExpressionLineNode(item, null);
                lines.Add(line);
            }
            else if (lastChild is Describe08Parser.ExpressionContext)
            {
                var expression = DoExpression((lastChild as Describe08Parser.ExpressionContext)!);
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
        private AstExpressionLineNode DoItemOrExpressionPart(Describe08Parser.Item_or_expression_partContext context)
        {
            int childCount = context.ChildCount;
            var firstChild = context.GetChild(0);

            if(firstChild is  Describe08Parser.ItemContext)
            {
                var item = DoItem((firstChild as Describe08Parser.ItemContext)!);

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
            else if(firstChild is Describe08Parser.ExpressionContext)
            {
                var expression = DoExpression((firstChild as Describe08Parser.ExpressionContext)!);

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
        /// "item : text_chunk+ TAG?"
        /// "item : text_chunk+ LINK+"
        /// "item : text_chunk+ LINK+ TAG"
        /// "item : text_chunk+ TAG LINK+ ;"
        /// </summary>
        private AstItemNode DoItem(Describe08Parser.ItemContext context)
        {
            int childCount = context.ChildCount;
            if (childCount < 1) throw new Exception("Item is empty");

            // for position
            ITerminalNode? firstToken = null;
            ITerminalNode? lastToken = null;

            // get text
            string text = "";
            AstTagNode? tag = null;
            List<AstLinkNode>? links = new List<AstLinkNode>();
            for (int i = 0; i < childCount; i++)
            {
                var cur = context.GetChild(i); if (cur == null)
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided ItemContext is null.",
                        nameof(cur));
                }
                else if (cur is Describe08Parser.Text_chunkContext)
                {
                    var child = (cur as Describe08Parser.Text_chunkContext)!;
                    ITerminalNode? token = child.GetChild(0) as ITerminalNode;
                    string? s = token?.GetText();
                    text += s;

                    if (firstToken == null)
                    {
                        firstToken = token;
                        lastToken = token;
                    }
                    else lastToken = token;
                }
                else if(cur is ITerminalNode)
                {
                    var token = (cur as ITerminalNode)!;
                    if (GetTokenType(token) == "TAG")
                    {
                        tag = doTag(token);
                    }
                    else if (GetTokenType(token) == "LINK")
                    {
                        AstLinkNode link = doLink(token);
                        links.Add(link);
                    }

                    if (firstToken == null)
                    {
                        firstToken = token;
                        lastToken = token;
                    }
                    else lastToken = token;
                }
                else
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided ItemContext is not valid.",
                        nameof(cur));
                }
            }
            if (links.Count == 0) links = null;

            // get position
            if (firstToken == null || lastToken == null)
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
            AstItemNode item = AstFactory.CreateItemNode(infochunk, tag, links);
            return item;
        }


        // do ProductionArrow Leaf
        private AstLeafNode doProductionArrow(Describe08Parser.ProducerContext context)
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
                    $"The first child of provided ProducerContext is not valid.",
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
        private AstLinkNode doLink(ITerminalNode token)
        {
            string text = token.GetText();

            int oindex = text.IndexOf('[');
            int cindex = text.IndexOf(']');

            if (oindex == -1 || cindex == -1 || cindex < oindex)
            {
                throw new ArgumentException("Invalid input string format in Link.");
            }

            //string open = text.Substring(0, oindex + 1);
            //string id = text.Substring(oindex + 1, cindex - oindex - 1);
            //string close = text.Substring(cindex, text.Length - cindex);

            AstLeafNode o = doLeaf(AstLeafType.OpenTag, token, 0, oindex + 1);
            AstLeafNode c = doLeaf(AstLeafType.CloseTag, token, cindex, text.Length - cindex);
            string inside = text.Substring(oindex + 1, cindex - oindex - 1);
            string[] sep = inside.Split('|');

            AstLeafNode url;
            AstLeafNode? title = null;
            AstLeafNode? letter = null;
            if (sep.Length == 1)
            {
                url = doLeaf(AstLeafType.Text, token, oindex + 1, cindex - oindex - 1);
            }
            else if (sep.Length == 2)
            {
                url = doLeaf(AstLeafType.Text, token, oindex + 1, sep[0].Length);
                title = doLeaf(AstLeafType.Text, token, oindex + 1 + sep[0].Length, sep[1].Length);
            }
            else if (sep.Length == 3)
            {
                url = doLeaf(AstLeafType.Text, token, oindex + 1, sep[0].Length);
                title = doLeaf(AstLeafType.Text, token, oindex + 1 + sep[0].Length, sep[1].Length);
                letter = doLeaf(AstLeafType.Text, token, oindex + 1 + sep[0].Length + sep[1].Length, sep[2].Length);
            }
            else if (sep.Length > 3)
            {
                int x = sep[2].Length;
                for (int i = 3; i < sep.Length; i++) x += sep[i].Length;
                url = doLeaf(AstLeafType.Text, token, oindex + 1, sep[0].Length);
                title = doLeaf(AstLeafType.Text, token, oindex + 1 + sep[0].Length, sep[1].Length);
                letter = doLeaf(AstLeafType.Text, token, oindex + 1 + sep[0].Length + sep[1].Length, x);
            }
            else
            {
                throw new ArgumentException(
                    $"The provided token is not valid.",
                    nameof(token));
            }

            AstLinkNode tag = AstFactory.CreateLinkNode(o, url, title, letter, c);
            return tag;
        }
        private AstTagNode doTag(ITerminalNode token)
        {
            string text = token.GetText();
            SourcePosition pos = doPosition(token);

            int oindex = text.IndexOf('<');
            int cindex = text.IndexOf('>');

            if (oindex == -1 || cindex == -1 || cindex < oindex)
            {
                throw new ArgumentException("Invalid input string format in Tag.");
            }

            //string open = text.Substring(0, oindex + 1);
            //string id = text.Substring(oindex + 1, cindex - oindex - 1);
            //string close = text.Substring(cindex, text.Length - cindex);

            AstLeafNode o = doLeaf(AstLeafType.OpenTag, token, 0, oindex + 1);
            AstLeafNode d = doLeaf(AstLeafType.Text, token, oindex + 1, cindex - oindex - 1);
            AstLeafNode c = doLeaf(AstLeafType.CloseTag, token, cindex, text.Length - cindex);

            AstTagNode tag = AstFactory.CreateTagNode(o, d, c);
            return tag;
        }
        private AstLeafNode doLeaf(AstLeafType type, ITerminalNode token, int startPos, int length)
        {
            // get the rest
            SourcePosition pos = doPosition(token, startPos, length);
            string text = token.GetText();
            text = text.Substring(startPos, length);
            string? ltrivia = doLeadingTrivia(text);
            string? rtrivia = doTrailingTrivia(text);
            text = text.Trim();

            // get leaf
            AstLeafNode leaf = AstFactory.CreateLeafNode(type, text, ltrivia, rtrivia, pos);
            return leaf;
        }
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
            if (lastToken == null) return doPosition(firstToken);

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
        private SourcePosition doPosition(ITerminalNode token, int startPos, int length)
        {
            int startIndex, startLine, startCol, endIndex, endLine, endCol;
            startIndex = startLine = startCol = -1;
            endIndex = endLine = endCol = -1;

            // text
            string tokenText = token.GetText();
            string subText = tokenText.Substring(startPos, length);

            // first
            startIndex = token.Symbol.StartIndex + startPos;

            // Calculate the start line and column by considering new lines before startPos
            string textBeforeStart = tokenText.Substring(0, startPos);
            string[] linesBeforeStart = textBeforeStart.Split('\n');
            startLine = token.Symbol.Line + linesBeforeStart.Length - 1;

            // column
            if (linesBeforeStart.Length > 1) 
                startCol = linesBeforeStart[linesBeforeStart.Length - 1].Length;
            else startCol = token.Symbol.Column + startPos;

            // last
            endIndex = startIndex + length - 1;

            // Calculate the end line and column by considering new lines within the subText
            string[] linesWithinSubText = subText.Split('\n');
            int newLinesCount = linesWithinSubText.Length - 1;
            endLine = startLine + newLinesCount;

            // column
            if (newLinesCount == 0)
            {
                // If there are no new lines in the substring
                endCol = startCol + length;
            }
            else
            {
                // If there are new lines, calculate the column of the last line
                endCol = linesWithinSubText[newLinesCount].Length;
            }

            // return
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
        static string GetTokenType(ITerminalNode token)
        {
            int type = token.Symbol.Type;
            return Describe07Lexer.DefaultVocabulary.GetSymbolicName(type);
        }
        static string GetTokenType(int tokenType)
        {
            return Describe07Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
    }
}
