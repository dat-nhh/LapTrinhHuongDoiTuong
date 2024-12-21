using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class String
    {
        string s;
        short x, y;
        public String()
        {
            s = "Hello";
            x = 1;
            y = 2;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public String(string s, short x, short y, byte bg, byte fg)
        {
            this.s = s;
            this.x = x;
            this.y = y;
            Console.BackgroundColor = (ConsoleColor) bg;
            Console.ForegroundColor = (ConsoleColor) fg;
        }
        public void view()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.CursorTop = y;
            Console.CursorLeft = x;
            Console.Write(this.s);
        }
        public void act()
        {
            view();
            ConsoleKeyInfo phim = Console.ReadKey(true);
            if (phim.Key == ConsoleKey.LeftArrow)
            {
                this.x--;
            }
            if (phim.Key == ConsoleKey.RightArrow)
            {
                this.x++;
            }
            if (phim.Key == ConsoleKey.UpArrow)
            {
                this.y--;

            }
            if (phim.Key == ConsoleKey.DownArrow)
            {
                this.y++;

            }
            if (phim.Key != ConsoleKey.Escape) act();
        }
    }
}
