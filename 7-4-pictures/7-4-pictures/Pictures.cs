using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_4_pictures
{
    public partial class Pictures : Form
    {
        int i = 1;
        public Pictures()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.imageList1.Images[0];
            label1.Text = this.imageList1.Images.Keys[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i > 9) i = 0;
            label1.Text = this.imageList1.Images.Keys[i].ToString();
            pictureBox1.Image = this.imageList1.Images[i++];
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
