using System;

namespace _022_多条件判断
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("您考了多少分？");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score < 0 || score > 100)
            {
                Console.WriteLine("请输入正确的分数！");
            }else if(score>=0 && score <= 59)
            {
                Console.WriteLine("差，继续努力！");
            }else if (score >= 60 && score <= 79)
            {
                Console.WriteLine("中，加油！");
            }else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("良，不错！");
            }else
            {
                Console.WriteLine("优，你很棒！");
            }
            Console.ReadKey();

        }
    }
}
