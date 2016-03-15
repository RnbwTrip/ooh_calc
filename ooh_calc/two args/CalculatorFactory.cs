using System;

namespace ooh_calc.two_args
{
    public static class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "buttonPlus":
                    return new Add();   
                case "buttonMinus":
                    return new Minus();
                case "buttonMultiply":
                    return new Multiply();
                case "buttonDivide":
                    return new Divide();
                default: throw new ArgumentException("Произошла ошибка","name");
            }

        }
    }
}
