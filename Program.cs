#region 优化代码2

Console.CursorVisible = false;

int x = 50, y = 20;
Console.SetWindowSize(x, y);
Console.SetBufferSize(x, y);


int cg = 1;

int m1 = 0;
int n1 = 0;

int m = 0, n = 0;

while (true)
{

    switch (cg)
    {
        case 1:

            {
                #region 界面设置

                Console.ForegroundColor = ConsoleColor.Yellow;

                int b = 1;

                Console.SetCursorPosition(x / 2 - 2, 8);
                Console.Write("开始界面");

                Console.SetCursorPosition(x / 2 - 4, 17);
                Console.Write("按j开始游戏");

                while (true)
                {

                    if (b == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x / 2 - 2, 13);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(x / 2 - 2, 13);
                    }

                    Console.Write("开始游戏");

                    if (b == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x / 2 - 2, 15);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(x / 2 - 2, 15);
                    }

                    Console.Write("结束游戏");

                    char c = Console.ReadKey(true).KeyChar;
                    if (c == 'j' && b == 1)
                    {
                        cg = 2;
                        break;
                    }
                    else if (c == 'j' && b == 0)
                    {
                        cg = 3;
                        break;
                    }
                    switch (c)
                    {
                        case 'w':
                        case 'W':
                            {
                                b = 1;
                                break;
                            }
                            ;
                        case 's':
                        case 'S':
                            {
                                b = 0;
                                break;
                            }
                    }


                }
                #endregion
                break;
            }

        case 2:
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                Random x1 = new Random();
                Random y1 = new Random();

                int xboss = x1.Next(2, x - 3);
                int yboss = x1.Next(2, y - 5);

                #region boss
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xboss, yboss);
                    Console.Write("B");

                    if (xboss == 2 && yboss == 2)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;


                #endregion



                #region 墙
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < x; i++)
                {
                    Console.Write('0');
                }

                Console.SetCursorPosition(0, y - 1);
                for (int i = 0; i < x; i++)
                {
                    Console.Write('0');
                }

                Console.SetCursorPosition(0, y - 4);
                for (int i = 0; i < x; i++)
                {
                    Console.Write('0');
                }

                Console.SetCursorPosition(y - 1, 0);
                for (int i = 0; i < y; i++)
                {
                    Console.Write('0');
                    Console.SetCursorPosition(x - 1, i);
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < y; i++)
                {
                    Console.Write('0');
                    Console.SetCursorPosition(0, i);
                }
                #endregion

                m = 2;
                n = 2;


                #region 移动
                Console.CursorVisible = false;

                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(2, 2);

                Console.Write(1);

                char c;

                while (true)
                {
                    c = Console.ReadKey(true).KeyChar;
                    Convert.ToString(c);

                    if (m == m1 && n == n1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.SetCursorPosition(m, n);
                        Console.Write(" ");
                    }



                    m1 = m;
                    n1 = n;

                    switch (c)
                    {
                        case 'w':
                        case 'W':
                            {
                                --n;
                                if (n < 1)
                                {
                                    ++n;
                                }
                                break;
                            }


                        case 's':
                        case 'S':
                            {
                                ++n;
                                if (n > y - 5)
                                {
                                    --n;
                                }
                                break;
                            }

                        case 'd':
                        case 'D':
                            {
                                ++m;
                                if (m > x - 2)
                                {
                                    --m;
                                }
                                break;
                            }


                        case 'a':
                        case 'A':
                            {
                                --m;
                                if (m < 1)
                                {
                                    ++m;
                                }
                                break;
                            }


                    }

                    if (m == xboss && n == yboss)
                    {
                        m = m1;
                        n = n1;
                    }

                    Console.SetCursorPosition(m, n);
                    Console.Write(1);

                    if ((m == xboss + 1 || m == xboss - 1) && (n == yboss + 1 || n == yboss - 1))
                    {
                        Console.SetCursorPosition(2, y - 3);
                        Console.Write("开始战斗！");
                        Console.SetCursorPosition(40, y - 2);
                        Console.Write("按j下一步");

                        break;
                    }

                    --m1;
                    --n1;

                }

                #endregion
                cg = 4;

                break;
            }

        case 3:
            {
                #region 结束界面
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.SetCursorPosition(x / 2 - 2, 8);
                Console.Write("结束界面");

                Console.SetCursorPosition(x / 2 - 2, 17);
                Console.Write("按j确定");

                int b1 = 1;
                while (true)
                {

                    if (b1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x / 2 - 2, 13);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(x / 2 - 2, 13);
                    }
                    Console.Write("重新开始");

                    if (b1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x / 2 - 2, 15);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(x / 2 - 2, 15);
                    }
                    Console.Write("退出游戏");

                    char c1 = Console.ReadKey(true).KeyChar;

                    if (c1 == 'j' && b1 == 1)
                    {
                        cg = 1;
                        break;
                    }
                    else if (c1 == 'j' && b1 == 2)
                    {
                        Environment.Exit(0);
                    }
                    switch (c1)
                    {
                        case 'w':
                        case 'W':
                            b1 = 1;
                            break;
                        case 's':
                        case 'S':
                            b1 = 2;
                            break;
                    }
                }
                #endregion

                break;

            }
        case 4:
            {
                #region 对战环节
                Random hps = new Random();

                int bosshp = hps.Next(0, 2);

                int defense = 10;

                int playerhp = hps.Next(10, 20);

                int sum;

                while (true)
                {
                    Random atks = new Random();
                    int bossatk = atks.Next(2, 5);
                    int playeratk = atks.Next(5, 15);

                    if (playeratk < defense)
                    {
                        sum = 0;
                    }
                    else
                    {
                        sum = playeratk - defense;
                    }

                    bosshp -= sum;
                    playerhp -= bossatk;

                    char c = Console.ReadKey(true).KeyChar;

                    if (c == 'j')
                    {
                        Console.SetCursorPosition(2, y - 3);
                        Console.Write("您攻击力为{0}，boss扣除血量为{1}，您扣除了{2}点血", playeratk, sum, bossatk);
                        Console.SetCursorPosition(2, y - 2);
                        Console.Write("剩余血量{0}", playerhp);

                    }

                    if (playerhp <= 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(x / 2 - 3, y / 2);
                        Console.Write("YOU DIE");
                        Console.SetCursorPosition(x / 2 - 3, y / 2 - 2);
                        Console.Write("按j继续");

                        c = Console.ReadKey(true).KeyChar;

                        if (c == 'j')
                        {
                            cg = 3;
                            break;
                        }
                    }
                    else if (bosshp <= 0)

                    {
                        Console.SetCursorPosition(x / 2 - 3, y / 2);
                        Console.Write("YOU win");
                        Console.SetCursorPosition(x / 2 - 3, y / 2 - 2);
                        Console.Write("按j继续");
                        c = Console.ReadKey(true).KeyChar;
                        if (c == 'j')
                        {
                            m1 = 0;
                            n1 = 0;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();

                            Random x1 = new Random();
                            Random y1 = new Random();

                            int xboss = x1.Next(2, x - 3);
                            int yboss = x1.Next(2, y - 5);

                            #region boss
                            while (true)
                            {

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(xboss, yboss);
                                Console.Write("J");

                                if (xboss == m && yboss == n)
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            Console.ForegroundColor = ConsoleColor.White;


                            #endregion



                            #region 墙
                            Console.SetCursorPosition(0, 0);
                            for (int i = 0; i < x; i++)
                            {
                                Console.Write('0');
                            }

                            Console.SetCursorPosition(0, y - 1);
                            for (int i = 0; i < x; i++)
                            {
                                Console.Write('0');
                            }

                            Console.SetCursorPosition(0, y - 4);
                            for (int i = 0; i < x; i++)
                            {
                                Console.Write('0');
                            }

                            Console.SetCursorPosition(y - 1, 0);
                            for (int i = 0; i < y; i++)
                            {
                                Console.Write('0');
                                Console.SetCursorPosition(x - 1, i);
                            }

                            Console.SetCursorPosition(0, 0);
                            for (int i = 0; i < y; i++)
                            {
                                Console.Write('0');
                                Console.SetCursorPosition(0, i);
                            }
                            #endregion

                            #region 移动
                            Console.CursorVisible = false;

                            Console.ForegroundColor = ConsoleColor.Red;

                            while (true)
                            {
                                c = Console.ReadKey(true).KeyChar;
                                Convert.ToString(c);

                                if (m == m1 && n == n1)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.SetCursorPosition(m, n);
                                    Console.Write(" ");
                                }



                                m1 = m;
                                n1 = n;

                                switch (c)
                                {
                                    case 'w':
                                    case 'W':
                                        {
                                            --n;
                                            if (n < 1)
                                            {
                                                ++n;
                                            }
                                            break;
                                        }


                                    case 's':
                                    case 'S':
                                        {
                                            ++n;
                                            if (n > y - 5)
                                            {
                                                --n;
                                            }
                                            break;
                                        }

                                    case 'd':
                                    case 'D':
                                        {
                                            ++m;
                                            if (m > x - 2)
                                            {
                                                --m;
                                            }
                                            break;
                                        }


                                    case 'a':
                                    case 'A':
                                        {
                                            --m;
                                            if (m < 1)
                                            {
                                                ++m;
                                            }
                                            break;
                                        }


                                }

                                if (m == xboss && n == yboss)
                                {
                                    m = m1;
                                    n = n1;
                                }

                                Console.SetCursorPosition(m, n);
                                Console.Write(1);

                                if ((m == xboss + 1 || m == xboss - 1) && (n == yboss + 1 || n == yboss - 1))
                                {
                                    Console.SetCursorPosition(2, y - 3);
                                    Console.Write("结束！");
                                    Console.SetCursorPosition(40, y - 2);
                                    Console.Write("按j下一步");
                                    c = Console.ReadKey(true).KeyChar;
                                    if (c == 'j')
                                    {
                                        break;

                                    }
                                }

                                --m1;
                                --n1;

                            }

                            #endregion
                            cg = 3;
                            break;
                        }

                    }


                }
                #endregion
                break;
            }

    }
}
#endregion
