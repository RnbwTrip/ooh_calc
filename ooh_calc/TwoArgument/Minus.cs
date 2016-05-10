namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs difference.
    /// </summary>
    public class Minus: ICalculator
    {
        /// <summary>
        /// Difference of two arguments
        /// </summary>
        /// <param name="first">
        /// Minuend
        /// </param>
        /// <param name="second">
        /// Subtrahend
        /// </param>
        /// <returns>
        /// Returns the difference
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
