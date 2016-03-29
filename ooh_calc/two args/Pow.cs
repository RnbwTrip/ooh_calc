using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ooh_calc.two_args
{
    public class Pow : ICalculator
    {
            public double Calculate(double first, double second)
            {
                return Math.Pow(first,second);
            }
        }
    }

