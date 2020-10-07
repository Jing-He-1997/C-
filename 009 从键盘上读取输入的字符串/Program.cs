using System;

namespace _009_从键盘上读取输入的字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str=Console.ReadLine();//用来接收用户输入的一行文本，也叫做一行字符串，按下换行结束
            //Console.WriteLine(str);

            //string str = "123";
            //int num=Convert.ToInt32(str);//这个方法可以把一个整数的字符串转化为整数
            //num++;
            //Console.WriteLine(num);

            //string str = Console.ReadLine();
            //int num = Convert.ToInt32(str);
            //Console.WriteLine(num);

            //string str = Console.ReadLine();
            //double num = Convert.ToDouble(str);//这个方法可以把用户输入的小数字符串转化为double
            //Console.WriteLine(num);

            Console.Write("请输入第一个数字:");
            string str1 = Console.ReadLine();
            Console.Write("请输入第二个数字:");
            string str2 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);
            int res = num1 + num2;
            Console.WriteLine("您输入的结果为："+res);

            Console.ReadKey();
           
        }
    }
}
