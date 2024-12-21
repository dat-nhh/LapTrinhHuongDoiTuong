using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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
        public void nextsecond()
        {
            if(second == 59) 
            {
                second= 0;
                if (minute == 59)
                {
                    minute = 0;
                    hour++;
                }
                else minute++;
            }
            else second++;
        }
        public void previoussecond()
        {
            if (second == 0)
            {
                second = 59;
                if (minute == 0)
                {
                    minute = 59;
                    hour--;
                }
                else minute--;
            }
            else second--;
        }
        public void show()
        {
            Console.WriteLine($"Thoi gian: {hour}:{minute}:{second}");
        }
    }
}
