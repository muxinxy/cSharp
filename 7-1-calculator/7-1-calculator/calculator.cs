using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_1_calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double result = num1 + num2;
            string res = Convert.ToString(result);
            Result.Text = res;
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double result = num1 - num2;
            string res = Convert.ToString(result);
            Result.Text = res;
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double result = num1 * num2;
            string res = Convert.ToString(result);
            Result.Text = res;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double result = num1 / num2;
            string res = Convert.ToString(result);
            Result.Text = res;
        }
    }
}
