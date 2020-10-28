using System;

namespace 练习9_2_输出n个数找到最小值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("准备输入数字的个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums=new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int i1 = 0;//i1为最小值在数组中的位置
            int minNum = nums[0];//将数字中最小值初始化为数组中的第一个数
            for (int i = 1; i < nums.Length-1; i++)
            {
                if (minNum > nums[i])
                {
                    minNum = nums[i];
                    i1 = i;//获取数组中最小数字的位置
                }
            }

            int temp = nums[0];
            nums[0] = nums[i1];
            nums[i1] = temp;

            Console.Write("输出结果为：");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
