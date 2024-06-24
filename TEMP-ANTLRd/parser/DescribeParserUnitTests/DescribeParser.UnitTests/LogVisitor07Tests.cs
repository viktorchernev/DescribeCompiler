using DescribeParser.Visitors;

namespace DescribeParser.UnitTests
{
    [TestFixture]
    public class LogVisitor07Tests
    {
        //[ClassName]Tests
        //[UnitOfWorkName]_[ScenarioUnderTest]_[ExpectedBehavior]
        //ByDefault, WhenCalled or Always


        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Ctor_Invocation_LogNotNull()
        {
            LogVisitor07 visitor = new LogVisitor07();
            Assert.IsNotNull(visitor.Log);
        }
        
        [Test]
        public void Ctor_Invocation_LastErrorNull()
        {
            LogVisitor07 visitor = new LogVisitor07();
            Assert.IsNull(visitor.LastError);
        }
    }
}