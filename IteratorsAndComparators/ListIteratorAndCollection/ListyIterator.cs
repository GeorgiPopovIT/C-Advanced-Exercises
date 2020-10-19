using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
   public class ListyIterator<T> : IEnumerable<T>
    {
        private int index;
        public ListyIterator(params T[] data)
        {
            this.index = 0;
            Data = new List<T>(data);
        }
        public List<T> Data { get; set; }
        
        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return this.index + 1 < this.Data.Count;
        }
        public void Print()
        {
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.Data[this.index]);
        }
        public void PrintAll()
        {
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(string.Join(" ", this.Data));
        }
    
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Data.Count; i++)
            {
                yield return Data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
