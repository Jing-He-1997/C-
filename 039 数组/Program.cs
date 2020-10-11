using System;

namespace _039_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一种数组的初始化方式
            //int[] scores = {23, 24, 25, 26, 27, 28, 28, 29};//使用这种方式赋值的时候，一定要注意，在数组声明的时候赋值


            //第二种数组创建的方式
            //int[] scores=new int[10];
            //int[] scores;
            //scores=new int[10];

            //第三种数组创建方式
            //int[] scores=new int[10]{1,2,3,4,5,6,7,8,9,10};
            //Console.WriteLine(scores[0]);//当我们访问索引不存在的值会出现异常

            //char[] charArray=new char[2]{'a','b'};
            //Console.WriteLine(charArray[1]);

            string[] names=new string[]{"AA","BB","CC","DD"};
            Console.WriteLine(names[0]);
            Console.ReadKey();
        }
    }
}
