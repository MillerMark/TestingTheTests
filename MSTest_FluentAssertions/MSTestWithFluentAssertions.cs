using System.Data;
using FluentAssertions;
using System.Security.AccessControl;
using System.Runtime.CompilerServices;
using FluentAssertions.Specialized;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.ComponentModel;
using System.Net.Sockets;
using static System.TimeZoneInfo;

namespace MSTest_FluentAssertions
{
    [TestClass]
    public class MSTestWithFluentAssertions
    {
        [TestMethod]
        public void TestCount()
        {
            List<string> list = new () { "1", "2", "3" };
            list.Should().StartWith("1");
            list.Should().HaveCount(2);
        }

        [TestMethod]
        public void TestShouldBe()
        {
            (3 + 4).Should().Be(7);
            list.Should().Be(expectedValue);
        }
    }
}
