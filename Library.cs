using System;
using System.Collections.Generic;

namespace classes
{
    class Library
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public int BookCapacity { get; set; }

        // We made our list of books private so that we could control access to it. In this case, we want to check and make sure the library has space before we add another book.
        private List<Book> _bookInventory {get; set;} = new List<Book>();

        // Method that accepts an instance of a book, checks to see if there's space at the library, and then adds the book to inventory
        public void AddBook(Book newBookToAdd){
            if(BookCapacity > _bookInventory.Count){
                _bookInventory.Add(newBookToAdd);
            } else {
                Console.WriteLine("The library is full.");
            }
        }

        public void AddBook(string title, string author, int ISBN){
              if(BookCapacity > _bookInventory.Count){
               Book newBook = new Book(title, author){
                   ISBNNumber = ISBN
               };
               _bookInventory.Add(newBook);
            } else {
                Console.WriteLine("The library is full.");
            }

        }

        // Method to print book inventory to console (since it's private)
        public void ListBooks(){
              foreach(Book singleBook in _bookInventory){
                Console.WriteLine($"{singleBook.Title} by {singleBook.Author}");
            }

        }


    }
}