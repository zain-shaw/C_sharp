using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 员工管理程序
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float Ia;
            float.TryParse(textBox3.Text, out Ia);
            textBox4.Text = (Ia * 0.1).ToString();//将浮点型转换为textbox4接受的字符型
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float Ia, Ib, Ic;
            float.TryParse(textBox8.Text, out Ia);
            if(Ia>100||Ia<0)
            {
                MessageBox.Show("成绩输入错误");
            }
            float.TryParse(textBox5.Text, out Ib);
            if (Ib > 100 || Ib < 0)
            {
                MessageBox.Show("成绩输入错误");
            }
            float.TryParse(textBox7.Text, out Ic);
            if (Ic > 100 || Ic < 0)
            {
                MessageBox.Show("成绩输入错误");
            }
            textBox6.Text = ((Ia + Ib + Ic) / 3).ToString();
        }
    }
}
