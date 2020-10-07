using System;

namespace 练习5_计算梯形面积
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入梯形的上底：");
            double shangdi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入梯形的下底：");
            double xiadi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入梯形的高：");
            double high = Convert.ToDouble(Console.ReadLine());

            double area = (shangdi + xiadi) * high / 2;
            Console.WriteLine("梯形的面积为：" + area);
            Console.ReadKey();
        }
    }
}
