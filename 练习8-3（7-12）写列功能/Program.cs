using System;

namespace 练习8_3_7_12_写列功能
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("输入一个整数n：");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("不能输入负数，sorry~");
                    break;
                }
                if (n == 0)
                {
                    n = n + 1;
                }
                if (n > 0)
                {
                    Console.WriteLine("输出结果为：");
                    for(int i = n; i >= 1; i--)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
