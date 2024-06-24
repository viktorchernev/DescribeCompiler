using DescribeParser.Visitors;

namespace DescribeParser.UnitTests
{
    [TestFixture]
    public class LogVisitor11Tests
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
            LogVisitor11 visitor = new LogVisitor11();
            Assert.IsNotNull(visitor.Log);
        }
        
        [Test]
        public void Ctor_Invocation_LastErrorNull()
        {
            LogVisitor11 visitor = new LogVisitor11();
            Assert.IsNull(visitor.LastError);
        }
    }
}