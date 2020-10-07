using System;

namespace 练习8_4_7_13_1000之内的所有完数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1000以内的完数有：");
            for(int i = 2; i <= 1000; i++)//从2开始是因为完数要除去数本身（数本身不算因子）
            {
                int sum = 0;
                for(int j = 1; j <= i-1; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
