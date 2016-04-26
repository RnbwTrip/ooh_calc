using System;

namespace ooh_calc.OneArgument
{
    public class Ln : ISingleCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new ArgumentException("Натуральный логарифм нельзя взять от отрицательного числа", "first");
            }
            return Math.Log(first);
        }
    }
}
