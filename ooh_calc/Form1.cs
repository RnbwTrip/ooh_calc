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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            String firstString = textBox1.Text;
            String secondString = textBox2.Text;
            Double first = Convert.ToDouble(firstString);
            Double second = Convert.ToDouble(secondString);
            Double answer = first + second;
            String answerString = Convert.ToString(answer);
            textAnswer.Text = answerString;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            String firstString = textBox1.Text;
            String secondString = textBox2.Text;
            Double first = Convert.ToDouble(firstString);
            Double second = Convert.ToDouble(secondString);
            Double answer = first - second;
            String answerString = Convert.ToString(answer);
            textAnswer.Text = answerString;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            String firstString = textBox1.Text;
            String secondString = textBox2.Text;
            Double first = Convert.ToDouble(firstString);
            Double second = Convert.ToDouble(secondString);
            Double answer = first * second;
            String answerString = Convert.ToString(answer);
            textAnswer.Text = answerString;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            String firstString = textBox1.Text;
            String secondString = textBox2.Text;
            Double first = Convert.ToDouble(firstString);
            Double second = Convert.ToDouble(secondString);
            Double answer = first / second;
            String answerString = Convert.ToString(answer);
            textAnswer.Text = answerString;
        }
    }
}
