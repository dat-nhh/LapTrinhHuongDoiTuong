using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class HDHocPhi
    {
        string mssv, hoten;
        HocPhan[] dshp;
        byte n;
        public HDHocPhi()
        {
            mssv = "63133655";
            hoten = "Nguyen Hoai Huy Dat";
            n = 3;
            dshp = new HocPhan[n];
            for(int i = 0; i < n; i++)
            {
                dshp[i] = new HocPhan();
                dshp[i].Nhap();
            }
        }
        public HDHocPhi(string mssv, string hoten, byte n)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.n = n;
            dshp = new HocPhan[n];
            for (int i = 0; i < n; i++)
            {
                dshp[i] = new HocPhan();
                dshp[i].Nhap();
            }
        }
        public void nhap()
        {
            mssv=Console.ReadLine();
            hoten=Console.ReadLine();
            n=byte.Parse(Console.ReadLine());
            dshp = new HocPhan[n];
            for (int i = 0; i < n; i++)
            {
                dshp[i] = new HocPhan();
                dshp[i].Nhap();
            }
        }
        public void xuat()
        {
            float t = 0;
            foreach (HocPhan hp in dshp)
            {
                t += hp.hocphi();
            }
            Console.WriteLine($"{mssv}\t{hoten}\nDanh sach hoc phan:");
            foreach (HocPhan hp in dshp)
                hp.xuat();
            Console.WriteLine($"Tong tien hoc phi: {t}");
        }
        public int tongtcth()
        {
            int t = 0;
            foreach (HocPhan hp in dshp)
            {
                t += hp.Tcth;
            }
            return t;
        }
    }
}
