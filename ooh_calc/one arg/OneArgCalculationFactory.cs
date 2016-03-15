using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc
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
