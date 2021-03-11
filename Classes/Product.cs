using CSharpFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Classes
{
    class Product : IMarketableProduct
    {
        public Product[] products = new Product[0];
        public string Name { get; set; }
        public double Price { get; set; }
        public enum Category { }
        public int Number { get; set; }
        public readonly int Id;
        private static int _id = 0;
        public Product()
        {
            _id++;
            Id = _id;
        }
        public Product(string name,double price,int number)
        {
            Name = name;
            Price = price;
            Number = number;
        }
        public void ShowProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }
        }

        public string ProductSales()
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            Console.WriteLine("--->Yeni mehsul elave et<---");
            Console.WriteLine(">Mehsulun Adini Daxil Edin<");
            Name = Console.ReadLine();
            Console.WriteLine("Mehsulun Qiymetini Daxil Edin");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mehsulun Sayini Daxil Edin");
            Number = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public void ChangeProductInfo()
        {
            throw new NotImplementedException();
        }

        public string ProductForCategory()
        {
            throw new NotImplementedException();
        }

        public string ProductForPrice()
        {
            throw new NotImplementedException();
        }

        public void ShowProductForName()
        {
            throw new NotImplementedException();
        }
    }
}
