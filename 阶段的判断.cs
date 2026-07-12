using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇;
using static 贪吃蛇.Number;


namespace 贪吃蛇
{
    public class Judge
    {
        public int judge1(char c, int b)
        {
            if (c == 'j' && b == 1)
            {
                return 2;
            }
            else if (c == 'j' && b == 0)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
