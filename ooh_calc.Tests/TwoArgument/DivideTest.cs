using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class DivideTest
    {
        [Test]
        public void BasicTestDivide()
        {
            ICalculator calculator = new Divide();
            double result = calculator.Calculate(7, 3);
            Assert.AreEqual(2.33333,result,0.00001);
        }
    }
}
