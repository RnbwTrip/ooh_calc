using System;

namespace ooh_calc.OneArgument
{
    public class Sqrt: ISingleCalculator
    {
        public double Calculate(double first)
        {
            if (first<0)
            {
                throw new ArgumentException("Квадратный корень - положительное число", "first");
            }
            return Math.Sqrt(first);
        }
    }
}
