namespace _2._4._4_项目四_数字古诗的保存和输出
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sentence1 = new char[] { '归', '来', '一', '只', '复', '一', '只' };
            char[] sentence2 = new char[] { '三', '四', '五', '六', '七', '八', '只' };
            char[] sentence3 = new char[] { '凤', '凰', '何', '少', '鸟', '何', '多' };
            char[] sentence4 = new char[] { '啄', '尽', '人', '间', '千', '石', '食' };
            Console.WriteLine("横向展示;\n");
            {
                for(int time=1;time<=4;time++)
                {
                    if(time==1)
                    {
                        for(int word=0;word<7;word++)
                        {
                            Console.Write(sentence1[word]);
                            if(word==6)
                            {
                                Console.Write("\n");
                            }
                        }
                    }//输出一句


                    if (time == 2)
                    {
                        for (int word = 0; word < 7; word++)
                        {
                            Console.Write(sentence2[word]);
                            if (word == 6)
                            {
                                Console.Write("\n");
                            }
                        }
                    }//输出一句


                    if (time == 3)
                    {
                        for (int word = 0; word <7; word++)
                        {
                            Console.Write(sentence3[word]);
                            if (word == 6)
                            {
                                Console.Write("\n");
                            }
                        }
                    }//输出一句


                    if (time == 4)
                    {
                        for (int word = 0; word <7; word++)
                        {
                            Console.Write(sentence4[word]);
                            if (word == 6)
                            {
                                Console.Write("\n");
                            }
                        }
                    }//输出一句

                }



            }


            Console.WriteLine("\n纵向展示;\n");
            {
                for (int time = 0; time <=7; time++)

                {
                    Console.Write(sentence1[time] + "\t");
                    Console.Write(sentence2[time] + "\t");
                    Console.Write(sentence3[time] + "\t");
                    Console.Write(sentence4[time] + "\t");
                    Console.Write("\n");
                }
            }
        }
    }
}
