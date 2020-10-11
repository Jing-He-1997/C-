using System;

namespace _040_数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = {1, 2, 3, 4, 5, 6, 7, 8};
            //scores.Length//得到数组的长度
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //int i = 0;
            //while (i<scores.Length)
            //{
            //    Console.WriteLine(scores[i]);
            //    i++;
            //}

            foreach (int temp in scores)//foreach会依次取到数组中的值，然后赋值给temp，然后执行循环体
            {
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }
    }
}
