using System;
using System.Collections.Generic;
using System.Text;

namespace lr9
{
    public class AnimalCollection : IEnumerable<Animal>
    {
        private List<Animal> animals;

        public AnimalCollection()
        {
            animals = new List<Animal>();
        }

        public void Add(Animal animal)
        {
            animals.Add(animal);
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return animals.GetEnumerator();
        }
    }

}
