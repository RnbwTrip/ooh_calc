using System;

namespace ooh_calc.TwoArgument
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
                case "buttonPow":
                    return new Pow();
                case "buttonLog":
                    return new Log();
                case "buttonDiv":
                    return new Div();
                case "buttonMod":
                    return new Mod();
                case "buttonPercent":
                    return new Percent();
                default: throw new ArgumentException("Произошла ошибка","name");
            }

        }
    }
}
