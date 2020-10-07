using System;

namespace _021_三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myInteger = 10;
            //string resStr = (myInteger < 10) 
            //    ? "Less than 10" 
            //    : "Greater than or equal to 10";
            //Console.WriteLine(resStr);

            Console.WriteLine("请输入一个分数：");
            int score = Convert.ToInt32(Console.ReadLine());
            string resStr = score > 50 ? "您输入的分数大于50" : "您输入的分数小于等于50";
            Console.WriteLine(resStr);
            Console.ReadKey();
            

            
        }
    }
}
