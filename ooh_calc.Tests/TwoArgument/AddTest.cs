using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class AddTest
    {
        [Test]
        public void BasicTestAdd()
        {
            ICalculator calculator = new Add();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(4,result);
        }
    }
}
