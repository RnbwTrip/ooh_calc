using System.Runtime.ExceptionServices;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class SinTest
    {
        [TestCase(5, -0.95892)]
        [TestCase(112, -0.88999)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new Sin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result,0.00001);
        }
    }
}
