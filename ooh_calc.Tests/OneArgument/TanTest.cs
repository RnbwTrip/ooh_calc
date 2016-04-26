using System.Runtime.ExceptionServices;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class TanTest
    {
        [TestCase(5, -3.38051)]
        [TestCase(112, -1.95187)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new Tan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result,0.00001);
        }
    }
}
