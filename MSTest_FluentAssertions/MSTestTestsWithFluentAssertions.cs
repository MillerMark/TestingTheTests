using FluentAssertions;

namespace MSTest_FluentAssertions
{
    [TestClass]
    public class MSTestTestsWithFluentAssertions
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> list = new () { "1", "2", "3" };
            list.Should().StartWith("1");
            list.Should().HaveCount(2);
            list.Should().HaveCount(4);
            list.Should().HaveCount(5);
        }
    }
}
