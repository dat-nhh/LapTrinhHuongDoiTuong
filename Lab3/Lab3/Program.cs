using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Bai 3.1
            //PhanSo p1 = new PhanSo(3,4);
            //PhanSo p2 = new PhanSo(2,3);
            //PhanSo kq = new PhanSo();
            //kq.cong(p1, p2); kq.toigian();
            //Console.Write($"Phuong thuc cong: "); kq.xuat();
            //kq.tru(p1, p2); kq.toigian();
            //Console.Write($"Phuong thuc tru: "); kq.xuat();
            //kq.nhan(p1, p2); kq.toigian();
            //Console.Write($"Phuong thuc nhan: "); kq.xuat();
            //kq.chia(p1, p2); kq.toigian();
            //Console.Write($"Phuong thuc chia: "); kq.xuat();
            //kq = p1 + p2; kq.toigian();
            //Console.Write($"Toan tu cong: "); kq.xuat();
            //kq = p1 - p2; kq.toigian();
            //Console.Write($"Toan tu tru: "); kq.xuat();
            //kq = p1 * p2; kq.toigian();
            //Console.Write($"Toan tu nhan: "); kq.xuat();
            //kq = p1 / p2; kq.toigian();
            //Console.Write($"Toan tu chia: "); kq.xuat();

            ////Bai 3.2
            //VeMB[] ds;
            //byte n;
            //do
            //{
            //    Console.Write("Nhap so ve: ");
            //    n = byte.Parse(Console.ReadLine());
            //} while (n < 2 || n > 20);
            //ds = new VeMB[n];
            //ds[0] = new VeMB();
            //for (int i = 1; i < n; i++)
            //{
            //    string mv, ht, lv;
            //    int ng, th, nm;
            //    Console.Write("Ma ve:"); mv = Console.ReadLine();
            //    Console.Write("Ho ten:"); ht = Console.ReadLine();
            //    Console.Write("Loai ve:"); lv = Console.ReadLine();
            //    Console.Write("Ngay KH(ngay thang nam): ");
            //    ng = int.Parse(Console.ReadLine());
            //    th = int.Parse(Console.ReadLine());
            //    nm = int.Parse(Console.ReadLine());
            //    ds[i] = new VeMB(mv, ht, lv, ng, th, nm);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 1; j < n; j++)
            //    {
            //        if (ds[i].tienve() < ds[j].tienve())
            //        {
            //            VeMB t = new VeMB();
            //            t = ds[i];
            //            ds[i] = ds[j];
            //            ds[j] = t;
            //        }
            //    }
            //}
            //float tb = 0;
            //foreach (VeMB ve in ds)
            //{
            //    tb += ve.tienve();
            //}
            //tb /= n;
            //Console.WriteLine($"Tien ve trung binh cua {n} ve: {tb}");
            //int s = 0;
            //foreach (VeMB ve in ds)
            //{
            //    if (ve.Loaive == "Business") s++;
            //}
            //Console.WriteLine($"So luonh ve may bay loai Business: {s}");

            ////Bai 3.3
            //HDHocPhi hd = new HDHocPhi();
            //hd.nhap();
            //hd.xuat();
            //Console.WriteLine($"Tong tin chi thuc hanh: {hd.tongtcth()}");

            ////Bai 3.4
            //Time t1 = new Time();
            //t1 = t1++;
            //t1.show();
            //Time t2 = new Time(10,24,0);
            //t2 = t2--;
            //t2.show();
            //Console.Write("Nhap s: "); int s = Convert.ToInt32(Console.ReadLine());
            //t2 = t2 + s;
            //t2.show();

            ////Bai 3.5
            HocVien[] ds;
            byte n;
            do
            {
                Console.Write("Nhap so hoc vien: ");
                n = byte.Parse(Console.ReadLine());
            } while (n < 2 || n > 30);
            ds = new HocVien[n];
            ds[0] = new HocVien();
            for (int i = 1; i < n; i++)
            {
                ds[i] = new HocVien();
                ds[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                ds[i].xuat();
            }

            //Bai 3.6
            //Console.WriteLine("Cau a: 9.5");
            //Console.WriteLine("Cau b: 9.5");
            //Console.WriteLine("Cau c: Acer  1   7.5");
            //Console.WriteLine("Cau d: Dell Latitude E7440   1   9.5");

            Console.ReadKey();
        }
    }
}
