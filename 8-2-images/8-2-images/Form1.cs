using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_2_images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "壁纸（1）";
            label1.Visible = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "壁纸（2）";
            label1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "壁纸（3）";
            label1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
