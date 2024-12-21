using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class VeMB
    {
        string mave, hoten, loaive;
        DateTime ngaymua, ngaykh;
        static int giasan = 500;

        public string Loaive { get => loaive; set => loaive = value; }

        public VeMB()
        {
            mave = "V1234";
            hoten = "Nguyen Van An";
            loaive = "First";
            ngaymua = DateTime.Now;
            ngaykh = new DateTime(2023, 4, 5); // 5/4/2023
        }
        public VeMB(string mave, string hoten, string loaive,int ngay, int thang, int nam)
        {
            this.mave = mave;
            this.hoten = hoten;
            this.loaive = loaive;
            this.ngaymua = DateTime.Now;
            this.ngaykh = new DateTime(nam, thang, ngay);
        }
        public float tienve()
        {
            float giamgia= (float)0.5f / 100 * ((ngaykh - ngaymua).Days);
            if (this.loaive == "First")
                return (float)giamgia * giasan * 3 + 10 / 100 * giamgia * giasan * 3;
            else
            if (this.loaive == "Business")
                return (float)giamgia * giasan * 2 + 10 / 100 * giamgia * giasan * 2;
            else
            if (this.loaive == "Prenium")
                return (float)giamgia * giasan * 1.5f + 10 / 100 * giamgia * giasan * 1.5f;
            else return giasan;
        }
        public void xuat()
        {
            Console.WriteLine($"{mave}\t{hoten}\t{ngaykh.ToShortDateString()}\t{loaive}\t{this.tienve()}");
        }
        public static float operator+(float a, VeMB ve)
        {
            return a + ve.tienve();
        }
        public static bool operator<(VeMB v1, VeMB v2)
        {
            return v1.tienve() < v2.tienve();
        }
        public static bool operator >(VeMB v1, VeMB v2)
        {
            return v1.tienve() > v2.tienve();
        }
    }
}
