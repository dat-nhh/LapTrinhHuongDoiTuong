using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class PhanSo
    {
        int tu, mau;
        public PhanSo()
        {
            tu = 0; 
            mau = 1;
        }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public PhanSo(PhanSo p)
        {
            this.tu = p.tu;
            this.mau = p.mau;
        }
        public void cong(PhanSo p1, PhanSo p2)
        {
            this.tu = p1.tu * p2.mau + p2.tu * p1.mau;
            this.mau = p1.mau * p2.mau;
        }
        public void tru(PhanSo p1, PhanSo p2)
        {
            this.tu = p1.tu * p2.mau - p2.tu * p1.mau;
            this.mau = p1.mau * p2.mau;
        }
        public void nhan(PhanSo p1, PhanSo p2)
        {
            this.tu = p1.tu * p2.tu;
            this.mau = p1.mau * p2.mau;
        }
        public void chia(PhanSo p1, PhanSo p2)
        {
            this.tu = p1.tu * p2.mau;
            this.mau = p1.mau * p2.tu;
        }
        public int UCLN(int a, int b)
        {
            if (a % b != 0)
                return UCLN(b, a % b);
            else
                return b;
        }
        public void toigian()
        {
            if(this.tu==this.mau)
            {
                this.tu = 1;
                this.mau = 1;
            }
            else
            {
                int uc;
                if (this.tu > this.mau) uc = UCLN(this.tu, this.mau);
                else uc = UCLN(this.mau,this.tu);
                this.tu = (int)this.tu / uc;
                this.mau = (int)this.mau / uc;
            }
        }
        public void xuat()
        {
            Console.WriteLine($"{this.tu}/{this.mau}");
        }
        public static PhanSo operator +(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.cong(p1, p2);
            return kq;
        }
        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tru(p1, p2);
            return kq;
        }
        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.nhan(p1, p2);
            return kq;
        }
        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.chia(p1, p2);
            return kq;
        }
    }
}
