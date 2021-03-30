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

            //Создаем змейку
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            snake.Draw();

            Console.ReadLine();
        }
    }
}
