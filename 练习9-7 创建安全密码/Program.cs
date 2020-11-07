using System;

namespace 练习9_7_创建安全密码
{
    class Program
    {
        static void Main(string[] args)
        {
                int count = 0;
                int count1 = 0;
                Console.WriteLine("请创建密码：");
                while (true)
                {
                    string str = Console.ReadLine();
                if (str.Length >= 8 && str.Length <= 16)
                {
                    //定义四个布尔值分别代表四种字符
                    bool isHaveUpper = false;
                    bool isHaveLower = false;
                    bool isHaveNumber = false;
                    bool isHaveSpecial = false;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] >= 'A' && str[i] <= 'Z')
                        {
                            isHaveUpper = true;
                        }
                        else if (str[i]>='a'&&str[i]<='z')
                        {
                            isHaveLower = true;
                        }
                        else if (str[i] >= '0' && str[i] <= '9')
                        {
                            isHaveNumber = true;
                        }
                        else if (str[i] == '~' || str[i] == '!' || str[i] == '@' || str[i] == '#' || str[i] == '$' || str[i] == '%' || str[i] == '^')
                        {
                            isHaveSpecial = true;
                        }
                        else
                        {
                            count1++;
                        }
                    }
                    
                    if (isHaveSpecial) count++;
                    if (isHaveNumber) count++;
                    if (isHaveUpper) count++;
                    if (isHaveLower) count++;

                    if (count>=3&&count1==0)
                    {
                        Console.WriteLine("密码创建成功！");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("不满足密码创建条件！请重新输入：");
                    }
                }
                else
                {
                    Console.WriteLine("密码长度应大于等于8且不超过16个字符！请重新输入：");
                }

                count1 = 0;//当再次进入循环时，count1要重置为0JI
                }

            Console.ReadKey();
        }
    }
}
