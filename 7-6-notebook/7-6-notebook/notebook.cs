using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_6_notebook
{
    public partial class notebook : Form
    {
        public notebook()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((System.IO.Path.GetExtension(openFileDialog1.FileName)).ToLower() == ".txt")
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName);
            }
            toolStripStatusLabel1.Text = "打开的文件 ||";
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((System.IO.Path.GetExtension(openFileDialog1.FileName)).ToLower() == ".txt")
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
            toolStripStatusLabel1.Text = "文件已保存 ||";
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Dir = @"D:\文档\";
            string FileTitle = "新建 RTF 文档";
            string FileExt = ".rtf";

            string s1 = Dir + FileTitle + FileExt;
            int j = 2;
            if (System.IO.File.Exists(s1))
            {
                string s = String.Format("{0}{1}({2}){3}", Dir, FileTitle, j, FileExt);
                while (System.IO.File.Exists(s))
                {
                    j++;
                    s = String.Format("{0}{1}({2}){3}", Dir, FileTitle, j, FileExt);
                }
                if (!System.IO.File.Exists(s))
                {
                    CreateRtfFile(s);
                }
            }
            else
                CreateRtfFile(s1);
            toolStripStatusLabel1.Text = "文件已新建 ||";
        }

        public void CreateRtfFile(string RtfFileName)
        {
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.SaveFile(RtfFileName);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            新建ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            打开ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            保存ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            剪切ToolStripMenuItem_Click(sender, e);
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)

            {

                richTextBox1.Cut();

            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Equals(""))

                return;

            Clipboard.SetDataObject(richTextBox1.SelectedText, true);
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))

            {

                粘贴ToolStripMenuItem.Enabled = true;

                richTextBox1.Paste();

            }

            else

            {

                粘贴ToolStripMenuItem.Enabled = false;

            }
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 重做ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            复制ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            粘贴ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            撤销ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            重做ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void notebook_Load(object sender, EventArgs e)
        {
            string date;
            date=DateTime.Now.ToString("yyyy/MM/dd");
            toolStripStatusLabel2.Text = "当前日期：" + date;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.SelectionFont = this.fontDialog1.Font;
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)

            {

                richTextBox1.SelectedText = "";

            }
        }

        private void 图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "图片文件|*.jpg|所有文件|*.*";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //获取RichTextBox控件中鼠标焦点的索引位置 
                int startPosition = this.richTextBox1.SelectionStart;
                //从鼠标焦点处开始选中几个字符
                this.richTextBox1.SelectionLength = 2;
                //清空剪切板，防止里面之前有内容
                Clipboard.Clear();
                //给剪切板设置图片对象
                string img = openFileDialog2.FileName;
                Bitmap bmp = new Bitmap(img);
                Clipboard.SetImage(bmp);
                //将图片粘贴到鼠标焦点位置(由于有选中2个字符，所以那2个字符会被图片覆盖)
                richTextBox1.Paste();
                Clipboard.Clear();
            }
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);//支持位于运算
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            richTextBox1.SelectionFont = newFont;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;
            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            颜色ToolStripMenuItem_Click(sender, e);
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SelectionColor = f.Color;
            }
            richTextBox1.Focus();
        }
    }
}
