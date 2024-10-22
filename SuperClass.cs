using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._2Owusu
{
    public class SuperClass
    {
        public string color { get; set; }
        public Boolean filled { get; set; }

        public SuperClass()
        {
            color= "red";
            filled = true;
        }


        public SuperClass(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public override string ToString()
        {
            return "I am the superclass";
        }
    }
}
