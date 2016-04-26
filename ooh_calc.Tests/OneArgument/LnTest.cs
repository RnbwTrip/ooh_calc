using System;
using System.Runtime.ExceptionServices;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class LnTest
    {
        [TestCase(10, 2.303)]
        [TestCase(127, 4.844)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result,0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            ISingleCalculator calculator = new Ln();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-10));
        }
    }
}
