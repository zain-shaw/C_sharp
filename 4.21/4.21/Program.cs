using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._21
{
    class Program
    {
        static int road1(int stair)
        {
            if (stair == 0)
            {
                return 1;
            }
            else
            {
                return stair * road1(stair - 1);
            }
        }
        static int road2(int stair)
        {
            if (stair == 0)
            {
                return 0;
            }
            else
            {
                int a = 1;
                for (int time = 1; time <= stair; time++)
                {
                    a *= time;
                }
                return a;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字：");
            int stair = int.Parse(Console.ReadLine());
            if (stair <= 30)
            {
                Console.Write("共有" + road1(stair)+"\n");
            }
            else
            {
                Console.Write("共有" + road2(stair)+"\n");
            }
        }
    }
}
