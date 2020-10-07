using System;

namespace _003_变量的类型
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 34;
            int score = 6000;
            long count = 1000000000000000030;
            Console.WriteLine("byte:{0} int:{1} count:{2}", myByte, score, count);


            float myFloat= 12.5f;
            //默认的小数是double类型的 所以想要存储float类型需要在数字后面+f
            double myDouble = 12.6;
            Console.WriteLine("float:{0} double:{1}", myFloat, myDouble);

            char myChar = 'A';
            string myString = "A";
            string myString1 = "";
            bool myBool = true;//布尔类型
            Console.WriteLine("char:{0} string:{1} string1:{2} bool:{3}", myChar, myString, myString1, myBool);

            Console.ReadKey();

        }
    }
}
