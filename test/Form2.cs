using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "颜色改变";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK){
                textBox1.ForeColor = colorDialog.Color;
            }
          //  colorDialog.ShowDialog();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择文件夹";
            ofd.Filter = "所有文件(*.*)|*.*";
            if(ofd.ShowDialog()==DialogResult.OK){
                string file = ofd.FileName;
                MessageBox.Show("已选择文件"+file,"选择文件提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.RestoreDirectory = true;
            if(sa.ShowDialog()==DialogResult.OK){
            
            }
        }

        private void 另存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
