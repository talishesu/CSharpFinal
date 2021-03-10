using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Classes
{
    class Product
    {
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
    }
}
