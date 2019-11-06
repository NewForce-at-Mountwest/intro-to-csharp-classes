using System;

namespace classes
{

    class Person
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string PhoneNumber { get; set; }

        public void sayHello(){
            Console.WriteLine($"Hello, my name is {FirstName}");
        }
    }
}