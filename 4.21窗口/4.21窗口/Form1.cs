using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._21窗口
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点了视图");
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OpenFileDialog().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点了1");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "选择图片";
            fd.Filter = "图片文件/.jpg.jpeg.gif.png";
            DialogResult dr = fd.ShowDialog();
            if (dr==DialogResult.OK)
            {
                string imgName = fd.FileName;
                pictureBox1.Image = Image.FromFile(imgName);
                string imgUrl=Application
            }
        }
    }
}
