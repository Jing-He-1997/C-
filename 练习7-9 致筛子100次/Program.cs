using System;

namespace 练习7_9_掷筛子100次
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i1 = 0;
            int i2 = 0;
            int i3 = 0;
            int i4 = 0;
            int i5 = 0;
            int i6 = 0;
            for (int i = 0; i < 100; i++)
            {
                int num=rnd.Next(1, 7);
                if (num == 1)
                {
                    i1++;
                }
                if (num == 2)
                {
                    i2++;
                }
                if (num == 3)
                {
                    i3++;
                }
                if (num == 4)
                {
                    i4++;
                }
                if (num == 5)
                {
                    i5++;
                }
                if (num == 6)
                {
                    i6++;
                }
            }
            Console.WriteLine("筛子为1的次数为{0}\n筛子为2的次数为{1}\n筛子为3的次数为{2}\n筛子为4的次数为{3}\n筛子为5的次数为{4}\n筛子为6的次数为{5}", i1, i2, i3, i4, i5, i6);
            Console.ReadKey();
        }
    }
}
