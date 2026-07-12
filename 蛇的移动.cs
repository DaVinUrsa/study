using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using 贪吃蛇;
using static 贪吃蛇.Number;

namespace 贪吃蛇
{
    public class Generate//生成一个头
    {
        public void print ()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(snakeX[0], snakeY[0]);
            Console.Write('■');
        }
    }

    

    public class Walk//控制移动
    {
        public void move()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            char z = 'b' , b =  'b';
            Nothit nothit = new Nothit();
            Eat eat = new Eat();

            while (true)
            {
                if( z != b )
                {
                    z = b;
                }
                else
                {
                    z = Console.ReadKey(true).KeyChar;
                }
                switch (z)
                {
                    case 'w':
                    case 'W':
                        {
                            while(true)
                            {
                                nothit.judge(snakeX[0], snakeY[0]);
                                if (cg == 3)
                                {
                                    break;
                                }

                                if (Console.KeyAvailable)
                                {
                                    b = Console.ReadKey(true).KeyChar;
                                    if (b != 'w'&& b != 'W')
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                   for(int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write(' ');
                                    }

                                    oldx = snakeX[0];
                                    oldy = snakeY[0];

                                    tailX = snakeX[snakeX.Count - 1];
                                    tailY = snakeY[snakeY.Count - 1];

                                    for (int i = snakeX.Count - 1; i > 0; i--)
                                    {
                                        snakeX[i] = snakeX[i - 1];
                                        snakeY[i] = snakeY[i - 1];
                                    }

                                    snakeY[0]--;
                                    
                                    eat.eat();

                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    for (int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write('■');
                                    }


                                    Thread.Sleep(500);
                                }
                            }
                            break;
                            
                        }
                       
                    case 's':
                    case 'S':
                        {
                            while (true)
                            {
                                nothit.judge(snakeX[0], snakeY[0]);
                                if (cg == 3)
                                {
                                    break;
                                }

                                if (Console.KeyAvailable)
                                {
                                    b = Console.ReadKey(true).KeyChar;
                                    if (b != 's' && b != 'S')
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write(' ');
                                    }

                                    oldx = snakeX[0];
                                    oldy = snakeY[0];

                                    tailX = snakeX[snakeX.Count - 1];
                                    tailY = snakeY[snakeY.Count - 1];

                                    for (int i = snakeX.Count - 1; i > 0; i--)
                                    {
                                        snakeX[i] = snakeX[i - 1];
                                        snakeY[i] = snakeY[i - 1];
                                    }

                                    snakeY[0]++;

                                    eat.eat();

                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    for (int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write('■');
                                    }


                                    Thread.Sleep(500);
                                }
                            }
                            break;
                        }
                        
                    case 'a':
                    case 'A':
                        {
                            while (true)
                            {
                                nothit.judge(snakeX[0], snakeY[0]);
                                if (cg == 3)
                                {
                                    break;
                                }

                                if (Console.KeyAvailable)
                                {
                                    b = Console.ReadKey(true).KeyChar;
                                    if (b != 'a' && b != 'A')
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write(' ');
                                    }

                                    oldx = snakeX[0];
                                    oldy = snakeY[0];

                                    tailX = snakeX[snakeX.Count - 1];
                                    tailY = snakeY[snakeY.Count - 1];

                                    for (int i = snakeX.Count - 1; i > 0; i--)
                                    {
                                        snakeX[i] = snakeX[i - 1];
                                        snakeY[i] = snakeY[i - 1];
                                    }

                                    snakeX[0]--;

                                    eat.eat();

                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    for (int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write('■');
                                    }


                                    Thread.Sleep(500);
                                }
                            }
                            break;
                        }
                        
                    case 'd':
                    case 'D':
                        {
                            while (true)
                            {
                                nothit.judge(snakeX[0], snakeY[0]);
                                if (cg == 3)
                                {
                                    break;
                                }

                                if (Console.KeyAvailable)
                                {
                                    b = Console.ReadKey(true).KeyChar;
                                    if (b != 'd' && b != 'D')
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write(' ');
                                    }

                                    oldx = snakeX[0];
                                    oldy = snakeY[0];

                                    tailX = snakeX[snakeX.Count - 1];
                                    tailY = snakeY[snakeY.Count - 1];

                                    for (int i = snakeX.Count - 1; i > 0; i--)
                                    {
                                        snakeX[i] = snakeX[i - 1];
                                        snakeY[i] = snakeY[i - 1];
                                    }

                                    snakeX[0]++;

                                    eat.eat();

                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    for (int i = 0; i < snakeX.Count; i++)
                                    {
                                        Console.SetCursorPosition(snakeX[i], snakeY[i]);
                                        Console.Write('■');
                                    }


                                    Thread.Sleep(500);
                                }
                            }
                            break;
                        }
                        
                }
                if (cg == 3)
                {
                    break;
                }

            }
        }
    }
    
}
