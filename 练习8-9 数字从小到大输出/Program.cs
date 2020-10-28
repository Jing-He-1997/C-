using System;

namespace 练习8_9_数字从小到大输出
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一组数字：");
            string str = Console.ReadLine();
            string str1 = "";
            int[] nums=new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                str1 = Convert.ToString(str[i]);
                
                //处理格式异常
                //try
                //{
                //    nums[i] = int.Parse(str1); // int.Parse()方法将string类型转化为int类型
                //}
                //catch (FormatException e)
                //{
                //    throw new FormatException("输入内容错误！");
                //}

                if (int.TryParse(str1, out nums[i]))//该if语句判断用户输入的是否为数字   int.TryParse将string类型转化为int类型的同时省去了处理异常的部分
                {
                }
                else
                {
                    Console.WriteLine("输入内容错误！");
                    return;
                }
            }

            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (nums[j] < nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Console.Write("输出的结果为：");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }


            Console.ReadKey();
        }
    }
}//5768
