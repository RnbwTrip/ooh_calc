using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class LogTest
    {
        [Test]
        public void BasicTestLog()
        {
            ICalculator calculator = new Log();
            double result = calculator.Calculate(8, 2);
            Assert.AreEqual(3,result);
        }
    }
}
