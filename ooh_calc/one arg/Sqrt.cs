using System;

namespace ooh_calc.one_arg
{
    public class Sqrt: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
