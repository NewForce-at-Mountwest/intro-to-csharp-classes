using System;
using System.Collections.Generic;

namespace classes {
    class Patron : Person {
        public int LibraryCardNumber {get; set;}
        public List<Book> CheckedOutBooks {get; set;} = new List<Book>();
    }
}