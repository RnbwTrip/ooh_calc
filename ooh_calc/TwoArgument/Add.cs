namespace ooh_calc.TwoArgument
{
    /// <summary>
    /// Public Class.
    /// Exists "Calculate" function, which performs addition.
    /// </summary>
    public class Add: ICalculator
    {
        /// <summary>
        /// Addition of two arguments
        /// </summary>
        /// <param name="first">
        /// first summand
        /// </param>
        /// <param name="second">
        /// second summand
        /// </param>
        /// <returns>
        /// Returns the sum
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
