using System;

namespace 练习8_7_猜数字游戏
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个数字：");
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num<25)
                {
                    Console.Write("您猜小了，这个数字比"+num+"大，请重新输入：");
                }
                if (num > 25)
                {
                    Console.Write("您猜大了，这个数字比" + num + "小，请重新输入：");
                }
                if (num==25)
                {
                    Console.Write("恭喜您猜对了，这个数字为："+num);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
