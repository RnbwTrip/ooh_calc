using System;

namespace ooh_calc.TwoArgument
{
    public class Div : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return (int)((Math.Round(first))/(Math.Round(second)));
        }
    }
}
