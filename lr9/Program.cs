using System;
using System.Collections.Generic;

namespace lr9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Triangle(4, 6),
            new Square(3)
        };

            Console.WriteLine("Площі фігур:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Площа: {shape.GetArea()}");
            }

            AnimalCollection animals = new AnimalCollection();
            animals.Add(new Animal("Elephant", 6000, 3.5));
            animals.Add(new Animal("Cat", 4, 0.4));
            animals.Add(new Animal("Dog", 20, 0.6));

            Console.WriteLine("\nТварини, відсортовані за вагою:");
            AnimalComparer animalComparer = new AnimalComparer();
            List<Animal> sortedByWeight = new List<Animal>(animals);
            sortedByWeight.Sort(animalComparer);

            foreach (var animal in sortedByWeight)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("\nТварини, відсортовані за зростом:");
            AnimalHeightComparer animalHeightComparer = new AnimalHeightComparer();
            List<Animal> sortedByHeight = new List<Animal>(animals);
            sortedByHeight.Sort(animalHeightComparer);

            foreach (var animal in sortedByHeight)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
