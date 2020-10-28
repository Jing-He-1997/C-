using System;

namespace 练习8_5_水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100到999之间的仙花数为：");
            string str = "";
            for (int i = 100; i < 1000; i++)
            {
                int i1 = i / 100;
                int i2 = (i / 10) % 10;
                int i3 = i % 10;
                if (i == i1 * i1 * i1 + i2 * i2 * i2 + i3 * i3 * i3)
                {
                    str = i1 + "*" + i1 + "*" + i1 + "+" + i2 + "*" + i2 + "*" + i2 + "+" + i3 + "*" + i3 + "*" + i3;
                    Console.WriteLine(i + "=" + str);
                }
            }

            Console.ReadKey();
        }
    }
}
