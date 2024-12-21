using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class HocVien
    {
        string mahv, tenhv;
        char lop;
        int soth;
        static int hp1t = 100;
        public HocVien() 
        {
            mahv = "63133655";
            tenhv = "Nguyen Hoai Huy Dat";
            lop = 'A';
            soth = 24;
        }
        public HocVien(string mahv, string tenhv, char lop, int soth)
        {
            this.mahv = mahv;
            this.tenhv = tenhv;
            this.lop = lop;
            this.soth = soth;
        }
        public void nhap()
        {
            this.mahv = Console.ReadLine();
            this.tenhv = Console.ReadLine();
            this.lop = char.Parse(Console.ReadLine());
            this.soth = int.Parse(Console.ReadLine());
        }
        public float tienhp()
        {
            float giam = 0;
            if (soth > 50) giam = 0.1f * soth * hp1t;
            if (soth <= 50 && soth > 30) giam = 0.07f * soth * hp1t;
            return (float)soth * hp1t - giam;
        }
        public void xuat()
        {
            Console.WriteLine($"{tenhv}\nLop {lop}\nSo tiet: {soth}\nTien hoc phi: {this.tienhp()}");
        }
        public static float operator +(HocVien hv, float a)
        {
            return hv.tienhp() + a;
        }
    }
}
