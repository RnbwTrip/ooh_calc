using System;

namespace ooh_calc.TwoArgument
{
    public class Pow : ICalculator
    {
            public double Calculate(double first, double second)
            {
                return Math.Pow(first,second);
            }
        }
    }

