using System;
using System.Collections.Generic;
using System.Text;

namespace lr9
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * Base * Height; // Площа трикутника: 1/2 * основа * висота
        }
    }

}
