using System;


namespace 练习8_8__字符串加密
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一串字符串：");
            string str = Console.ReadLine();
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((Convert.ToInt32(str[i])>='x'&& Convert.ToInt32(str[i])<='z')|| (Convert.ToInt32(str[i]) >= 'X' && Convert.ToInt32(str[i]) <= 'Z'))
                {
                    int num = Convert.ToInt32((str[i]) - 23);
                    char c = Convert.ToChar(num);
                    str1+=c;
                }
                else
                {
                    int num = Convert.ToInt32((str[i]) +3);
                    char c = Convert.ToChar(num);//这里只能用ToChar不能用ToString ToString生成的是数字类型的字符串
                    str1 += c;
                }
            }
            Console.WriteLine("加密后的字符串为：" + str1);
            Console.ReadKey();
        }
    }
}
