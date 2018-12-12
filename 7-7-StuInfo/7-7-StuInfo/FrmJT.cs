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
    public partial class FrmJT : Form
    {
        public FrmJT()
        {
            InitializeComponent();
        }

        private void FrmJT_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg;
            if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("家庭住址不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtCode.Text.Trim().Equals(""))
            {
                MessageBox.Show("邮政编码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMobile.Text.Trim().Equals(""))
            {
                MessageBox.Show("移动电话不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msg = "家庭住址是" + txtAddress.Text.Trim()
                    + "，邮编" + txtCode.Text.Trim()
                    + "，移动电话" + txtMobile.Text.Trim()
                    + "，固定电话" + txtPhone.Text.Trim() + "。\n";
                MessageBox.Show(msg, "信息确认", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain.JTmsg = msg;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
