using System;

namespace classes{

    class Librarian : Person {

        public DateTime HireDate {get; set;}

        public DateTime EndDate {get; set;}

        public Library PlaceOfWork {get; set;}

        public int NumberOfShushes {get; set;}
    }
}