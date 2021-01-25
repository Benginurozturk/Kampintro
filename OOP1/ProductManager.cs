using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class productManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Updade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi");
        }
    }
}
