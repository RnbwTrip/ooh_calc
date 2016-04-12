using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class PercentTest
    {
        [TestCase(12000, 10, 1200)]
        //[TestCase(1500000, 100, 15000)]
        public void BasicTestPercent(double first, double second, double expected)
        {
            ICalculator calculator = new Percent();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
