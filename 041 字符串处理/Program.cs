using System;

namespace _041_字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "  www.  b  aidu.  CO  M  ";
            //str.Length//可以通过.length取到一个字符串的长度
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //string res = str.ToLower();//把字符串转化成小写并返回 对原字符串没有影响
            //string res = str.ToUpper();//把字符串转化成大写并返回 对原字符串没有影响
            //string res = str.Trim();//去掉字符串前面和后面的空格
            //string res = str.TrimStart();//去掉字符串前面的空格
            //string res = str.TrimEnd();//去掉字符串后面的空格
            string[] strArray=str.Split('.');//把原字符串按照指定的字符进行拆分，得到一个拆分后的字符串数组
            
            //Console.WriteLine(res+"|");
            Console.WriteLine(str+"|");

            foreach (string temp in strArray)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
