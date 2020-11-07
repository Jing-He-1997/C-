using System;

namespace 练习9_5_判断是否为Csharp合法标识符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入C#标识符：");
            string str=Console.ReadLine();
            bool isRight = true;
                if ((str[0]>='a'&&str[0]<='z')|| (str[0] >= 'A' && str[0] <= 'Z')||str[0]=='_'||str[0]=='@')
                {
                }
                else
                {
                    isRight =false;
                }

                for (int i = 1; i < str.Length; i++)
                {
                    if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || str[i] == '_' || (str[i] >= '1' && str[i] <= '9'))
                    {
                    }
                    else
                    {
                        isRight = false;
                        break;
                    }
                }

                if (isRight==true)
                {
                    Console.WriteLine(str+"是C#合法标识符");
                }
                else
                {
                    Console.WriteLine("\""+str+"\" 不是C#合法标识符");
                }

                Console.ReadKey();
        }
    }
}
