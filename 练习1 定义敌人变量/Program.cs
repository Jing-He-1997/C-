using System;

namespace 练习1_定义敌人变量
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nikoo";
            string type = "Thief";
            int age =18;
            double height = 1.85;
            double weight = 75;
            int hp = 100;
            int mp = 50;
            int dps = 12;
            int ac = 11;
            int ae = 8;
            int agi = 4;
            string buff = "double damage";
            Console.WriteLine("name:{0}\ntype:{1}\nage:{2}\nheight:{3}cm \nweight:{4}kg\n",name,type,age,height,weight);
            Console.Write("HP:{0} MP:{1}\nDPS:{2} AE:{3}\nAC:{4} AGI:{5} BUFF:{6}", hp, mp, dps, ae, ac, agi, buff);
            Console.ReadKey();

        }
    }
}
