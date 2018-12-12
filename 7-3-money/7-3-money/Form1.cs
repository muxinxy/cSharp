using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_3_money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Num.Text);
            int m100 = num / 100;
            M100.Text = Convert.ToString(m100);
            int m50 = (num - m100 * 100) / 50;
            M50.Text = Convert.ToString(m50);
            int m20 = (num - m100 * 100 - m50 * 50) / 20;
            M20.Text = Convert.ToString(m20);
            int m10 = (num - m100 * 100 - m50 * 50 - m20 * 20) / 10;
            M10.Text = Convert.ToString(m10);
            int m5 = (num - m100 * 100 - m50 * 50 - m20 * 20 - m10 * 10) / 5;
            M5.Text = Convert.ToString(m5);
            int m1 = num - m100 * 100 - m50 * 50 - m20 * 20 - m10 * 10 - m5 * 5;
            M1.Text = Convert.ToString(m1);
        }
    }
}
