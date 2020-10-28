using System;
using System.Collections.Generic;

namespace 练习9_3_特定条件插入数字
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("数组中的整数个数为：");
            ReEnter: int n = Convert.ToInt32(Console.ReadLine());
            if (n > 100)
            {
                Console.WriteLine("数字个数不能超过100！请重新输入：");
                goto ReEnter;//若超过100 返回ReEnter行
            }
            Random rd=new Random();//因为没有给出特定的数字，所以以随机数代替
            Console.Write("请输入需要插入的数字：");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            List<int>numList=new List<int>();
            for (int i = 0; i < n; i++)
            {
                nums[i] = rd.Next(1, 100);
                numList.Add(nums[i]);
            }

            for (int i = 0; i < numList.Count-1; i++)//遍历排序
            {
                for (int j = 0; j < numList.Count-1; j++)
                {
                    if (numList[j] > numList[j + 1])
                    {
                        int temp = numList[j];
                        numList[j] = numList[j + 1];
                        numList[j + 1] = temp;
                    }
                }
            }

            if (num>numList[numList.Count-1])//若需要插入的数字比排好序的最后一个数字大，则直接添加到list中
            {
                numList.Add(num);
            }
            else//如果不是上一个的条件，则插入
            {
                for (int i = 0; i < numList.Count; i++)
                {
                    if (num < numList[i])
                    {
                        numList.Insert(i, num);
                        break;
                    }
                }
            }
            
            Console.Write("输出结果为：");
            for (int i = 0; i < numList.Count; i++)
            {
                Console.Write(numList[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();//Enter后会多出一个数字？原因是什么？
        }
    }
}
