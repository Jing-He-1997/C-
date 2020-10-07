using System;

namespace 练习8_2_7_11_用户输入5个大写字母
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)//循环为死循环
            {
                Console.WriteLine("请输入5个大写字母：");
                string str = Console.ReadLine();
                if (str.Length != 5)
                {
                    Console.WriteLine("输入个数不等于5，请重新输入.");
                    continue;//跳出当前代码，进入下一次死循环
                }
                bool flag = true;//用来判断用户输入是否存在非字母
                bool flag1 = true;//用来判断用户输入是否存在小写字母

                for (int i = 0; i < 5; i++)//该循环通过遍历用户输入的形式查找用户输入的每个字符是否符合要求
                {
                    if (char.IsLetter(str[i]))//char.IsLetter()方法是确认用户输入的是字母
                    {
                        if (char.IsLower(str[i]))//char.IsLower()方法是确认用户输入的是小写字母
                        {
                            flag1 = false;//若在输入中找到小写字母，则flag1==false
                        }
                    }
                    else
                    {
                        flag = false;//若输入的不是字母，则flag==false
                    }
                }
                if (flag == false)//输出用户输入存在的问题，进行下一次死循环
                {
                    Console.WriteLine("输入包含非字母，请重新输入.");
                }
                else if (flag1 == false)//输出用户存在的问题，进行下一次死循环
                {
                    Console.WriteLine("输入包含小写字母，请重新输入.");
                }
                else//用户输入符合规范时进入，输出用户输入的内容
                {
                    Console.WriteLine("输出正确，结果为" + str);
                    break;//终止循环
                }
            }  
            Console.ReadKey();
        }
    }
}
