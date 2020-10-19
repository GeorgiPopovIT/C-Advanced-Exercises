using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComaparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryItearator(books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryItearator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index = -1;
            public object Current => Current;
            public LibraryItearator(List<Book> books)
            {
                this.books = books;
            }

            Book IEnumerator<Book>.Current => books[index];

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                if (index < books.Count)
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
