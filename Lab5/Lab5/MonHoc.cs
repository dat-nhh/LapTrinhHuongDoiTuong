using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Lab5
{
    internal class MonHoc
    {
        string ma, ten;
        byte sotc;
        float tlkt, dkt, tlgk, dgk, dthi;

        public byte Sotc { get => sotc; set => sotc = value; }

        public MonHoc(string ma="SOT331", string ten="LTHDT", byte sotc=3, float tlkt=0.3f, float dkt=6.5f, float tlgk = 0.3f, float dgk=8.7f, float dthi=9)
        {
            this.ma = ma;
            this.ten = ten;
            this.sotc = sotc;
            this.tlkt = tlkt;
            this.dkt = dkt;
            this.tlgk = tlgk;
            this.dgk = dgk;
            this.dthi = dthi;
        }
        public void nhap()
        {
            ma=Console.ReadLine();
            ten=Console.ReadLine();
            sotc=byte.Parse(Console.ReadLine());
            tlkt=float.Parse(Console.ReadLine());
            dkt=float.Parse(Console.ReadLine());
            tlgk=float.Parse(Console.ReadLine());
            dgk=float.Parse(Console.ReadLine());
            dthi=float.Parse(Console.ReadLine());
        }
        public float dtb()
        {
            return (float)tlkt * dkt + tlgk * dgk + (1 - tlkt - tlgk) * dthi;
        }
        public void xuat()
        {
            Console.WriteLine($"{ten}, dkt: {dkt}, dgk: {dgk}, dthi: {dthi}, dtb: {dtb()}");
        }
    }
    class SinhVien
    {
        string mssv, hoten;
        List<MonHoc> ls;
        public SinhVien(string mssv="", string hoten="")
        {
            this.mssv = mssv;
            this.hoten = hoten;
        }
        void doc()
        {
            try
            {
                FileStream f = new FileStream("C:\\Users\\LEGION\\Documents\\VS2022\\HocPhan.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    string[] item = line.Split(';');
                    string m = item[0];
                    string t = item[1];
                    byte tc = byte.Parse(item[2]);
                    float tlkt = float.Parse(item[3]);
                    float dkt = float.Parse(item[4]);
                    float tlgk = float.Parse(item[5]);
                    float dgk = float.Parse(item[6]);
                    float dthi = float.Parse(item[7]);
                    MonHoc mh = new MonHoc(m, t, tc, tlkt, dkt, tlgk, dgk, dthi);
                    ls.Add(mh);
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void nhap()
        {
            mssv=Console.ReadLine();
            hoten=Console.ReadLine();
            ls = new List<MonHoc>();
            doc();
        }

        public void xuat()
        {
            Console.WriteLine($"{mssv} {hoten} {tb()}");
            Console.WriteLine("Danh sach mh:");
            foreach(MonHoc mh in ls)
            {
                mh.xuat();
            }
        }
        public float tb()
        {
            float t =0, m = 0;
            foreach(MonHoc mh in ls)
            {
                t += (mh.dtb() * mh.Sotc);
                m += mh.Sotc;
            }
            return (float)t/m;
        }
        public int hocbong()
        {
            if (tb() <= 7) return 0;
            else
            {
                foreach(MonHoc mh in ls)
                {
                    if (mh.dtb() < 5.5) return 0;
                }
                return 1;
            }
        }
    }
}
