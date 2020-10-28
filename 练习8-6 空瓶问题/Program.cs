using System;

namespace 练习8_6_空瓶问题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("现在仓库里的可乐数为：");
            int num = Convert.ToInt32(Console.ReadLine());//初始可乐数
            int numEmpty = num;//初始空瓶子
            while (numEmpty>=3)
            {
                num += numEmpty/3;//喝了num瓶可乐
                int newCount = numEmpty / 3;//表示可以兑换多少瓶可乐
                int remainEmpty = numEmpty % 3;//表示剩余几个空瓶子没有被兑换
                numEmpty = newCount + remainEmpty;//兑换之后，还有多少空瓶子
            }
            Console.WriteLine("一共喝了"+num+"瓶可乐，剩余"+numEmpty+"个空瓶子");

            Console.ReadKey();
        }
    }
}
