using System;

namespace 练习2_交换变量存储值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个整数:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个整数:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //指针存放
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("num1:{0} num2:{1}", num1, num2);
            Console.ReadKey();

        }
    }
}
