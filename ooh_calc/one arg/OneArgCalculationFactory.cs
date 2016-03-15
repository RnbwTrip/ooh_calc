using System;

namespace ooh_calc.one_arg
{
    public static class OneArgCalculationFactory
    {
        public static ISingleCalculator CreateSingleCalculator(string name)
        {
            switch (name)
            {
                case "buttonSinus":
                    return new Sinus();
                case "buttonSqr":
                    return new Sqr();
                default: throw new ArgumentException("Произошла ошибка", "name");
            }
        }
    }
}
