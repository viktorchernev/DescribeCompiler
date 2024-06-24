using DescribeParser.Visitors;

namespace DescribeParser.UnitTests
{
    [TestFixture]
    public class LogVisitor10Tests
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
            LogVisitor10 visitor = new LogVisitor10();
            Assert.IsNotNull(visitor.Log);
        }
        
        [Test]
        public void Ctor_Invocation_LastErrorNull()
        {
            LogVisitor10 visitor = new LogVisitor10();
            Assert.IsNull(visitor.LastError);
        }
    }
}