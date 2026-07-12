using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using 贪吃蛇;
using static 贪吃蛇.Number;

namespace 贪吃蛇
{
    internal interface Isharp
    {
        void draw();
        
    }


    public class Start : Isharp
    {
        public void draw()
        {
            Iprint.pdraw(x / 2 - 2, 8, false, "开始界面");

            Iprint.pdraw(x / 2 - 2, 13, false, "开始游戏");

            Iprint.pdraw(x / 2 - 2, 15, false, "结束游戏");

            Iprint.pdraw(x / 2 - 2, 17, false, "按J;确定");

            int b = 1;

            Judge j = new Judge ();

            while (true)
            {
                char c = Console.ReadKey(true).KeyChar;

                cg=j.judge1(c,b);
                if (cg == 2||cg == 3)
                {
                    return;
                }

                switch (c)
                {
                    case 'w':
                    case 'W':
                        {
                            b = 1;
                            Iprint.pdraw(x / 2 - 2, 13, true, "开始游戏");
                            Iprint.pdraw(x / 2 - 2, 15, false, "结束游戏");
                            break;
                        }
                        ;
                    case 's':
                    case 'S':
                        {
                            b = 0;
                            Iprint.pdraw(x / 2 - 2, 13, false, "开始游戏");
                            Iprint.pdraw(x / 2 - 2, 15, true, "结束游戏");
                            break;
                        }
                }
                 

            }
        }
    }
    

    
    public class End : Isharp
    {
        public void draw()
        {
            Iprint.pdraw(x / 2 - 2, 8, false, "结束界面");

            Iprint.pdraw(x / 2 - 2, 13, false, "重新游戏");

            Iprint.pdraw(x / 2 - 2, 15, false, "退出游戏");

            Iprint.pdraw(x / 2 - 2, 17, false, "按J;确定");

            int b = 1;

            Judge j = new Judge();

            while (true)
            {
                char c = Console.ReadKey(true).KeyChar;

                cg = j.judge1(c, b);
                if (cg == 2 || cg == 3)
                {
                    return;
                }

                switch (c)
                {
                    case 'w':
                    case 'W':
                        {
                            b = 1;
                            Iprint.pdraw(x / 2 - 2, 13, true, "重新游戏");
                            Iprint.pdraw(x / 2 - 2, 15, false, "退出游戏");
                            break;
                        }
                        ;
                    case 's':
                    case 'S':
                        {
                            b = 0;
                            Iprint.pdraw(x / 2 - 2, 13, false, "重新游戏");
                            Iprint.pdraw(x / 2 - 2, 15, true, "退出游戏");
                            break;
                        }
                }


            }
        }
    }
}



