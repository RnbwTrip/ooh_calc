using System;

namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns the arc cosine.
    /// </summary>
    public class ACos: ISingleCalculator
    {
        /// <summary>
        /// Calculation of the arc cosine.
        /// </summary>
        /// <param name="first">
        /// The number in the radian form
        /// </param>
        /// <returns>
        /// Returns the arc cosine
        /// </returns>
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
