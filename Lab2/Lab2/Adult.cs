using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Adult
    {
        string name;
        short w; double h; // w = weight, h = height
        public Adult()
        {
            name = "Nguyen Van An";
            w = 65;
            h = 1.8;
        }
        public Adult(string name, short w, double h)
        {
            this.name = name;
            this.w = w;
            this.h = h;
        }
        public Adult(Adult a)
        {
            this.name = a.name; 
            this.w = a.w;
            this.h = a.h;
        }
        public void info()
        {
            Console.WriteLine(this.name);
            double bmi = w / (h * h);
            Console.WriteLine($"Chi so bmi: {bmi}");
            if (bmi >= 18.5 && bmi <= 25)
                Console.WriteLine("Suc khoe tot");
            else
            {
                Console.WriteLine("Suc khoe khong tot");
                cure(bmi);
            }
        }
        public void cure(double bmi)
        {
            if(bmi < 18.5)
            {
                double delta = 18.5 * (h * h) - w;
                Console.WriteLine($"Can tang {delta}kg de co suc khoe tot");
            }
            else 
            {
                if (bmi > 25)
                {
                    double delta = w - 18.5 * (h * h);
                    Console.WriteLine($"Can giam {delta}kg de co suc khoe tot");
                }
            }
        }
    }
}
