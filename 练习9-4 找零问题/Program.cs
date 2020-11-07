using System;
using System.Collections;
using System.Collections.Generic;

namespace 练习9_4_找零问题
{
    struct Teacher
    {
        public string name;
        public int salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("就职老师数：");
            int teachNum = Convert.ToInt32(Console.ReadLine());
            List<Teacher> teachers=new List<Teacher>();
            for (int i = 0; i < teachNum; i++)
            {
                Teacher teacher=new Teacher();
                Console.Write("请输入第{0}位老师的姓名：",i+1);
                teacher.name = Console.ReadLine();//需要处理异常
                Console.Write("请输入第{0}位老师的薪水：", i+1);
                teacher.salary = Convert.ToInt32(Console.ReadLine());//需要处理异常
                Console.WriteLine("{0}老师的薪水为{1}",teacher.name,teacher.salary);
                teachers.Add(teacher);
            }
            //统计所有老师薪水所需要的6种钞票数
            int counts100 = 0;
            int counts50 = 0;
            int counts20 = 0;
            int counts10 = 0;
            int counts5 = 0;
            int counts1 = 0;

            for (int i = 0; i <teachers.Count; i++)
            {
                //统计每位老师薪水所需要的6种钞票数
                int count100 = 0;
                int count50 = 0;
                int count20 = 0;
                int count10 = 0;
                int count5 = 0;
                int count1 = 0;

                int sum = teachers[i].salary;

                count100 = sum / 100;
                counts100 += count100;
                sum -= 100 * count100;

                count50 = sum / 50;
                counts50 += count50;
                sum -= 50 * count50;

                count20 = sum / 20;
                counts20 += count20;
                sum -= 20 * count20;

                count10 = sum / 10;
                counts10 += count10;
                sum -= 10 * count10;

                count5 = sum / 5;
                counts5 = count5;
                sum -= 5 * count5;

                count1 = sum / 1;
                counts1 += count1;
                sum -= 1 * count1;
                
            }

            

            

            Console.WriteLine("100元需要准备{0}张，50元需要准备{1}张，20元需要准备{2}张，10元需要准备{3}张，5元需要准备{4}张，1元需要准备{5}张",counts100,counts50,counts20,counts10,counts5,counts1);
            Console.ReadKey();
        }
    }
}
