using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class KetQuaHP
    {
        string maHP, tenHP;
        float dtb;
        byte SoTC;

        public float tra_dtb { get => dtb; set => dtb = value; }
        public byte tra_SoTC { get => SoTC; set => SoTC = value; }

        public void Nhap()
        {
            Console.Write("maHP:"); maHP = Console.ReadLine();
            Console.Write("tenHP:"); tenHP = Console.ReadLine();
            Console.Write("dtb:"); dtb = float.Parse(Console.ReadLine());
            Console.Write("SoTC:"); SoTC = byte.Parse(Console.ReadLine());
        }
    }
    class SINHVIEN
    {
        string MSSV, hoten;
        bool gtinh;
        static short tongTC=0;
        short n;
        KetQuaHP[] dshp; 
        public void Nhap()
        {
            Console.Write("MSSV:"); MSSV = Console.ReadLine();
            Console.Write("hoten:"); hoten = Console.ReadLine();
            Console.Write("gioi tinh:"); gtinh = bool.Parse(Console.ReadLine());
            Console.Write("SoSinhVien:"); n = byte.Parse(Console.ReadLine());
            dshp = new KetQuaHP[n];
            for(byte i=0; i<n; i++)
            {
                dshp[i] = new KetQuaHP();
                dshp[i].Nhap();
                tongTC += dshp[i].tra_SoTC;
            }
        }
        public float TBC()
        {
            float tong=0;
            for(byte i=0; i<n;i++)
            {
                tong += dshp[i].tra_dtb;
            }
            return tong/n;
        }
        public float TBTL()
        {
            return (TBTL() + TBC()) / 2;
        }
        public bool XetTN()
        {
            if (TBTL() > 2) return true;
            else return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
