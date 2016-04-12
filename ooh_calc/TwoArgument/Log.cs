using System;

namespace ooh_calc.TwoArgument
{
    public class Log: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first)/Math.Log(second);
        }
    }
}
