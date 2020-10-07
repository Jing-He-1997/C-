using System;

namespace _007_数字运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 14;
            //int num2 = 5;
            //int res1=num1 + num2;
            //int res2 = num1 - num2;
            //int res3 = num2 * num1;
            //int res4 = num1 / num2;
            //int res5 = num1 % num2;
            //double res = 123.4 % 2;

            //int num3 = 45;
            //double num4 = 3.1;
            //double res6 = num3 + num4;
            ////加减乘除两边的操作数都是整数的话，结果还是整数，如果不能被整除的话，自动略去小数部分
            //Console.WriteLine("假发的结果:{0}\n 减法的结果:{1} \n 乘法的结果:{2} \n 除法的结果:{3}\n 求余的结果:{4}和{5}", res1, res2, res3, res4, res5,res);


            //关于加法运算符更多的使用
            //1.字符串相加
            //string str1 = "123abc";
            //string str2 = "345cde";
            //string str = str1 = str2;
            //Console.WriteLine(str);

            //2.当一个字符串和一个数字相加，首先把数字转变成字符串，然后连接起来，结果是字符串
            string str1 = "123";
            int num = 456;
            string res = str1 + num;
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
