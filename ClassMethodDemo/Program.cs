using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Tuğçe Asena",
                LastName = "T.",
                Email = "ttt@mail.com",
                PhoneNumber = "+90 234 623 42 21",
                Title = "Mrs. "
            };

            Customer customer1 = new Customer()
            {
                Id = 2,
                Name = "Gökhan",
                LastName = "Şarapevi",
                Email = "eposta@mail.com",
                PhoneNumber = "+90 234 573 45 45",
                Title = "Mr. "
            };

            Customer customer2 = new Customer()
            {
                Id = 3,
                Name = "Furkan",
                LastName = "G.",
                Email = "postaadresi@mail.com",
                PhoneNumber = "+90 345 346 34 35",
                Title = "Mr. "
            };

            Customer customer3 = new Customer()
            {
                Id = 4,
                Name = "Baha",
                LastName = "Ö.",
                Email = "mail@mail.com",
                PhoneNumber = "+90 325 234 62 12",
                Title = "Mr. "
            };
            List<Customer> customers = new List<Customer>{ customer, customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("**-*-** In order to start the app press 'Enter' **-*-**");
            Console.WriteLine("**-*-** Keep pressing 'Enter' after each action takes place. **-*-**");
            Console.ReadKey();
            Console.WriteLine("**-*-** Customer Creation. **-*-**");
            customerManager.Add(customer);
            Console.WriteLine("**-*-** Customer Removal. **-*-**");
            customerManager.DeleteCustomer(customer1);
            Console.WriteLine("**-*-** Listing Customers. **-*-**");
            customerManager.ListCustomers(customers);
        }
    }
}
