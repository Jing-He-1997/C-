using System;

namespace 练习7_4_输出1_100之间的平方于平方根
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine("当前数为：" + i+"，其平方为：{0}，平方根为：{1}",i*i,Math.Sqrt(i));
            }
            Console.ReadKey();
        }

    }
}
