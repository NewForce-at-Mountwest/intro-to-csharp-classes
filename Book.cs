using System;

namespace classes
{
    class Book
    {
        // This constructor method will run every time you create a new instance of this class. That means that you can't create an instance of this class without providing a title and an author.
        public Book(string titleParam, string authorParam){
            Title = titleParam;
            Author = authorParam;
        }
        public string Title { get; set; }

        public string Author { get; set; }

        public int ISBNNumber { get; set; }
    }
}