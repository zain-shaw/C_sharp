using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 成绩查询判断
{
    class Program
    {
        static void Main(string[] args)
        {
            bool B_a = true;

            while(B_a)
            {
                Console.WriteLine("请输入你的成绩。");
                string S_score = Console.ReadLine();
                Console.WriteLine("请问你是A同学还是B同学。（请输入A或B）");
                string S_x = Console.ReadLine();
                int score = int.Parse(S_score);


                switch (S_x)
                {
                    case "A":
                        Console.WriteLine("你好，A同学。");
                        break;
                    case "B":
                        Console.WriteLine("你好，B同学。");
                        break;
                }
                


                if (score >= 80)
                {
                    Console.WriteLine("恭喜,好厉害的分数，成绩为：" + score);
                }
                else if (score >= 60 && score < 80)
                {
                    Console.WriteLine("分数不高，仍需努力，成绩为：" + score);
                }
                else
                {
                    Console.WriteLine("遗憾，下次努力。成绩为：" + score);
                }



                Console.WriteLine("是否结束程序，请输入YES或NO。");
                string input = Console.ReadLine();
                if (input.ToUpper() == "YES")
                {
                    B_a = false;
                    Console.WriteLine("程序结束。");
                    break;
                }
                else if (input =="shaw_zain")
                {
                    B_a = true;
                    Console.WriteLine("恭喜发现彩蛋！！！");
                }
                else
                {
                
                    B_a = true;
                    Console.WriteLine("程序继续");
                }


            }


         
                Console.WriteLine("while循环");
                int sum = 0, I_i = 1;
                while (I_i <= 100)
                {
                    sum += I_i;
                    I_i++;
                    Console.WriteLine("第" + I_i + "循环");
                }
            Console.WriteLine("最终值为" + sum);


            Console.WriteLine("DO/WHILE循环");
            do
            {
            sum += I_i;
            I_i++;
            Console.WriteLine("第" + I_i + "循环");
            } while (I_i <= 100);
            Console.WriteLine("最终值为" + sum);

            


            Console.WriteLine("IF循环");
            for (int I_a = 1; I_a <= 100; I_a++)
            {
                sum += 1;
                Console.WriteLine("第" + I_a + "循环");
            }
            Console.WriteLine("最终值为" + sum);

            {
                Console.WriteLine("数组计算1");
                int I_b = 0;
                int[] I_project1 = { 1, 2, 3, 4, 5 };
                foreach (int number in I_project1)
                {
                    I_b += number;
                }
                Console.WriteLine("最终值为" + I_b);
            }
            {
                Console.WriteLine("数组计算2,break");
                int I_b = 0;
                int[] I_project1 = { 1, 2, 3, 4, 5 };
                foreach (int number in I_project1)
                {
                    if(number<2)
                    {
                        Console.WriteLine("跳出。");
                        break;
                    }
                    I_b += number;
                }
                Console.WriteLine("最终值为" + I_b);
            }
            {
                Console.WriteLine("数组计算3,continue,");
                int I_b = 0;
                int[] I_project1 = { 1, 2, 3, 4, 5 };
                foreach (int number in I_project1)
                {
                    if (number < 2)
                    {
                        continue;
                    }
                    I_b += number;
                }
                Console.WriteLine("最终值为" + I_b);
            }






            Console.ReadKey();
        }
    }
}
