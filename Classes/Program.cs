using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İzmir";
            customer.Id = 1;
            customer.FirstName = "Furkan";
            customer.Lastname = "Yücel";

            Customer customer2 = new Customer
            {
               Id = 2, City = "İstanbul" , FirstName = "Berat", Lastname = "Yücel"
            };

            Console.WriteLine(customer.FirstName);

        }
    }

}
