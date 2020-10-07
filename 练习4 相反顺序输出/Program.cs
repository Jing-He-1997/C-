using System;

namespace 练习4_相反顺序输出
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入三位数的正整数：");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int ge = num1 % 10;
            int shi = (num1 / 10) % 10;
            int bai = num1 / 100;

            Console.WriteLine("{0}{1}{2}",ge,shi,bai);
            Console.ReadKey();
        }
    }
}
