using System;

namespace _005_在字符串前面加_
{
    class Program
    {
        static void Main(string[] args)
        {
            //当在字符串前面加上一个@字符的时候，我们就可以把一个字符串定义在多行
            //编译器不会再去识别字符串中的转义字符
            //如果需要在字符串中表示一个双引号的话，需要使用两个双引号
            string str1 = @"I'm a good man. \n
You are a bad girl.";
            Console.WriteLine(str1);
            string str2 = @"I'm a good man. \n""You are a bad girl.";//使用两个引号表示一个引号
            Console.WriteLine(str2);

            //使用@字符的第二个好处
            string path = "c:\\xxx\\xx\\xxx.doc";
            Console.WriteLine(path);
            string path2= @"c:\xxx\xx\xxx.doc";
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
