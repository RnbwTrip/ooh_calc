using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class MultiplyTest
    {
        [Test]
        public void BasicTestMultiply()
        {
            ICalculator calculator = new Multiply();
            double result = calculator.Calculate(5,3);
            Assert.AreEqual(15,result);
        }
    }
}
