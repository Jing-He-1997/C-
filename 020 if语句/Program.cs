using System;

namespace _020_if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool var = false;
            //if (var) 
            // Console.WriteLine("........");
            //Console.WriteLine("if后面的语句");


            Console.WriteLine("请输入一个分数：");
            int score = Convert.ToInt32(Console.ReadLine());
            //if (score > 50)
            //    Console.WriteLine("您输入的分数大于50");
            //if (score <= 50)
            //    Console.WriteLine("您输入的分数小于或等于50");

            if (score > 50)
            {
                score++;
                Console.WriteLine("您输入的分数大于50 "+score);
            }
            else 
            {
                score--;
                Console.WriteLine("您输入的分数小于或等于50 "+score); 
            }
            Console.ReadKey();
            
        }
    }
}
