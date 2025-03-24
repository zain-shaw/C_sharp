using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR循环
            {
                int Ia = 1;
                for (int Ib = 1; Ib <= 25; Ib++)
                {
                    Ia *= Ib;
                }
                Console.WriteLine("25！为" + Ia);
            }

            //WHILE循环
            {
                int Ia = 1, Ib = 1;
                while(Ia<=25)
                {
                    Ib *= Ia;
                    Ia++;
                }
                Console.WriteLine("\n25！为" + Ib);
            }

            //阶乘问答式
            {
                Console.WriteLine("\n请输入要计算的阶乘数：");
                string Ia = Console.ReadLine();
                int jc = int.Parse(Ia);
                int Id = 1;
                for(int Ib = 1;Ib<= jc;Ib++)
                {
                    Id *= Ib;
                }
                Console.WriteLine("\n"+jc + "的阶乘为" + Id);
            }
            

            int price = 0;
            for (int people = 1; people < 10000; people++)
            {
                if(people*8-3==people*7+4)
                {
                    Console.WriteLine("人数为" + people);
                    price = people * 8 - 3;
                    Console.WriteLine("价格为" + price);
                    break;
                }
            }

            /*5X+3Y+1/3Z = 100;
            X+Y+Z=100*/
            int Z = 0;
            for(int X = 0;X<=100;X++)
            {
                for (int Y = 0; Y <= 100; Y++)
                {
                    Z = 100 - X - Y;
                    if(5*X+3*Y+Z/3.0==100)
                    {
                        Console.WriteLine("X=" + X + "  Y=" + Y + "  Z=" + Z);
                    }
                   //for(int Z=0;Z<=100;Z++)
                   // {
                   //     if((X+Y+Z==100)&&(5*X+3*Y+Z/3==100))
                   //     {
                   //         Console.WriteLine("X="+X+"  Y="+Y+"  Z="+Z);
                   //     }
                    // }
                }
            }





            {
                int[] scores = { 12, 23, 34, 45, 56, 67, 78 };
                int sum = 0;
                Array.Sort(scores);        //从小大给数组排序
                Array.Reverse(scores);     //颠倒刚才的顺序
                foreach (int Ia in scores)
                {
                    Console.WriteLine(Ia + "\t");  //  \t，制表符
                    sum += Ia;
                }
                Console.WriteLine(1.0*sum / scores.Length + "\t"); //scores.Length数组长度
            }


          


            Console.ReadKey();

        }
    }
}
