using System;
using System.Collections.Generic;
using System.Text;
using static 贪吃蛇.Number;


namespace 贪吃蛇
{ 
    public static class Number
    {
        public static Random r = new Random();//随机数生成器
        public static Random food = new Random();//食物随机数生成器

        public static int x = 50, y = 20;//画面大小
        public static int cg = 1;//阶段控制
        
        
        public static int xfood, yfood;

        public static  List<int> snakeX = new List<int>();//蛇身体坐标数组
        public static List<int> snakeY = new List<int>();//蛇身体坐标数组

        public static int chi = 0;
        public static int yichi = 0;

        public static int oldx = 0;
        public static int oldy = 0;
        public static int tailX = 0;
        public static int tailY = 0;
    }
    internal class 主程序
    {

        static void Main()
        {
            Console.SetWindowSize(x + 1, y + 1);//设置窗口大小
            Console.SetBufferSize(x + 1, y + 1);//设置缓冲区大小


            Console.CursorVisible = false;//关闭光标

            Start s = new Start();//创建开始界面对象

            End e = new End();//创建结束界面对象

            Generate g = new Generate();//创建蛇对象

            Walk walk = new Walk();//创建蛇移动对象

            Food walkFood = new Food();//创建食物对象



            snakeX.Add(r.Next(2, x - 2));//随机生成蛇的初始位置
            snakeY.Add(r.Next(2, y - 2));//随机生成蛇的初始位置

            while (true)
            {
                switch (cg)
                {
                    case 1:
                        {
                            s.draw();
                            Console.Clear();
                            break;
                        }

                    case 2:
                        {
                            Wall.print();
                            g.print();
                            walkFood.draw();
                            walk.move();
                            Console.Clear();
                            break;
                        }

                    case 3:
                        {
                            e.draw();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
