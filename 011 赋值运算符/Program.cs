using System;

namespace _011_赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;//这个是最基本的赋值运算符
            num1 += 12;//num1=num1+12 46
            num1 -= 12;//num1=num1-12 34
            num1 *= 2; //num1=num1*2 68
            num1 /= 2;//num1=num1/2 34
            num1 %= 2;//num1=num1%2 0
            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
