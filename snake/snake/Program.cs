using System;
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
            //Console.SetBufferSize(999, 25);

            // Draw frame

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Point p = new Point(2, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();




            Console.ReadLine();
        }

    }
}
