using System;

namespace _028_循环的终端continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (true)
            //{
            //    index++;
            //    if (index == 5)
            //    {
            //        continue;
            //    }
            //    if (index == 10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(index);//当index==5时，使用了continue关键字，那么continue后面的代码不会去执行了，直接会进行循环的条件判断，根据判断结果判定是否执行下一次循环
            //}


            int res = 0;
            while (true)
            {
                int index = Convert.ToInt32(Console.ReadLine());
                
                if (index % 2 !=0)
                {
                    continue;
                }
                if (index == 0)
                {
                    break;
                }
                res += index;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
