using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class MinusTest
    {
        [Test]
        public void BasicTestMinus()
        {
            ICalculator calculator = new Minus();
            double result = calculator.Calculate(111,112);
            Assert.AreEqual(-1,result);
        }
    }
}
