using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Classes
{
    class Item
    {
        public string Product { get; set; }
        public int Number { get; set; }
        public readonly int Id;
        private static int _id = 0;
        public Item()
        {
            _id++;
            Id = _id;
        }
    }
}
