using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class MultiplyTest
    {
        [TestCase(8, 2, 16)]
        [TestCase(10000, 8, 80000)]
        public void BasicTestMultiply(double first, double second, double expected)
        {
            ICalculator calculator = new Multiply();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
