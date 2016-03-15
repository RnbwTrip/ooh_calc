using System;
using System.Windows.Forms;
using ooh_calc.one_arg;
using ooh_calc.two_args;

namespace ooh_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate(object sender, EventArgs e)
        {
            String firstString = textBox1.Text;
            String secondString = textBox2.Text;
            Double first = Convert.ToDouble(firstString);
            Double second = Convert.ToDouble(secondString);
            Double answer = 0;
            ICalculator calculator = CalculatorFactory.CreateCalculator(((Button) sender).Name);
            answer = calculator.Calculate(first, second);
            String answerString = Convert.ToString(answer);
            textAnswer.Text = answerString;

        }

        public void SingleCalculate(object sender, EventArgs e)
        {
            String firstString = textBox1.Text;
            Double first = Convert.ToDouble(firstString);
            Double answer = 0;
            ISingleCalculator calculator = OneArgCalculationFactory.CreateSingleCalculator(((Button)sender).Name);
            answer = calculator.Calculate(first);
            String answerString = Convert.ToString(answer);
            textAnswer.Text = answerString;
        }

    }
}
