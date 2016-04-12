using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTest
    {
        [Test]
        public void BasicTestSqrt()
        {
            ISingleCalculator calculator = new Sqrt();
            double result = calculator.Calculate(4);
            Assert.AreEqual(2,result);
        }
    }
}
