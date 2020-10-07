using System;

namespace 练习7_2_输入操作数
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            Console.Write("请输入第一个数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个数：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入操作数（0代表+，1代表-，2代表*，3代表/）：");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index == 0)
            {
                res = num1 + num2;
            }
            if (index == 1)
            {
                res = num1 - num2;
            }
            if (index == 2)
            {
                res = num1 * num2;
            }
            if (index == 3)
            {
                res = num1 / num2;
            }
            else
            {
                Console.WriteLine("请输入正确的操作数!!!!");
                goto myLabel;
            }
            Console.WriteLine(res);
            myLabel: Console.ReadKey();
        }
    }
}
