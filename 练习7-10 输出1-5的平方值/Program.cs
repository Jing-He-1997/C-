using System;

namespace 练习7_10_输出1_5的平方值
{
    class Program
    {
        static void Main(string[] args)
        {
            ////for语句
            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i * i);
            //}

            ////while语句
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i * i);
            //    i++;
            //}

            //do while语句
            int i = 1;
            do
            {
                Console.WriteLine(i * i);
                i++;
            } while (i <= 5);

            Console.ReadKey();
        }
    }
}
