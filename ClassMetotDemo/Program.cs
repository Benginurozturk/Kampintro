using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Benginur";
            customer1.LastName = "Öztürk";
            customer1.Adress = "Ankara";
            customer1.PhoneNumber = "0123456789";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Arzu";
            customer2.LastName = "Aktaş";
            customer2.Adress = "İzmir";
            customer2.PhoneNumber = "05562869765";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Kübra";
            customer3.LastName = "Ceylan";
            customer3.Adress = "Antalya";
            customer3.PhoneNumber = "01012112101";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

            Customer[] customer = new Customer[] { customer1, customer2, customer3 };

            customerManager.List();
            Console.WriteLine("---------------------");
            foreach (var item in customer)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }

    }
}