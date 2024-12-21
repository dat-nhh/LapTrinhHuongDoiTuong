using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMau1
{
    internal class Xe
    {
        private string dongxe;
        byte socn;
        DateTime nsx;
        static int giasan = 400;

        public virtual string Dongxe { get => dongxe; set => dongxe = value; }

        public Xe()
        {
            this.dongxe = "SUV";
            this.socn = 7;
            this.nsx = new DateTime(2015, 12, 30);
        }
        public Xe(string dongxe, byte socn, DateTime nsx)
        {
            this.dongxe = dongxe;
            this.socn = socn;
            this.nsx = nsx;
        }
        public virtual void nhap()
        {
            Console.Write("Dong xe: ");
            dongxe = Console.ReadLine();
            Console.Write("So cho ngoi: ");
            socn = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ngay san xuat (dd/mm/yyyy):");
            string dt = Console.ReadLine();
            nsx = DateTime.Parse(dt);
        }
        public float giaban()
        {
            DateTime now = DateTime.Now;
            int n = now.Year - this.nsx.Year;
            if (n > 2)
                return giasan * (float)1.15;
            else
            {
                if (n <= 2 && n > 1)
                    return giasan * (float)1.3;
                else
                    return giasan * (float)1.5;
            }
        }
        public virtual void xuat()
        {
            Console.Write($"dong xe: {dongxe}, {socn} cho ngoi, ngay sx: {nsx.ToShortDateString()}, gia ban: {giaban()}k");
        }
    }
    class XeVF : Xe, IComparable<XeVF>
    {
        string noidk;
        DateTime nsx;
        float ptb = (float)0.5;
        public XeVF() : base()
        {
            this.noidk = "Nha Trang";
        }
        public XeVF(string dongxe, byte socn, DateTime nsx, string noidk) : base(dongxe, socn, nsx)
        {
            this.noidk = noidk;
        }

        public string Noidk { get => noidk; set => noidk = value; }
        public override string Dongxe { get => base.Dongxe; set => base.Dongxe = value; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Noi dang ky: ");
            noidk = Console.ReadLine();
        }
        public float phitb()
        {
            return ptb * giaban();
        }
        public float phidk()
        {
            bool chk = XeVF.Equals(Noidk, "Ha Noi");
            if (chk == true)
                return (float)0.12 * giaban();
            else
                return (float)0.1 * giaban();
        }
        public float gialb()
        {
            return phitb() + giaban() + phidk();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($", phi tb: {phitb()}, phi dk: {phidk()}, gia lan banh: {gialb()}.");
        }
        public int CompareTo(XeVF other)
        {
            if(this.gialb() == other.gialb()) return 0;
            else
            {
                if(this.gialb() > other.gialb())
                    return 1;
                else
                    return -1;
            }
        }
        public int SSdongxe(string x)
        {
            bool chk = XeVF.Equals(Dongxe, x);
            if (chk == true)
                return 1;
            else
                return 0;
        }
    }
}