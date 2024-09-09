using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
   class Point
    {
        public Point (int x, int y)
        {
            _x = x;
            _y = y;
        }


        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY: {_y}");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Point point = new Point(3, 5);
            point.Print();
        }

    }



}




