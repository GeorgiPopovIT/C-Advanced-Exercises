using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Boxe<T> where T : IComparable<T>
    {
        private List<T> list;
        public Boxe(List<T> list)
        {
            this.list = list;
        }
       public int Count(List<T> list,T element)
        {
            int counter = 0;
            foreach (var generic in list)
            {
                if (generic.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
