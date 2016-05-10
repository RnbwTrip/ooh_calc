using System;

namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns the arc sine.
    /// </summary>
    public class ASinus: ISingleCalculator
    {
        /// <summary>
        /// Calculation of the arc sine.
        /// </summary>
        /// <param name="first">
        /// The number in the radian form
        /// </param>
        /// <returns>
        /// Returns the arc sine
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
