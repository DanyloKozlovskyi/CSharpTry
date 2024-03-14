using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prep_modul1_2
{
    public class ColoredSide : IColor
    {
        public string Color { get; protected set; }
        public double Length { get; set; }
        void IColor.ChangeColor(string color)
        {
            Color = color;
        }
        public override string ToString()
        {
            return $"{Color}, {Length}";
        }
        public ColoredSide(string color, double length)
        {
            Color = color;
            Length = length;
        }
    }
}
