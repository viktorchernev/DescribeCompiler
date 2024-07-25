using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Parser
{
    [TestFixture]
    public class DescribeLink_Tests
    {
        [Test]
        public void DescribeLink_DefaultValues_ShouldBeNull()
        {
            // Arrange
            var link = new DescribeLink();

            // Act & Assert
            Assert.IsNull(link.Url, "Url should be null by default");
            Assert.IsNull(link.Title, "Title should be null by default");
            Assert.IsNull(link.Letter, "Letter should be null by default");
        }

        [Test]
        public void DescribeLink_SetProperties_ShouldReturnExpectedValues()
        {
            // Arrange
            var link = new DescribeLink();
            var url = "https://example.com";
            var title = "Example";
            var letter = "A";

            // Act
            link.Url = url;
            link.Title = title;
            link.Letter = letter;

            // Assert
            Assert.AreEqual(url, link.Url, "Url should return the set value");
            Assert.AreEqual(title, link.Title, "Title should return the set value");
            Assert.AreEqual(letter, link.Letter, "Letter should return the set value");
        }
    }
}
