using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_7_StuInfo
{
    public partial class FrmGR : Form
    {
        public FrmGR()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg;
            msg = txtName.Text.Trim();
            if (msg == "")
            {
                MessageBox.Show("姓名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            if (RadMale.Checked)
                msg += ",男";
            else
                msg += ",女";
            if (txtAge.Text.Trim() != "")
                msg += "," + txtAge.Text.Trim() + "岁";
            if (txtNativePlace.Text.Trim() != "")
                msg += "," + txtNativePlace.Text.Trim() + "人";
            msg += "\n";
            string hobby; hobby = "";
            if (chk1.Checked)
                hobby += "<" + chk1.Text + ">";
            if (chk2.Checked)
                hobby += "<" + chk2.Text + ">";
            if (chk3.Checked)
                hobby += "<" + chk3.Text + ">";
            if (chk4.Checked)
                hobby += "<" + chk4.Text + ">";
            if (chk5.Checked)
                hobby += "<" + chk5.Text + ">";
            if (chk6.Checked)
                hobby += "<" + chk6.Text + ">";
            if (hobby != "")
                hobby = "爱好" + hobby;
            else
                hobby = "无特殊爱好";
            msg += hobby;
            msg += "\n";
            MessageBox.Show(msg, "信息确认", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmMain.GRmsg = msg;
        }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
