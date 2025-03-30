using System.ComponentModel.Design.Serialization;

namespace _2._4._3_项目三
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("版本一，for_if版：\n  ");
            int Ia=0, Ib=1,input=0;
            for(int time=1;time<=20; time++)
            {
                if(time==1)
                {
                    input = Ia;
                    Console.WriteLine("数字"+time+":"+input + "\n");
                }
                else if(time==2)
                {
                    input = Ib;
                    Console.WriteLine("数字"+time + ":" + input + "\n");
                }
                else
                {
                    input = Ia + Ib;
                    Console.WriteLine("数字"+time + ":" + input + "\n");
                    Ia = Ib;
                    Ib = input;
                }
               
            }


            Console.WriteLine("版本二，数组版：\n");
            int[] series = new int[20];
            series[0] = 0;
            Console.WriteLine("数字1:" + series[0]);
            series[1] = 1;
            Console.WriteLine("数字2:" + series[1]);
            for (int time = 2; time < series.Length; time++)
            {
                series[time] = series[time - 1] + series[time - 2];
                Console.WriteLine("数字"+time+":"+series[time]);
            }
            Console.ReadLine();
        }
    }
}
