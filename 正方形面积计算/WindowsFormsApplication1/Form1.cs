using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.oo;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { 
                double aa = 0;
                Class1 to = new Class1();
                aa = to.max1(3.6, 6.8);
                textBox1.Text ="正方形";
            }
            {
                int aa = 0;
                Class1 to = new Class1();
                aa = to.max2(9, 26);
                textBox2.Text = aa.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            square s = new square();
            s.name = "我是正方形";
            MessageBox.Show(s.whoami());
            s.width = 9;
            string a = s.getarea().ToString();
            MessageBox.Show("面积是"+a);
        }
    }
}
