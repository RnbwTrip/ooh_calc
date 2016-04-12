using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class MinusTest
    {
        [TestCase(8, 2, 6)]
        [TestCase(10000, 8, 9992)]
        public void BasicTestMinus(double first, double second, double expected)
        {
            ICalculator calculator = new Minus();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
