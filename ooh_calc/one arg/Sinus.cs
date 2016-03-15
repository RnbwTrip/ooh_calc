using System;

namespace ooh_calc.one_arg
{
    public class Sinus: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
