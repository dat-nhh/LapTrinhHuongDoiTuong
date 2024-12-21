using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan7
{
    internal class CanBo
    {
        int maso;
        string hoten;
        string gtinh;
        public CanBo(int maso, string hoten, string gtinh)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.gtinh = gtinh;
        }
    }
    class HanhChinh : CanBo
    {
        short songay;
        int luongthang;
        float tienluong;
        public HanhChinh(int maso, string hoten, string gtinh, short songay, int luongthang) : base(maso, hoten, gtinh)
        {
            this.songay = songay;
            this.luongthang = luongthang;
            this.tienluong = (float)songay * luongthang / 26;
        }
    }
    class GiaoVien : CanBo
    {
        short sotiet;
        int tien1tiet;
        float tienluong;
        public GiaoVien(int maso, string hoten, string gtinh, short sotiet, int tien1tiet) : base(maso, hoten, gtinh)
        {
            this.sotiet = sotiet;
            this.tien1tiet = tien1tiet;
            this.tienluong = sotiet * tien1tiet;
        }
    }
}
