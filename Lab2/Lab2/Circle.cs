using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Circle
    {
        float _r;
        public Circle()
        {
            _r = 5;
        }
        public Circle(float r)
        {
            _r = r;
        }
        public float GetRadius
        {
            get => _r;
            set => _r = value;
        }
        public void SetRadius(float r)
        {
            _r = r;
        }
        public double GetPerimeter()
        {
            return 3.14 * 2 * _r;
        }
        public double GetArea()
        {
            return 3.14 * _r * _r;
        }
    }
}
