using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class DivTest
    {
        [TestCase(11, 2, 5)]
        [TestCase(35000000000, 9000, 3888888)]
        public void BasicTestDiv(double first, double second, double expected)
        {
            ICalculator calculator = new Div();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
