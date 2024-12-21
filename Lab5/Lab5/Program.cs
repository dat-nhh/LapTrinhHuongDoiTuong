using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void BT5_1()
        {
            List_Rec list = new List_Rec();
            list.nhap();
            list.Xuat();
            Console.WriteLine("Sap Xep");
            list.SapXep();
            list.Xuat();
            Console.WriteLine("Xoa");
            list.Xoa();
            list.Xuat();
            Console.WriteLine("Them");
            list.Them();
            list.Xuat();
            Console.WriteLine($"Tong chi phi: {list.TongCP()}");

        }
        static void BT5_2()
        {
            SinhVien sv = new SinhVien();
            sv.nhap();
            sv.xuat();
            if (sv.hocbong() == 1)
                Console.WriteLine("Du dk hoc bong");
            else
                Console.WriteLine("Ko du dk hoc bong");
        }
        static void Main(string[] args)
        {
            //BT5_1();
            BT5_2();
            Console.ReadKey();
        }
    }
}
