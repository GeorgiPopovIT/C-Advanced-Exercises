using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book> 
    {
        public Library(params Book[] books)
        {
           Book  = new List<Book>(books);
        }
        public List<Book> Book { get; set; }
        public IEnumerator<Book> GetEnumerator()
        {
            Book.Sort();
            return Book.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        private class LibraryItearator : IEnumerator<Book>
        {
            private int index = -1;
            public object Current => Current;
            public LibraryItearator(List<Book> books)
            {
                this.Books = books;
            }
            public List<Book> Books;
            Book IEnumerator<Book>.Current => Books[index];

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                if (index < Books.Count)
                {
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
