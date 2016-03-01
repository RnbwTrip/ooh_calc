using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooh_calc
{
    class CalculatorFactory
    {
        public ICalculator CreateCalculator(string name)
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
