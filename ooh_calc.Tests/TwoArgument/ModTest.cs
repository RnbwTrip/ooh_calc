using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class ModTest
    {
        [TestCase(8, 2, 0)]
        [TestCase(11111, 8, 7)]
        public void BasicTestMod(double first, double second, double expected)
        {
            ICalculator calculator = new Mod();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
