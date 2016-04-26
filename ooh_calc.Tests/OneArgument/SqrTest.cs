using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class SqrTest
    {
        [TestCase(25,625)]
        [TestCase(7, 49)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new Sqr();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result);
        }
    }
}