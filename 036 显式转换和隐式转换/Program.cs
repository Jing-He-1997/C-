using System;

namespace _036_显式转换和隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte myByte = 123;
            //int myInt = myByte;//把一个小类型的数据复制给大类型的变量时，编译器会自动进行类型转换

            //myByte = (byte) myInt;//当把一个大类型赋值给一个小类型的变量的时候，需要进行显式转换（强制类型转换），里面写需要转换的类型

            //float myFloat = myInt;
            //myInt = (int) myFloat;

            //char c = 'a';
            //myFloat = c;

            string str = "123";
            int num = Convert.ToInt32(str);//当字符串里面存储的是整数的时候，就可以转化成int double类型，否则出现异常
                                           //当字符串里面存储的是小数时，就可以转换成为double类型
            int myNum = 1234;
            string str2 = Convert.ToString(myNum);//可以把一个int float double byte类型转换成字符串 
            string str3 = myNum + "";//一个int float double byte类型直接加上一个空的字符串，相当于把这个数字转化成一个字符串
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
