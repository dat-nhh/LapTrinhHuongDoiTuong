using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTtuan5
{
    public class point
    {
        private int _x;
        private int _y;
        public point()
        {
            _x = 1;
            _y = 2;
        }
        public point(int x, int y)
        {
            _x = x; _y = y;
        }
        public point(point p)
        {
            _x = p._x; _y = p._y;
        }
        public void set(int x, int y)
        {
            _x = x; _y = y;
        }
        public void print()
        {
            Console.WriteLine($"{_x} {_y}");
        }
        public int thay_y
        {
            get => _y; set => _y = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point();
            point p2 = new point(3, 4);
            point p3 = new point(p2);
            p1.set(5,6);
            p1.print();
            p2.print();
            p3.thay_y= 5;
            p3.print();
            Console.ReadKey();
        }
    }
}
