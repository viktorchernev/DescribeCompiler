using DescribeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Parser
{
    [TestFixture]
    public class DescribeParseJob_Tests
    {
        [Test]
        public void DescribeParseJob_DefaultValues_ShouldBeNull()
        {
            // Arrange
            var parseJob = new SimpleParseJob();

            // Act & Assert
            Assert.IsNull(parseJob.InitialDir, "InitialDir should be null by default");
            Assert.IsNull(parseJob.LastNamespace, "LastNamespace should be null by default");
            Assert.IsNull(parseJob.LastFile, "LastFile should be null by default");
        }

        [Test]
        public void DescribeParseJob_SetProperties_ShouldReturnExpectedValues()
        {
            // Arrange
            var parseJob = new SimpleParseJob();
            var initialDir = "C:\\Start";
            var lastNamespace = "MyNamespace";
            var lastFile = "MyFile.cs";

            // Act
            parseJob.InitialDir = initialDir;
            parseJob.LastNamespace = lastNamespace;
            parseJob.LastFile = lastFile;

            // Assert
            Assert.AreEqual(initialDir, parseJob.InitialDir, "InitialDir should return the set value");
            Assert.AreEqual(lastNamespace, parseJob.LastNamespace, "LastNamespace should return the set value");
            Assert.AreEqual(lastFile, parseJob.LastFile, "LastFile should return the set value");
        }
    }
}
