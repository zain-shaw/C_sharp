using System.Numerics;

namespace 兔子跳台阶
{
    internal class Program
    {
        static int road1(int stair)
        {
            if(stair==0)
            {
                return 0 ;
            }
            else if(stair==1)
            {
                return 1;
            }
            else if(stair==2)
            {
                return 2;
            }
            else
            {
                return road1(stair - 1)+road1(stair-2);//到此处时代码会分成两股，一股计算stair-1，一股计算stair-2.
            }
        }
        static BigInteger road2(int stair)
        {
            if (stair == 0)
            {
                return 0;
            }
            else if (stair == 1)
            {
                return 1;
            }
            else if (stair == 2)
            {
                return 2;
            }
            else
            {
                BigInteger a = 1, b = 2,c=0;//biginteger数据类型，大小不受限制
                for(int time=3;time<=stair;time++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入台阶数：");
            int stair = int.Parse(Console.ReadLine());
            if(stair<=30)
            {
                Console.Write("共有" + road1(stair) + "种跳法");//结构限制，为了计算速度仅能计算30以下斐波那契数。
            }
            else
            {
                Console.Write("共有" + road2(stair) + "种跳法");
            }
        }
    }
}
