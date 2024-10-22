using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._2Owusu
{
    public class Circle : SuperClass
    {
        public double radius { get; set; }

        public Circle()
        {
            radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return $"A Circle with radius = {radius}, which is a subclass of {base.ToString()}";
        }

    }
}
