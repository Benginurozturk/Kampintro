using System;

namespace OOP1
{
    class Program
    {
        private const string V = "Masa";
        private const int V1 = 500;

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = V;
            product1.UnitPrice = V1;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }

    internal class ProductManager
    {
        public ProductManager()
        {
        }

        internal void Add(Product product1)
        {
           
        }
    }

    internal class Product
    {
        internal int Id;
        internal int CategoryId;
        internal int UnitPrice;

        public string ProductName { get; internal set; }
        public int UnitsInStock { get; internal set; }
    }
}
