using System;

namespace ooh_calc.TwoArgument
{
    public class Log: ICalculator
    {
        public double Calculate(double first, double second)
        {
            if ((second == 1) && (second<0))
            {
                throw new ArgumentException("Основание логарифма больше нуля и не равно единице", "second");
            }
            if ((first < 0))
            {
                throw new ArgumentException("Основание логарифма больше нуля и не равно единице", "second");
            }
            return Math.Log(first)/Math.Log(second);
        }
    }
}
