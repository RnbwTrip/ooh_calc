using System;

namespace ooh_calc.OneArgument
{
    public class Ln : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
