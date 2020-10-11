using System;

namespace _037_枚举类型
{
    enum Gamestate:byte//修改该枚举类型的存储类型，默认为int  
    //枚举类型的定义
    {
        Pause=100,//默认代表整数0 修改默认值后递增
        Failed,//默认代表整数1 101
        Success,//默认代表整数2 102
        Start//默认代表整数3 103
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int state = 3;
            //if (state==3)
            //{
            //    Console.WriteLine("当前处于游戏开始界面");
            //}
            ////利用定义好的枚举类型 去声明变量
            //Gamestate state = Gamestate.Start;
            //if (state==Gamestate.Start)//枚举类型比较
            //{
            //    Console.WriteLine("游戏开始！");
            //}
            //Console.WriteLine(state);
            Gamestate state = Gamestate.Start;
            int num = (int) state;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
