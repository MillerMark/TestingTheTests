using CoreCalc;
using FluentAssertions;

namespace NUnit_FluentAssertions
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            calculator.Add(3, 4).Should().Be(7);
            calculator.Add(5, 2).Should().Be(7);
            calculator.Add(1, 2).Should().Be(3);
        }
    }
}