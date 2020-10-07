using System;

namespace 练习7_8_九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}*{1}={2} ", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
