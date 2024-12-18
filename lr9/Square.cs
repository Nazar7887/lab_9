using System;
using System.Collections.Generic;
using System.Text;

namespace lr9
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side; 
        }
    }
}
