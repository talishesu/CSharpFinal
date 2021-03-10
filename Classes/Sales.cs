using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Classes
{
    class Sales
    {
        public double Price { get; set; }
        public string SalesItem { get; set; }
        public string Date { get; set; }
        public readonly int Id;
        private static int _id = 0;
        public Sales()
        {
            _id++;
            Id = _id;
        }
    }
}
