using System;
using System.Collections.Generic;
using System.Text;

namespace lr9
{
    public class AnimalComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x == null || y == null) return 0;

            return x.Weight.CompareTo(y.Weight);
        }
    }

    public class AnimalHeightComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x == null || y == null) return 0;

            return x.Height.CompareTo(y.Height);
        }
    }

}
