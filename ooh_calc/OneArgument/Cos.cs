using System;

namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns the cosine.
    /// </summary>
        public class Cos : ISingleCalculator
        {
            /// <summary>
            /// Calculation of the cosine.
            /// </summary>
            /// <param name="first">
            /// The number in the radian form
            /// </param>
            /// <returns>
            /// Returns the cosine
            /// </returns>
            public double Calculate(double first)
            {
                return Math.Cos(first);
            }
        }
   
}
