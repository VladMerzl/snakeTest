﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snakeTest
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void DrawVertical()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
