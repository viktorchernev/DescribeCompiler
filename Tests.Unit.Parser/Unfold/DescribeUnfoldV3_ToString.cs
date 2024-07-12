using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Parser
{
    [TestFixture]
    public class DescribeUnfoldV3_ToString_Tests
    {
        private DescribeUnfoldV3 _describeUnfoldV3;


        [SetUp]
        public void Setup()
        {
            _describeUnfoldV3 = new DescribeUnfoldV3();
        }


        [Test]
        public void ToString_ShouldReturnExpectedString_WhenAllFieldsAreEmpty()
        {
            // Arrange
            string nl = Environment.NewLine;
            string ind = _describeUnfoldV3.INDENT;
            string expected = $"DescribeUnfold{nl}{nl}{ind}.AllFiles{nl}{ind}.ParsedFiles{nl}{ind}.FailedFiles{nl}{nl}{ind}.Ids{nl}{ind}.PrimaryProductions{nl}{ind}.Productions{nl}{ind}.Translations{nl}{ind}.Links{nl}{ind}.Decorators{nl}{ind}.Tildes{nl}{nl}{ind}.ProdidFile{nl}{ind}.ItemidFile{nl}";

            // Act
            string result = _describeUnfoldV3.ToString();

            // Assert
             Assert.AreEqual(expected, result);
        }

        [Test]
        public void ToString_ShouldReturnExpectedString_WhenFieldsArePopulated()
        {
            // Arrange
            _describeUnfoldV3.AllFiles.Add(1, "File1.txt");
            _describeUnfoldV3.ParsedFiles.Add(1);
            _describeUnfoldV3.FailedFiles.Add(2);
            _describeUnfoldV3.Ids.Add(1, "ID1");
            _describeUnfoldV3.PrimaryProductions.Add(3);
            _describeUnfoldV3.Productions.Add(1, new List<int> { 2, 3 });
            _describeUnfoldV3.Translations.Add(1, "Translation1");
            _describeUnfoldV3.Links.Add(1, new List<DescribeLink> { new DescribeLink { Url = "http://example.com" } });
            _describeUnfoldV3.Decorators.Add(1, new List<DescribeDecorator> { new DescribeDecorator { Name = "Dec1" } });
            _describeUnfoldV3.Tildes.Add(4, new List<int> { 5, 6 });
            _describeUnfoldV3.ItemidFile.Add(1, new List<int> { 2, 3 });
            _describeUnfoldV3.ProdidFile.Add(4, new List<int> { 5, 6 });

            string nl = Environment.NewLine;
            string ind = _describeUnfoldV3.INDENT;
            string expected =
                $"DescribeUnfold{nl}{nl}" +
                $"{ind}.AllFiles{nl}" +
                $"{ind}{ind}\"1\" \"File1.txt\"{nl}{nl}" +
                $"{ind}.ParsedFiles{nl}" +
                $"{ind}{ind}1 {nl}{nl}" +
                $"{ind}.FailedFiles{nl}" +
                $"{ind}{ind}2 {nl}{nl}{nl}" +
                $"{ind}.Ids{nl}" +
                $"{ind}{ind}\"1\" - \"ID1\"{nl}{nl}" +
                $"{ind}.PrimaryProductions{nl}" +
                $"{ind}{ind}\"3\" {nl}{nl}" +
                $"{ind}.Productions{nl}" +
                $"{ind}{ind}\"1\" -> \"2\", \"3\";{nl}{nl}" +
                $"{ind}.Translations{nl}" +
                $"{ind}{ind}\"1\" - \"Translation1\"{nl}{nl}" +
                $"{ind}.Links{nl}" +
                $"{ind}{ind}\"1\" - \"http://example.com\"{nl}{nl}" +
                $"{ind}.Decorators{nl}" +
                $"{ind}{ind}\"1\" - \"Dec1\"{nl}{nl}" +
                $"{ind}.Tildes{nl}" +
                $"{ind}{ind}\"4\" -> \"5\", \"6\";{nl}{nl}{nl}" +
                $"{ind}.ProdidFile{nl}" +
                $"{ind}{ind}\"4\" - \"5\"{nl}" +
                $"{ind}{ind}\"4\" - \"6\"{nl}{nl}" +
                $"{ind}.ItemidFile{nl}" +
                $"{ind}{ind}\"1\" - \"2\"{nl}" +
                $"{ind}{ind}\"1\" - \"3\"{nl}{nl}";

            // Act
            string result = _describeUnfoldV3.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
