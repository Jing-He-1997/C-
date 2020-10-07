using System;

namespace 练习7_7_1000以内的素数
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 1000; i++)
            {
                bool flag = true;
                for (int j = 2; j <i; j++)
                {
                    int res = i % j;
                    if (res == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
