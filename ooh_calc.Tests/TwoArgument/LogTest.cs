using System;
using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class LogTest
    {
        [TestCase(8, 2, 3)]
        [TestCase(10000, 8, 4.4292)]
        public void BasicTestLog(double first, double second, double expected)
        {
            ICalculator calculator = new Log();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [Test]
        public void ExceptionTest()
        {
            ICalculator calculator = new Log();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-3, 10));
        }
        
        [Test]
        public void Exception2Test()
        {
            ICalculator calculator = new Log();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(10, -5));
        }

        [Test]
        public void Exception3Test()
        {
            ICalculator calculator = new Log();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(10, 1));
        }

    }
}
