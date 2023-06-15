using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasWithNUnitTesting
{
    class FindPerimeter
    {
        public double RectanglePerimeter(double a, double b)// method for finding perimeter of a square
        {
            double area = 0;
            area = 2 * (a + b);
            return Math.Round(area, 2);
        }
        public double CirclePerimeter(double a)// method for finding perimeter of a square
        {
            double area = 0;
            area = 2 * Math.PI * a;
            return Math.Round(area, 2);
        }
        public double TrianglePerimeter(double a, double b, double c)// method for finding perimeter of a square
        {
            double area = 0;
            area = a + b + c;
            return Math.Round(area, 2);
        }
    }
}
