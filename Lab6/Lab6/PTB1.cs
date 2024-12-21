using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class PTB1
    {
        protected float a, b;
        public PTB1(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public string Giai()
        {
            if (a == 0)
            {
                if (b == 0)
                    return "PT vo so nghiem";
                else
                    return "Pt vo nghiem";
            }
            else
            {
                float x = -b / a;
                return "PT co mot nghiem: x = " + x;
            }
        }
    }
    internal class PTB2
    {
        float a, b, c;
        public PTB2(float a, float b, float c)
        {
            this.a = a; 
            this.b = b;
            this.c = c;
        }
        public string Giai()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        return "PT vo so nghiem";
                    else
                        return "Pt vo nghiem";
                }
                else
                {
                    float x = -b / a;
                    return "PT co mot nghiem: x = " + x;
                }
            }
            else
            {
                float del = b * b - (4 * a * c);
                if (del < 0)
                    return "PT vo nghiem";
                else
                {
                    if (del == 0)
                    {
                        float x = -b / (2 * a);
                        return "PTB1 co nghiem kep x1 = x2 = " + x;
                    }
                    else
                    {
                        float x1 = (float)(-b - Math.Sqrt(del)) / (2 * a);
                        float x2 = (float)(-b + Math.Sqrt(del)) / (2 * a);
                        return "PT co 2 nghiem x1=" + x1 + ", x2=" + x2;
                    }
                }
            }
        }
    }
}