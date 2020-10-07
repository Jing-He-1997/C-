using System;

namespace _004_定义变量存储主角的信息
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "JING";
            int hp = 100;
            int level = 34;
            float exp = 345.3f;
            //long l = 100000000000L;

            Console.WriteLine("角色:\t\\\"{0}\" \n血量:{1} \n等级:{2} \n经验值:{3}", name, hp, level, exp);//一个水平字表符表示四个空格 \t
            Console.ReadKey();
        }
    }
}
