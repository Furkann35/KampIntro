using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirt = new DateTime(2000,11,1), FirstName = "Furkan", LastName = "Yücel", NationalityId = "1111111111111"});
            Console.ReadLine();
        }
    }
}
