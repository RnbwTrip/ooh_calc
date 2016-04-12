using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class PercentTest
    {
        [Test]
        public void BasicTestPercent()
        {
            ICalculator calculator = new Percent();
            double result = calculator.Calculate(12000,10);
            Assert.AreEqual(1200,result);
        }
    }
}
