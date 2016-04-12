using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class DivTest
    {
        [Test]
        public void BasicTestDiv()
        {
            ICalculator calculator = new Div();
            double result = calculator.Calculate(11, 4);
            Assert.AreEqual(2,result);
        }
    }
}
