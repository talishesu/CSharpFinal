using CSharpFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Classes
{
    class Sales : IMarketableSales
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

        void IMarketableSales.Sales()
        {
            throw new NotImplementedException();
        }

        public void AddSales()
        {
            throw new NotImplementedException();
        }

        public string AllSales()
        {
            throw new NotImplementedException();
        }

        public string SalesForDate()
        {
            throw new NotImplementedException();
        }

        public string SalesForExactDate()
        {
            throw new NotImplementedException();
        }

        public string SalesForPrice()
        {
            throw new NotImplementedException();
        }

        public string SalesForNumber()
        {
            throw new NotImplementedException();
        }
    }
}
