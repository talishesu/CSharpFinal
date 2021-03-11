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
        List<Product> products = new List<Product>();
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

        public void Products()
        {
            throw new NotImplementedException();
        }

        public string ProductSales()
        {
            throw new NotImplementedException();
        }

        public void AddProduct()
        {
            Console.WriteLine("--->Yeni mehsul elave et<---");
            Console.WriteLine(">Mehsulun Adini Daxil Edin<");
            Name = Console.ReadLine();
            Console.WriteLine("Mehsulun Qiymetini Daxil Edin");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mehsulun Sayini Daxil Edin");
            Number = Convert.ToInt32(Console.ReadLine());
            products.Add(new Product(Name, Price, Number));
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
