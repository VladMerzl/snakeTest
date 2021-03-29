using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();*/

            Console.SetBufferSize(80, 25);

            //Линия сверху
            HorizontalLine upperLine = new HorizontalLine(0, 78, 0, '+');
            upperLine.Draw();

            //Линия снизу
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            bottomLine.Draw();
            
            //Линия слева
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            leftLine.Draw();

            //Линия справа
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            rightLine.Draw();

            Console.ReadLine();
        }
    }
}
