using System;

namespace 练习7_1_最大值最小值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个整数:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int maxNum = num1;
            int minNum = num1;
            Console.Write("请输入第二个整数:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 > maxNum)
            {
                maxNum = num2;
            }
            if (num2 < minNum)
            {
                minNum = num2;
            }
            Console.Write("请输入第三个整数:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 > maxNum)
            {
                maxNum = num3;
            }
            if (num3 < minNum)
            {
                minNum = num3;
            }
            Console.Write("请输入第四个整数:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            if (num4 > maxNum)
            {
                maxNum = num4;
            }
            if (num4 < minNum)
            {
                minNum = num4;
            }

            Console.WriteLine("四个数中，最大值为：{0}  最小值为：{1}", maxNum, minNum);
            Console.ReadKey();


        }
    }
}
