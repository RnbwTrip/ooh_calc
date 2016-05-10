namespace ooh_calc.OneArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs construction of a square.
    /// </summary>
    public class Sqr: ISingleCalculator
    {
        /// <summary>
        /// Construction of a square
        /// </summary>
        /// <param name="first">
        /// Number 
        /// </param>
        /// <returns>
        /// Returns the number in square
        /// </returns>
        public double Calculate(double first)
        {
            return (first*first);
        }
    }
}
