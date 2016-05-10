namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which returns percentage of the number.
    /// </summary>
    public class Percent : ICalculator
    {
        /// <summary>
        /// Percentage of the number
        /// </summary>
        /// <param name="first">
        /// Number
        /// </param>
        /// <param name="second">
        /// Percents
        /// </param>
        /// <returns>
        /// Returns the percentage of the number
        /// </returns>
        public double Calculate(double first, double second)
        {
            return (first*(second/100));
        }
    }
}
