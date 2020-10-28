using System;

namespace 练习9_1_猴子吃桃
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入天数：");
            int day = Convert.ToInt32(Console.ReadLine());
            long sum = 1;
            for (int i = 1; i < day; i++)
            {
                long n= Convert.ToInt64(Math.Pow(2, i-1));//计算的最大值为62天
                sum += 3 * n;
            }
            Console.WriteLine("猴子一共吃了{0}颗桃子", sum);
            Console.ReadKey();
        }
    }
}
