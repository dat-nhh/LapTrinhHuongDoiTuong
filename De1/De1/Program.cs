using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Phi());
            //List<XeVF> list = new List<XeVF>();
            //byte n;
            //do
            //{
            //    Console.WriteLine("Nhap n:");
            //    n = byte.Parse(Console.ReadLine());
            //} while (n <= 0 || n >= 20);
            //for (int i = 0; i < n; i++)
            //{
            //    XeVF xe = new XeVF();
            //    xe.nhap();
                
            //    list.Add(xe);
            //}
            //Console.WriteLine("---Danh sanh xe---");
            //foreach (XeVF xe in list)
            //{
            //    xe.xuat();
            //}
            ////////////////////////////
            //list.Sort();
            //list.Reverse();
            //Console.WriteLine("---Danh sanh xe da sap xep---");
            //foreach (XeVF xe in list)
            //{
            //    xe.xuat();
            //}
            ////////////////////////////
            //Console.WriteLine("Nhap vi tri p: ");
            //byte p = byte.Parse(Console.ReadLine());
            //Console.WriteLine("---Nhap thong tin---");
            //XeVF xethem = new XeVF();
            //xethem.nhap();
            //list.Insert(p - 1, xethem);
            //Console.WriteLine("---Danh sanh xe da them---");
            //foreach (XeVF xe in list)
            //{
            //    xe.xuat();
            //}
            ///////////////////////////
            //Console.WriteLine("Nhap dong xe can xoa: ");
            //string xexoa = Console.ReadLine();
            //list.RemoveAll(x => x.Dongxe == xexoa);
            //Console.WriteLine("---Danh sanh xe da xoa---");
            //foreach (XeVF xe in list)
            //{
            //    xe.xuat();
            //}
            //Console.ReadKey();
        }
    }
}
