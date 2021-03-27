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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(2, 6, '%');
            Point p4 = p3;
            p4.x = 9;   
            //Из-за того, что точки p3 и p4 обращаются к данным по одному адресу, значение x у p3 также изменится

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            numList.Remove(0);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);

            foreach (Point p in pointList)
            {
                Console.WriteLine(p.x + ", " + p.y + ", " + p.sym);
            }

            Console.ReadLine();
        }
    }
}
