using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇;
using static 贪吃蛇.Number;

namespace 贪吃蛇
{
    public class Food
    {
        public void draw()
        {
            while (true)
            {
                xfood = food.Next(1, x - 1);
                yfood = food.Next(1, y - 1);
                if (xfood == snakeX[0] && yfood == snakeY[0])
                {
                    continue;
                }
                else
                {
                    break;
                }            
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xfood, yfood);
            Console.Write('■');
        }
    }

    public class Eat()
    {
        /*public void eat()
        {
            if (snakeX[0] == xfood && snakeY[0] == yfood)
            {
                chi = chi + 1;
                snakeX.Add(0);
                snakeY.Add(0);
                Console.SetCursorPosition(xfood, yfood);
                Console.Write(' ');
                Food f = new Food();
                f.draw();
                
            }
        }*/

        public void eat()
        {
            if (snakeX[0] == xfood && snakeY[0] == yfood)
            {
                snakeX.Add(tailX);
                snakeY.Add(tailY);
                Console.SetCursorPosition(xfood, yfood);
                Console.Write(' ');
                Food f = new Food();
                f.draw();
            }
            
        }
    }
}