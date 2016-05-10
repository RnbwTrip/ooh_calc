using System;

namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns remainder of the division.
    /// </summary>
    public class Mod : ICalculator
    {
        /// <summary>
        /// Calculation of remainder of the divison
        /// </summary>
        /// <param name="first">
        /// Dividend
        /// </param>
        /// <param name="second">
        /// Divider
        /// </param>
        /// <returns>
        /// Returns the remainder of the divison
        /// </returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new ArgumentException("Деление на ноль недопустимо", "second");
            }
            return (int)((Math.Round(first))%(Math.Round(second)));
        }
    }
}
