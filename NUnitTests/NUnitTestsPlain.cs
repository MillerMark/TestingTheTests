using NUnit.Framework;
using CoreCalc;

namespace NUnitTests
{
    public class NUnitTestsPlain
    {

        [SetUp]
        public void Setup()
        {
            
        }


        [Test]
        public void Test1()
        {
            List<string> list = new List<string>();
            Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator);
            Assert.That(calculator.Add(11, 12), Is.EqualTo(23));
            Assert.That(calculator.Add(3, 4), Is.EqualTo(7));
            Assert.That(calculator.Add(4, 3), Is.EqualTo(7));
        }
    }
}