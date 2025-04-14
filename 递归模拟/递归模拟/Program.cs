using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归模拟
{
    class Program
    {
        static int sum(int a)
        {
            int ib = 0;
            for(int time=1;time<= a;time++)
            {
                ib += time;
            }
            return ib;
        }
        static int jiecheng(int a)
        {
            int b = 1;
            for(int time=1;time<= a;time++)
            {
                b = b * time;
            }
            return b;
        }
        static int monkey(int a)
        {
            int peach = 1;
            for(int time=1;time<=a;time++)
            {
                peach = (peach + 1) * 2;
            }
            return peach;
        }
        static int people(int day)
        {
            if(day==10)
            {
                return 1;
            }
            return (people(day + 1) + 1) * 2;//递推方法
        }
        static int pear(int day)
        {
            if(day==0)
            {
                return 1;
            }
            else
            {
                return (pear(day - 1) + 1) * 2;
            }
        }


        static int rice(int time)
        {
            if(time==31)
            {
                return 1;
            }
            else
            {
                return rice(time + 1) * 2;
            }
        }







        //作业

        static int 

        static void Main(string[] args)
        {
            {
                int ia = 0;
                for (int time = 1; time <= 100; time++)
                {
                    ia += time;
                }
                Console.WriteLine("100个数的和" + ia + " 50个数的和" + sum(50));
                Console.WriteLine("阶乘是"+jiecheng(30));
                Console.WriteLine("桃子有：" + monkey(10));
                Console.WriteLine("苹果有：" + people(0));
                Console.WriteLine("梨有：" + pear(10));
                Console.WriteLine("米有：" + rice(1));
            }

            
        }
    }
}
