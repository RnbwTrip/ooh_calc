using System;

namespace ooh_calc.OneArgument
{
    public class ASinus: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
