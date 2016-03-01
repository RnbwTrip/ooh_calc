using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooh_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Calculate(object sender, EventArgs e)
        {
            String firstString = textBox1.Text;
            String secondString = textBox2.Text;
            Double first = Convert.ToDouble(firstString);
            Double second = Convert.ToDouble(secondString);
            Double answer = 0;
            switch (((Button) sender).Name)
            {
                case "buttonPlus":
                    answer = first + second;
                    break;
                case "buttonMinus":
                    answer = first - second;
                    break;
                case "buttonMultiply":
                    answer = first*second;
                    break;
                case "buttonDivide":
                    answer = first/second;
                    break;
            }
            String answerString = Convert.ToString(answer);
            textAnswer.Text = answerString;

        }
    }
}
