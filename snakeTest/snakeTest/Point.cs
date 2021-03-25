using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snakeTest
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
            //constructor
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
