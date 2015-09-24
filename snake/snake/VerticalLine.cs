﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yUp,int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
