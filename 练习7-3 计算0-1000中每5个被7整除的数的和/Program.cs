using System;

namespace 练习7_3_计算0_1000中每5个被7整除的数的和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0)
                {
                    sum = sum+i;
                    count++;
                    if (count >= 5 && count % 5 == 0)
                    {
                        Console.WriteLine(sum);
                        sum = 0;
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
