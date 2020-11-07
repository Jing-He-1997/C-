using System;
using System.Linq;

namespace 练习9_6_回文串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个字母字符串：");
            string str = Console.ReadLine();
            //char[] chars = str.ToArray();//将string类型的字符串转换为char[]类型的字符串
            //Array.Reverse(chars,0,str.Length);//将chars倒序输出
            //string str1 = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    str1 += chars[i];
            //}

            //if (str.Equals(str1))//由于string是微软封装的一个字符串类，在内部他已经对 = = 操作符进行了重写。重写后他比较的则是两个变量的内容是否相同,而不是地址
            //{
            //    Console.WriteLine(str + " 是回文串");
            //}
            //else
            //{
            //    Console.WriteLine(str + " 不是回文串");
            //}

            bool isHui = true;
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i]!=str[str.Length-1-i])
                {
                    isHui =false;
                    break;
                }
            }

            if (isHui)
            {
                Console.WriteLine(str+"是回文串!");
            }
            else
            {
                Console.WriteLine(str+"不是回文串！");
            }

            Console.ReadKey();
        }
    }
}
