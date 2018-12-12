using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _9_2_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtName.Text))
            {
                FileStream fileStream = new FileStream(txtName.Text, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(txtContent.Text);
                streamWriter.Close();
                fileStream.Close();
            }
            else
                MessageBox.Show("文件已存在！");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtName.Text))
            {
                string MyText = "";
                string ch;
                int a = 0;
                FileStream fileStream = new FileStream(txtName.Text, FileMode.Open, FileAccess.Read);
                a = fileStream.ReadByte();
                while (a != -1)
                {
                    {
                        ch = ((char)a).ToString();
                        MyText = MyText + ch;
                        a = fileStream.ReadByte();
                    }
                }
                txtContent.Text = MyText;
                fileStream.Close();
            }
            else
                MessageBox.Show("文件不存在！");
        }
    }
}
