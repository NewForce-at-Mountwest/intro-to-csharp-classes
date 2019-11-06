using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Dictionary<string, string> eastSideLibrary = new Dictionary<string, string>(){
            //     {"name", "East Side Library"},
            //     {"address", "123 East Street"}
            // };

            // Dictionary<string, string> westSideLibrary = new Dictionary<string, string>(){
            //     {"name", "West Side Library"},
            //     {"address", "123 West Street"}
            // };

            // Dictionary<string, string> northSideLibrary = new Dictionary<string, string>();

            // northSideLibrary.Add("name", "North Side Library");
            // northSideLibrary.Add("address", "123 North Street");

            // Dictionary<string, string> southSideLibrary = new Dictionary<string, string>(){
            //     {"name", "South Side Library"},
            //     {"address", "123 South Street"},

            // };

            // List<Dictionary<string, string>> cityLibraries = new List<Dictionary<string, string>>(){
            //     eastSideLibrary, westSideLibrary, southSideLibrary, northSideLibrary
            // };



            // ------ CLASSES ------//

            // Create a new instance of a library
            Library eastSideLibrary = new Library();

            // Assign it some properties
            eastSideLibrary.Name = "East Side Library";
            eastSideLibrary.Address = "123 East Street";
            eastSideLibrary.BookCapacity = 125;

            // Create another instance of a library and assign it some properties
            Library westSideLibrary = new Library()
            {
                Name = "West Side Library",
                Address = "123 West Street",
                BookCapacity = 43
            };

            // Add those libraries to a list
            List<Library> cityLibraries = new List<Library>(){
                eastSideLibrary, westSideLibrary
            };

            // ------- CONSTRUCTOR METHODS ------//

            // Create a few instances of books with constructor methods
            Book bookOfLove = new Book("The Book of Love", "Coach Dave");
            bookOfLove.ISBNNumber = 3456;

            Book bookOfDespair = new Book("The Book of Despair", "Jordan"){
                ISBNNumber = 1234
            };

            Book eastOfEden = new Book("East of Eden", "John Steinback");


            // ------ ADDING BOOKS TO LIBRARIES ------//

            // This commented out code worked BEFORE we made our _bookList private

            // eastSideLibrary._bookInventory.Add(bookOfLove);
            // eastSideLibrary.BookInventory.Add(new Book(){
            //     Title = "East of Eden",
            //     Author = "John Steinback",
            //     ISBNNumber = 1234
            // });

            // foreach(Book singleBook in eastSideLibrary.BookInventory){
            //     Console.WriteLine($"{singleBook.Title} by {singleBook.Author}");
            // }

            // westSideLibrary.BookInventory.Add(bookOfDespair);

            // We made the _bookInventory private so we could keep people from randomly adding stuff. Now we have to use the .AddBook() method provided by the library class

            eastSideLibrary.AddBook(bookOfDespair);
            eastSideLibrary.AddBook(bookOfLove);
            eastSideLibrary.ListBooks();













            // Lightning exercise -- book class

            // Move to seperate files

            // Give libraries a list of type book

            // Give books a library property

            // Give libraries a method to add a book and a method to list all books
        }
    }
}
