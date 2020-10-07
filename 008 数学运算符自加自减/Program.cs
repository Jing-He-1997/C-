using System;

namespace _008_数学运算符自加自减
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 45;
            ////num1++;
            ////++num1;//++不管是放在操作数的前面还是后面，都是让操作数+1
            ////int res = num1++;//45
            //int res= ++num1;//46 ++如果放在前面会先进行自增，然后在进行其余的运算，如果放在操作数的后面，会先使用操作数进行运算，然后让操作数自增
            //Console.WriteLine(res+":"+num1);

            int num1 = 45;
            int res = num1--;
            int res1 =--num1;
            Console.WriteLine(res + ":" + num1+"\n"+res1 + ":" + num1);
            Console.ReadKey();


        }
    }
}
