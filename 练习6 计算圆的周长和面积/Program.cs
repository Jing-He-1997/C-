using System;

namespace 练习6_计算圆的周长和面积
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入圆的半径:");
            int n = Convert.ToInt32(Console.ReadLine());

           double length=2*n*Math.PI;
           double area =(Math.Pow(n,2))* Math.PI;

            Console.WriteLine("圆的周长为：{0} 圆的面积为：{1}", length, area);
            Console.ReadKey();
        }
    }
}
