using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇;
using static 贪吃蛇.Number;

namespace 贪吃蛇
{
    public class Nothit
    {
        public void judge(int m, int n)
        {
            if (m == 0 || m == x || n == 0 || n == y)
            {
                cg = 3;
            }
        }
    }
}