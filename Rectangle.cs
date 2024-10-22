using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._2Owusu
{
    internal class Rectangle : SuperClass
    {
        public double width { get; set; }
        public double length { get; set; }

        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }

        public Rectangle(double width, double length) : base()
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getArea()
        {
            return width * length;
        }

        public double getPerimeter()
        {
            return 2 * (width + length);
        }

        public override string ToString()
        {
            return $"A Rectangle with width = {width} and length= {length}, which is a subclass of {base.ToString()}";
        }
    }
}
