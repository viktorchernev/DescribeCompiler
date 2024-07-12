using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Parser
{
    [TestFixture]
    public class DescribeUnfoldV3_AddEntry_Tests
    {
        private DescribeUnfoldV3 _describeUnfoldV3;


        [SetUp]
        public void Setup()
        {
            _describeUnfoldV3 = new DescribeUnfoldV3();
        }


        [Test]
        public void Test_Initialization()
        {
            // Verify that dictionaries and lists are initialized
            Assert.IsNotNull(_describeUnfoldV3.AllFiles);
            Assert.IsNotNull(_describeUnfoldV3.ParsedFiles);
            Assert.IsNotNull(_describeUnfoldV3.FailedFiles);
            Assert.IsNotNull(_describeUnfoldV3.Ids);
            Assert.IsNotNull(_describeUnfoldV3.PrimaryProductions);
            Assert.IsNotNull(_describeUnfoldV3.Productions);
            Assert.IsNotNull(_describeUnfoldV3.Tildes);
            Assert.IsNotNull(_describeUnfoldV3.Translations);
            Assert.IsNotNull(_describeUnfoldV3.Links);
            Assert.IsNotNull(_describeUnfoldV3.Decorators);
            Assert.IsNotNull(_describeUnfoldV3.ItemidFile);
            Assert.IsNotNull(_describeUnfoldV3.ProdidFile);
        }

        [Test]
        public void Test_AddEntry_AllFiles()
        {
            // Adding a file to AllFiles
            _describeUnfoldV3.AllFiles.Add(1, "File1.txt");
            Assert.AreEqual(1, _describeUnfoldV3.AllFiles.Count);
            Assert.AreEqual("File1.txt", _describeUnfoldV3.AllFiles[1]);
        }

        [Test]
        public void Test_AddEntry_ParsedFiles()
        {
            // Adding a file to ParsedFiles
            _describeUnfoldV3.ParsedFiles.Add(1);
            Assert.AreEqual(1, _describeUnfoldV3.ParsedFiles.Count);
            Assert.Contains(1, _describeUnfoldV3.ParsedFiles);
        }

        [Test]
        public void Test_AddEntry_FailedFiles()
        {
            // Adding a file to FailedFiles
            _describeUnfoldV3.FailedFiles.Add(2);
            Assert.AreEqual(1, _describeUnfoldV3.FailedFiles.Count);
            Assert.Contains(2, _describeUnfoldV3.FailedFiles);
        }

        [Test]
        public void Test_AddEntry_Ids()
        {
            // Adding an ID to Ids dictionary
            _describeUnfoldV3.Ids.Add(1, "ID1");
            Assert.AreEqual(1, _describeUnfoldV3.Ids.Count);
            Assert.AreEqual("ID1", _describeUnfoldV3.Ids[1]);
        }

        [Test]
        public void Test_AddEntry_PrimaryProductions()
        {
            // Adding a primary production
            _describeUnfoldV3.PrimaryProductions.Add(3);
            Assert.AreEqual(1, _describeUnfoldV3.PrimaryProductions.Count);
            Assert.Contains(3, _describeUnfoldV3.PrimaryProductions);
        }

        [Test]
        public void Test_AddEntry_Productions()
        {
            // Adding a production
            _describeUnfoldV3.Productions.Add(1, new List<int> { 2, 3 });
            Assert.AreEqual(1, _describeUnfoldV3.Productions.Count);
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, _describeUnfoldV3.Productions[1]);
        }

        [Test]
        public void Test_AddEntry_Tildes()
        {
            // Adding a tilde
            _describeUnfoldV3.Tildes.Add(4, new List<int> { 5, 6 });
            Assert.AreEqual(1, _describeUnfoldV3.Tildes.Count);
            CollectionAssert.AreEqual(new List<int> { 5, 6 }, _describeUnfoldV3.Tildes[4]);
        }

        [Test]
        public void Test_AddEntry_Translations()
        {
            // Adding a translation
            _describeUnfoldV3.Translations.Add(1, "Translation1");
            Assert.AreEqual(1, _describeUnfoldV3.Translations.Count);
            Assert.AreEqual("Translation1", _describeUnfoldV3.Translations[1]);
        }

        [Test]
        public void Test_AddEntry_Links()
        {
            // Adding a link
            var links = new List<DescribeLink> { new DescribeLink() };
            _describeUnfoldV3.Links.Add(1, links);
            Assert.AreEqual(1, _describeUnfoldV3.Links.Count);
            CollectionAssert.AreEqual(links, _describeUnfoldV3.Links[1]);
        }

        [Test]
        public void Test_AddEntry_Decorators()
        {
            // Adding a decorator
            var decorators = new List<DescribeDecorator> { new DescribeDecorator() };
            _describeUnfoldV3.Decorators.Add(1, decorators);
            Assert.AreEqual(1, _describeUnfoldV3.Decorators.Count);
            CollectionAssert.AreEqual(decorators, _describeUnfoldV3.Decorators[1]);
        }

        [Test]
        public void Test_AddEntry_ItemidFile()
        {
            // Adding an item to ItemidFile
            _describeUnfoldV3.ItemidFile.Add(1, new List<int> { 2, 3 });
            Assert.AreEqual(1, _describeUnfoldV3.ItemidFile.Count);
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, _describeUnfoldV3.ItemidFile[1]);
        }

        [Test]
        public void Test_AddEntry_ProdidFile()
        {
            // Adding an item to ProdidFile
            _describeUnfoldV3.ProdidFile.Add(4, new List<int> { 5, 6 });
            Assert.AreEqual(1, _describeUnfoldV3.ProdidFile.Count);
            CollectionAssert.AreEqual(new List<int> { 5, 6 }, _describeUnfoldV3.ProdidFile[4]);
        }
    }
}
