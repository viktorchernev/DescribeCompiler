using DescribeParser.Visitors;

namespace DescribeParser.UnitTests
{
    [TestFixture]
    public class LogVisitor08Tests
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
            LogVisitor08 visitor = new LogVisitor08();
            Assert.IsNotNull(visitor.Log);
        }
        
        [Test]
        public void Ctor_Invocation_LastErrorNull()
        {
            LogVisitor08 visitor = new LogVisitor08();
            Assert.IsNull(visitor.LastError);
        }
    }
}