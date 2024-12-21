using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    abstract class Shape
    {
        protected string name;
        public Shape(string name = "")
        {
            this.name = name;
        }
        public abstract float Area();
    }
    interface IPaint
    {
        float Cost { get; set; }
        float Price();
    }
    class Rectangle: Shape, IPaint, IComparable<Rectangle>
    {
        float d, r;
        float cost;

        public float Cost { get => cost; set => cost = value; }
        public Rectangle(float d=4, float r=3, float c=2, string name="Rectangle"):base(name)
        {
            this.d = d;
            this.r = r;
            this.cost = c;
        }
        public void Info()
        {
            Console.WriteLine($"{name}, dai: {d}, rong: {r}, chi phi: {Price()}");
        }
        public override float Area()
        {
            return d * r;
        }
        public float Price()
        {
            return cost * Area();
        }
        public int CompareTo(Rectangle other)
        {
            if(this.Price() == other.Price()) return 0;
            else
            {
                if(this.Price() > other.Price()) return 1;
                else 
                    return -1;
            }
        }
    }
    class List_Rec
    {
        List<Rectangle> list;
        int n;
        public void nhap()
        {
            do
                Console.Write("nhap n:");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 10);
            list = new List<Rectangle>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("dai va rong:");
                float dai = float.Parse(Console.ReadLine());
                float rong = float.Parse(Console.ReadLine());
                Rectangle rec = new Rectangle(dai, rong);
                list.Add(rec);
            }
        }
        public void SapXep()
        {
            list.Sort();
        }
        public void Xoa()
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            foreach (Rectangle rec in list)
            {
                if (rec.Area() < x)
                {
                    list.Remove(rec);
                    break;
                }
            }
        }
        public void Them()
        {
            Console.Write("dai va rong:");
            float dai = float.Parse(Console.ReadLine());
            float rong = float.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(dai, rong);
            int i;
            do
            {
                Console.Write("vi tri i:");
                i = int.Parse(Console.ReadLine());
            }
            while (i < 2 || i > list.Count);
            list.Insert(i, rec);
        }
        public float TongCP()
        {
            float s = 0;
            foreach(Rectangle rec in list)
            {
                s += rec.Price();
            }
            return s;
        }
        public void Xuat()
        {
            foreach(Rectangle rec in list)
                rec.Info();
        }
    }
}