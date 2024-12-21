using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        //bai 1.1
        static void b1_1()
        {
            Console.WriteLine("Bai 1.1");
            string hoten;
            DateTime ngaysinh;
            bool gioitinh;
            //nhap du lieu
            Console.Write("nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("nhap ngay sinh: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("nhap gioi tinh: ");
            gioitinh = Convert.ToBoolean(Console.ReadLine());
            //xuat du lieu
            if (gioitinh)
                Console.WriteLine($"{hoten}\t{ngaysinh.ToShortDateString()}\tNam");
            else
                Console.WriteLine($"{hoten}\t{ngaysinh.ToShortDateString()}\tNu");
        }
        //bai 1.2
        static void b1_2()
        {
            Console.WriteLine("Bai 1.2");
            short a, b, c;
            Console.Write("a = "); a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToInt16(Console.ReadLine());
            Console.Write("c = "); c = Convert.ToInt16(Console.ReadLine());
            if(a<=b)
            {
                if (b <= c)
                    Console.WriteLine("increasing");
                else
                    Console.WriteLine("neither increasing nor decreasing order");
            }
            else
            {
                if (b >= c)
                    Console.WriteLine("decreasing");
                else
                    Console.WriteLine("neither increasing nor decreasing order");
            }
        }
        //bai1.3
        static void b1_3()
        {
            Console.WriteLine("Bai 1.3");
            float a, b;
            char c;
            Console.Write("a = "); a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = "); b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap dau: "); c=Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '+': Console.WriteLine($"{a}+{b}={a + b}"); break;
                case '-': Console.WriteLine($"{a}-{b}={a - b}"); break;
                case '*': Console.WriteLine($"{a}*{b}={a * b}"); break;
                case '/': Console.WriteLine($"{a}/{b}={a / b}"); break;
                default: Console.WriteLine("Invalid"); break;
            }
        }
        //bai 1.4
        static void b1_4(short i)
        {
            if (i > 3) ;
            else
            {
                string true_pw = "123";
                Console.Write("Nhap Passwords: ");
                string pw = Console.ReadLine();
                bool ss = true_pw.Equals(pw);
                if (ss == true)
                    Console.WriteLine("Dang nhap thanh cong");
                else
                {
                    Console.WriteLine("Mat khau khong hop le");
                    i++;
                    if (i <= 3) Console.WriteLine("Moi nhap lai");
                    b1_4(i);
                }
            }
        }
        //bai 1.5
        static void quicksort(int[] a, int l, int r)
        {
            int i, j, m;
            int tam, key;
            if (l < r)
            {
                m = (l + r) / 2;
                key = a[m];
                i = l; j = r;
                while (i < j)
                {
                    while (a[i] < key) i=i+1;
                    while (a[j] > key) j=j-1;
                    if (i <= j)
                    {
                        tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                        i=i+1;
                        j=j-1;
                    }
                    if (j > l) quicksort(a, l, j);
                    if (i < r) quicksort(a, i, r);
                }
            }
        }
        static int ktnt(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0) return 1;
            return 0;
        }
        static void b1_5()
        {
            Console.WriteLine("Bai 1.5");
            int n;
            do
            {
                Console.Write("Nhap n (3<n<20): ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 3 || n > 20);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            quicksort(a, 0, n-1);
            Console.WriteLine("Mang sau khi sap xep:");
            for (int i = 0; i < n; i++)
                Console.WriteLine($"a[{i}]={a[i]}");
            int c = 0;
            for(int i=0;i<n;i++)
            {
                if (a[i] != 1)
                    if (ktnt(a[i]) == 0)
                    {
                        Console.WriteLine($"{a[i]} la so nguyen to");
                        c++;
                    }
            }
            Console.WriteLine($"Vay mang co {c} so nguyen to");
        }
        //bai 1.6
        static void b1_6()
        {
            int n;
            bool kt = false;
            Console.Write("Nhap nam: ");
            n=int.Parse(Console.ReadLine());
            if (n % 4 == 0 && n % 100 != 0) kt = true;
            if (n % 400 == 0) kt = true;
            if (kt == true)
                Console.WriteLine($"{n} la nam nhuan");
            else
                Console.WriteLine($"{n} khong la nam nhuan");
        }
        //bai 1.7
        static void game()
        {
            Random rd = new Random();
            int bot, a;
            bot = rd.Next(1, 4);
            Console.Write("Moi ban chon: ");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Ban chon Keo"); break;
                case 2: Console.WriteLine("Ban chon Bua"); break;
                case 3: Console.WriteLine("Ban chon Bao"); break;
                default: Console.WriteLine("LOI"); break;
            }
            switch (bot)
            {
                case 1: Console.WriteLine("May chon Keo"); break;
                case 2: Console.WriteLine("May chon Bua"); break;
                case 3: Console.WriteLine("May chon Bao"); break;
            }
            Console.WriteLine("---Ket qua---");
            if (a != 1 && a != 2 && a != 3) Console.WriteLine("Sai Luat");
            else
            {
                if (a == bot) Console.WriteLine("-----HOA-----");
                else
                {
                    if (a == 3 && bot == 1) Console.WriteLine("--BAN THUA--");
                    else
                    {
                        if (a == 1 && bot == 3) Console.WriteLine("-BAN THANG-");
                        else
                        {
                            if (a < bot) Console.WriteLine("--BAN THUA--");
                            else
                                Console.WriteLine("-BAN THANG-");
                        }
                    }
                }
            }
            Console.Write("Ban co muon choi tiep khong? < 1 - co | 2 - Khong >");
            ConsoleKeyInfo phim = Console.ReadKey(true);
            Console.Write("\n");
            if (phim.Key == ConsoleKey.D1 || phim.Key == ConsoleKey.NumPad1) game();
            if (phim.Key == ConsoleKey.D2 || phim.Key == ConsoleKey.NumPad2) ;
        }
        static void b1_7()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*      TRO CHOI KEO BUA BAO      *");
            Console.WriteLine("*         Chon 1 là Keo          *");
            Console.WriteLine("*         Chon 2 là Bua          *");
            Console.WriteLine("*         Chon 3 là Bao          *");
            Console.WriteLine("**********************************");
            game();
        }
        //bai 1.8
        static void b1_8()
        {
            Console.WriteLine("Bai 1.8");
            Console.WriteLine("Cau a: 15, 10");
            Console.WriteLine("Cau b: 1, 0");
            Console.WriteLine("Cau c: Loi thieu convert");
            Console.WriteLine("Cau d: Loi chu wrte");
            Console.WriteLine("Cau e: 1");
        }
            //main
            static void Main(string[] args)
        {
            b1_1();
            b1_2();
            b1_3();
            Console.WriteLine("Bai 1.4");
            b1_4(1);
            b1_5();
            b1_6();
            b1_7();
            b1_8();
            Console.ReadKey();
        }
    }
}
