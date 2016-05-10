using System;

namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs integer division.
    /// </summary>
    public class Div : ICalculator
    {
        /// <summary>
        /// Integer division of two arguments
        /// </summary>
        /// <param name="first">
        /// Dividend
        /// </param>
        /// <param name="second">
        /// Divider
        /// </param>
        /// <returns>
        /// Returns the integer quotient
        /// </returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new ArgumentException("Деление на ноль недопустимо", "second");
            }
            return (int)((Math.Round(first))/(Math.Round(second)));
        }
    }
}
