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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("hello","English",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
            textBox1.Text = "name is David";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你好","中文",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            textBox2.Text = "年龄是28";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "name";
            textBox2.Text = "年龄";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }

    }
}
