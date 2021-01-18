using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductName = "Paslanmaz Çelik";
            product1.ProductWeight = 10;
            product1.ProductPrice = 1000;

            Product product2 = new Product();
            product2.ProductName = "Dökme Demir";
            product2.ProductWeight = 20;
            product2.ProductPrice = 1500;

            Product product3 = new Product();
            product3.ProductName = "Bakır";
            product3.ProductWeight = 30;
            product3.ProductPrice = 2000;

            Product[] products = new Product[] { product1, product2, product3 };
            Console.WriteLine("\n for ---");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + ":" + products[i].ProductWeight + ":" + products[i].ProductPrice);
            }



            Console.WriteLine("\n foreach ---");
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + ":" + product.ProductWeight + ":" + product.ProductPrice);
            }
            Console.WriteLine("\n while ---");
            int sayac = 0;
            while (sayac < products.Length)
            {
                Console.WriteLine(products[sayac].ProductName + ":" + products[sayac].ProductWeight + ":" + products[sayac].ProductPrice);
                sayac++;
            }
        }


        class Product
        {
            public string ProductName { get; set; }
            public int ProductWeight { get; set; }
            public int ProductPrice { get; set; }



        }


    }

}
    

