using System;

namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs division.
    /// </summary>
    public class Divide: ICalculator
    {
        /// <summary>
        /// Division of two arguments
        /// </summary>
        /// <param name="first">
        /// Dividend
        /// </param>
        /// <param name="second">
        /// Divider
        /// </param>
        /// <returns>
        /// Returns the quotient
        /// </returns>
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
