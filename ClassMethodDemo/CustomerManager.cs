using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Title + customer.LastName + " added to the system.\n");
            Console.ReadKey();
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Title + customer.LastName + " removed from the system.\n");
            Console.ReadKey();
        }
        public void ListCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("******"+customer.Id+"******");
                Console.WriteLine("Customer Info: " + customer.Title + " " + customer.Name + " " + customer.LastName);
                Console.WriteLine("Email address: "+customer.Email);
                Console.WriteLine("Phone Number: "+customer.PhoneNumber);
            }
            Console.ReadKey();
        }
    }
}
