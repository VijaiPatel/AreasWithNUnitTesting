using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasWithNUnitTesting
{
    class FindArea
    {
        public double Rectangle(double a, double b)//method for area of rectangle
        {
            double area = 0;
            area= a * b;
            return Math.Round(area, 2);// rounds to 2 decimal places
        }
        public double Circle(double a)// method for circle area
        {
            double area = 0;
            area = Math.PI * Math.Pow(a, 2);// area of circle
            return Math.Round(area, 2);
        }
        public double Triangle(double a, double b, double c)//method for area of triangle
        {
            double area = 0;
            double s = (a + b + c) / 2; //using heron's formula
            double toberooted = s * ((s - a) * (s - b) * (s - c));
            if (toberooted < 0)//if toberooted is negative then the sides cannot make a triangle
            {
                return 0;
            }
            else
            {
                area = Math.Sqrt(toberooted);
                return Math.Round(area, 2);
            }

        }
        public double RectanglePerimeter(double a, double b)// method for finding perimeter of a square
        {
            double area = 0;
            area = 2*(a+b);
            return Math.Round(area, 2);
        }
        public double CirclePerimeter(double a)// method for finding perimeter of a square
        {
            double area = 0;
            area = 2*Math.PI*a;
            return Math.Round(area, 2);
        }
        public double TrianglePerimeter(double a, double b, double c)// method for finding perimeter of a square
        {
            double area = 0;
            area = a + b +c;
            return Math.Round(area, 2);
        }
    }
}
