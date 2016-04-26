using System;
using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class DivideTest
    {
        [TestCase(4, 2, 2)]
        [TestCase(8000000, 20000, 400)]
        public void BasicTestDivide(double first, double second, double expected)
        {
            ICalculator calculator = new Divide();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ExceptionTest()
        {
            ICalculator calculator = new Divide();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(1,0));
        }
    }
}
