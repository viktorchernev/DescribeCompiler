using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DescribeParser.Ast
{
    public static partial class AstFactory
    {
        private static void ValidateAstNode(AstNode node)
        {
            ArgumentNullException.ThrowIfNull(node, nameof(node));
        }

        private static void ValidateAstBranchNode(IAstBranchNode node)
        {
            ArgumentNullException.ThrowIfNull(node, nameof(node));
        }
        private static void ValidateAstBranchNodeP(IAstBranchNode node)
        {
            ArgumentNullException.ThrowIfNull(node, nameof(node));
            ArgumentNullException.ThrowIfNull(node.Leafs, $"{nameof(node)}.{nameof(node.Leafs)}");
            ArgumentNullException.ThrowIfNull(node.Children, $"{nameof(node)}.{nameof(node.Children)}");

            foreach (var leaf in node.Leafs)
            {
                ArgumentNullException.ThrowIfNull(leaf, $"{nameof(leaf)} element");
            }
            foreach (var child in node.Children)
            {
                ArgumentNullException.ThrowIfNull(child, $"{nameof(child)} element");
            }
        }

        private static void ValidateAstChildNode(IAstChildNode node)
        {
            ArgumentNullException.ThrowIfNull(node, nameof(node));
        }
        private static void ValidateAstChildNodeP(IAstChildNode node)
        {
            ArgumentNullException.ThrowIfNull(node, nameof(node));
            ArgumentNullException.ThrowIfNull(node.Position, $"{nameof(node)}.{nameof(node.Position)}");
        }

        private static void ValidateSourcePosition(SourcePosition position)
        {
            ArgumentNullException.ThrowIfNull(position, nameof(position));
        }
        private static void ValidateSourcePositionP(SourcePosition position)
        {
            ArgumentNullException.ThrowIfNull(position, nameof(position));
            ArgumentNullException.ThrowIfNull(position.FirstColumn, $"{nameof(position)}.{nameof(position.FirstColumn)}");
            ArgumentNullException.ThrowIfNull(position.FirstIndex, $"{nameof(position)}.{nameof(position.FirstIndex)}");
            ArgumentNullException.ThrowIfNull(position.FirstLine, $"{nameof(position)}.{nameof(position.FirstLine)}");
            ArgumentNullException.ThrowIfNull(position.LastColumn, $"{nameof(position)}.{nameof(position.LastColumn)}");
            ArgumentNullException.ThrowIfNull(position.LastIndex, $"{nameof(position)}.{nameof(position.LastIndex)}");
            ArgumentNullException.ThrowIfNull(position.LastLine, $"{nameof(position)}.{nameof(position.LastLine)}");
        }
        private static void ValidateSourcePositionList(IEnumerable<SourcePosition> positions)
        {
            ArgumentNullException.ThrowIfNull(positions, nameof(positions));
        }
        private static void ValidateSourcePositionListP(IEnumerable<SourcePosition> positions)
        {
            ArgumentNullException.ThrowIfNull(positions, nameof(positions));

            foreach (var pos in positions)
            {
                ArgumentNullException.ThrowIfNull(pos, $"{nameof(positions)} element");
                ArgumentNullException.ThrowIfNull(pos.FirstColumn, $"{nameof(pos)}.{nameof(pos.FirstColumn)}");
                ArgumentNullException.ThrowIfNull(pos.FirstIndex, $"{nameof(pos)}.{nameof(pos.FirstIndex)}");
                ArgumentNullException.ThrowIfNull(pos.FirstLine, $"{nameof(pos)}.{nameof(pos.FirstLine)}");
                ArgumentNullException.ThrowIfNull(pos.LastColumn, $"{nameof(pos)}.{nameof(pos.LastColumn)}");
                ArgumentNullException.ThrowIfNull(pos.LastIndex, $"{nameof(pos)}.{nameof(pos.LastIndex)}");
                ArgumentNullException.ThrowIfNull(pos.LastLine, $"{nameof(pos)}.{nameof(pos.LastLine)}");
            }
        }

        private static void ValidateAstNodeListP(IEnumerable<IAstChildNode> nodes)
        {
            ArgumentNullException.ThrowIfNull(nodes, nameof(nodes));

            foreach (var node in nodes)
            {
                ArgumentNullException.ThrowIfNull(node, $"{nameof(nodes)} element");
                ArgumentNullException.ThrowIfNull(node.Position, $"{nameof(nodes)} element.{nameof(node.Position)}");
            }
        }

        private static void ValidateString(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text), "The string cannot be null.");
            }
        }
    }
}
