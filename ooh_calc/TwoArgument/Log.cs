using System;

namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs logarithm.
    /// </summary>
    public class Log: ICalculator
    {
        /// <summary>
        /// Perfoming logarithm
        /// </summary>
        /// <param name="first">
        /// Number
        /// </param>
        /// <param name="second">
        /// Logarithmic base
        /// </param>
        /// <returns>
        /// Returns the quotient
        /// </returns>
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
