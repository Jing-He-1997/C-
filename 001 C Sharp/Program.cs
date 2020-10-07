
using System;
using System.Collections.Generic;
using System.Text;
//定义命名空间
namespace _001_C_Sharp { 
    //定义一个类
    class Program
    //定义一个方法
    {
        
        static void Main(string[] args){
            //方法体
            Console.WriteLine("Hello World");
            Console.Write("this is text1, ");
            Console.Write("this is text2, ");
            Console.WriteLine("this is text3.");

            Console.WriteLine("两个数字相加{0}+{1}={2}", 3, 34, 34);
            Console.WriteLine("数字{0}和{1}以及{2}", 3, 34, 34);

            Console.ReadKey();
          
        }
    }
    //Home End键 定位光标到最前方和最后方
    //按住Shift 光标移动 （区间全选）
    //Ctrl   +A 全选代码 +S 保存当前代码 +X 剪切 +Home 定义第一个字符 +End 定义最后一个字符
    //Insert 键 覆盖字符
    
}
