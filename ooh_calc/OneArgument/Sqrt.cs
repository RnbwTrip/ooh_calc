using System;

namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which calculates the square root.
    /// </summary>
    public class Sqrt: ISingleCalculator
    {
        /// <summary>
        /// Calculation of the square root
        /// </summary>
        /// <param name="first">
        /// Number positive
        /// </param>
        /// <returns>
        /// Returns the square root
        /// </returns>
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
