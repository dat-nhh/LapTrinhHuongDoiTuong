using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class HocPhan
    {
        string mahp, tenhp;
        byte stc, tcth;
        static int hp1t = 250;

        public byte Tcth { get => tcth; set => tcth = value; }

        public HocPhan() 
        {
            mahp = "SOT331";
            tenhp = "OOP";
            stc = 3;
            tcth = 1;
        }
        public HocPhan(string mahp, string tenhp, byte stc, byte tcth)
        {
            this.mahp = mahp;
            this.tenhp = tenhp;
            this.stc = stc;
            this.tcth = tcth;
        }
        public void Nhap()
        {
            this.mahp = Console.ReadLine();
            this.tenhp = Console.ReadLine();
            this.stc = byte.Parse(Console.ReadLine());
            this.tcth = byte.Parse(Console.ReadLine());
        }
        public float hocphi()
        {
            return (float)tcth * hp1t * 1.5f + (stc - tcth) * hp1t;
        }
        public void xuat()
        {
            Console.WriteLine($"{mahp}\t{tenhp}\t{stc}\t{this.hocphi()}");
        }
        public static float operator+(HocPhan hp, float a)
        {
            return hp.hocphi() + a;
        }
    }
}
