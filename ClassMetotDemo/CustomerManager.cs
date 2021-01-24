using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted.");
        }
        public void List()
        {
            Console.WriteLine("List of customers.");
        }
    }
}
