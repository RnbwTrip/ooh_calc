using NUnit.Framework;
using ooh_calc.TwoArgument;

namespace ooh_calc.Tests.TwoArgument
{
    [TestFixture]
    public class ModTest
    {
        [Test]
        public void BasicTestMod()
        {
            ICalculator calculator = new Mod();
            double result = calculator.Calculate(100,21);
            Assert.AreEqual(16,result);
        }
    }
}
