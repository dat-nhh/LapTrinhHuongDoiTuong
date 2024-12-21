using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Time
    {
        int hour, minute, second;
        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public int GetHour
        {
            get => hour;
            set => hour = value;
        }
        public int GetMinute
        {
            get => minute;
            set => minute = value;
        }
        public int GetSecond
        {
            get => second;
            set => second = value;
        }
        public static Time operator ++(Time t)
        {
            if (t.second == 59)
            {
                if (t.minute == 59)
                    return new Time(t.hour++, t.minute=0, t.second=0); 
                else 
                    return new Time(t.hour, t.minute++, t.second = 0);
            }
            else 
                return new Time(t.hour, t.minute, t.second++);
        }
        public static Time operator --(Time t)
        {
            if (t.second == 0)
            {
                if (t.minute == 0)
                    return new Time(t.hour--, t.minute = 59, t.second = 59);
                else
                    return new Time(t.hour, t.minute--, t.second = 59);
            }
            else
                return new Time(t.hour, t.minute, t.second--);
        }
        public static Time operator +(Time t, int s)
        {
            t.second += s;
            if(t.second >= 60)
            {
                do
                {
                    if (t.minute >= 60)
                    {
                        t.hour++;
                        t.minute = 0;
                        t.second -= 60;
                    }
                    else
                    {
                        t.hour++;
                        t.minute++;
                        t.second -= 60;
                    }
                }
                while (t.second >= 60);
            }
            return new Time(t.hour, t.minute, t.second);
        }
        public void show()
        {
            Console.WriteLine($"Thoi gian: {hour}:{minute}:{second}");
        }
    }
}
