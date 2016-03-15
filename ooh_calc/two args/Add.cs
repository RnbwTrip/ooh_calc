namespace ooh_calc.two_args
{
    public class Add: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
