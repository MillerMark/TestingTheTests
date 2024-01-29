using CoreCalc;
using FluentAssertions;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace NUnit_FluentAssertions
{
    public class NUnitWithFluentAssertions
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            calculator.AddTwoNumbers(3, 4).Should().Be(7);
            calculator.AddTwoNumbers(5, 2).Should().Be(7);
            calculator.AddTwoNumbers(1, 2).Should().Be(3);
        }

        [Test]
        public void TestShouldBe()
        {
            List<string> list = new List<string>();
            
        }

        
    }
}