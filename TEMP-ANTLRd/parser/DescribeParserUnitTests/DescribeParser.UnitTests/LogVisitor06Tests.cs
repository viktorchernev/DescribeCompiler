using DescribeParser.Visitors;

namespace DescribeParser.UnitTests
{
    [TestFixture]
    public class LogVisitor06Tests
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
            LogVisitor06 visitor = new LogVisitor06();
            Assert.IsNotNull(visitor.Log);
        }
        
        [Test]
        public void Ctor_Invocation_LastErrorNull()
        {
            LogVisitor06 visitor = new LogVisitor06();
            Assert.IsNull(visitor.LastError);
        }
    }
}