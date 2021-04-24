using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                { 
                    Firstname = "Furkan"
                },
                new Student
                {
                    Firstname = "Berat"
                },
                new Person
                {
                    Firstname = "İsmail"
                }

            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Firstname);
            }            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
  
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Departmant { get; set; }
    }
}
