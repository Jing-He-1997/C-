using System;

namespace _012_运算符的优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12 + 90;
            int num1 = 12 + 90 * 2/4%4;//在程序中的表达式子，先进行优先级高的运算符的运算
            int num2 = (12 + 90) * 2;//可以通过（）改变运算符的优先级
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
