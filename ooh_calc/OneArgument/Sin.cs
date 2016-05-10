using System;

namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns the sine.
    /// </summary>
    public class Sin : ISingleCalculator
    {
        /// <summary>
        /// Calculation of the sine.
        /// </summary>
        /// <param name="first">
        /// The number in the radian form
        /// </param>
        /// <returns>
        /// Returns the sine
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
