using System;

namespace ooh_calc.OneArgument
{
        public class Cos : ISingleCalculator
        {
            public double Calculate(double first)
            {
                return Math.Cos(first);
            }
        }
   
}
