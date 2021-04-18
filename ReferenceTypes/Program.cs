using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enum,boolean   value tpyes
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayı 1: " + sayi1);


            ////arrays,class,interface references types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar1[0] = 1000;
            //Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            person1.Firstname = "Furkan";
            Person person2 = new Person();
            person2 = person1;
            person1.Firstname = "Yücel";
            //Console.WriteLine(person2.Firstname);




            Customer customer = new Customer();
            customer.Firstname = "Oğuz";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();
            employee.Firstname = "Veli";
            Person person3 = customer;
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            Personmaneger personmaneger = new Personmaneger();
            personmaneger.Add(employee);

        }
    }

    //base class : Person
    class Person
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class Personmaneger
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.Firstname);
        }
    }
}
