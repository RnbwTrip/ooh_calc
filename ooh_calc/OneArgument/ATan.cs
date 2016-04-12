using System;

namespace ooh_calc.OneArgument
{
    public class ATan : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
