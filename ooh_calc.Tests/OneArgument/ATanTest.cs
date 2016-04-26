using System.Runtime.ExceptionServices;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class ATanTest
    {
        [TestCase(0.5, 0.46364)]
        [TestCase(1, 0.78539)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new ATan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result,0.00001);
        }
    }
}
