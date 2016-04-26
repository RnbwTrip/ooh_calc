using System.Runtime.ExceptionServices;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class ACosTest
    {
        [TestCase(0.5, 1.04719)]
        [TestCase(1, 0)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new ACos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result,0.00001);
        }
    }
}
