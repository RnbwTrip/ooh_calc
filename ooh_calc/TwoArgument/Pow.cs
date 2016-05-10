using System;

namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs involution.
    /// </summary>
    public class Pow : ICalculator
    {
        /// <summary>
        /// Involution
        /// </summary>
        /// <param name="first">
        /// Number
        /// </param>
        /// <param name="second">
        /// Degree
        /// </param>
        /// <returns>
        /// Returns the involution
        /// </returns>
            public double Calculate(double first, double second)
            {
                return Math.Pow(first,second);
            }
        }
    }

