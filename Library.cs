using System;
using System.Collections.Generic;
using System.Text;

namespace task22_3
{
    class Library
    {
        public Book[] Books;
        public void AddBook(Book[] Books, Book book)
        {
            
            Book[] newBooks = new Book[Books.Length + 1];
            newBooks[Books.Length] = book;

            for (int i = 0; i < Books.Length; i++)
            {

                newBooks[i] = Books[i];
            }

            Books = newBooks;

            foreach (var item in Books)
            {
                Console.WriteLine(item);
            }
        }

        public void GetFilteredBooks(string value)
        {
            int index = 0;
            Library[] genreBooks = new Library[index];
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre==value)
                {

                    genreBooks[index] = Books[i];
                    index++;
                }
            }
            
        }
        public void GetFiltererdBooks(double minPrice, double maxPrice)
        {
            int index = 0;
            Library[] rangeBooks = new Library[index];
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price > minPrice && Books[i].Price < maxPrice)
                {

                    rangeBooks[index] = Books[i];
                    index++;
                }
            }
           
        }

    }
}
