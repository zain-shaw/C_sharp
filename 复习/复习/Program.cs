using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 65, 75,55,85,95,64,52,30,80,98 };
            int number = 0;
            Console.Write("不及格为：");
            foreach (int input in scores)
            {

                if (input < 60)
                {
                    Console.Write(input + "\t");
                    number++;
                }
            }
            Console.Write("\n不及格人数为："+number);
            //计算不及格人数和值

            Console.Write("\n及格为：");
            foreach (int input in scores)
            {

                if (input >= 60)
                {
                    Console.Write(input + "\t");
                }

            }
            Console.Write("\n及格人数为：" + (scores.Length-number));
            //计算及格人数和值

            {
                int Ia = 0;
                foreach (int input in scores)
                {

                    Ia += input;

                }
                Console.Write("\n平均值为" +(Ia*1.0/scores.Length));
            }//计算平均值


            {
                Array.Sort(scores);//从小到大
                Array.Reverse(scores);//从大到小
                Console.Write("\n从大到小排序为：" );
                foreach (int input in scores)
                {
                   Console.Write(input + "\t");
                }
            }//给数组排序


            {
                int Ia = 0;
                foreach (int input in scores)
                {
                    if(input>Ia)
                    {
                        Ia = input;
                    }
                }
                Console.Write("\n最高成绩为：");
                Console.Write(Ia + "\t");
            }//计算最高成绩



            Console.ReadKey();
        }
    }
}
