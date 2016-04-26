using System.Runtime.ExceptionServices;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class CosTest
    {
        [TestCase(5, 0.28366)]
        [TestCase(112, 0.45596)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new Cos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result,0.00001);
        }
    }
}
