using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Point
    {
        short x, y;
        public Point()
        {
            x = 0; y = 0;
        }
        public Point(short a, short b)
        {
            x = a; y = b;
        }
        public void print()
        {
            Console.WriteLine($"{x} {y}");
        }
        public double distance(Point p)
        {
            int dx=p.x - x;
            int dy=p.y - y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
