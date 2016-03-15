using System;

namespace ooh_calc.one_arg
{
    public static class OneArgCalculationFactory
    {
        public static ISingleCalculator CreateSingleCalculator(string name)
        {
            switch (name)
            {
                case "buttonASinus":
                    return new ASinus();
                case "buttonSqr":
                    return new Sqr();
                case "buttonACos":
                    return new ACos();
                case "buttonSqrt":
                    return new Sqrt();
                case "buttonLn":
                    return new Ln();
                default: throw new ArgumentException("Произошла ошибка", "name");
            }
        }
    }
}
