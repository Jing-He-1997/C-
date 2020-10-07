using System;

namespace _018_条件布尔运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            //    bool res = !var1;//！取反操作 当var1为true res为false 当var1为false res为true
            //    bool res1 = var1 & var2;//false
            //    bool res2 = var1 | var2;//true
            //    bool res3 = var1 ^ var2;//true
            //    Console.WriteLine(res);
            //    Console.WriteLine(res1);
            //    Console.WriteLine(res2);
            //    Console.WriteLine(res3);

            //&& ||
            bool res = var1 && var2;//false
            bool res2 = var1 || var2;//true
            Console.WriteLine(res);
            Console.WriteLine(res2);

            Console.ReadKey(); 
        }
        //&和&&的区别 &：无论如何都会计算var1和var2 &&：若var1为false，则不计算var2
        //|和||的区别 |：无论如何都会计算var1和var2 ||：若var1为false才会计算var2
    }
}
