using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntarfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
        };


            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }
        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "Yücel",
                Address = "İzmir",
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Berat",
                LastName = "Yücel",
                Departmant = "Computer Sciences",
            };
            manager.Add(customer);
            manager.Add(student);
            //manager.Add(new Customer { Id = 1, FirstName = "Furkan", LastName = "Yücel" ,Address = "İzmir"});

        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
