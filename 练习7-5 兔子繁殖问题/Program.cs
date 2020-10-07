using System;

namespace 练习7_5_兔子繁殖问题
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int group = 0;
            for(int i = 2; i <= 20; i++)
            {
                sum += group;
                group = sum-group;
            }
            Console.WriteLine("20个月后，兔子个数为：" + 2 * sum);
            Console.ReadKey();

        }
    }
}
