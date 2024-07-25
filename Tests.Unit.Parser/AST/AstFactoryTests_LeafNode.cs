using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Parser.AST
{
    [TestFixture]
    public class AstFactoryTests_LeafNode
    {
        [Test]
        public void CreateLeafNode_WithBasicParameters_CreatesLeafNode()
        {
            // Arrange
            var leaftype = AstLeafType.Text; // Assuming you have an enum AstLeafType with a value Text
            var text = "sample text";
            var position = AstFactory.CreateSourcePosition(0, 1, 0, 11, 1, 11);

            // Act
            var leafNode = AstFactory.CreateLeafNode(leaftype, text, position);

            // Assert
            Assert.NotNull(leafNode);
            Assert.AreEqual(leaftype, leafNode.LeafType);
            Assert.AreEqual(text, leafNode.Text);
            Assert.AreEqual(position, leafNode.Position);
            Assert.IsNull(leafNode.LeadingTrivia);
            Assert.IsNull(leafNode.TrailingTrivia);
            Assert.IsNull(leafNode.Parent);
        }

        [Test]
        public void CreateLeafNode_WithTrailingTrivia_CreatesLeafNode()
        {
            // Arrange
            var leaftype = AstLeafType.Text;
            var text = "sample text";
            var trailingTrivia = " ";
            var position = AstFactory.CreateSourcePosition(0, 1, 0, 11, 1, 11);

            // Act
            var leafNode = AstFactory.CreateLeafNode(leaftype, text, trailingTrivia, position);

            // Assert
            Assert.NotNull(leafNode);
            Assert.AreEqual(leaftype, leafNode.LeafType);
            Assert.AreEqual(text, leafNode.Text);
            Assert.AreEqual(position, leafNode.Position);
            Assert.IsNull(leafNode.LeadingTrivia);
            Assert.AreEqual(trailingTrivia, leafNode.TrailingTrivia);
            Assert.IsNull(leafNode.Parent);
        }

        [Test]
        public void CreateLeafNode_WithLeadingAndTrailingTrivia_CreatesLeafNode()
        {
            // Arrange
            var leaftype = AstLeafType.Text;
            var text = "sample text";
            var leadingTrivia = "\n";
            var trailingTrivia = " ";
            var position = AstFactory.CreateSourcePosition(0, 1, 0, 11, 1, 11);

            // Act
            var leafNode = AstFactory.CreateLeafNode(leaftype, text, leadingTrivia, trailingTrivia, position);

            // Assert
            Assert.NotNull(leafNode);
            Assert.AreEqual(leaftype, leafNode.LeafType);
            Assert.AreEqual(text, leafNode.Text);
            Assert.AreEqual(position, leafNode.Position);
            Assert.AreEqual(leadingTrivia, leafNode.LeadingTrivia);
            Assert.AreEqual(trailingTrivia, leafNode.TrailingTrivia);
            Assert.IsNull(leafNode.Parent);
        }

        //CreateLeafNode_WithParentNode_CreatesLeafNode()
        //same as above but with a parent
    }
}
