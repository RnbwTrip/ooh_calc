using System;

namespace ooh_calc.OneArgument
{  /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which calculates the hyperbolic logarithm.
    /// </summary>
    public class Ln : ISingleCalculator
    {
        /// <summary>
        /// Calculation the hyperbolic logarithm
        /// </summary>
        /// <param name="first">
        /// Number
        /// </param>
        /// <returns>
        /// Returns the quotient
        /// </returns>
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
