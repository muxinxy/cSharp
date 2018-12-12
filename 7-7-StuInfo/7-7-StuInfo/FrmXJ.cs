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
    public partial class FrmXJ : Form
    {
        public FrmXJ()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg;
            if(txtNum.Text.Trim().Equals(""))
            {
                MessageBox.Show("学号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtClass.Text.Trim().Equals(""))
            {
                MessageBox.Show("班级不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDep.Text.Trim().Equals(""))
            {
                MessageBox.Show("院系不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSub.Text.Trim().Equals(""))
            {
                MessageBox.Show("专业不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msg = "学号"+txtNum.Text.Trim()
                    +"，所在班级是"+txtClass.Text.Trim()
                    +"，所属院系是"+txtDep.Text.Trim()
                    +"，所学专业是"+txtSub.Text.Trim()+"。\n";
                MessageBox.Show(msg, "信息确认", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain.XJmsg = msg;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
