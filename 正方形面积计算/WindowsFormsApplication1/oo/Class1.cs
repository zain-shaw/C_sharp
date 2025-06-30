using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.oo
{
    class Class1
    {
        public void max(double a,double b)
        {
            double c;
            c=a > b ? a: b;//无结果
        }
        public double max1 (double a, double b)
        {
            return a > b ? a : b;
        }
        public int max2(int a,int b)
        {
            return a < b ? a : b;
        }
    }
}
