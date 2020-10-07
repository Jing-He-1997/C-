using System;

namespace 练习7_6_1_100中能被3整除不能被5整除的数的个数
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("一共有{0}个这样的数", count);
            Console.ReadKey();
        }
    }
}
