using System;
using System.Collections;
using System.Collections.Generic;


namespace IteratorsAndComparators
{
    public class CustomStack<T> : IEnumerable
    {
        private List<T> list;

        public CustomStack()
        {
            this.list = new List<T>();
        }
        public void Pop()
        {
            if (list.Count > 0)
            {
                var item = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }
        public void Push(T item)
        {
            list.Add(item);
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
