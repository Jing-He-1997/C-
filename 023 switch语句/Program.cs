using System;

namespace _023_switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 3;
            switch (state)
            {
                case 0:
                    Console.WriteLine("当前是开始界面");
                    break;
                case 1:
                    Console.WriteLine("当前是战斗中");
                    break;
                case 2:
                    Console.WriteLine("游戏暂停");
                    break;
                case 3:
                    Console.WriteLine("游戏胜利");
                    break;
                case 4:
                    Console.WriteLine("游戏失败");
                    break;
                //case 5:
                //case 6:
                //    //两个case语句可以放在一起
                //    Console.WriteLine("游戏保存中");
                //    break;
                default:
                    Console.WriteLine("当前state超出了游戏状态的范围");
                    break;
            }
            Console.ReadKey();


        }
    }
}
