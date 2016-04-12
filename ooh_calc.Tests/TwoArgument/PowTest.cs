using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class PowTest
    {
        [TestCase(8, 2, 64)]
        [TestCase(10, 8, 100000000)]
        public void BasicTestPow(double first, double second, double expected)
        {
            ICalculator calculator = new Pow();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
