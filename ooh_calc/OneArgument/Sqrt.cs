using System;

namespace ooh_calc.OneArgument
{
    public class Sqrt: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
