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

namespace _9_1_directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string dirStr = "";
        public static void DispDirs(DirectoryInfo dir)
        {
            
            DirectoryInfo[] directories = dir.GetDirectories();
            foreach(DirectoryInfo dirX in directories)
            {
                DispDirs(dirX);
                
            }
            dirStr = dirStr + "\r\n" + dir.FullName;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(txtDir.Text);
            if (dir.Exists)
            {
                DispDirs(dir);
                txtOutput.Text = dirStr;
            }
            else
                txtOutput.Text= "访问目录不存在!";
        }
    }
}
