using System;

namespace 练习3_显示乘积
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入四个整数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int res = num1 * num2 * num3 * num4;

            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
