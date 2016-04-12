using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class PowTest
    {
        [Test]
        public void BasicTestPow()
        {
            ICalculator calculator = new Pow();
            double result = calculator.Calculate(5,3);
            Assert.AreEqual(125,result);
        }
    }
}
