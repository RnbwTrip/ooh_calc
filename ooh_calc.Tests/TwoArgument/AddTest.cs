using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class AddTest
    {
        [TestCase(2,2,4)]
        [TestCase(1500, 10000000, 10001500)]
        public void BasicTestAdd(double first, double second, double expected)
        {
            ICalculator calculator = new Add();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected,result);
        }
    }
}
