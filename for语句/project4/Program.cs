using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int I_i = 1; I_i <= 100; I_i++) //for(变量;条件（没有默认ture）;执行命令)
            {
                sum += I_i;//sum=sum+I_i
               // Console.WriteLine(I_i);//由结果可知for循环，在未达到条件时，不断在这个域内循环
            }
            Console.WriteLine("sum=" + sum);
            int I_sixty = 1;
            for(int I_a=1;I_a<=6;I_a++)
            {
                I_sixty *= 2;
            }
            Console.WriteLine("米粒数为："+I_sixty);
            long jc = 1;
            for(int I_h=1;I_h<=3;I_h++)
            {
                jc *= 2;
            }
            Console.WriteLine("jc=" + jc);
            


            for (int ren = 1; ren < 100; ren++)
            {
                if(8*ren-3==7*ren+4)
                {
                    Console.WriteLine("人数为" + ren);
                    Console.WriteLine("价格为" + (ren * 8 - 3));
                    break;                 
                }
            }
            Console.ReadKey();
        }
    }
}
