using System;

namespace ooh_calc.TwoArgument
{
    public class Divide: ICalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new ArgumentException("Деление на ноль недопустимо", "second");
            }
            return first / second;
        }
    }
}
