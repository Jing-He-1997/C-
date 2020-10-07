using System;

namespace _019_goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 5;
            //goto mylabel;//goto语句用来控制程序跳转到某个位置
            myInteger++;
           //mylabel:
            Console.WriteLine(myInteger);
            Console.ReadKey();

        }
    }
}
