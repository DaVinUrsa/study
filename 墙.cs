using System;
using System.Collections.Generic;
using System.Text;
using static 贪吃蛇.Number;

namespace 贪吃蛇
{
    public static class Wall
    {
        
        public static void print()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= x; i++)
            {
                Console.Write('0');
            }

            Console.SetCursorPosition(x, 0);
            for (int i = 0; i <= y; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write('0'); 
            }

            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= y; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('0');
            }

            Console.SetCursorPosition(0, y);
            for (int i = 0; i <= x; i++)
            {
                Console.Write('0');
            }

        }
    }
}
