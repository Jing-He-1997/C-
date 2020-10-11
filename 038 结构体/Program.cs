using System;

namespace _038_结构体
{
    //可以把结构体当成几个类型组成的一个新的类型
    struct Position
    {
        public float x;
        public float y;
        public float z;
    }

    enum  Direction
    {
        West,
        North,
        East,
        South
    }

    struct Path
    {
        public float distance;
        public Direction dir;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////通过三个float类型的变量表示一个敌人的坐标
            //float enemy1X = 34;
            //float enemy1Y = 1;
            //float enemy1Z = 34;

            ////当使用结构体声明变量的时候，相当于使用结构体中的所有变量去声明
            //Position enemy1Position;
            //enemy1Position.x = 34;//可以通过.加上属性名来访问结构体中的指定变量
            //Position enemy2Position;

            Path path1;
            path1.dir = Direction.East;
            path1.distance = 1000;
        }
    }
}
