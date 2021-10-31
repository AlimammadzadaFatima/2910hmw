using System;
using System.Collections.Generic;
using System.Text;

namespace _2910hmw
{
    class Library
    {
         public Book[] books;
        public void AddBook(Book book, int noo)
        {
            var temp = this.books;
            Book[] books = new Book[temp.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                books[i] = temp[i];
            }
            books[books.Length - 1] = book;
            this.books = books;
        }
        public Book [] GetFilteredBooks (string genr)
        {
            int say = 0;
            foreach (var item in books)
            { if (item.Genre == genr)
                    say++;
            }
            Book [] filtered = new Book[say]; int index = 0;
            foreach (var item in books)
            {
                if (item.Genre==genr)
                {
                    filtered[index] = item;
                    index++;
                }
            }
            return filtered;
        }
        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            int i = 0;
            foreach ( var item in books)
            { if (item.Price > minPrice && item.Price < maxPrice)
                    i++;
            }
            Book[] getfilteredint = new Book[i]; int count = 0;
            foreach (var item in books)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                {
                    getfilteredint[count] = item;
                    count++;
                }
            }
            return getfilteredint;
        }
    }
}
