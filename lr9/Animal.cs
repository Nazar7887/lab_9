using System;
using System.Collections.Generic;
using System.Text;

namespace lr9
{
    public class Animal : IComparable<Animal>
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Animal(string name, double weight, double height)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public int CompareTo(Animal other)
        {
            if (other == null) return 1;
            return Weight.CompareTo(other.Weight);
        }

        public override string ToString()
        {
            return $"{Name}, Вага: {Weight} кг, Зріст: {Height} м";
        }
    }

}
