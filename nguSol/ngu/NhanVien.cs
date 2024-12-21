using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngu
{
    internal class NhanVien
    {
        class CanBo
        {
            int maso;
            string hoten;
            string gtinh;
            public void nhap(int maso, string hoten, string gtinh)
            {
                this.maso = maso;
                this.hoten = hoten;
                this.gtinh = gtinh;
            }
        }
        class NVHanhChinh: CanBo
        {
            short songay;
            int luongthang;
            public void nhap(int maso, string hoten, string gtinh, short songay, int luongthang):base (maso, hoten, gtinh)
            {
                this.songay = songay;
                this.luongthang= luongthang;
            }
        }
        class GiaoVien: CanBo
        {
            short sotiet;
            int tien1tiet;
            public void nhap(int maso, string hoten, string gtinh, short sotiet, int tien1tiet):base (maso, hoten, gtinh)
            {
                this.sotiet = sotiet;
                this.tien1tiet= tien1tiet;
            }
        }

    }
}
