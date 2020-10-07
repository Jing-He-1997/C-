using System;

namespace _006_变量的声明和赋值
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl + k 然后 Ctrl + c 可以注释选中行
            //Crtl + k 然后 Ctrl + u 取消注释选中行
            //int age;
            int age = 25;
            age = 45;
            int hp, mp=90, exp=99;//没有初始化不能使用
            hp = 100;

            Console.WriteLine("age:{0} hp:{1} mp:{2} exp:{3}", age, hp, mp, exp);
            Console.ReadKey();
        }
    }
}
