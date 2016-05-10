using System;

namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns the tangent.
    /// </summary>
   public class Tan:ISingleCalculator
    {
        /// <summary>
        /// Calculation of the tangent.
        /// </summary>
        /// <param name="first">
        /// The number in the radian form
        /// </param>
        /// <returns>
        /// Returns the tangent
        /// </returns>
       public double Calculate(double first)
       {
           return Math.Tan(first);
       }
    }
}
