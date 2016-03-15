using System;

namespace ooh_calc.one_arg
{
    public class ASinus: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
