using DescribeParser.Unfold;
using DescribeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Parser
{
    [TestFixture]
    public class DescribeUnfold_AddEntry_Tests
    {
        [Test]
        public void DescribeUnfold_Constructor_ShouldInitializeProperties()
        {
            // Arrange & Act
            var unfold = new DescribeUnfold();

            // Assert
            Assert.IsNotNull(unfold.ParseJob, "ParseJob should be initialized.");
            Assert.IsNotNull(unfold.AllFiles, "AllFiles should be initialized.");
            Assert.IsNotNull(unfold.ParsedFiles, "ParsedFiles should be initialized.");
            Assert.IsNotNull(unfold.FailedFiles, "FailedFiles should be initialized.");
            Assert.IsNotNull(unfold.PrimaryProductions, "PrimaryProductions should be initialized.");
            Assert.IsNotNull(unfold.Productions, "Productions should be initialized.");
            Assert.IsNotNull(unfold.Tildes, "Tildes should be initialized.");
            Assert.IsNotNull(unfold.Translations, "Translations should be initialized.");
            Assert.IsNotNull(unfold.Links, "Links should be initialized.");
            Assert.IsNotNull(unfold.Decorators, "Decorators should be initialized.");
            Assert.IsNotNull(unfold.ItemidFile, "ItemidFile should be initialized.");
            Assert.IsNotNull(unfold.ProdidFile, "ProdidFile should be initialized.");
        }

        [Test]
        public void DescribeUnfold_SetAndGetProperties_ShouldWorkCorrectly()
        {
            // Arrange
            var unfold = new DescribeUnfold();

            var testJob = new SimpleParseJob { InitialDir = "C:\\Test" };
            var testAllFiles = new List<string> { "file1.txt", "file2.txt" };
            var testParsedFiles = new List<string> { "file1.txt" };
            var testFailedFiles = new List<string> { "file2.txt" };
            var testPrimaryProductions = new List<string> { "prod1", "prod2" };
            var testProductions = new Dictionary<string, List<string>> { { "prod1", new List<string> { "item1" } } };
            var testTildes = new Dictionary<string, List<string>> { { "tilde1", new List<string> { "item2" } } };
            var testTranslations = new Dictionary<string, string> { { "item1", "translation1" } };
            var testLinks = new Dictionary<string, List<DescribeLink>>
            {
                { "item1", new List<DescribeLink> { new DescribeLink { Url = "http://example.com" } } }
            };
            var testDecorators = new Dictionary<string, List<DescribeDecorator>>
            {
                { "item1", new List<DescribeDecorator> { new DescribeDecorator { Name = "Decorator1" } } }
            };
            var testItemidFile = new Dictionary<string, List<string>> { { "item1", new List<string> { "file1.txt" } } };
            var testProdidFile = new Dictionary<string, List<string>> { { "prod1", new List<string> { "file1.txt" } } };

            // Act
            unfold.ParseJob = testJob;
            unfold.AllFiles = testAllFiles;
            unfold.ParsedFiles = testParsedFiles;
            unfold.FailedFiles = testFailedFiles;
            unfold.PrimaryProductions = testPrimaryProductions;
            unfold.Productions = testProductions;
            unfold.Tildes = testTildes;
            unfold.Translations = testTranslations;
            unfold.Links = testLinks;
            unfold.Decorators = testDecorators;
            unfold.ItemidFile = testItemidFile;
            unfold.ProdidFile = testProdidFile;

            // Assert
            Assert.AreEqual(testJob, unfold.ParseJob);
            CollectionAssert.AreEqual(testAllFiles, unfold.AllFiles);
            CollectionAssert.AreEqual(testParsedFiles, unfold.ParsedFiles);
            CollectionAssert.AreEqual(testFailedFiles, unfold.FailedFiles);
            CollectionAssert.AreEqual(testPrimaryProductions, unfold.PrimaryProductions);
            CollectionAssert.AreEqual(testProductions, unfold.Productions);
            CollectionAssert.AreEqual(testTildes, unfold.Tildes);
            CollectionAssert.AreEqual(testTranslations, unfold.Translations);
            CollectionAssert.AreEqual(testLinks, unfold.Links);
            CollectionAssert.AreEqual(testDecorators, unfold.Decorators);
            CollectionAssert.AreEqual(testItemidFile, unfold.ItemidFile);
            CollectionAssert.AreEqual(testProdidFile, unfold.ProdidFile);
        }

        [Test]
        public void DescribeUnfold_ToString_ShouldReturnLengthyString()
        {
            // Arrange
            var unfold = new DescribeUnfold();

            var testJob = new SimpleParseJob { InitialDir = "C:\\Test" };
            var testAllFiles = new List<string> { "file1.txt", "file2.txt" };
            var testParsedFiles = new List<string> { "file1.txt" };
            var testFailedFiles = new List<string> { "file2.txt" };
            var testPrimaryProductions = new List<string> { "prod1", "prod2" };
            var testProductions = new Dictionary<string, List<string>> { { "prod1", new List<string> { "item1" } } };
            var testTildes = new Dictionary<string, List<string>> { { "tilde1", new List<string> { "item2" } } };
            var testTranslations = new Dictionary<string, string> { { "item1", "translation1" } };
            var testLinks = new Dictionary<string, List<DescribeLink>>
            {
                { "item1", new List<DescribeLink> { new DescribeLink { Url = "http://example.com" } } }
            };
            var testDecorators = new Dictionary<string, List<DescribeDecorator>>
            {
                { "item1", new List<DescribeDecorator> { new DescribeDecorator { Name = "Decorator1" } } }
            };
            var testItemidFile = new Dictionary<string, List<string>> { { "item1", new List<string> { "file1.txt" } } };
            var testProdidFile = new Dictionary<string, List<string>> { { "prod1", new List<string> { "file1.txt" } } };
            string testString = unfold.ToString();
            int minimumLength = 50;

            // Act
            bool isNotNull = testString != null;
            bool isNotEmpty = !string.IsNullOrEmpty(testString);
            bool isLongerThanMinimumLength = testString.Length > minimumLength;

            // Assert
            Assert.IsTrue(isNotNull, "String should not be null.");
            Assert.IsTrue(isNotEmpty, "String should not be empty.");
            Assert.IsTrue(isLongerThanMinimumLength, $"String should be longer than {minimumLength} characters.");
        }

        [Test]
        public void ToJson_ShouldSerializeObjectToJson()
        {
            // Arrange
            var unfold = new DescribeUnfold
            {
                ParseJob = new SimpleParseJob { InitialDir = "C:\\", LastNamespace = "TestNamespace", LastFile = "TestFile" },
                AllFiles = new List<string> { "file1.txt", "file2.txt" },
                ParsedFiles = new List<string> { "file1.txt" },
                FailedFiles = new List<string> { "file2.txt" },
                PrimaryProductions = new List<string> { "prod1", "prod2" },
                Productions = new Dictionary<string, List<string>> { { "prod1", new List<string> { "item1" } } },
                Tildes = new Dictionary<string, List<string>> { { "tilde1", new List<string> { "item2" } } },
                Translations = new Dictionary<string, string> { { "item1", "translation1" } },
                Links = new Dictionary<string, List<DescribeLink>> { { "item1", new List<DescribeLink> { new DescribeLink { Url = "http://example.com" } } } },
                Decorators = new Dictionary<string, List<DescribeDecorator>> { { "item1", new List<DescribeDecorator> { new DescribeDecorator { Name = "Decorator1" } } } },
                ItemidFile = new Dictionary<string, List<string>> { { "item1", new List<string> { "file1.txt" } } },
                ProdidFile = new Dictionary<string, List<string>> { { "prod1", new List<string> { "file1.txt" } } }
            };

            // Act
            string json = unfold.ToJson();

            // Assert
            Assert.IsNotNull(json, "JSON should not be null.");
            Assert.IsTrue(json.Contains("ParseJob"), "JSON should contain 'ParseJob' key.");
            Assert.IsTrue(json.Contains("AllFiles"), "JSON should contain 'AllFiles' key.");
            // Add more assertions as needed to check for presence of other keys/values
        }

        [Test]
        public void FromJson_ShouldDeserializeJsonToObject()
        {
            // Arrange
            string json = @"{
                ""ParseJob"": { ""InitialDir"": ""C:\\"" },
                ""AllFiles"": [""file1.txt"", ""file2.txt""],
                ""ParsedFiles"": [""file1.txt""],
                ""FailedFiles"": [""file2.txt""],
                ""PrimaryProductions"": [""prod1"", ""prod2""],
                ""Productions"": { ""prod1"": [""item1""] },
                ""Tildes"": { ""tilde1"": [""item2""] },
                ""Translations"": { ""item1"": ""translation1"" },
                ""Links"": { ""item1"": [{ ""Url"": ""http://example.com"" }] },
                ""Decorators"": { ""item1"": [{ ""Name"": ""Decorator1"" }] },
                ""ItemidFile"": { ""item1"": [""file1.txt""] },
                ""ProdidFile"": { ""prod1"": [""file1.txt""] }
            }";

            var unfold = new DescribeUnfold();

            // Act
            unfold.FromJson(json);

            // Assert
            Assert.IsNotNull(unfold.ParseJob, "ParseJob should not be null.");
            Assert.AreEqual("C:\\", unfold.ParseJob.InitialDir, "InitialDir should be 'C:\\'.");
            CollectionAssert.AreEqual(new List<string> { "file1.txt", "file2.txt" }, unfold.AllFiles);
            CollectionAssert.AreEqual(new List<string> { "file1.txt" }, unfold.ParsedFiles);
            CollectionAssert.AreEqual(new List<string> { "file2.txt" }, unfold.FailedFiles);
            CollectionAssert.AreEqual(new List<string> { "prod1", "prod2" }, unfold.PrimaryProductions);
            Assert.AreEqual(1, unfold.Productions.Count);
            Assert.AreEqual("item1", unfold.Productions["prod1"][0]);
            // Add more assertions as needed to check other properties
        }
    }
}
