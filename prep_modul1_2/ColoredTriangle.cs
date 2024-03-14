using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prep_modul1_2
{
    public class ColoredTriangle : IShape
    {
        public ColoredSide Side1 { get; set; }
        public ColoredSide Side2 { get; set; }
        public ColoredSide Side3 { get; set; }
        double IShape.Perimeter()
        {
            return Side1.Length + Side2.Length + Side3.Length;
        }
        public override string ToString()
        {
            return $"{Side1}, {Side2}, {Side3}";
        }
        public ColoredTriangle(ColoredSide side1, ColoredSide side2, ColoredSide side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public bool EqualsSide()
        {
            return (Side1.Color == Side2.Color) 
                && (Side2.Color == Side3.Color) && (Side1.Color == Side3.Color);
        }
    }
}
