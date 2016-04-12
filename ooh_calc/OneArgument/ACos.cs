using System;

namespace ooh_calc.OneArgument
{
    public class ACos: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
