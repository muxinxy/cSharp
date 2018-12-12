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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public static string GRmsg;
        public static string XJmsg;
        public static string JTmsg;
        public static string QTmsg;

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGR frmGR = new FrmGR();
            frmGR.MdiParent = this;
            frmGR.Show();
        }

        private void 学籍信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXJ frmXJ = new FrmXJ();
            frmXJ.MdiParent = this;
            frmXJ.Show();
        }

        private void 家庭信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJT frmJT = new FrmJT();
            frmJT.MdiParent = this;
            frmJT.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            个人信息ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            学籍信息ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            家庭信息ToolStripMenuItem_Click(sender, e);
        }

        private void 信息确认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQT frmQT = new FrmQT();
            frmQT.MdiParent = this;
            QTmsg = GRmsg + XJmsg + JTmsg;
            frmQT.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            信息确认ToolStripMenuItem_Click(sender, e);
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
