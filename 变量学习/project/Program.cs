using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program    //class“类”
    {
        static void Main(string[] args)
        {
            Console.WriteLine("春眠不觉晓，\n处处闻啼鸟。\n夜来风雨声，\n花落知多少。");
            int I_a, I_b, I_c,I_d;
            I_a = 11;
            I_b = 22;
            I_c =(int) Math.Pow(I_a,I_b);
            I_d = I_a * I_b;
            Console.WriteLine("I_c的幂运算值为"+I_c+"\n"+"I_d的积运算值为"+I_d);
            Console.ReadKey();   /*等待读键*/
        }
    }
}
