using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇;
using static 贪吃蛇.Number;

namespace 贪吃蛇
{
    public static class  Iprint
    {
        public static int M, N;
        public static bool C;
        public static string Str;

        static public void pdraw(int m, int n, bool c, string str)
        {
            M = m;
            N = n;
            C = c;
            Str = str;
            Console.ForegroundColor = C ? ConsoleColor.Green : ConsoleColor.Yellow;
            Console.SetCursorPosition(M, N);
            Console.Write(Str);
        }

    }
}
