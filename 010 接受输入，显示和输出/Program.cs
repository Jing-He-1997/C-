using System;

namespace _010_接受输入_显示和输出
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个数字:");
            string str1 = Console.ReadLine();
            Console.Write("请输入第二个数字:");
            string str2 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);
            int res = num1 + num2;
            Console.WriteLine("您输入的结果为：" + res);

            Console.ReadKey();
        }
    }
}
