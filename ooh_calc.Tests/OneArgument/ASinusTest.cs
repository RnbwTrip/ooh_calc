using System.Runtime.ExceptionServices;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class ASinusTest
    {
        [TestCase(0.5, 0.52359)]
        [TestCase(1, 1.57079)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new ASinus();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result,0.00001);
        }
    }
}
