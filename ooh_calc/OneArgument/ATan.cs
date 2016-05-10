using System;

namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns the arc tangent.
    /// </summary>
    public class ATan : ISingleCalculator
    {
        /// <summary>
        /// Calculation of the arc tangent.
        /// </summary>
        /// <param name="first">
        /// The number in the radian form
        /// </param>
        /// <returns>
        /// Returns the arc tangent
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
