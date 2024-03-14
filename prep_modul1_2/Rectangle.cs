using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prep_modul1_2
{
    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        double IShape.Perimeter()
        {
            return 2 * (Height + Width);
        }
        public override string ToString()
        {
            return $"{Height}, {Width}";
        }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
