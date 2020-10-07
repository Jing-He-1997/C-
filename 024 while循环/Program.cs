using System;

namespace _024_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)//死循环
            //{
            //    Console.WriteLine("升级了");
            //}
            int index = 1;
            while (index<=9)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadKey();
        }
    }
}
