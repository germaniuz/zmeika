﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            Point p3 = new Point(15, 6, '$');
            //p3.Draw();

            Point p4 = new Point(8, 4, '%');
            //p4.Draw();

            List<int> numList = new List<int>();

            numList.Add(10);
            numList.Add(20);
            numList.Add(30);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

           /* foreach (int i in numList)
            {
                Console.WriteLine(i);
            };*/
            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
               i.Draw();
            }


            Console.ReadLine();
        }

    }
}
